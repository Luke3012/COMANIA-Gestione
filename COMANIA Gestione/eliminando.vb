Public Class eliminando
    Private Sub eliminando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Utente.Show()
        Close()
    End Sub
End Class