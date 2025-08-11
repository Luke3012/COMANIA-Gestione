Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class materiale

    Dim numutente As String = Utente.numutente
    Dim dir As String = Utente.dir
    Dim folder As String
    Dim lines() As String
    Private Sub materiale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Hide()

        If Not Directory.Exists(dir & "\personal\" & numutente) Then
            Directory.CreateDirectory(dir & "\personal\" & numutente)
        End If
        If Not Directory.Exists(dir & "\personal\public") Then
            Directory.CreateDirectory(dir & "\personal\public")
        End If
        Try
            File.Delete(dir & "\personal\list.xls")
        Catch
        End Try
        Try
            File.WriteAllBytes(dir & "\personal\list.xls", My.Resources.lista)
        Catch
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim writelavoro As New StreamWriter(folder & "notes.txt", True)
        writelavoro.WriteLine(TextBox1.Text)
        writelavoro.Close()
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(folder & "notes.txt")
        ListBox1.Items.AddRange(lines)
        TextBox1.Text = ""
        cmdUp.Enabled = False
        cmdDown.Enabled = False
        delete.Enabled = False
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
        W = New IO.StreamWriter(folder & "notes.txt")
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
        W = New IO.StreamWriter(folder & "notes.txt")
        For i = 0 To ListBox1.Items.Count - 1
            W.WriteLine(ListBox1.Items.Item(i))
        Next
        W.Close()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim line As String
        Dim Input As StreamReader
        Dim PolicyIdCode As String
        Dim strFile As New ArrayList
        PolicyIdCode = ListBox1.SelectedItem
        Input = File.OpenText(folder & "notes.txt")
        While Input.Peek <> -1
            line = Input.ReadLine
            If Not line = PolicyIdCode Then
                strFile.Add(line)
            End If
        End While
        Input.Close()
        If File.Exists(folder & "notes.txt") Then
            File.Delete(folder & "notes.txt")
        End If
        Dim objWriter As New System.IO.StreamWriter(folder & "notes.txt", True)
        For Each item As String In strFile
            objWriter.WriteLine(item)
        Next
        objWriter.Flush()
        objWriter.Close()
        ListBox1.Items.Clear()
        lines = File.ReadAllLines(folder & "notes.txt")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        AcceptButton = Button2
    End Sub

    Dim xlPageBreakManual As Long = -4135
    Private Async Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Prima di stampare Aggiungi qualcosa nella tua lista!", MsgBoxStyle.Exclamation, "Attenzione!")
            Exit Sub
        End If
        Enabled = False
        Dim lst As List(Of String) = New List(Of String)
        For i = 0 To ListBox1.Items.Count - 1
            lst.Add(ListBox1.Items.Item(i))
        Next
        PictureBox1.Show()

        sceglistampante.Close()
        sceglistampante.ShowDialog()
        If sceglistampante.selected = "" Then
            PictureBox1.Hide()
            Enabled = True
            Exit Sub
        End If

        Dim stampante As String = sceglistampante.selected

        Dim task As New Task(Sub()
                                 Try
                                     Dim xlApp As New Excel.Application
                                     Dim xlWorkBook As Excel.Workbook
                                     Dim xlWorkSheet As Excel.Worksheet
                                     xlApp.DisplayAlerts = False
                                     xlApp.Workbooks.Open(dir & "\personal\list.xls")
                                     xlWorkBook = xlApp.ActiveWorkbook
                                     xlWorkSheet = xlWorkBook.ActiveSheet

                                     'Adesso parte il ciclo...
                                     Dim riga As Integer = 5
                                     For i = 0 To lst.Count - 1
                                         xlWorkSheet.Cells.Range("A" & riga).Value = i + 1
                                         xlWorkSheet.Cells.Range("B" & riga).Value = lst.Item(i)
                                         riga += 1
                                     Next

                                     xlWorkBook.SaveAs(folder & "print.xls")
                                     xlWorkBook.Save()
                                     xlWorkBook.Saved = True
                                     xlWorkSheet.PrintOut(From:=1, To:=1, Copies:=1, Collate:=True, ActivePrinter:=stampante)

                                     xlApp.Quit()
                                     releaseObject(xlApp)
                                     releaseObject(xlWorkBook)
                                 Catch
                                 End Try
                             End Sub)
        task.Start()
        Await task

        PictureBox1.Hide()
        Enabled = True
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Lista già vuota!", MsgBoxStyle.Exclamation, "Impossibile Eiminare!")
            Exit Sub
        End If

        If MessageBox.Show("Sei sicuro/a di voler eliminare tutti gli appunti?", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ListBox1.Items.Clear()
            File.Delete(folder & "notes.txt")
        End If
    End Sub

    Private Sub mod1_Click(sender As Object, e As EventArgs) Handles mod1.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()

        folder = dir & "\personal\public\"
        Try
            lines = File.ReadAllLines(folder & "notes.txt")
            ListBox1.Items.AddRange(lines)
        Catch
        End Try

        GroupBox1.Enabled = True
        mod1.BackColor = Color.White
        mod2.BackColor = Color.Silver
    End Sub

    Private Sub mod2_Click(sender As Object, e As EventArgs) Handles mod2.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""

        folder = dir & "\personal\" & numutente & "\"
        Try
            lines = File.ReadAllLines(folder & "notes.txt")
            ListBox1.Items.AddRange(lines)
        Catch
        End Try

        GroupBox1.Enabled = True
        mod2.BackColor = Color.White
        mod1.BackColor = Color.Silver
    End Sub
End Class