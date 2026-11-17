
Imports System.Security.Cryptography

Module PasswordHelper

    Public Function HashPassword(password As String) As String

        Dim salt(15) As Byte

        Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
            rng.GetBytes(salt)
        End Using

        Dim iterations As Integer = 100000

        Using pbkdf2 As New Rfc2898DeriveBytes(
            password,
            salt,
            iterations,
            HashAlgorithmName.SHA256)

            Dim hash As Byte() = pbkdf2.GetBytes(32)

            Return iterations & "." &
                   Convert.ToBase64String(salt) & "." &
                   Convert.ToBase64String(hash)

        End Using

    End Function


    Public Function VerifyPassword(password As String,
                                   storedHash As String) As Boolean

        Dim parts As String() = storedHash.Split("."c)

        If parts.Length <> 3 Then
            Return False
        End If

        Dim iterations As Integer = Integer.Parse(parts(0))
        Dim salt As Byte() = Convert.FromBase64String(parts(1))
        Dim originalHash As Byte() = Convert.FromBase64String(parts(2))

        Using pbkdf2 As New Rfc2898DeriveBytes(
            password,
            salt,
            iterations,
            HashAlgorithmName.SHA256)

            Dim newHash As Byte() = pbkdf2.GetBytes(originalHash.Length)

            Return CryptographicOperations.FixedTimeEquals(
                newHash, originalHash)

        End Using

    End Function

End Module
