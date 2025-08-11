Imports System.IO
Imports System.Net
Public Class downloadxls
    Private Sub downloadxls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            File.Delete(Application.StartupPath & "\COMANIA.xls")
        Catch
        End Try
        Try
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadFileCompleted, AddressOf wc_downloadCompleto
            client.DownloadFileAsync(New Uri("https://onedrive.live.com/download?cid=3781DC0B8F8FC809&resid=3781DC0B8F8FC809%2111828&authkey=AO38SHpUwsAABSE"), Application.StartupPath & "\COMANIA.xls")
            File.SetAttributes(Application.StartupPath & "\COMANIA.xls", FileAttributes.Hidden)
        Catch
            Label1.Text = "Errore Download!"
            Try
                File.Delete(Application.StartupPath & "\COMANIA.xls")
            Catch
            End Try
            MsgBox("Scaricamento non riuscito.", MsgBoxStyle.Exclamation)
            Close()
        End Try
    End Sub
    Private Sub wc_downloadCompleto()
        Label1.Text = "Download Completato"
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stampa.Show()
        Close()
        Timer1.Stop()
    End Sub
End Class