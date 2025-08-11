Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Windows

Public Class stampa
    Private Sub stampa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Hide()
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TopMost = False
        Button1.Enabled = False
        Button1.Text = "STAMPO ..."
        Button3.Enabled = False
        Button2.Hide()
            PictureBox1.Show()

            'Campo Dichiarazioni
            Dim utenteselecteduser As String = Utente.selecteduser.Text
            Dim utentetextbox5 As String = Utente.TextBox5.Text
            Dim utentetextbox6 As String = Utente.TextBox6.Text
            Dim utentebarra As String = Utente.barra.Text
            Dim utentecheckbox4 As Boolean = Utente.CheckBox4.Checked
            Dim utentecheckbox1 As Boolean = Utente.CheckBox1.Checked
            Dim utentecheckbox5 As Boolean = Utente.CheckBox5.Checked
            Dim utentecombobox2 As String = Utente.ComboBox2.Text
            Dim utentecombobox1 As String = Utente.ComboBox1.Text
            Dim utentetextbox8 As String = Utente.TextBox8.Text
            Dim utentetextbox9 As String = Utente.TextBox9.Text
        Dim utentetextbox2 As String = Utente.TextBox2.Text
        Dim utentetextbox4 As String = Utente.TextBox4.Text

        Dim errore As Boolean = False

        sceglistampante.Close()
        sceglistampante.ShowDialog()
        If sceglistampante.selected = "" Then
            Button1.Enabled = True
            Button1.Text = "STAMPA!"
            Button3.Enabled = True
            Button2.Show()
            PictureBox1.Hide()
            Exit Sub
        End If

        Dim stampante As String = sceglistampante.selected

        Dim task As New Task(Sub()
                                 Try
                                     Try
                                         File.Delete(Forms.Application.StartupPath & "\print.xls")
                                     Catch
                                     End Try
                                     Dim xlApp As New Excel.Application
                                     Dim xlWorkBook As Excel.Workbook
                                     Dim xlWorkSheet As Excel.Worksheet
                                     xlApp.DisplayAlerts = False
                                     xlApp.Workbooks.Open(Forms.Application.StartupPath & "\COMANIA.xls")
                                     xlWorkBook = xlApp.ActiveWorkbook
                                     xlWorkSheet = xlWorkBook.ActiveSheet
                                     xlWorkSheet.Cells.Range("B5").Value = utentetextbox4
                                     xlWorkSheet.Cells.Range("B6").Value = utenteselecteduser
                                     xlWorkSheet.Cells.Range("B7").Value = utentetextbox5
                                     xlWorkSheet.Cells.Range("B9").Value = utentetextbox6
                                     If Not utentebarra = "" Then
                                         xlWorkSheet.Cells.Range("B10").Value = utentebarra
                                     Else
                                         xlWorkSheet.Cells.Range("B10").Value = "NESSUN SERIALE"
                                     End If
                                     If utentecheckbox4 = True Then
                                         xlWorkSheet.Cells.Range("B11").Value = xlWorkSheet.Cells.Range("B11").Value & "BORSA "
                                     End If
                                     If utentecheckbox1 = True Then
                                         xlWorkSheet.Cells.Range("B11").Value = xlWorkSheet.Cells.Range("B11").Value & "CARICABATTERIE "
                                     End If
                                     If utentecheckbox5 = True Then
                                         xlWorkSheet.Cells.Range("B11").Value = xlWorkSheet.Cells.Range("B11").Value & "ALTRO"
                                     End If
                                     If Not utentecombobox2 = "" Then
                                         xlWorkSheet.Cells.Range("B12").Value = utentecombobox2
                                     Else
                                         xlWorkSheet.Cells.Range("B12").Value = "NON SPECIFICATO"
                                     End If
                                     xlWorkSheet.Cells.Range("B14").Value = utentecombobox1
                                     If Not utentetextbox8 = "" Then
                                         xlWorkSheet.Cells.Range("B15").Value = "€ " & utentetextbox8
                                     Else
                                         xlWorkSheet.Cells.Range("B15").Value = "€ 0"
                                     End If
                                     If utentetextbox9 = "" Or utentetextbox9 = " " Then
                                         xlWorkSheet.Cells.Range("B16").Value = "NESSUNA NOTA"
                                     Else
                                         xlWorkSheet.Cells.Range("B16").Value = utentetextbox9
                                     End If

                                     xlWorkSheet.Cells.Range("B18").Value = utentetextbox2
                                     xlApp.DisplayAlerts = False
                                     xlWorkBook.SaveAs(Forms.Application.StartupPath & "\print.xls")
                                     xlWorkBook.Save()
                                     xlWorkBook.Saved = True
                                     xlWorkSheet.PrintOut(From:=1, To:=1, Copies:=1, Collate:=True, ActivePrinter:=stampante)
                                     xlApp.Quit()
                                     xlApp.Workbooks.Close()
                                     File.SetAttributes(Forms.Application.StartupPath & "\print.xls", FileAttributes.Hidden)
                                     xlApp.Quit()
                                     releaseObject(xlApp)
                                     releaseObject(xlWorkBook)
                                 Catch
                                     errore = True
                                 End Try
                             End Sub)
        task.Start()
        Await task

        Close()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button2.Show()
        PictureBox1.Hide()
        Button2.Text = "Chiudi"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If My.Computer.Network.IsAvailable = True Then
            downloadxls.Close()
            downloadxls.Show()
            Close()
        End If
    End Sub
End Class