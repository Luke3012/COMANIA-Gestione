Imports System.IO
Public Class eliminaaccount
    Dim dir As String
    Dim selecteduser As Integer
    Private Sub resetcolors()
        PictureBox1.Image = My.Resources.Logo
        uno.BackColor = DefaultBackColor
        due.BackColor = DefaultBackColor
        tre.BackColor = DefaultBackColor
        quattro.BackColor = DefaultBackColor
        cinque.BackColor = DefaultBackColor
        pass.Enabled = True
    End Sub
    Dim img As String
    Dim nome As String
    Private Async Function loading() As Task
        Label3.Text = "Caricamento in Corso ..."
        Dim loadi As New Task(Sub()
                                  Threading.Thread.Sleep(50)
                              End Sub)
        loadi.Start()
        Await loadi
    End Function
    Private Async Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        resetcolors()
        uno.BackColor = Color.Red
        selecteduser = 1
        Try
            Await loading()
            img = dir & "\logininfo\1\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\1\nome.txt")
        Label3.Text = "Hai selezionato l'utente " & nome & "."
    End Sub

    Private Async Sub due_Click(sender As Object, e As EventArgs) Handles due.Click
        resetcolors()
        due.BackColor = Color.Red
        selecteduser = 2
        Try
            Await loading()
            img = dir & "\logininfo\2\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\2\nome.txt")
        Label3.Text = "Hai selezionato l'utente " & nome & "."
    End Sub

    Private Async Sub tre_Click(sender As Object, e As EventArgs) Handles tre.Click
        resetcolors()
        tre.BackColor = Color.Red
        selecteduser = 3
        Try
            Await loading()
            img = dir & "\logininfo\3\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\3\nome.txt")
        Label3.Text = "Hai selezionato l'utente " & nome & "."
    End Sub

    Private Async Sub quattro_Click(sender As Object, e As EventArgs) Handles quattro.Click
        resetcolors()
        quattro.BackColor = Color.Red
        selecteduser = 4
        Try
            Await loading()
            img = dir & "\logininfo\4\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\4\nome.txt")
        Label3.Text = "Hai selezionato l'utente " & nome & "."
    End Sub

    Private Async Sub cinque_Click(sender As Object, e As EventArgs) Handles cinque.Click
        resetcolors()
        cinque.BackColor = Color.Red
        selecteduser = 5
        Try
            Await loading()
            img = dir & "\logininfo\5\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\5\nome.txt")
        Label3.Text = "Hai selezionato l'utente " & nome & "."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eliminando()
    End Sub
    Private Sub eliminando()
        Dim namereader As String = File.ReadAllText(dir & "\logininfo\" & selecteduser & "\nome.txt")
        If pass.Text = "" Then
            MsgBox("Inserisci prima la password!")
        Else
            If File.Exists(dir & "\logininfo\" & selecteduser & "\pass.txt") Then
                Dim passreader As String = File.ReadAllText(dir & "\logininfo\" & selecteduser & "\pass.txt")
                If passreader = pass.Text Then
                    login.Hide()
                    If MessageBox.Show("Sei sicuro di voler eliminare l'account di " & namereader & "?", "ELIMINAZIONE ACCOUNT", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Try
                            Directory.Delete(dir & "\logininfo\" & selecteduser, True)
                            MsgBox("Fatto.", MsgBoxStyle.Information)
                            login.Show()
                            Close()
                        Catch
                            Dim scrivi As New StreamWriter(dir & "\logininfo\" & selecteduser & "\deleteall.txt")
                            scrivi.Write("TRA POCO ELIMINO TUTTOOOOOOOOOOOOO MUHAHAHAHAH")
                            scrivi.Close()
                            MsgBox("Fatto.", MsgBoxStyle.Exclamation)
                            Application.Restart()
                        End Try
                    End If
                Else
                    MsgBox("Password Errata!", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Password inesistente, errore!")
            End If
        End If
    End Sub
    Private Sub eliminaaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dir = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
        If Not Directory.Exists(dir & "\logininfo\1") Then
            uno.Enabled = False
        End If
        If Not Directory.Exists(dir & "\logininfo\2") Then
            due.Enabled = False
        End If
        If Not Directory.Exists(dir & "\logininfo\3") Then
            tre.Enabled = False
        End If
        If Not Directory.Exists(dir & "\logininfo\4") Then
            quattro.Enabled = False
        End If
        If Not Directory.Exists(dir & "\logininfo\5") Then
            cinque.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Close()
    End Sub
End Class