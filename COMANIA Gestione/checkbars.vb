Public Class checkbars
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            MsgBox("Ottimo, sono perfettamente identici!", MsgBoxStyle.Information)
        Else
            MsgBox("Sono DIVERSI!!!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub checkbars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim savedir As String
        savedir = Utente.barra.Text
        TextBox2.Text = savedir
    End Sub
End Class