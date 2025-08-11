Imports System.IO
Public Class visualizzanonfiniti
    Dim dir As String = file.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Dim files As String()
    Private Sub visualizzanonfiniti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListBox1.Items.Clear()
            files = File.ReadAllLines(dir & "\persons\todowrite.txt")
            ListBox1.Items.AddRange(files)
            setting()
        Catch
            MsgBox("Nessun lavoro da completare!")
            Close()
        End Try
    End Sub

    Dim strOrig As String
    Dim leftString As String
    Dim rightString As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selezionato As String
        selezionato = ListBox1.SelectedItem
        If Not selezionato = "" Then
            Button1.Enabled = True
            TextBox1.Text = File.ReadAllText(dir & "\persons\" & ListBox1.SelectedItem & "\date.txt")
            strOrig = ListBox1.SelectedItem
            leftString = strOrig.Substring(0, strOrig.IndexOf("\"))
            rightString = Split(ListBox1.SelectedItem, "\")(1)
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x As Integer = 0 To Utente.ListBox1.Items.Count - 1
            If Utente.ListBox1.Items(x).ToString = leftString Then
                Utente.ListBox1.SelectedIndex = x
            End If
        Next
        For y As Integer = 0 To Utente.ListBox2.Items.Count - 1
            If Utente.ListBox2.Items(y).ToString = rightString Then
                Utente.ListBox2.SelectedIndex = y
            End If
        Next
        Close()
    End Sub

    Private Sub setting()
        Dim writetofi As New StreamWriter(dir & "\persons\todo.txt")
        writetofi.Write(ListBox1.Items.Count)
        writetofi.Close()
    End Sub
End Class