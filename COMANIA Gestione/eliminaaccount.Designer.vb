<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminaaccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eliminaaccount))
        Me.uno = New System.Windows.Forms.Button()
        Me.due = New System.Windows.Forms.Button()
        Me.tre = New System.Windows.Forms.Button()
        Me.quattro = New System.Windows.Forms.Button()
        Me.cinque = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uno
        '
        Me.uno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.uno.Location = New System.Drawing.Point(13, 121)
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
        Me.due.Location = New System.Drawing.Point(70, 121)
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
        Me.tre.Location = New System.Drawing.Point(129, 121)
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
        Me.quattro.Location = New System.Drawing.Point(186, 121)
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
        Me.cinque.Location = New System.Drawing.Point(245, 121)
        Me.cinque.Name = "cinque"
        Me.cinque.Size = New System.Drawing.Size(53, 41)
        Me.cinque.TabIndex = 21
        Me.cinque.Text = "5"
        Me.cinque.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.COMANIA_Gestione.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(14, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.delete
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(233, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 69)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 50)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Seleziona il numero dell'Account che vuoi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eliminare e poi premi il pulsante elim" &
    "ina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in basso a destra."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Digita la password legata all'account"
        '
        'pass
        '
        Me.pass.Enabled = False
        Me.pass.Location = New System.Drawing.Point(14, 204)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(286, 20)
        Me.pass.TabIndex = 26
        Me.pass.UseSystemPasswordChar = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(13, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(287, 32)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "RITORNA AL MENU'"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Seleziona un Account per Continuare"
        '
        'eliminaaccount
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 504)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cinque)
        Me.Controls.Add(Me.quattro)
        Me.Controls.Add(Me.tre)
        Me.Controls.Add(Me.due)
        Me.Controls.Add(Me.uno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "eliminaaccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimina un Account Computer Mania"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uno As Button
    Friend WithEvents due As Button
    Friend WithEvents tre As Button
    Friend WithEvents quattro As Button
    Friend WithEvents cinque As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
