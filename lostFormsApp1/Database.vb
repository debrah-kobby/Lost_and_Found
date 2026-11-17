
Imports Microsoft.Data.Sqlite
Imports System.IO

Module Database

    Public ReadOnly DbPath As String =
        Path.Combine(Application.LocalUserAppDataPath, "LostFound.db")

    Public ReadOnly ConnectionString As String =
        "Data Source=" & DbPath

    Public Sub InitializeDatabase()

        Directory.CreateDirectory(Application.LocalUserAppDataPath)

        Using connection As New SqliteConnection(ConnectionString)

            connection.Open()

            ' Enable foreign key enforcement
            Using command As New SqliteCommand(
                "PRAGMA foreign_keys = ON;", connection)

                command.ExecuteNonQuery()

            End Using


            ' ==========================================
            ' CREATE USERS TABLE
            ' ==========================================
            Dim query As String =
                "CREATE TABLE IF NOT EXISTS Users (" &
                "UserID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "StudentID TEXT NOT NULL UNIQUE, " &
                "FirstName TEXT NOT NULL, " &
                "LastName TEXT NOT NULL, " &
                "Email TEXT NOT NULL UNIQUE, " &
                "PasswordHash TEXT NOT NULL, " &
                "CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP);"

            Using command As New SqliteCommand(query, connection)
                command.ExecuteNonQuery()
            End Using


            ' ==========================================
            ' ADD ROLE COLUMN TO USERS TABLE
            ' ==========================================
            If Not ColumnExists(connection, "Users", "Role") Then

                Dim alterUsers As String =
                    "ALTER TABLE Users " &
                    "ADD COLUMN Role TEXT NOT NULL DEFAULT 'Student'"

                Using command As New SqliteCommand(alterUsers, connection)
                    command.ExecuteNonQuery()
                End Using

            End If


            ' ==========================================
            ' CREATE LOST ITEMS TABLE
            ' ==========================================
            Dim lostItemsQuery As String =
                "CREATE TABLE IF NOT EXISTS LostItems (" &
                "LostItemID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "ItemName TEXT NOT NULL, " &
                "Category TEXT NOT NULL, " &
                "LocationLost TEXT NOT NULL, " &
                "Description TEXT NOT NULL, " &
                "PhoneNumber TEXT NOT NULL, " &
                "Email TEXT NOT NULL, " &
                "DateLost TEXT NOT NULL, " &
                "Status TEXT DEFAULT 'Pending', " &
                "CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP);"

            Using command As New SqliteCommand(lostItemsQuery, connection)
                command.ExecuteNonQuery()
            End Using


            ' ==========================================
            ' CREATE FOUND ITEMS TABLE
            ' ==========================================
            Dim foundItemsQuery As String =
                "CREATE TABLE IF NOT EXISTS FoundItems (" &
                "FoundItemID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "ItemName TEXT NOT NULL, " &
                "Category TEXT NOT NULL, " &
                "LocationFound TEXT NOT NULL, " &
                "Description TEXT NOT NULL, " &
                "PhoneNumber TEXT NOT NULL, " &
                "Email TEXT NOT NULL, " &
                "DateFound TEXT NOT NULL, " &
                "Status TEXT DEFAULT 'Available', " &
                "CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP);"

            Using command As New SqliteCommand(foundItemsQuery, connection)
                command.ExecuteNonQuery()
            End Using


            ' ==========================================
            ' ADD USERID TO LOST ITEMS
            ' ==========================================
            If Not ColumnExists(connection, "LostItems", "UserID") Then

                Dim alterLostItems As String =
                    "ALTER TABLE LostItems " &
                    "ADD COLUMN UserID INTEGER REFERENCES Users(UserID)"

                Using command As New SqliteCommand(alterLostItems, connection)
                    command.ExecuteNonQuery()
                End Using

            End If


            ' ==========================================
            ' ADD USERID TO FOUND ITEMS
            ' ==========================================
            If Not ColumnExists(connection, "FoundItems", "UserID") Then

                Dim alterFoundItems As String =
                    "ALTER TABLE FoundItems " &
                    "ADD COLUMN UserID INTEGER REFERENCES Users(UserID)"

                Using command As New SqliteCommand(alterFoundItems, connection)
                    command.ExecuteNonQuery()
                End Using

            End If


            ' ==========================================
            ' CREATE CLAIMS TABLE
            ' ==========================================
            Dim claimsQuery As String =
                "CREATE TABLE IF NOT EXISTS Claims (" &
                "ClaimID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "UserID INTEGER NOT NULL REFERENCES Users(UserID), " &
                "FoundItemID INTEGER NOT NULL REFERENCES FoundItems(FoundItemID), " &
                "Reason TEXT NOT NULL, " &
                "DateClaimed TEXT DEFAULT CURRENT_TIMESTAMP, " &
                "Status TEXT DEFAULT 'Pending');"

            Using command As New SqliteCommand(claimsQuery, connection)
                command.ExecuteNonQuery()
            End Using

        End Using

    End Sub


    ' ==========================================
    ' CHECK WHETHER A COLUMN EXISTS
    ' ==========================================
    Private Function ColumnExists(connection As SqliteConnection,
                                  tableName As String,
                                  columnName As String) As Boolean

        Dim query As String = "PRAGMA table_info(" & tableName & ")"

        Using command As New SqliteCommand(query, connection)

            Using reader As SqliteDataReader = command.ExecuteReader()

                While reader.Read()

                    If reader("name").ToString() = columnName Then
                        Return True
                    End If

                End While

            End Using

        End Using

        Return False

    End Function

End Module
