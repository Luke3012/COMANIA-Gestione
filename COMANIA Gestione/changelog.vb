Imports System.IO
Public Class changelog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            File.Delete(Application.StartupPath & "\changelog.txt")
        Catch
        End Try
        login.Show()
        Close()
    End Sub

    Private Sub changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = login.Label4.Text
    End Sub
End Class