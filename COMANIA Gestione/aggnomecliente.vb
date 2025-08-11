Imports System.IO
Public Class aggnomecliente
    Dim lines As String()
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Directory.Exists(dir & "\persons\" & nome.Text) Then
            If aggutenti.ListBox1.Items.Contains(nome.Text) Then
                Directory.CreateDirectory(dir & "\persons\" & nome.Text)
                MsgBox("Questo Cliente risulta già inserito nel Database, è stato ripristinato perché corrotto.", MsgBoxStyle.Exclamation)
                If aggutenti.Visible = False Then Close()
            Else
                aggiungi()
            End If
        Else
            If Not aggutenti.ListBox1.Items.Contains(nome.Text) Then
                aggiungi()
            Else
                MsgBox("Questo Cliente è già stato inserito nel database!", MsgBoxStyle.Exclamation)
                If aggutenti.Visible = False Then Close()
            End If
        End If
    End Sub
    Private Sub aggiungi()
        Dim writeutente As New StreamWriter(dir & "\persons\list.txt", True)
        writeutente.WriteLine(nome.Text)
        writeutente.Close()
        aggutenti.ListBox1.Items.Clear()
        lines = File.ReadAllLines(dir & "\persons\list.txt")
        aggutenti.ListBox1.Items.AddRange(lines)
        Try
            Directory.CreateDirectory(dir & "\persons\" & nome.Text)
        Catch
        End Try
        Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub nome_TextChanged(sender As Object, e As EventArgs) Handles nome.TextChanged
        Dim selStart As Integer = nome.SelectionStart
        nome.Text = nome.Text.ToUpper()
        nome.SelectionStart = selStart
        If nome.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class