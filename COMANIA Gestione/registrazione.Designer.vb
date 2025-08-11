<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrazione
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrazione))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.uno = New System.Windows.Forms.Button()
        Me.due = New System.Windows.Forms.Button()
        Me.tre = New System.Windows.Forms.Button()
        Me.quattro = New System.Windows.Forms.Button()
        Me.cinque = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleziona il numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "utente che desideri, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i numeri già registrati" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sono quelli " &
    "disabilitati."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.COMANIA_Gestione.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'uno
        '
        Me.uno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uno.Location = New System.Drawing.Point(27, 172)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(51, 41)
        Me.uno.TabIndex = 17
        Me.uno.Text = "1"
        Me.uno.UseVisualStyleBackColor = True
        '
        'due
        '
        Me.due.Cursor = System.Windows.Forms.Cursors.Hand
        Me.due.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.due.Location = New System.Drawing.Point(84, 172)
        Me.due.Name = "due"
        Me.due.Size = New System.Drawing.Size(53, 41)
        Me.due.TabIndex = 18
        Me.due.Text = "2"
        Me.due.UseVisualStyleBackColor = True
        '
        'tre
        '
        Me.tre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tre.Location = New System.Drawing.Point(143, 172)
        Me.tre.Name = "tre"
        Me.tre.Size = New System.Drawing.Size(53, 41)
        Me.tre.TabIndex = 19
        Me.tre.Text = "3"
        Me.tre.UseVisualStyleBackColor = True
        '
        'quattro
        '
        Me.quattro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quattro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quattro.Location = New System.Drawing.Point(202, 172)
        Me.quattro.Name = "quattro"
        Me.quattro.Size = New System.Drawing.Size(53, 41)
        Me.quattro.TabIndex = 20
        Me.quattro.Text = "4"
        Me.quattro.UseVisualStyleBackColor = True
        '
        'cinque
        '
        Me.cinque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cinque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cinque.Location = New System.Drawing.Point(261, 172)
        Me.cinque.Name = "cinque"
        Me.cinque.Size = New System.Drawing.Size(53, 41)
        Me.cinque.TabIndex = 21
        Me.cinque.Text = "5"
        Me.cinque.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Foto! (Opzionale, ma figo :D)"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(193, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Seleziona una foto cliccando qui..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(119, 247)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(119, 295)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Immagine o GIF|*.bmp;*.jpg;*.gif;*.img;*.png"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(59, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 40)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Crea ACCOUNT!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 471)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(302, 29)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "TORNA AL MENU'"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "La password sarà visibile, ma solo per questa volta."
        '
        'registrazione
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cinque)
        Me.Controls.Add(Me.quattro)
        Me.Controls.Add(Me.tre)
        Me.Controls.Add(Me.due)
        Me.Controls.Add(Me.uno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registrazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrazione Computer Mania"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents uno As Button
    Friend WithEvents due As Button
    Friend WithEvents tre As Button
    Friend WithEvents quattro As Button
    Friend WithEvents cinque As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
End Class
