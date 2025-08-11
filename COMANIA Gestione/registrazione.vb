Imports System.IO
Public Class registrazione
    Dim dir As String
    Private Sub registrazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dir = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
        If Directory.Exists(dir & "\logininfo\1") Then
            uno.Enabled = False
        End If
        If Directory.Exists(dir & "\logininfo\2") Then
            due.Enabled = False
        End If
        If Directory.Exists(dir & "\logininfo\3") Then
            tre.Enabled = False
        End If
        If Directory.Exists(dir & "\logininfo\4") Then
            quattro.Enabled = False
        End If
        If Directory.Exists(dir & "\logininfo\5") Then
            cinque.Enabled = False
        End If
    End Sub
    Dim img As String
    Dim yesimg As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            img = OpenFileDialog1.FileName
            Try
                PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
                yesimg = True
            Catch
                MsgBox("Impossibile caricare l'immagine!", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Directory.Delete(dir & "\logininfo\" & selecteduser, True)
        Catch
        End Try
        Button2.Text = "Creo Account..."
        uno.Enabled = False
        due.Enabled = False
        tre.Enabled = False
        quattro.Enabled = False
        cinque.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        ControlBox = False
        Try
            If TextBox1.Text = "" Then
                MsgBox("Inserisci un nome!", MsgBoxStyle.Exclamation)
                Button2.Text = "Crea ACCOUNT!"
                uno.Enabled = True
                due.Enabled = True
                tre.Enabled = True
                quattro.Enabled = True
                cinque.Enabled = True
                TextBox1.Enabled = True
                TextBox2.Enabled = True
                Button1.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                ControlBox = True
            Else
                If TextBox2.Text = "" Then
                    MsgBox("Inserisci una password!", MsgBoxStyle.Exclamation)
                    Button2.Text = "Crea ACCOUNT!"
                    uno.Enabled = True
                    due.Enabled = True
                    tre.Enabled = True
                    quattro.Enabled = True
                    cinque.Enabled = True
                    TextBox1.Enabled = True
                    TextBox2.Enabled = True
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Button3.Enabled = True
                    ControlBox = True
                Else
                    Directory.CreateDirectory(dir & "\logininfo\" & selecteduser)
                    Dim nome As New StreamWriter(dir & "\logininfo\" & selecteduser & "\nome.txt")
                    nome.Write(TextBox1.Text)
                    nome.Close()
                    Dim pass As New StreamWriter(dir & "\logininfo\" & selecteduser & "\pass.txt")
                    pass.Write(TextBox2.Text)
                    pass.Close()
                    If yesimg = True Then
                        Try
                            File.Copy(OpenFileDialog1.FileName, dir & "\logininfo\" & selecteduser & "\image")
                        Catch
                            MsgBox("Errore Copia immagine!", MsgBoxStyle.Exclamation)
                        End Try
                    End If
                    login.Hide()
                    Timer1.Start()
                End If
            End If
        Catch
            Button2.Text = "Crea ACCOUNT!"
            uno.Enabled = True
            due.Enabled = True
            tre.Enabled = True
            quattro.Enabled = True
            cinque.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            ControlBox = True
            MsgBox("Errore creazione account!")
            Try
                Directory.Delete(dir & "\logininfo\" & selecteduser, True)
            Catch
            End Try
        End Try
    End Sub

    Dim selecteduser As Integer
    Private Sub resetcolors()
        uno.BackColor = DefaultBackColor
        due.BackColor = DefaultBackColor
        tre.BackColor = DefaultBackColor
        quattro.BackColor = DefaultBackColor
        cinque.BackColor = DefaultBackColor
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub
    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        resetcolors()
        uno.BackColor = Color.Yellow
        selecteduser = 1
    End Sub

    Private Sub due_Click(sender As Object, e As EventArgs) Handles due.Click
        resetcolors()
        due.BackColor = Color.Yellow
        selecteduser = 2
    End Sub

    Private Sub tre_Click(sender As Object, e As EventArgs) Handles tre.Click
        resetcolors()
        tre.BackColor = Color.Yellow
        selecteduser = 3
    End Sub

    Private Sub quattro_Click(sender As Object, e As EventArgs) Handles quattro.Click
        resetcolors()
        quattro.BackColor = Color.Yellow
        selecteduser = 4
    End Sub

    Private Sub cinque_Click(sender As Object, e As EventArgs) Handles cinque.Click
        resetcolors()
        cinque.BackColor = Color.Yellow
        selecteduser = 5
    End Sub
    Private Sub accountcreated()
        Timer1.Stop()
        MsgBox("Ottimo, account Creato! Ora fai il login.")
        login.Show()
        Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        accountcreated()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        Close()
    End Sub
End Class