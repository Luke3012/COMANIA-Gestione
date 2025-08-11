<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModLavori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModLavori))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.cmdUp = New System.Windows.Forms.Button()
        Me.cmdDown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Elimina lavori"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Chiudi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Aggiungi Lavori"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.Add
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(248, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 48)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 10
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(15, 97)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 212)
        Me.ListBox1.TabIndex = 13
        '
        'delete
        '
        Me.delete.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.delete
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.Enabled = False
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Location = New System.Drawing.Point(235, 318)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(62, 64)
        Me.delete.TabIndex = 19
        Me.delete.UseVisualStyleBackColor = True
        '
        'cmdUp
        '
        Me.cmdUp.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.short_round_up_arrow_512
        Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUp.Enabled = False
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.Location = New System.Drawing.Point(248, 97)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Size = New System.Drawing.Size(48, 45)
        Me.cmdUp.TabIndex = 20
        Me.cmdUp.UseVisualStyleBackColor = True
        '
        'cmdDown
        '
        Me.cmdDown.BackgroundImage = Global.COMANIA_Gestione.My.Resources.Resources.Rounded_shift_down_arrow
        Me.cmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDown.Enabled = False
        Me.cmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDown.Location = New System.Drawing.Point(248, 264)
        Me.cmdDown.Name = "cmdDown"
        Me.cmdDown.Size = New System.Drawing.Size(48, 45)
        Me.cmdDown.TabIndex = 21
        Me.cmdDown.UseVisualStyleBackColor = True
        '
        'ModLavori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDown)
        Me.Controls.Add(Me.cmdUp)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModLavori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Lavori Computer Mania"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents delete As Button
    Friend WithEvents cmdUp As Button
    Friend WithEvents cmdDown As Button
End Class
