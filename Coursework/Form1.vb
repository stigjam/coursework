Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the application
        End
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Dim key As String = CreateKey()
        txtBoxKey.Text = key

        Try
            ' Use inputbox to capture filename desired by user
            ' TODO: remove default value
            Dim Filename As String = InputBox("Enter the name of the File which you wish to encrypt", "Select File", "sample.txt")
            txtBox1.Text = My.Computer.FileSystem.ReadAllText("Sample Data\" & Filename)

            Dim encryptedText As String = Encrypt(txtBox1.Text, key)
            txtBox2.Text = encryptedText
            Dim Filename2 As String = InputBox("Enter the name of the file you wish to save", "Input filename", "test.txt")
            My.Computer.FileSystem.WriteAllText(Filename2, encryptedText, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Try
            ' Use inputbox to capture filename desired by user
            ' TODO: remove default value
            Dim Filename As String = InputBox("Enter the name of the File which you wish to decrypt", "Select File", "test.txt")
            Dim FileContents As String = My.Computer.FileSystem.ReadAllText(Filename)
            txtBox1.Text = FileContents

            Dim Key As String = InputBox("Enter the eight character key previously used", "Enter key")
            Dim decryptedText As String = Decrypt(FileContents, Key)
            txtBox2.Text = decryptedText
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Function CreateKey() As String
        Dim Result As String = ""
        Dim PlainText As String = txtBox1.Text
        Dim KeyValue As Integer = 0
        Dim RandomNumber As Integer
        Dim NextCharacter As String

        For Counter As Integer = 1 To 8
            Randomize()
            RandomNumber = Int((126 - 33 + 1) * Rnd()) + 33
            KeyValue = KeyValue + RandomNumber
            NextCharacter = Chr(RandomNumber)
            Result = Result + NextCharacter
        Next

        Return Result
    End Function

    Private Function GetOffsetFactor(key As String) As Integer
        Dim result As Integer = 0

        For Each character As Char In key
            Dim asciiCode As Integer = Asc(character)
            result = result + asciiCode
        Next

        Dim decimalResult As Decimal = result
        Dim roundedResult As Decimal = Math.Floor(decimalResult / Len(key))
        result = roundedResult - 32
        Return result
    End Function

    Private Function Encrypt(plainText As String, key As String) As String
        Dim Result As String = ""
        Dim offsetFactor As Integer = GetOffsetFactor(key)

        For Counter As Integer = 1 To Len(plainText)
            Dim LetterToConvert As String = Mid(plainText, Counter, 1)
            If LetterToConvert = " " Then
                Result = Result & " "
            Else
                Dim AsciiCode As Integer = Asc(LetterToConvert)
                Dim resultCharacter = AsciiCode + offsetFactor

                If (resultCharacter > 126) Then
                    resultCharacter = resultCharacter - 94
                End If

                Result = Result + Chr(resultCharacter)
            End If
        Next

        Return Result
    End Function

    Private Function Decrypt(encryptedText As String, key As String) As String
        Dim Result As String = ""
        Dim offsetFactor As Integer = GetOffsetFactor(key)

        For Counter As Integer = 1 To Len(encryptedText)
            Dim LetterToConvert As String = Mid(encryptedText, Counter, 1)
            If LetterToConvert = " " Then
                Result = Result & " "
            Else
                Dim AsciiCode As Integer = Asc(LetterToConvert)
                Dim resultCharacter = AsciiCode - offsetFactor

                If (resultCharacter < 33) Then
                    resultCharacter = resultCharacter + 94
                End If

                Result = Result + Chr(resultCharacter)
            End If
        Next

        Return Result
    End Function

End Class