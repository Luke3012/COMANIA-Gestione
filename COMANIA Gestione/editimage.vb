Imports System.IO
Public Class editimage
    Dim img As String
    Dim numutente As String = File.ReadAllText(Application.StartupPath & "\utentetemp.txt")
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Private Sub editimage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Button1, "Elimina la tua immagine profilo.")
        ToolTip1.SetToolTip(Button2, "Aggiungi un immagine profilo o modifica la tua immagine esistente.")
        ToolTip1.SetToolTip(Button3, "Chiudi e Salva.")
        ToolTip1.SetToolTip(Label1, "Non su di me!")
        If Not File.Exists(dir & "\logininfo\" & numutente & "\image") Then
            Button1.Enabled = False
            ToolTip1.SetToolTip(Button1, "Non puoi eliminare la tua immagine profilo se non ne hai ancora aggiunto una...")
        Else
            Try
                img = dir & "\logininfo\" & numutente & "\image"
                PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            Catch
                MsgBox("Errore caricamento immagine!", MsgBoxStyle.Critical)
                Close()
            End Try
        End If
    End Sub

    Dim img2 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            img2 = OpenFileDialog1.FileName
            Try
                PictureBox1.Image = System.Drawing.Bitmap.FromFile(img2)
                ToolTip1.SetToolTip(Button1, "Elimina la tua immagine profilo.")
                Button1.Enabled = True
                Button3.Enabled = True
                Try
                    Utente.PictureBox1.Image.Dispose()
                    Utente.PictureBox1.Image = System.Drawing.Bitmap.FromFile(img2)
                    File.Delete(dir & "\logininfo\" & numutente & "\image")
                Catch
                    File.Copy(OpenFileDialog1.FileName, dir & "\logininfo\" & numutente & "\image2")
                End Try
                Try
                    File.Copy(img2, dir & "\logininfo\" & numutente & "\image", True)
                Catch
                    MsgBox("Errore copia immagine!", MsgBoxStyle.Exclamation)
                End Try
            Catch
                MsgBox("Impossibile caricare l'immagine!", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Utente.PictureBox1.Image = My.Resources.ResourceManager.GetObject("Logo")
            PictureBox1.Image = Utente.PictureBox1.Image
            File.Delete(dir & "\logininfo\" & numutente & "\image")
        Catch
            Try
                Dim scrivi As New StreamWriter(dir & "\logininfo\" & numutente & "\images.txt")
                scrivi.Write("")
                scrivi.Close()
            Catch
            End Try
        End Try
        Button1.Enabled = False
        ToolTip1.SetToolTip(Button1, "Non puoi eliminare la tua immagine profilo se non ne hai ancora aggiunto una...")
    End Sub
End Class