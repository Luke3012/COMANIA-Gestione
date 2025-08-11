Imports System.IO
Imports System.Net
Public Class login
    Dim dir As String
    Dim version As String = "52"

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        Label4.Text = "Versione " & version.Insert(1, ".")

        If File.Exists(Application.StartupPath & "\changelog.txt") Then
            changelog.Show()
            Close()
        End If
        pulizia()
        Button1.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        pass.Enabled = False
        uno.Enabled = False
        due.Enabled = False
        tre.Enabled = False
        quattro.Enabled = False
        cinque.Enabled = False
        eliminaaccount.Enabled = False

        Try
            If File.Exists(Application.StartupPath & "\percorsotemp.txt") Then
                dir = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
                Label5.Text = "Ho caricato la cartella dati di prima, clicca sotto se vuoi cambiarla"
                Button1.Enabled = True
                Button3.Enabled = True
                Button5.Enabled = True
                eliminaaccount.Enabled = True
                TextBox3.Text = dir
                controllaaccount()
            End If
        Catch
            MsgBox("Non sono riuscito a caricare la cartella dati precedente, selezionala di nuovo!", MsgBoxStyle.Exclamation)
            Try
                File.Delete(Application.StartupPath & "\percorsotemp.txt")
            Catch
            End Try
        End Try
        Try
            File.Delete(Application.StartupPath & "\updatercheck.txt")
        Catch
        End Try
        Try
            File.Delete(Application.StartupPath & "\updaternew.txt")
        Catch
        End Try
        checkupdate()
        TopMost = False
    End Sub

    Private Sub pulizia()
        Try
            File.Delete(Application.StartupPath & "\todo.bat")
        Catch
        End Try
        Try
            File.Delete(Application.StartupPath & "\updatercheck.txt")
        Catch
        End Try
        Try
            File.Delete(Application.StartupPath & "\updaternew.txt")
        Catch
        End Try
        Try
            File.Delete(Application.StartupPath & "\utentetemp.txt")
        Catch
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        changelog.Close()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath
            If Directory.Exists(FolderBrowserDialog1.SelectedPath & "\logininfo") Then
                Try
                    Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\persons")
                Catch
                End Try
                Try
                    Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\personal")
                Catch
                End Try
                Button1.Enabled = True
                Button3.Enabled = True
                Button5.Enabled = True
                eliminaaccount.Enabled = True
                Try
                    File.Delete(Application.StartupPath & "\percorsotemp.txt")
                Catch
                End Try
                Dim scriviperc As New StreamWriter(Application.StartupPath & "\percorsotemp.txt")
                scriviperc.Write(FolderBrowserDialog1.SelectedPath)
                scriviperc.Close()
                File.SetAttributes(Application.StartupPath & "\percorsotemp.txt", FileAttributes.Hidden)
                dir = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
                controllaaccount()
            Else
                If MessageBox.Show("Cartella non impostata per l'area lavoro! Imposto?", "CARTELLA LAVORO", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\logininfo")
                    Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\persons")
                    Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\personal")
                    Button1.Enabled = True
                    Button3.Enabled = True
                    Button5.Enabled = True
                    eliminaaccount.Enabled = True
                    Try
                        File.Delete(Application.StartupPath & "\percorsotemp.txt")
                    Catch
                    End Try
                    Dim scriviperc As New StreamWriter(Application.StartupPath & "\percorsotemp.txt")
                    scriviperc.Write(FolderBrowserDialog1.SelectedPath)
                    scriviperc.Close()
                    File.SetAttributes(Application.StartupPath & "\percorsotemp.txt", FileAttributes.Hidden)
                    dir = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
                    controllaaccount()
                Else
                    TextBox3.Text = "Percorso..."
                End If
            End If
        End If
    End Sub
    Private Sub controllaaccount()
        If File.Exists(dir & "\logininfo\1\deleteall.txt") Then
            Directory.Delete(dir & "\logininfo\1", True)
        End If
        If File.Exists(dir & "\logininfo\2\deleteall.txt") Then
            Directory.Delete(dir & "\logininfo\2", True)
        End If
        If File.Exists(dir & "\logininfo\3\deleteall.txt") Then
            Directory.Delete(dir & "\logininfo\3", True)
        End If
        If File.Exists(dir & "\logininfo\4\deleteall.txt") Then
            Directory.Delete(dir & "\logininfo\4", True)
        End If
        If File.Exists(dir & "\logininfo\5\deleteall.txt") Then
            Directory.Delete(dir & "\logininfo\5", True)
        End If
        If Directory.Exists(dir & "\logininfo\1") Then
            uno.Enabled = True
        End If
        If Directory.Exists(dir & "\logininfo\2") Then
            due.Enabled = True
        End If
        If Directory.Exists(dir & "\logininfo\3") Then
            tre.Enabled = True
        End If
        If Directory.Exists(dir & "\logininfo\4") Then
            quattro.Enabled = True
        End If
        If Directory.Exists(dir & "\logininfo\5") Then
            cinque.Enabled = True
        End If
    End Sub
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
        Label2.Text = "Caricamento in Corso ..."
        Dim loadi As New Task(Sub()
                                  Threading.Thread.Sleep(50)
                              End Sub)
        loadi.Start()
        Await loadi
    End Function
    Private Async Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        resetcolors()
        uno.BackColor = Color.Yellow
        selecteduser = 1
        checkimage2()
        Try
            Await loading()
            img = dir & "\logininfo\1\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\1\nome.txt")
        Label2.Text = "Sei " & nome & "?"
        pass.Select()
    End Sub
    Private Sub checkimage2()
        If File.Exists(dir & "\logininfo\" & selecteduser & "\image2") Then
            Try
                File.Delete(dir & "\logininfo\" & selecteduser & "\image")
                My.Computer.FileSystem.RenameFile(dir & "\logininfo\" & selecteduser & "\image2", "image")
            Catch
            End Try
        End If
        If File.Exists(dir & "\logininfo\" & selecteduser & "\images.txt") Then
            Try
                File.Delete(dir & "\logininfo\" & selecteduser & "\images.txt")
                File.Delete(dir & "\logininfo\" & selecteduser & "\image")
            Catch
            End Try
        End If
    End Sub

    Private Async Sub due_Click(sender As Object, e As EventArgs) Handles due.Click
        resetcolors()
        due.BackColor = Color.Yellow
        selecteduser = 2
        checkimage2()
        Try
            Await loading()
            img = dir & "\logininfo\2\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\2\nome.txt")
        Label2.Text = "Sei " & nome & "?"
        pass.Select()
    End Sub

    Private Async Sub tre_Click(sender As Object, e As EventArgs) Handles tre.Click
        resetcolors()
        tre.BackColor = Color.Yellow
        selecteduser = 3
        checkimage2()
        Try
            Await loading()
            img = dir & "\logininfo\3\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\3\nome.txt")
        Label2.Text = "Sei " & nome & "?"
        pass.Select()
    End Sub

    Private Async Sub quattro_Click(sender As Object, e As EventArgs) Handles quattro.Click
        resetcolors()
        quattro.BackColor = Color.Yellow
        selecteduser = 4
        checkimage2()
        Try
            Await loading()
            img = dir & "\logininfo\4\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\4\nome.txt")
        Label2.Text = "Sei " & nome & "?"
        pass.Select()
    End Sub

    Private Async Sub cinque_Click(sender As Object, e As EventArgs) Handles cinque.Click
        resetcolors()
        cinque.BackColor = Color.Yellow
        selecteduser = 5
        checkimage2()
        Try
            Await loading()
            img = dir & "\logininfo\5\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome = File.ReadAllText(dir & "\logininfo\5\nome.txt")
        Label2.Text = "Sei " & nome & "?"
        pass.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changelog.Close()
        logging()
    End Sub
    Private Sub logging()
        If pass.Text = "" Then
            MsgBox("Inserisci prima la password!")
        Else
            If File.Exists(dir & "\logininfo\" & selecteduser & "\pass.txt") Then
                Dim passreader As String = File.ReadAllText(dir & "\logininfo\" & selecteduser & "\pass.txt")
                If passreader = pass.Text Then
                    Dim scrivipers As New StreamWriter(Application.StartupPath & "\utentetemp.txt")
                    scrivipers.Write(selecteduser)
                    scrivipers.Close()
                    File.SetAttributes(Application.StartupPath & "\utentetemp.txt", FileAttributes.Hidden)
                    Button1.Text = "Password giusta, accedo..."
                    Button1.Enabled = False
                    Button2.Enabled = False
                    Button3.Enabled = False
                    Button4.Enabled = False
                    Button5.Enabled = False
                    Button6.Enabled = False
                    uno.Enabled = False
                    due.Enabled = False
                    tre.Enabled = False
                    quattro.Enabled = False
                    cinque.Enabled = False
                    pass.Enabled = False
                    Label2.Text = "Accesso in Corso ..."
                    Timer1.Start()
                Else
                    MsgBox("Password Errata!", MsgBoxStyle.Exclamation)
                    pass.Select()
                End If
            Else
                MsgBox("Password inesistente, errore!")
                pass.Select()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        changelog.Close()
        registrazione.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        changelog.Close()
        PictureBox1.Image = My.Resources.Logo
        eliminaaccount.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        changelog.Close()
        Try
            File.Delete(Application.StartupPath & "\updatercheck.txt")
        Catch
        End Try
        Try
            File.Delete(Application.StartupPath & "\updaternew.txt")
        Catch
        End Try

        checkupdate()
    End Sub
    Public Async Sub checkupdate()
        If loadingg.Visible = True Then
            Dim task As New Task(Sub()
                                     Threading.Thread.Sleep(1000)
                                 End Sub)
            task.Start()
            Await task
            checkupdate()
            Exit Sub
        End If
        infoagg.Text = "Controllo aggiornamenti in corso..."
        Button2.Enabled = False
        Try
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadFileCompleted, AddressOf Dopocontrollo
            client.DownloadFileAsync(New Uri("https://onedrive.live.com/download?cid=3781DC0B8F8FC809&resid=3781DC0B8F8FC809%2111825&authkey=AP0A5HEX6ZMxBpA"), Application.StartupPath & "\updatercheck.txt")
            File.SetAttributes(Application.StartupPath & "\updatercheck.txt", FileAttributes.Hidden)
        Catch
            Button2.Enabled = True
            infoagg.Text = "Controlla nuovamente"
            MsgBox("Errore controllo! Controlla la tua connessione o riprova dopo", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub Dopocontrollo()
        Dim versione As Integer = version
        Try
            Dim capiscoseaggiornamento As Integer = File.ReadAllText(Application.StartupPath & "\updatercheck.txt")
            If capiscoseaggiornamento > versione Then
                infoagg.Text = "Aggiornamento disponibile! Se vuoi aggiornare clicca qui sotto."
                If MessageBox.Show("Aggiornamento DISPONIBILEEEEE! AGGIORNA SUBITO! :D", "AGGIORNAMENTO!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    aggiorna.Show()
                    Close()
                    registrazione.Close()
                    eliminaaccount.Close()
                    changelog.Close()
                Else
                    Button2.Enabled = True
                End If
            Else
                infoagg.Text = "Appena controllato, tutto è aggiornato qui!"
                Button2.Enabled = True
            End If
        Catch
            infoagg.Text = "Errore controllo! Controlla la tua connessione o riprova dopo"
            Button2.Enabled = True
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Utente.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        changelog.Button1.Text = "Chiudi"
        changelog.ShowDialog()
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        If File.Exists(dir & "\logininfo\" & selecteduser & "\pass.txt") Then
            Dim passreader As String = File.ReadAllText(dir & "\logininfo\" & selecteduser & "\pass.txt")
            If passreader = pass.Text Then
                Button1.PerformClick()
            End If
        End If
    End Sub
End Class
