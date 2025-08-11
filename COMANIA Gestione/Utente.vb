Imports System
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Utente
    Dim img As String
    Public numutente As String = File.ReadAllText(Application.StartupPath & "\utentetemp.txt")
    Public dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Dim tofi As Integer
    Dim fito As Integer
    Dim lines() As String
    Dim soldiaccumulati As Integer
    Dim listalavori() As String
    Dim difects() As String





    Private Sub Utente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            img = dir & "\logininfo\" & numutente & "\image"
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        Catch
        End Try
        nome.Text = File.ReadAllText(dir & "\logininfo\" & numutente & "\nome.txt")
        check()
        infos()
        hour.Text = Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
        controllo.Start()
    End Sub
    Private Sub check()
        If Not File.Exists(dir & "\persons\money.txt") Then
            Dim write As New StreamWriter(dir & "\persons\money.txt")
            write.Write(0)
            write.Close()
        End If
        If Not File.Exists(dir & "\persons\todo.txt") Then
            Dim write As New StreamWriter(dir & "\persons\todo.txt")
            write.Write(0)
            write.Close()
        End If
        If Not File.Exists(dir & "\persons\done.txt") Then
            Dim write As New StreamWriter(dir & "\persons\done.txt")
            write.Write(0)
            write.Close()
        End If
        If Not File.Exists(dir & "\persons\list.txt") Then
            Dim write As New StreamWriter(dir & "\persons\list.txt")
            write.Write("")
            write.Close()
        End If
        If Not File.Exists(dir & "\persons\worklist.txt") Then
            Dim write As New StreamWriter(dir & "\persons\worklist.txt")
            write.WriteLine("RIPARAZIONE HARDDISK")
            write.WriteLine("RIPARAZIONE SCHERMO PC")
            write.WriteLine("RIPARAZIONE GENERICA PC")
            write.WriteLine("INSTALLAZIONE HDD/SSD")
            write.WriteLine("RIPARAZIONE ALIMENTATORE")
            write.WriteLine("RIPARAZIONE TASTIERA NOTEBOOK")
            write.WriteLine("RIPARAZIONE LCD SMARTPHONE")
            write.WriteLine("NON SPECIFICATO")
            write.Close()
        End If
        If Not File.Exists(dir & "\persons\difects.txt") Then
            Dim write As New StreamWriter(dir & "\persons\difects.txt")
            write.WriteLine("NON PARTE")
            write.WriteLine("SCHERMO ROTTO")
            write.WriteLine("HARDDISK DANNEGGIATO")
            write.WriteLine("TASTIERA DANNEGGIATA")
            write.WriteLine("ALIMENTATORE ROTTO")
            write.WriteLine("SCHEDA VIDEO")
            write.WriteLine("LCD SMARTPHONE")
            write.WriteLine("NON SPECIFICATO")
            write.Close()
        End If
        tofi = File.ReadAllText(dir & "\persons\todo.txt")
        fito = File.ReadAllText(dir & "\persons\done.txt")
        dafinire.Text = tofi
        finiti.Text = fito
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        ListBox1.Items.AddRange(lines)
        soldiaccumulati = File.ReadAllText(dir & "\persons\money.txt")
        difects = File.ReadAllLines(dir & "\persons\difects.txt")
    End Sub
    Private Sub infos()
        ToolTip1.SetToolTip(PictureBox1, "La tua immagine profilo, clicca sul pulsante modifica per modificarla.")
        ToolTip1.SetToolTip(indietro, "Clicca qui se vuoi tornare al menu' principale. Assicurati di aver fatto tutto!")
        ToolTip1.SetToolTip(selecteduser, "Qui veririchi l'utente che hai selezionato.")
        ToolTip1.SetToolTip(selectedwork, "Qui veririchi il lavoro che hai selezionato.")
        ToolTip1.SetToolTip(workstate, "Qui veririchi se il lavoro selezionato è stato completato o se è incompleto.")
        ToolTip1.SetToolTip(modificalavori, "Clicca qui per modificare la lista dei lavori disponibili.")
        ToolTip1.SetToolTip(Button1, "Clicca qui per modificare la lista dei clienti disponibili.")
        ToolTip1.SetToolTip(savework, "Salva il lavoro svolto.")
        ToolTip1.SetToolTip(Button6, "Modifica il tuo nome.")
        ToolTip1.SetToolTip(Button7, "Modifica la tua immagine profilo.")
        If gotoprint.Enabled = False Then
            ToolTip1.SetToolTip(gotoprint, "Non puoi stampare se il lavoro è già completato o se non ne hai selezionato uno.")
        End If
    End Sub
    Private Sub indietro_Click(sender As Object, e As EventArgs) Handles indietro.Click
        If MessageBox.Show("Sei sicuro/a di voler tornare al menu'?", "?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            login.Show()
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        controllo.Stop()
        aggutenti.Close()
        aggutenti.ShowDialog()
        TextBox1.Text = ""
        Try
            ListBox1.SelectedItem = selecteduser.Text
        Catch
            disabilitaicosi()
            GroupBox4.Enabled = False
            selecteduser.Text = "Nessun utente selezionato..."
            selectedwork.Text = "Nessun lavoro selezionato..."
            workstate.Text = "Nessun lavoro selezionato..."
        End Try
        If Not ListBox1.SelectedItem = selecteduser.Text Then
            disabilitaicosi()
            GroupBox4.Enabled = False
            selecteduser.Text = "Nessun utente selezionato..."
            selectedwork.Text = "Nessun lavoro selezionato..."
            workstate.Text = "Nessun lavoro selezionato..."
        End If
        controllo.Start()
    End Sub

    Dim lines2() As String
    Dim stringanome As String
    Dim sebarre As Boolean
    Dim checkcartelle() As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        controllo.Stop()

        If aggiornando = True Or ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If

        disabilitaicosi()
        Button3.Enabled = True
        selecteduser.Clear()
        selecteduser.Text = ListBox1.SelectedItem
        If Not Directory.Exists(dir & "\persons\" & selecteduser.Text) Then
            Directory.CreateDirectory(dir & "\persons\" & selecteduser.Text)
        End If
        checkfolders()

        controllo.Start()
    End Sub

    Private Sub checkfolders()
        If selecteduser.Text = "" Then
            selecteduser.Text = "Nessun cliente selezionato..."
            GroupBox4.Enabled = False
        Else
            GroupBox4.Enabled = True
            stringanome = selecteduser.Text
            ListBox2.Items.Clear()
            For Each folder As String In System.IO.Directory.GetDirectories(dir & "\persons\" & stringanome & "\")
                ListBox2.Items.Add(Path.GetFileName(folder))
            Next
            checkcartelle = Directory.GetDirectories(dir & "\persons\" & stringanome & "\")
            Convert.ToInt32(checkcartelle.Length)
            If checkcartelle.Length > 0 Then
                selectedwork.Text = "Seleziona un lavoro..."
            End If
            If Not GroupBox5.Enabled = True Then
                If checkcartelle.Length = 0 Then
                    selectedwork.Text = "Non ci sono lavori, aggiungili!"
                    workstate.Text = "Non ci sono lavori, aggiungili!"
                ElseIf checkcartelle.Length > 0 Then
                    workstate.Text = "Nessun lavoro selezionato ..."
                End If
            End If
        End If
    End Sub

    Private Sub disabilitaicosi()
        GroupBox5.Enabled = False
        gotoprint.Enabled = False
        sebarre = True
        codbars.Hide()
        If Not workstate.Text = "Non ci sono lavori, aggiungili!" Then
            workstate.Text = "Nessun lavoro selezionato..."
        End If
        TextBox3.Text = ""
        TextBox4.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        barra.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox2.Text = ""
        TextBox9.Text = ""
        TextBox8.Text = ""
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim selStart As Integer = TextBox1.SelectionStart
        TextBox1.Text = TextBox1.Text.ToUpper()
        TextBox1.SelectionStart = selStart
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        ListBox1.Items.AddRange(lines)
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If i > ListBox1.Items.Count - 1 Then Exit For
            If Not ListBox1.Items(i).Contains(TextBox1.Text) Then
                ListBox1.Items.Remove(ListBox1.Items(i))
                i -= 1
            End If
        Next
    End Sub
    Dim stringalavoro As String
    Private Async Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        controllo.Stop()

        If ListBox2.SelectedIndex = -1 Then
            Exit Sub
        End If

        stringalavoro = ListBox2.SelectedItem
        selectedwork.Text = ListBox2.SelectedItem

        If aggiornando = True Then
            Exit Sub
        End If

        GroupBox5.Text = "Caricamento Ordine in Corso ..."
        Dim loadi As New Task(Sub()
                                  Threading.Thread.Sleep(50)
                              End Sub)
        loadi.Start()
        Await loadi

        Try
            disabilitaicosi()

            loaddata()

        Catch
        End Try

        GroupBox5.Text = "Gestione Ordine"

        controllo.Start()
    End Sub

    Private Sub loaddata()

        gotoprint.Enabled = True
        Dim readstatus As String
        readstatus = File.ReadAllText(dir & "\persons\" & stringanome & "\" & stringalavoro & "\status.txt")
        workstate.Text = readstatus
        Dim savedir As String = dir & "\persons\" & stringanome & "\" & stringalavoro
        Dim worktype As String = File.ReadAllText(savedir & "\worktype.txt")
        If File.Exists(savedir & "\done.txt") Then
            CheckBox2.Enabled = False
            CheckBox2.Checked = True
        Else
            CheckBox2.Enabled = True
            CheckBox2.Checked = False
        End If
        TextBox2.Enabled = True
        Dim data As String = File.ReadAllText(savedir & "\date.txt")
        TextBox4.Text = data
        ID = stringalavoro
        TextBox3.Text = ID
        Dim borsa As String = File.ReadAllText(savedir & "\borsa.txt")
        If borsa = "True" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
        Dim accessori As String = File.ReadAllText(savedir & "\accessori.txt")
        If accessori = "True" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        Dim caricatore As String = File.ReadAllText(savedir & "\caricatore.txt")
        If caricatore = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        Dim telefono As String = File.ReadAllText(savedir & "\phone.txt")
        TextBox5.Text = telefono
        Dim modello As String = File.ReadAllText(savedir & "\model.txt")
        TextBox6.Text = modello
        Dim difetto As String = File.ReadAllText(savedir & "\difect.txt")
        ComboBox2.Text = difetto
        Dim seriale As String = File.ReadAllText(savedir & "\serial.txt")
        TextBox9.Text = seriale
        Dim preventivo As String = File.ReadAllText(savedir & "\preventivo.txt")
        TextBox8.Text = preventivo
        Dim prezzo As String = File.ReadAllText(savedir & "\prezzo.txt")
        TextBox2.Text = prezzo
        If File.Exists(savedir & "\barre.txt") Then
            Dim barre As String = File.ReadAllText(savedir & "\barre.txt")
            codbars.Show()
            CheckBox3.Checked = True
            barra.Text = barre
        End If
        listalavori = File.ReadAllLines(dir & "\persons\worklist.txt")
        If noadd = False Then
            ComboBox1.Items.AddRange(listalavori)
        End If

        ComboBox1.Text = worktype
        difects = File.ReadAllLines(dir & "\persons\difects.txt")
        If noadd = False Then
            ComboBox2.Items.AddRange(difects)
        End If
        ComboBox2.Text = difetto

        GroupBox5.Enabled = True
        saved = True
        buttonsave()
        delete.Show()
        sebarre = False
        GroupBox5.Enabled = True
    End Sub

    Dim pinok As Boolean
    Dim ID As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        disabilitaicosi()
        CheckBox2.Enabled = True
        pinok = False
        Do
            ID = Now.Second & Now.Millisecond & Now.Minute
            If Not Directory.Exists(dir & "\persons\" & stringanome & "\" & ID) Then
                pinok = True
            End If
        Loop Until pinok = True
        TextBox3.Text = ID
        TextBox4.Text = Now.Date & " " & Now.Hour & ":" & Now.Minute
        saved = False
        buttonsave()
        GroupBox5.Enabled = True
        listalavori = File.ReadAllLines(dir & "\persons\worklist.txt")
        selectedwork.Text = "Nessun lavoro selezionato..."
        workstate.Text = "Nessun lavoro selezionato..."
        listalavori = File.ReadAllLines(dir & "\persons\worklist.txt")
        ComboBox1.Items.AddRange(listalavori)
        difects = File.ReadAllLines(dir & "\persons\difects.txt")
        ComboBox2.Items.AddRange(difects)
        delete.Hide()
        codbars.Hide()
        sebarre = False
        ListBox2.Items.Clear()
        For Each folder As String In System.IO.Directory.GetDirectories(dir & "\persons\" & stringanome & "\")
            ListBox2.Items.Add(Path.GetFileName(folder))
        Next
        TextBox2.Enabled = True
        TextBox2.Text = "0"
    End Sub
    Private Sub buttonsave()
        If saved = True Then
            savework.BackgroundImage = My.Resources.saved
            savework.Enabled = False
        Else
            savework.BackgroundImage = My.Resources.save
            savework.Enabled = True
        End If
    End Sub

    Dim saved As Boolean
    Private Sub modificalavori_Click(sender As Object, e As EventArgs) Handles modificalavori.Click
        controllo.Stop()
        Dim temporaneo As String
        temporaneo = ComboBox1.SelectedItem
        ModLavori.Close()
        ModLavori.ShowDialog()
        Try
            ComboBox1.Text = temporaneo
        Catch
        End Try
        controllo.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        saved = False
        buttonsave()
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim selStart As Integer = ComboBox1.SelectionStart
        ComboBox1.Text = ComboBox1.Text.ToUpper()
        ComboBox1.SelectionStart = selStart
        saved = False
        buttonsave()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            barra.Enabled = True
        Else
            If barra.Text = "" Then
                barra.Enabled = False
            Else
                If sebarre = False Then
                    If MessageBox.Show("Sei sicuro/a di voler eliminare il codice a barre salvato?", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        barra.Text = ""
                    Else
                        CheckBox3.Checked = True
                    End If
                End If
            End If
        End If
        saved = False
        buttonsave()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        saved = False
        buttonsave()
    End Sub

    Private Sub barre_TextChanged(sender As Object, e As EventArgs) Handles barra.TextChanged
        saved = False
        buttonsave()
    End Sub

    Private Async Sub savework_Click(sender As Object, e As EventArgs) Handles savework.Click
        controllo.Stop()
        GroupBox5.Text = "Salvataggio Ordine in Corso ..."
        Dim loadi As New Task(Sub()
                                  Threading.Thread.Sleep(50)
                              End Sub)
        loadi.Start()
        Await loadi

        If Not ComboBox1.Text = "" Then
            If Not TextBox2.Text = "" Then
                If CheckBox3.Checked = True Then
                    If barra.Text = "" Then
                        MsgBox("Inserisci codice a barre!", MsgBoxStyle.Exclamation)
                    Else
                        saving()
                    End If
                Else
                    saving()
                End If
            Else
                MsgBox("Inserisci l'importo! (Minimo 0€)", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Inserisci tipologia di lavoro!", MsgBoxStyle.Exclamation)
        End If

        GroupBox5.Text = "Gestione Ordine"
        controllo.Start()
    End Sub
    Private Sub saving()
        TextBox2.Enabled = False
        Directory.CreateDirectory(dir & "\persons\" & stringanome & "\" & ID)
        Dim savedir As String = dir & "\persons\" & stringanome & "\" & ID
        If CheckBox2.Checked = False Then
            Dim write As New StreamWriter(dir & "\persons\" & stringanome & "\" & ID & "\status.txt")
            write.Write("Incompleto")
            write.Close()
        Else
            Dim write As New StreamWriter(dir & "\persons\" & stringanome & "\" & ID & "\status.txt")
            write.Write("Completato")
            write.Close()
        End If
        If Not File.Exists(savedir & "\already.txt") Then
            If CheckBox2.Checked = False Then
                tofi = tofi + 1
                File.WriteAllText(dir & "\persons\todo.txt", tofi)
                Dim writedafinire As New StreamWriter(dir & "\persons\todowrite.txt", True)
                writedafinire.WriteLine(stringanome & "\" & ID)
                writedafinire.Close()
            End If
        End If
        If File.Exists(savedir & "\already.txt") Then
            If Not File.Exists(savedir & "\done.txt") Then
                If CheckBox2.Checked = True Then
                    gotoprint.Enabled = True
                    tofi = tofi - 1
                    fito = fito + 1
                    File.WriteAllText(dir & "\persons\todo.txt", tofi)
                    File.WriteAllText(dir & "\persons\done.txt", fito)
                    Dim writedone As New StreamWriter(dir & "\persons\" & stringanome & "\" & ID & "\status.txt")
                    writedone.Write("Completato")
                    writedone.Close()
                    soldiaccumulati = soldiaccumulati + TextBox2.Text
                    Dim writesoldi As New StreamWriter(dir & "\persons\money.txt")
                    writesoldi.Write(soldiaccumulati)
                    writesoldi.Close()
                    Dim writedonene1 As New StreamWriter(savedir & "\done.txt")
                    writedonene1.Write("")
                    writedonene1.Close()
                    Dim line As String
                    Dim Input As StreamReader
                    Dim PolicyIdCode As String
                    Dim strFile As New ArrayList
                    PolicyIdCode = stringanome & "\" & ID
                    Input = File.OpenText(dir & "\persons\todowrite.txt")
                    While Input.Peek <> -1
                        line = Input.ReadLine
                        If Not line = PolicyIdCode Then
                            strFile.Add(line)
                        End If
                    End While
                    Input.Close()
                    If File.Exists(dir & "\persons\todowrite.txt") Then
                        File.Delete(dir & "\persons\todowrite.txt")
                    End If
                    Dim objWriter As New System.IO.StreamWriter(dir & "\persons\todowrite.txt", True)
                    For Each item As String In strFile
                        objWriter.WriteLine(item)
                    Next
                    objWriter.Flush()
                    objWriter.Close()
                    Dim writefinito As New StreamWriter(dir & "\persons\tofiwrite.txt", True)
                    writefinito.WriteLine(stringanome & "\" & ID)
                    writefinito.Close()
                    Dim writefineora As New StreamWriter(savedir & "\finishdate.txt")
                    writefineora.Write(Now.Date & " " & Now.Hour & ":" & Now.Minute)
                    writefineora.Close()
                End If
            End If
        Else
            If Not File.Exists(savedir & "\done.txt") Then
                gotoprint.Enabled = True
                If CheckBox2.Checked = True Then
                    fito = fito + 1
                    Dim writefito21 As New StreamWriter(dir & "\persons\done.txt")
                    writefito21.Write(fito)
                    writefito21.Close()
                    Dim writedone1 As New StreamWriter(dir & "\persons\" & stringanome & "\" & ID & "\status.txt")
                    writedone1.Write("Completato")
                    writedone1.Close()
                    soldiaccumulati = soldiaccumulati + TextBox2.Text
                    Dim writesoldi1 As New StreamWriter(dir & "\persons\money.txt")
                    writesoldi1.Write(soldiaccumulati)
                    writesoldi1.Close()
                    Dim writedonene As New StreamWriter(savedir & "\done.txt")
                    writedonene.Write("")
                    writedonene.Close()
                    Dim writefinito2 As New StreamWriter(dir & "\persons\tofiwrite.txt", True)
                    writefinito2.WriteLine(stringanome & "\" & ID)
                    writefinito2.Close()
                    Dim writefineora2 As New StreamWriter(savedir & "\finishdate.txt")
                    writefineora2.Write(Now.Date & " " & Now.Hour & ":" & Now.Minute)
                    writefineora2.Close()
                End If
            End If
        End If
        Dim write2 As New StreamWriter(savedir & "\worktype.txt")
        write2.Write(ComboBox1.Text)
        write2.Close()
        Dim write3 As New StreamWriter(savedir & "\date.txt")
        write3.Write(TextBox4.Text)
        write3.Close()
        If CheckBox4.Checked = True Then
            Dim write4 As New StreamWriter(savedir & "\borsa.txt")
            write4.Write("True")
            write4.Close()
        Else
            Dim write4 As New StreamWriter(savedir & "\borsa.txt")
            write4.Write("False")
            write4.Close()
        End If
        If CheckBox5.Checked = True Then
            Dim write5 As New StreamWriter(savedir & "\accessori.txt")
            write5.Write("True")
            write5.Close()
        Else
            Dim write5 As New StreamWriter(savedir & "\accessori.txt")
            write5.Write("False")
            write5.Close()
        End If
        If CheckBox1.Checked = True Then
            Dim write6 As New StreamWriter(savedir & "\caricatore.txt")
            write6.Write("True")
            write6.Close()
        Else
            Dim write6 As New StreamWriter(savedir & "\caricatore.txt")
            write6.Write("False")
            write6.Close()
        End If
        Dim write7 As New StreamWriter(savedir & "\phone.txt")
        write7.Write(TextBox5.Text)
        write7.Close()
        Dim write20 As New StreamWriter(savedir & "\model.txt")
        write20.Write(TextBox6.Text)
        write20.Close()
        Dim write21 As New StreamWriter(savedir & "\difect.txt")
        write21.Write(ComboBox2.Text)
        write21.Close()
        Dim write22 As New StreamWriter(savedir & "\serial.txt")
        write22.Write(TextBox9.Text)
        write22.Close()
        Dim write23 As New StreamWriter(savedir & "\preventivo.txt")
        write23.Write(TextBox8.Text)
        write23.Close()
        Try
            File.Delete(savedir & "\barre.txt")
        Catch
        End Try
        If CheckBox3.Checked = True Then
            If Not barra.Text = "" Then
                Dim write8 As New StreamWriter(savedir & "\barre.txt")
                write8.Write(barra.Text)
                write8.Close()
            End If
        End If
        Dim write9 As New StreamWriter(savedir & "\prezzo.txt")
        write9.Write(TextBox2.Text)
        write9.Close()
        Try
            Dim writeal As New StreamWriter(savedir & "\already.txt")
            writeal.Write("")
            writeal.Close()
        Catch
        End Try
        tofi = File.ReadAllText(dir & "\persons\todo.txt")
        fito = File.ReadAllText(dir & "\persons\done.txt")
        dafinire.Text = tofi
        finiti.Text = fito
        soldiaccumulati = File.ReadAllText(dir & "\persons\money.txt")
        saved = True
        buttonsave()
        ListBox2.Items.Clear()
        For Each folder As String In System.IO.Directory.GetDirectories(dir & "\persons\" & stringanome & "\")
            ListBox2.Items.Add(Path.GetFileName(folder))
        Next
        ListBox2.SelectedItem = TextBox3.Text
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        saved = False
        buttonsave()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        saved = False
        buttonsave()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
        saved = False
        buttonsave()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Not CheckBox2.Enabled = False Then
            If CheckBox2.Checked = True Then
                If MessageBox.Show("Sei sicuro/a di aver terminato il lavoro? Una volta terminato non puoi riattivarlo!", "TERMINE LAVORO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    CheckBox2.Checked = True
                    saved = False
                    buttonsave()
                    CheckBox2.Enabled = False
                Else
                    CheckBox2.Checked = False
                End If
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox2.Text = digitsOnly.Replace(TextBox2.Text, "")
        saved = False
        buttonsave()
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Async Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        controllo.Stop()

        If MessageBox.Show("Sei sicuro/a di voler eliminare questo ordine? (Meglio di no...)", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            GroupBox5.Text = "Eliminazione Ordine in Corso ..."
            Dim loadi As New Task(Sub()
                                      Threading.Thread.Sleep(50)
                                  End Sub)
            loadi.Start()
            Await loadi

            disabilitaicosi()
            If Not File.Exists(dir & "\persons\" & stringanome & "\" & stringalavoro & "\done.txt") Then
                tofi = tofi - 1
                Dim writetofi As New StreamWriter(dir & "\persons\todo.txt")
                writetofi.Write(tofi)
                writetofi.Close()
                Dim line As String
                Dim Input As StreamReader
                Dim PolicyIdCode As String
                Dim strFile As New ArrayList
                PolicyIdCode = stringanome & "\" & ID
                Input = File.OpenText(dir & "\persons\todowrite.txt")
                While Input.Peek <> -1
                    line = Input.ReadLine
                    If Not line = PolicyIdCode Then
                        strFile.Add(line)
                    End If
                End While
                Input.Close()
                If File.Exists(dir & "\persons\todowrite.txt") Then
                    File.Delete(dir & "\persons\todowrite.txt")
                End If
                Dim objWriter As New System.IO.StreamWriter(dir & "\persons\todowrite.txt", True)
                For Each item As String In strFile
                    objWriter.WriteLine(item)
                Next
                objWriter.Flush()
                objWriter.Close()
            Else
                fito = fito - 1
                Dim writefito As New StreamWriter(dir & "\persons\done.txt")
                writefito.Write(fito)
                writefito.Close()
                Dim line As String
                Dim Input As StreamReader
                Dim PolicyIdCode As String
                Dim strFile As New ArrayList
                PolicyIdCode = stringanome & "\" & ID
                Input = File.OpenText(dir & "\persons\tofiwrite.txt")
                While Input.Peek <> -1
                    line = Input.ReadLine
                    If Not line = PolicyIdCode Then
                        strFile.Add(line)
                    End If
                End While
                Input.Close()
                If File.Exists(dir & "\persons\tofiwrite.txt") Then
                    File.Delete(dir & "\persons\tofiwrite.txt")
                End If
                Dim objWriter As New System.IO.StreamWriter(dir & "\persons\tofiwrite.txt", True)
                For Each item As String In strFile
                    objWriter.WriteLine(item)
                Next
                objWriter.Flush()
                objWriter.Close()

            End If
            Directory.Delete(dir & "\persons\" & stringanome & "\" & ID, True)
            tofi = File.ReadAllText(dir & "\persons\todo.txt")
            fito = File.ReadAllText(dir & "\persons\done.txt")
            dafinire.Text = tofi
            finiti.Text = fito
            ListBox2.Items.Clear()
            For Each folder As String In System.IO.Directory.GetDirectories(dir & "\persons\" & stringanome & "\")
                ListBox2.Items.Add(Path.GetFileName(folder))
            Next
            selectedwork.Text = "Nessun lavoro selezionato..."
        End If
        If ListBox2.Items.Count = 0 Then
            If MessageBox.Show("Ho notato che adesso il cliente non ha alcun lavoro da svolgere...vuoi eliminarlo?", "?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Directory.Delete(dir & "\persons\" & ListBox1.SelectedItem)
                Catch
                End Try
                Dim line As String
                Dim Input As StreamReader
                Dim PolicyIdCode As String
                Dim strFile As New ArrayList
                PolicyIdCode = ListBox1.SelectedItem
                Input = File.OpenText(dir & "\persons\list.txt")
                While Input.Peek <> -1
                    line = Input.ReadLine
                    If Not line = PolicyIdCode Then
                        strFile.Add(line)
                    End If
                End While
                Input.Close()
                If File.Exists(dir & "\persons\list.txt") Then
                    File.Delete(dir & "\persons\list.txt")
                End If
                Dim objWriter As New System.IO.StreamWriter(dir & "\persons\list.txt", True)
                For Each item As String In strFile
                    objWriter.WriteLine(item)
                Next
                objWriter.Flush()
                objWriter.Close()
                ListBox1.Items.Clear()
                lines = File.ReadAllLines(dir & "\persons\list.txt")
                ListBox1.Items.AddRange(lines)
                disabilitaicosi()
                selecteduser.Text = "Nessun cliente selezionato ..."
                GroupBox4.Enabled = False
            End If
        End If

        GroupBox5.Text = "Gestione Ordine"
        controllo.Start()
    End Sub

    Private Sub codbars_Click(sender As Object, e As EventArgs) Handles codbars.Click
        controllo.Stop()
        checkbars.Close()
        checkbars.ShowDialog()
        controllo.Start()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, Button2.MouseEnter, Button7.MouseEnter
        Button2.Visible = True
        Button7.Visible = True
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles Button2.Leave, Button7.Leave

        Button2.Visible = False
        Button7.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        controllo.Stop()
        editimage.Close()
        editimage.ShowDialog()
        controllo.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        controllo.Stop()
        editname.Close()
        editname.ShowDialog()
        controllo.Start()
    End Sub

    Private Sub gotoprint_Click(sender As Object, e As EventArgs) Handles gotoprint.Click
        controllo.Stop()
        If CheckBox2.Checked = True Then
            If MessageBox.Show("Il lavoro è stato già completato! Stampare comunque?", "STAMPO?", MessageBoxButtons.YesNo) = DialogResult.No Then
                Exit Sub
            End If
        End If
        stampa.Close()
        If File.Exists(Application.StartupPath & "\COMANIA.xls") Then
            stampa.ShowDialog()
        Else
            Try
                My.Computer.Network.Ping("www.google.com")
                downloadxls.ShowDialog()
            Catch ex As System.Net.NetworkInformation.PingException
                MsgBox("Non puoi stampare, impossibile scaricare file di risorsa. (La tua connessione ad internet non è stabile)")
            End Try
        End If
        controllo.Start()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox8.Text = digitsOnly.Replace(TextBox8.Text, "")
        saved = False
        buttonsave()
    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        saved = False
        buttonsave()
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim selStart As Integer = TextBox6.SelectionStart
        TextBox6.Text = TextBox6.Text.ToUpper()
        TextBox6.SelectionStart = selStart
        saved = False
        buttonsave()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        saved = False
        buttonsave()
    End Sub
    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim selStart As Integer = ComboBox2.SelectionStart
        ComboBox2.Text = ComboBox2.Text.ToUpper()
        ComboBox2.SelectionStart = selStart
        saved = False
        buttonsave()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dim selStart As Integer = TextBox9.SelectionStart
        TextBox9.Text = TextBox9.Text.ToUpper()
        TextBox9.SelectionStart = selStart
        saved = False
        buttonsave()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        controllo.Stop()

        If Not finiti.Text = 0 Then
            visualizzacompletati.Close()
            visualizzacompletati.ShowDialog()
        Else
            MsgBox("Nessun lavoro è stato completato fin ad ora!", MsgBoxStyle.Exclamation)
        End If

        controllo.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        controllo.Stop()
        other.ShowDialog()
        controllo.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        controllo.Stop()

        If Not dafinire.Text = 0 Then
            visualizzanonfiniti.Close()
            visualizzanonfiniti.ShowDialog()
        Else
            MsgBox("Nessun lavoro da finire!", MsgBoxStyle.Exclamation)
        End If

        controllo.Start()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        controllo.Stop()
        Dim temporaneo2 As String = ComboBox2.SelectedItem
        modificadifetti.Close()
        modificadifetti.ShowDialog()
        Try
            ComboBox2.Text = temporaneo2
        Catch
        End Try
        controllo.Start()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        controllo.Stop()
        materiale.Close()
        materiale.ShowDialog()
        controllo.Start()
    End Sub

    Dim noadd As Boolean = False
    Private Sub updatedata()
        controllo.Stop()
        templist = ""
        templist2 = ""
        templistnow = ""
        templistnow2 = ""

        aggiornando = True
        Dim tempfound As Boolean = False

        For i As Integer = 0 To ListBox1.Items.Count - 1
            templist = templist & ListBox1.Items(i).ToString
        Next
        If Not ListBox1.SelectedItem = "" Then
            For i As Integer = 0 To ListBox2.Items.Count - 1
                templist2 = templist2 & ListBox2.Items(i).ToString
            Next
        End If

        Try
            Dim temp As String = ListBox1.SelectedItem
            Dim temp2 As String = ListBox2.SelectedItem
            lines = File.ReadAllLines(dir & "\persons\list.txt")
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(lines)

            If TextBox1.Text <> "" Then
                Dim selection As Integer = TextBox1.SelectionStart
                Dim hei As String = TextBox1.Text
                TextBox1.Text = ""
                TextBox1.Text = hei
                TextBox1.SelectionStart = selection
            End If

            If temp <> "" Then
                For i As Integer = 0 To ListBox1.Items.Count - 1
                    If ListBox1.Items(i).ToString = temp Then
                        tempfound = True
                    End If
                Next
                If tempfound = False Then
                    aggiornando = False
                    disabilitaicosi()
                    selectedwork.Text = "Nessun lavoro selezionato ..."
                    selecteduser.Text = "Nessun cliente selezionato..."
                    ListBox2.Items.Clear()
                Else
                    ListBox1.SelectedItem = temp

                    If ListBox1.SelectedItem = temp Then
                        tempfound = False
                        checkfolders()
                        For i As Integer = 0 To ListBox2.Items.Count - 1
                            If ListBox2.Items(i).ToString = temp2 Then
                                tempfound = True
                            End If
                        Next
                        If tempfound = True Then
                            ListBox2.SelectedItem = temp2
                            ' If saved = True Then
                            'noadd = True
                            'Try
                            'loaddata()
                            'Catch
                            'End Try
                            '  noadd = False
                            'End If
                        ElseIf temp2 <> "" Then
                            aggiornando = False
                            disabilitaicosi()
                            selectedwork.Text = "Nessun lavoro selezionato ..."
                        End If
                    End If
                End If
                ListBox1.SelectedItem = temp
            End If

            For i As Integer = 0 To ListBox1.Items.Count - 1
                templistnow = templistnow & ListBox1.Items(i).ToString
            Next
            If ListBox1.SelectedItem <> "" Then
                For i As Integer = 0 To ListBox2.Items.Count - 1
                    templistnow2 = templistnow2 & ListBox2.Items(i).ToString
                Next
            End If

            If templist <> templistnow Or templist2 <> templistnow2 Then
                hour.Text = Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            End If

            tofi = File.ReadAllText(dir & "\persons\todo.txt")
            fito = File.ReadAllText(dir & "\persons\done.txt")
            dafinire.Text = tofi
            finiti.Text = fito

        Catch
        End Try

        Button2.Visible = False
        Button7.Visible = False

        aggiornando = False

        controllo.Start()
    End Sub

    Private Sub controllo_Tick(sender As Object, e As EventArgs) Handles controllo.Tick
        updatedata()
    End Sub

    Dim templist As String
    Dim templist2 As String
    Dim templistnow As String
    Dim templistnow2 As String
    Public aggiornando As Boolean = False

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        controllo.Stop()
        aggutenti.Close()
        aggutenti.ListBox1.Items.AddRange(ListBox1.Items)
        aggnomecliente.Close()
        aggnomecliente.ShowDialog()

        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        ListBox1.Items.AddRange(lines)

        Try
            If Not aggnomecliente.nome.Text = "" Then
                ListBox1.SelectedItem = aggnomecliente.nome.Text
                Button3.PerformClick()
            End If
        Catch
        End Try
        controllo.Start()
    End Sub
End Class