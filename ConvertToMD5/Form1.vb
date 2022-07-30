
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.TextLength > 0 Then
            TextBox2.Text = CovertToMD5(TextBox1.Text)
            TextBox1.Focus()
            TextBox1.SelectAll()
        Else
            MsgBox("Please type any text!", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            TextBox1.Focus()
        End If
    End Sub

    Function CovertToMD5(retVal As String) As String
        Using MD5 = System.Security.Cryptography.MD5.Create()
            Return System.BitConverter.ToString(MD5.ComputeHash(System.Text.Encoding.Default.GetBytes(retVal))).Replace("-", String.Empty)
        End Using
    End Function

End Class
