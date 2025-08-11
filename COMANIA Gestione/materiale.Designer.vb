<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class materiale
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mod1 = New System.Windows.Forms.Button()
        Me.mod2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(537, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Chiudi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Scrivi qui cosa vuoi aggiungere alla lista."
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(26, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(315, 169)
        Me.ListBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sposta e/o elimina i tuoi appunti"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stampa"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.printIcon_bw
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(424, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 81)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.Rounded_shift_down_arrow
        Me.cmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDown.Enabled = False
        Me.cmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDown.Location = New System.Drawing.Point(347, 250)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(48, 45)
        Me.cmdDown.TabIndex = 31
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.short_round_up_arrow_512
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUp.Enabled = False
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.Location = New System.Drawing.Point(347, 126)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(48, 45)
        Me.cmdUp.TabIndex = 30
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.delete
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.Enabled = False
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Location = New System.Drawing.Point(347, 188)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(48, 51)
        Me.delete.TabIndex = 29
        Me.delete.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.Add
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(414, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 48)
        Me.Button2.TabIndex = 32
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(89, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(319, 21)
        Me.TextBox1.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.unnamed__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(424, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 81)
        Me.Button3.TabIndex = 35
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Resetta Tutto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(183, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Seleziona la Modalità"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.delete)
        Me.GroupBox1.Controls.Add(Me.cmdDown)
        Me.GroupBox1.Controls.Add(Me.cmdUp)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 335)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'mod1
        '
        Me.mod1.BackColor = System.Drawing.Color.Silver
        Me.mod1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod1.Location = New System.Drawing.Point(77, 30)
        Me.mod1.Name = "mod1"
        Me.mod1.Size = New System.Drawing.Size(167, 44)
        Me.mod1.TabIndex = 38
        Me.mod1.Text = "Pubblico"
        Me.mod1.UseVisualStyleBackColor = False
        '
        'mod2
        '
        Me.mod2.BackColor = System.Drawing.Color.Silver
        Me.mod2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod2.Location = New System.Drawing.Point(305, 30)
        Me.mod2.Name = "mod2"
        Me.mod2.Size = New System.Drawing.Size(167, 44)
        Me.mod2.TabIndex = 39
        Me.mod2.Text = "Privato"
        Me.mod2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.COMANIA_Gestione.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(15, 438)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'materiale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mod2)
        Me.Controls.Add(Me.mod1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "materiale"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materiale da Ordinare / Appunti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents cmdDown As Button
    Friend WithEvents cmdUp As Button
    Friend WithEvents delete As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mod1 As Button
    Friend WithEvents mod2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
