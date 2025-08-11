Imports System.IO
Public Class aggutenti
    Dim lines As String()
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Private Sub aggutenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        ListBox1.Items.AddRange(lines)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Utente.ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        Utente.ListBox1.Items.AddRange(lines)
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim selStart As Integer = TextBox1.SelectionStart
        TextBox1.Text = TextBox1.Text.ToUpper()
        TextBox1.SelectionStart = selStart
        TextBox1.Enabled = True

        If (TextBox1.Text.Replace(" ", "") = "") Or TextBox1.Text = ListBox1.SelectedItem Then
            Button2.Visible = False
            AcceptButton = delete
            Exit Sub
        End If

        Button2.Visible = True
        AcceptButton = Button2
    End Sub

    Dim selezionato As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex < 0 Then
            TextBox1.Text = ""
            TextBox1.Enabled = False
            Exit Sub
        End If

        selezionato = ListBox1.SelectedItem
        If selezionato = "" Then
            delete.Enabled = False
            cmdUp.Enabled = False
            cmdDown.Enabled = False
        Else
            delete.Enabled = True
            cmdUp.Enabled = True
            cmdDown.Enabled = True
        End If
        If Not ListBox1.SelectedIndex > 0 Then
            cmdUp.Enabled = False
        End If
        If Not ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            cmdDown.Enabled = False
        End If

        TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Dim checkcartelle() As String
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If ListBox1.SelectedIndex < 0 Or ListBox1.SelectedIndex > ListBox1.Items.Count - 1 Then
            MsgBox("Seleziona un elemento prima di eliminare!", MsgBoxStyle.Exclamation, "Attenzione!")
            Exit Sub
        End If

        Try
            checkcartelle = Directory.GetDirectories(dir & "\persons\" & ListBox1.SelectedItem & "\")
            Convert.ToInt32(checkcartelle.Length)
            If checkcartelle.Length > 0 Then
                MsgBox("Devi prima eliminare i suoi lavori!", MsgBoxStyle.Exclamation)
            Else
                deleting()
            End If
        Catch
            deleting()
        End Try
    End Sub
    Private Sub deleting()
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
        TextBox1.Text = ""
        selezionato = ""
        delete.Enabled = False
        cmdUp.Enabled = False
        cmdDown.Enabled = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        save()

        TextBox1.Text = ""
        selezionato = ""
        delete.Enabled = False
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        ListBox1.Items.AddRange(lines)
        cmdUp.Enabled = False
        cmdDown.Enabled = False
        aggnomecliente.Close()
        aggnomecliente.ShowDialog()
    End Sub

    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        If ListBox1.SelectedIndex > 0 Then
            Dim F = ListBox1.SelectedIndex - 1
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F
        End If

        save()
    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            Dim F = ListBox1.SelectedIndex + 2
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F - 1
        End If

        save()
    End Sub

    Private Sub save()
        Dim W As IO.StreamWriter
        Dim i As Integer
        W = New IO.StreamWriter(dir & "\persons\list.txt")
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex < 0 Or ListBox1.SelectedIndex > ListBox1.Items.Count - 1 Then
            MsgBox("Seleziona un elemento prima di modificare!", MsgBoxStyle.Exclamation, "Attenzione!")
            Exit Sub
        End If
        Dim before As String = ListBox1.Items.Item(ListBox1.SelectedIndex)
        Try
            My.Computer.FileSystem.RenameDirectory(dir & "\persons\" & before, TextBox1.Text)
        Catch
            MsgBox("Si è verificato un errore durante la rinominazione!", MsgBoxStyle.Critical, "Errore!")
            Exit Sub
        End Try
        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text
        If Utente.ListBox1.SelectedItem = before Then Utente.selecteduser.Text = TextBox1.Text

        Button2.Visible = False
        save()
        Try
            File.WriteAllText(dir & "\persons\tofiwrite.txt", File.ReadAllText(dir & "\persons\tofiwrite.txt").Replace(before, TextBox1.Text))
        Catch
        End Try
        Try
            File.WriteAllText(dir & "\persons\todowrite.txt", File.ReadAllText(dir & "\persons\todowrite.txt").Replace(before, TextBox1.Text))
        Catch
        End Try
        AcceptButton = delete
    End Sub
End Class