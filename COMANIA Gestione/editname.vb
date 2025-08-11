Imports System.IO
Imports System.Media

Public Class editname
    Dim numutente As String = File.ReadAllText(Application.StartupPath & "\utentetemp.txt")
    Dim dir As String = File.ReadAllText(Application.StartupPath & "\percorsotemp.txt")
    Dim curpass As String = ""

    Private Sub editname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nome.Text = File.ReadAllText(dir & "\logininfo\" & numutente & "\nome.txt")
        curpass = File.ReadAllText(dir & "\logininfo\" & numutente & "\pass.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pass1.ReadOnly = True Then
            If pass2.Text = "" Then
                MsgBox("La Password non può essere vuota!", MsgBoxStyle.Exclamation, "Password")
                Exit Sub
            End If
            If MessageBox.Show("Sei sicuro/a di voler cambiare password in '" & pass2.Text & "' ?", "MODIFICO?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim write2 As New StreamWriter(dir & "\logininfo\" & numutente & "\pass.txt")
                write2.Write(pass2.Text)
                write2.Close()
            End If
        End If
        Dim write As New StreamWriter(dir & "\logininfo\" & numutente & "\nome.txt")
        write.Write(nome.Text)
        write.Close()
        Utente.nome.Text = File.ReadAllText(dir & "\logininfo\" & numutente & "\nome.txt")
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pass1.TextChanged
        If pass1.Text = curpass Then
            pass1.ReadOnly = True
            pass2.ReadOnly = False
            SystemSounds.Asterisk.Play()
            Label3.Text = "Password Corretta!"
            pass2.Select()
        End If
    End Sub

    Private Sub pass2_TextChanged(sender As Object, e As EventArgs) Handles pass2.TextChanged

    End Sub
End Class