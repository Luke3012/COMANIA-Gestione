Imports System.IO
Imports System.Net

Public Class aggiorna
    Private Sub aggiorna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label2.Text = "Recupero Informazioni per il Download Link..."
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadFileCompleted, AddressOf wc_downloadCompleto
            client.DownloadFileAsync(New Uri("https://onedrive.live.com/download?cid=3781DC0B8F8FC809&resid=3781DC0B8F8FC809%2111826&authkey=ANYvDRMyyZKl6Aw"), Application.StartupPath & "\updaternew.txt")
            File.SetAttributes(Application.StartupPath & "\updaternew.txt", FileAttributes.Hidden)
        Catch
            MsgBox("Aggiornamento non riuscito.", MsgBoxStyle.Exclamation)
            System.Windows.Forms.Application.Restart()
        End Try
    End Sub
    Private Sub wc_downloadCompleto()
        Dim upgradelink As String = File.ReadAllText(Application.StartupPath & "\updaternew.txt")
        Try
            Label2.Text = "Scarico l'aggiornamento..."
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf Progresso
            AddHandler client.DownloadFileCompleted, AddressOf wc_downloadCompleto2
            client.DownloadFileAsync(New Uri(upgradelink), Application.StartupPath & "\COMPUTERMANIAnew.exe")
        Catch
            MsgBox("Aggiornamento non riuscito.", MsgBoxStyle.Exclamation)
            System.Windows.Forms.Application.Restart()
        End Try
    End Sub
    Private Sub wc_downloadCompleto2()
        Dim scrivi As New StreamWriter(Application.StartupPath & "\todo.bat")
        scrivi.Write("taskkill /F /IM COMPUTERMANIA.exe & if exist COMPUTERMANIAnew.exe del COMPUTERMANIA.exe & rename COMPUTERMANIAnew.exe COMPUTERMANIA.exe & start COMPUTERMANIA.exe")
        scrivi.Close()
        Dim chiudieaggiorna As New Process
        With chiudieaggiorna.StartInfo
            .FileName = ("todo.bat")
            .WorkingDirectory = Application.StartupPath & "\"
            .WindowStyle = ProcessWindowStyle.Hidden
        End With
        MsgBox("Dai l'OK e concludo l'aggiornamento!", MsgBoxStyle.Information)
        File.Create(Application.StartupPath & "\changelog.txt")
        File.SetAttributes(Application.StartupPath & "\changelog.txt", FileAttributes.Hidden)
        Try
            File.Delete(Application.StartupPath & "\COMANIA.xls")
        Catch
        End Try
        chiudieaggiorna.Start()
        Close()
    End Sub
    Private Sub Progresso(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub
End Class