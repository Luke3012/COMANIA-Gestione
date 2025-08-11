Imports System.Drawing.Printing

Public Class sceglistampante
    Public selected As String = ""

    Private Sub Sceglistampante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String

        ' Find all printers installed
        For Each pkInstalledPrinters In
        PrinterSettings.InstalledPrinters
            ListBox1.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        If IO.File.Exists(Application.StartupPath & "\stampante") Then
            If ListBox1.Items.Contains(IO.File.ReadAllText(Application.StartupPath & "\stampante")) Then
                ListBox1.SelectedItem = IO.File.ReadAllText(Application.StartupPath & "\stampante")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selected = ""
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.File.WriteAllText(Application.StartupPath & "\stampante", ListBox1.SelectedItem, System.Text.Encoding.Default)
        Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex < 0 Then
            Button1.Enabled = False
            selected = ""
            Exit Sub
        End If

        selected = ListBox1.SelectedItem
        Button1.Enabled = True
    End Sub
End Class