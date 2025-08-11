Imports System.IO
Public Class other
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MessageBox.Show("Sei sicuro/a di voler eliminare TUTTI i dati dei Clienti?", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If MessageBox.Show("In questo modo non elimino i dati degli utenti, ma dei clienti...Vado?", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If MessageBox.Show("Ultimo avvertimento, perderai TUTTI i dati! Procedo?", "ELIMINO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    aggutenti.Close()
                    checkbars.Close()
                    editimage.Close()
                    editname.Close()
                    ModLavori.Close()
                    eliminando.Show()
                    Utente.Close()
                    Try
                        Directory.Delete(dir & "\persons", True)
                        Directory.CreateDirectory(dir & "\persons")
                        Close()
                    Catch
                        MsgBox("Errore eliminazione dati clienti!", MsgBoxStyle.Exclamation)
                        Utente.Show()
                        eliminando.Close()
                        Close()
                    End Try
                Else
                    Close()
                End If
            Else
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aggiornandodati.Show()
        Utente.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Sei sicuro/a di voler scaricare l'ultimo Update di COMANIA? Chiuderò tutto il tuo lavoro!", "PROCEDO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            aggiorna.Show()
            Utente.Close()
        End If
    End Sub
End Class