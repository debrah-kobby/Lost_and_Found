
Imports Microsoft.Data.Sqlite
Imports System.Data

Module UserRepository

    ' ==========================================
    ' REGISTER A NEW USER
    ' ==========================================
    Public Function RegisterUser(studentID As String,
                                 firstName As String,
                                 lastName As String,
                                 email As String,
                                 passwordHash As String) As Boolean

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO Users " &
                "(StudentID, FirstName, LastName, Email, PasswordHash) " &
                "VALUES (@studentID, @firstName, @lastName, @email, @passwordHash)"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@studentID", studentID)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@passwordHash", passwordHash)

                Try
                    command.ExecuteNonQuery()
                    Return True

                Catch ex As SqliteException When ex.SqliteErrorCode = 19
                    Return False
                End Try

            End Using

        End Using

    End Function


    ' ==========================================
    ' AUTHENTICATE USER
    ' ==========================================
    Public Function AuthenticateUser(studentID As String,
                                     password As String) As Boolean

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT PasswordHash FROM Users WHERE StudentID = @studentID"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@studentID", studentID)

                Dim result As Object = command.ExecuteScalar()

                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return False
                End If

                Dim storedHash As String = result.ToString()

                Return PasswordHelper.VerifyPassword(password, storedHash)

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET USER ID
    ' ==========================================
    Public Function GetUserID(studentID As String) As Integer

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT UserID FROM Users WHERE StudentID = @studentID"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@studentID", studentID)

                Dim result As Object = command.ExecuteScalar()

                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return 0
                End If

                Return Convert.ToInt32(result)

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET USER ROLE
    ' ==========================================
    Public Function GetUserRole(studentID As String) As String

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT COALESCE(Role, 'Student') " &
                "FROM Users " &
                "WHERE StudentID = @studentID COLLATE NOCASE"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@studentID", studentID.Trim())

                Dim result As Object = command.ExecuteScalar()

                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return ""
                End If

                Return result.ToString().Trim()

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET DATABASE FILE LOCATION
    ' ==========================================
    Public Function GetDatabasePath() As String

        Dim builder As New SqliteConnectionStringBuilder(ConnectionString)

        Return builder.DataSource

    End Function


    ' ==========================================
    ' SAVE LOST ITEM
    ' ==========================================
    Public Function SaveLostItem(itemName As String,
                                 category As String,
                                 location As String,
                                 description As String,
                                 phoneNumber As String,
                                 email As String,
                                 dateLost As DateTime) As Boolean

        If CurrentUserID <= 0 Then
            Throw New Exception("No logged-in user found. Please log in again.")
        End If

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO LostItems " &
                "(ItemName, Category, LocationLost, Description, " &
                "PhoneNumber, Email, DateLost, UserID) " &
                "VALUES (@itemName, @category, @location, @description, " &
                "@phoneNumber, @email, @dateLost, @userID)"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@itemName", itemName)
                command.Parameters.AddWithValue("@category", category)
                command.Parameters.AddWithValue("@location", location)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue(
                    "@dateLost", dateLost.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Return command.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' ==========================================
    ' SAVE FOUND ITEM
    ' ==========================================
    Public Function SaveFoundItem(itemName As String,
                                  category As String,
                                  location As String,
                                  description As String,
                                  phoneNumber As String,
                                  email As String,
                                  dateFound As DateTime) As Boolean

        If CurrentUserID <= 0 Then
            Throw New Exception("No logged-in user found. Please log in again.")
        End If

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "INSERT INTO FoundItems " &
                "(ItemName, Category, LocationFound, Description, " &
                "PhoneNumber, Email, DateFound, UserID) " &
                "VALUES (@itemName, @category, @location, @description, " &
                "@phoneNumber, @email, @dateFound, @userID)"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@itemName", itemName)
                command.Parameters.AddWithValue("@category", category)
                command.Parameters.AddWithValue("@location", location)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue(
                    "@dateFound", dateFound.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Return command.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET ALL LOST ITEMS
    ' ==========================================
    Public Function GetLostItems() As DataTable

        Dim itemsTable As New DataTable()

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT LostItemID AS ItemID, " &
                "ItemName, Category, LocationLost, Description, " &
                "DateLost, Status " &
                "FROM LostItems " &
                "ORDER BY LostItemID DESC"

            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' GET ALL FOUND ITEMS
    ' ==========================================
    Public Function GetFoundItems() As DataTable

        Dim itemsTable As New DataTable()

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT FoundItemID AS ItemID, " &
                "ItemName, Category, LocationFound, Description, " &
                "DateFound, Status " &
                "FROM FoundItems " &
                "ORDER BY FoundItemID DESC"

            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' GET MY LOST ITEMS
    ' ==========================================
    Public Function GetMyLostItems() As DataTable

        Dim itemsTable As New DataTable()

        If CurrentUserID <= 0 Then Return itemsTable

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT LostItemID AS ItemID, " &
                "ItemName, Category, LocationLost, DateLost, Status " &
                "FROM LostItems " &
                "WHERE UserID = @userID " &
                "ORDER BY LostItemID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' GET MY FOUND ITEMS
    ' ==========================================
    Public Function GetMyFoundItems() As DataTable

        Dim itemsTable As New DataTable()

        If CurrentUserID <= 0 Then Return itemsTable

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT FoundItemID AS ItemID, " &
                "ItemName, Category, LocationFound, DateFound, Status " &
                "FROM FoundItems " &
                "WHERE UserID = @userID " &
                "ORDER BY FoundItemID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' SUBMIT A CLAIM
    ' ==========================================
    Public Function SubmitClaim(foundItemID As Integer,
                                reason As String) As Boolean

        If CurrentUserID <= 0 Then
            Throw New Exception("No logged-in user found. Please log in again.")
        End If

        If String.IsNullOrWhiteSpace(reason) Then
            Throw New Exception("Please provide a reason for claiming this item.")
        End If

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Using pragmaCommand As New SqliteCommand(
                "PRAGMA foreign_keys = ON;", connection)

                pragmaCommand.ExecuteNonQuery()

            End Using

            Dim query As String =
                "INSERT INTO Claims " &
                "(UserID, FoundItemID, Reason) " &
                "SELECT @userID, FoundItemID, @reason " &
                "FROM FoundItems " &
                "WHERE FoundItemID = @foundItemID " &
                "AND Status = 'Available' " &
                "AND NOT EXISTS (" &
                "SELECT 1 FROM Claims " &
                "WHERE UserID = @userID " &
                "AND FoundItemID = @foundItemID " &
                "AND Status IN ('Pending', 'Approved'))"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@userID", CurrentUserID)
                command.Parameters.AddWithValue("@foundItemID", foundItemID)
                command.Parameters.AddWithValue("@reason", reason.Trim())

                Return command.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET CLAIMS SUBMITTED BY CURRENT USER
    ' ==========================================
    Public Function GetMyClaims() As DataTable

        Dim claimsTable As New DataTable()

        If CurrentUserID <= 0 Then Return claimsTable

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT Claims.ClaimID, Claims.FoundItemID, " &
                "FoundItems.ItemName, FoundItems.Category, " &
                "FoundItems.LocationFound AS Location, " &
                "Claims.DateClaimed AS DateReported, " &
                "Claims.Reason, Claims.Status " &
                "FROM Claims " &
                "INNER JOIN FoundItems " &
                "ON Claims.FoundItemID = FoundItems.FoundItemID " &
                "WHERE Claims.UserID = @userID " &
                "ORDER BY Claims.ClaimID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    claimsTable.Load(reader)
                End Using

            End Using

        End Using

        Return claimsTable

    End Function


    ' ==========================================
    ' SEARCH AND FILTER FOUND ITEMS
    ' ==========================================
    Public Function SearchFoundItems(searchName As String,
                                     category As String,
                                     location As String) As DataTable

        Dim itemsTable As New DataTable()

        If String.IsNullOrWhiteSpace(searchName) Then
            searchName = ""
        Else
            searchName = searchName.Trim()
        End If

        If String.IsNullOrWhiteSpace(category) OrElse
           category.Trim().Equals("All", StringComparison.OrdinalIgnoreCase) Then
            category = ""
        Else
            category = category.Trim()
        End If

        If String.IsNullOrWhiteSpace(location) OrElse
           location.Trim().Equals("All", StringComparison.OrdinalIgnoreCase) Then
            location = ""
        Else
            location = location.Trim()
        End If

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT FoundItemID AS ItemID, ItemName, Category, " &
                "LocationFound, Description, DateFound, Status " &
                "FROM FoundItems " &
                "WHERE (@searchName = '' OR ItemName LIKE @searchName) " &
                "AND (@category = '' OR Category = @category) " &
                "AND (@location = '' OR LocationFound = @location) " &
                "ORDER BY FoundItemID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@searchName", "%" & searchName & "%")
                command.Parameters.AddWithValue("@category", category)
                command.Parameters.AddWithValue("@location", location)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' SEARCH AND FILTER LOST ITEMS
    ' ==========================================
    Public Function SearchLostItems(searchName As String,
                                    category As String,
                                    location As String) As DataTable

        Dim itemsTable As New DataTable()

        If String.IsNullOrWhiteSpace(searchName) Then
            searchName = ""
        Else
            searchName = searchName.Trim()
        End If

        If String.IsNullOrWhiteSpace(category) OrElse
           category.Trim().Equals("All", StringComparison.OrdinalIgnoreCase) Then
            category = ""
        Else
            category = category.Trim()
        End If

        If String.IsNullOrWhiteSpace(location) OrElse
           location.Trim().Equals("All", StringComparison.OrdinalIgnoreCase) Then
            location = ""
        Else
            location = location.Trim()
        End If

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT LostItemID AS ItemID, ItemName, Category, " &
                "LocationLost, Description, DateLost, Status " &
                "FROM LostItems " &
                "WHERE (@searchName = '' OR ItemName LIKE @searchName) " &
                "AND (@category = '' OR Category = @category) " &
                "AND (@location = '' OR LocationLost = @location) " &
                "ORDER BY LostItemID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@searchName", "%" & searchName & "%")
                command.Parameters.AddWithValue("@category", category)
                command.Parameters.AddWithValue("@location", location)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    itemsTable.Load(reader)
                End Using

            End Using

        End Using

        Return itemsTable

    End Function


    ' ==========================================
    ' GET CURRENT USER PROFILE
    ' ==========================================
    Public Function GetUserProfile() As DataTable

        Dim profileTable As New DataTable()

        If CurrentUserID <= 0 Then Return profileTable

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT UserID, FirstName, LastName, Email, CreatedAt " &
                "FROM Users WHERE UserID = @userID"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@userID", CurrentUserID)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    profileTable.Load(reader)
                End Using

            End Using

        End Using

        Return profileTable

    End Function


    ' ==========================================
    ' GET DASHBOARD STATISTICS
    ' ==========================================
    Public Function GetDashboardStatistics() As DataTable

        Dim statistics As New DataTable()

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT " &
                "(SELECT COUNT(*) FROM LostItems) AS LostItems, " &
                "(SELECT COUNT(*) FROM FoundItems) AS FoundItems, " &
                "(SELECT COUNT(*) FROM Claims WHERE Status = 'Pending') AS PendingClaims, " &
                "(SELECT COUNT(*) FROM Users) AS TotalUsers"

            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    statistics.Load(reader)
                End Using

            End Using

        End Using

        Return statistics

    End Function


    ' ==========================================
    ' GET ALL PENDING CLAIMS FOR ADMIN
    ' ==========================================
    Public Function GetPendingClaims() As DataTable

        Dim claimsTable As New DataTable()

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT Claims.ClaimID, " &
                "Claims.FoundItemID, " &
                "Users.StudentID, " &
                "Users.FirstName || ' ' || Users.LastName AS StudentName, " &
                "FoundItems.ItemName, " &
                "FoundItems.Category, " &
                "FoundItems.LocationFound, " &
                "FoundItems.DateFound, " &
                "Claims.Reason, " &
                "Claims.DateClaimed, " &
                "Claims.Status " &
                "FROM Claims " &
                "INNER JOIN Users ON Claims.UserID = Users.UserID " &
                "INNER JOIN FoundItems ON Claims.FoundItemID = FoundItems.FoundItemID " &
                "WHERE Claims.Status = 'Pending' " &
                "ORDER BY Claims.DateClaimed ASC"

            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    claimsTable.Load(reader)
                End Using

            End Using

        End Using

        Return claimsTable

    End Function


    ' ==========================================
    ' APPROVE A CLAIM
    ' ==========================================
    Public Function ApproveClaim(claimID As Integer) As Boolean

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Using transaction As SqliteTransaction = connection.BeginTransaction()

                Try

                    ' First, approve the selected pending claim
                    ' only if its found item is still available.

                    Dim approveQuery As String =
                        "UPDATE Claims " &
                        "SET Status = 'Approved' " &
                        "WHERE ClaimID = @claimID " &
                        "AND Status = 'Pending' " &
                        "AND EXISTS (" &
                        "SELECT 1 FROM FoundItems " &
                        "WHERE FoundItems.FoundItemID = Claims.FoundItemID " &
                        "AND FoundItems.Status = 'Available')"

                    Using command As New SqliteCommand(
                        approveQuery, connection, transaction)

                        command.Parameters.AddWithValue("@claimID", claimID)

                        If command.ExecuteNonQuery() = 0 Then
                            transaction.Rollback()
                            Return False
                        End If

                    End Using


                    ' Change the found item's status to Claimed.

                    Dim updateItemQuery As String =
                        "UPDATE FoundItems " &
                        "SET Status = 'Claimed' " &
                        "WHERE FoundItemID = (" &
                        "SELECT FoundItemID FROM Claims " &
                        "WHERE ClaimID = @claimID) " &
                        "AND Status = 'Available'"

                    Using command As New SqliteCommand(
                        updateItemQuery, connection, transaction)

                        command.Parameters.AddWithValue("@claimID", claimID)

                        If command.ExecuteNonQuery() = 0 Then
                            transaction.Rollback()
                            Return False
                        End If

                    End Using

                    transaction.Commit()

                    Return True

                Catch ex As Exception

                    transaction.Rollback()
                    Throw

                End Try

            End Using

        End Using

    End Function


    ' ==========================================
    ' REJECT A CLAIM
    ' ==========================================
    Public Function RejectClaim(claimID As Integer) As Boolean

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "UPDATE Claims " &
                "SET Status = 'Rejected' " &
                "WHERE ClaimID = @claimID " &
                "AND Status = 'Pending'"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("@claimID", claimID)

                Return command.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    ' ==========================================
    ' GET ALL CLAIMS FOR ADMIN
    ' ==========================================
    Public Function GetAllClaims() As DataTable

        Dim claimsTable As New DataTable()

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            Dim query As String =
                "SELECT Claims.ClaimID, " &
                "Claims.FoundItemID, " &
                "Users.StudentID, " &
                "Users.FirstName || ' ' || Users.LastName AS StudentName, " &
                "FoundItems.ItemName, " &
                "FoundItems.Category, " &
                "FoundItems.LocationFound, " &
                "Claims.Reason, " &
                "Claims.DateClaimed, " &
                "Claims.Status " &
                "FROM Claims " &
                "INNER JOIN Users ON Claims.UserID = Users.UserID " &
                "INNER JOIN FoundItems ON Claims.FoundItemID = FoundItems.FoundItemID " &
                "ORDER BY Claims.ClaimID DESC"

            Using command As New SqliteCommand(query, connection)

                Using reader As SqliteDataReader = command.ExecuteReader()
                    claimsTable.Load(reader)
                End Using

            End Using

        End Using

        Return claimsTable

    End Function

End Module
