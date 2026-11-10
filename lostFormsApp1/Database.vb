
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

        End Using

    End Sub

End Module
