Imports System.IO
Public Class ModLavori
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Dim lines As String()
    Private Sub ModLavori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\worklist.txt")
        ListBox1.Items.AddRange(lines)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Utente.ComboBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\worklist.txt")
        Utente.ComboBox1.Items.AddRange(lines)
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button2.Enabled = True
        Dim selStart As Integer = TextBox1.SelectionStart
        TextBox1.Text = TextBox1.Text.ToUpper()
        TextBox1.SelectionStart = selStart
        If TextBox1.Text = "" Then
            Button2.Enabled = False
        End If
        If ListBox1.Items.Contains(TextBox1.Text) Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim writelavoro As New StreamWriter(dir & "\persons\worklist.txt", True)
        writelavoro.WriteLine(TextBox1.Text)
        writelavoro.Close()
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\worklist.txt")
        ListBox1.Items.AddRange(lines)
        TextBox1.Text = ""
        cmdUp.Enabled = False
        cmdDown.Enabled = False
        delete.Enabled = False
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim line As String
        Dim Input As StreamReader
        Dim PolicyIdCode As String
        Dim strFile As New ArrayList
        PolicyIdCode = ListBox1.SelectedItem
        Input = File.OpenText(dir & "\persons\worklist.txt")
        While Input.Peek <> -1
            line = Input.ReadLine
            If Not line = PolicyIdCode Then
                strFile.Add(line)
            End If
        End While
        Input.Close()
        If File.Exists(dir & "\persons\worklist.txt") Then
            File.Delete(dir & "\persons\worklist.txt")
        End If
        Dim objWriter As New System.IO.StreamWriter(dir & "\persons\worklist.txt", True)
        For Each item As String In strFile
            objWriter.WriteLine(item)
        Next
        objWriter.Flush()
        objWriter.Close()
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\worklist.txt")
        ListBox1.Items.AddRange(lines)
        delete.Enabled = False
        selezionato = ""
        cmdUp.Enabled = False
        cmdDown.Enabled = False
    End Sub

    Dim selezionato As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
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
    End Sub

    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        If ListBox1.SelectedIndex > 0 Then
            Dim F = ListBox1.SelectedIndex - 1
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F
        End If
        Dim W As IO.StreamWriter
        Dim i As Integer
        W = New IO.StreamWriter(dir & "\persons\worklist.txt")
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            Dim F = ListBox1.SelectedIndex + 2
            ListBox1.Items.Insert(F, ListBox1.SelectedItem)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            ListBox1.SelectedIndex = F - 1
        End If
        Dim W As IO.StreamWriter
        Dim i As Integer
        W = New IO.StreamWriter(dir & "\persons\worklist.txt")
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub
End Class