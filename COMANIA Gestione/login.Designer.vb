<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.infoagg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.uno = New System.Windows.Forms.Button()
        Me.due = New System.Windows.Forms.Button()
        Me.tre = New System.Windows.Forms.Button()
        Me.quattro = New System.Windows.Forms.Button()
        Me.cinque = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTIONE ORDINI COMPUTER MANIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Che utente sei?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(455, 147)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(234, 20)
        Me.pass.TabIndex = 5
        Me.pass.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(381, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(308, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Accedi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Verifica Aggiornamenti"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.COMANIA_Gestione.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Versione 0.0"
        '
        'infoagg
        '
        Me.infoagg.AutoSize = True
        Me.infoagg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoagg.Location = New System.Drawing.Point(12, 425)
        Me.infoagg.Name = "infoagg"
        Me.infoagg.Size = New System.Drawing.Size(261, 15)
        Me.infoagg.TabIndex = 9
        Me.infoagg.Text = "Non ho verificato la presenza di aggiornamenti"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Accesso e registrazione riservati solo allo staff!"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(381, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(308, 32)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Altrimenti Registrati"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(389, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(311, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SELEZIONA PRIMA LA CARTELLA DEI DATI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(692, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "  (comania)"
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(695, 441)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 33)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(415, 454)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(274, 20)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "Percorso..."
        '
        'uno
        '
        Me.uno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uno.Location = New System.Drawing.Point(402, 100)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(51, 41)
        Me.uno.TabIndex = 16
        Me.uno.Text = "1"
        Me.uno.UseVisualStyleBackColor = True
        '
        'due
        '
        Me.due.Cursor = System.Windows.Forms.Cursors.Hand
        Me.due.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.due.Location = New System.Drawing.Point(459, 100)
        Me.due.Name = "due"
        Me.due.Size = New System.Drawing.Size(53, 41)
        Me.due.TabIndex = 17
        Me.due.Text = "2"
        Me.due.UseVisualStyleBackColor = True
        '
        'tre
        '
        Me.tre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tre.Location = New System.Drawing.Point(518, 100)
        Me.tre.Name = "tre"
        Me.tre.Size = New System.Drawing.Size(53, 41)
        Me.tre.TabIndex = 18
        Me.tre.Text = "3"
        Me.tre.UseVisualStyleBackColor = True
        '
        'quattro
        '
        Me.quattro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quattro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quattro.Location = New System.Drawing.Point(577, 100)
        Me.quattro.Name = "quattro"
        Me.quattro.Size = New System.Drawing.Size(53, 41)
        Me.quattro.TabIndex = 19
        Me.quattro.Text = "4"
        Me.quattro.UseVisualStyleBackColor = True
        '
        'cinque
        '
        Me.cinque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cinque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cinque.Location = New System.Drawing.Point(636, 100)
        Me.cinque.Name = "cinque"
        Me.cinque.Size = New System.Drawing.Size(53, 41)
        Me.cinque.TabIndex = 20
        Me.cinque.Text = "5"
        Me.cinque.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.delete
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(695, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 66)
        Me.Button5.TabIndex = 21
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(692, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Elimina Account"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Clicca su ""..."" per selezionare una cartella origine dati!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(365, 341)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(265, 28)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Cosa è cambiato nell'ultima versione?"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(362, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Visualizza il Changelog qui!"
        '
        'login
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 486)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cinque)
        Me.Controls.Add(Me.quattro)
        Me.Controls.Add(Me.tre)
        Me.Controls.Add(Me.due)
        Me.Controls.Add(Me.uno)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.infoagg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login su ComputerMania"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents infoagg As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents uno As Button
    Friend WithEvents due As Button
    Friend WithEvents tre As Button
    Friend WithEvents quattro As Button
    Friend WithEvents cinque As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents Label10 As Label
End Class
