<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.chkPavilion = New System.Windows.Forms.CheckBox()
        Me.chkLawn = New System.Windows.Forms.CheckBox()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.txtPavilion = New System.Windows.Forms.TextBox()
        Me.txtLawn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalTickets = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLawn)
        Me.GroupBox1.Controls.Add(Me.txtPavilion)
        Me.GroupBox1.Controls.Add(Me.txtBox)
        Me.GroupBox1.Controls.Add(Me.chkLawn)
        Me.GroupBox1.Controls.Add(Me.chkPavilion)
        Me.GroupBox1.Controls.Add(Me.chkBox)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Location = New System.Drawing.Point(26, 25)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(48, 21)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "&Box"
        Me.chkBox.UseVisualStyleBackColor = True
        '
        'chkPavilion
        '
        Me.chkPavilion.AutoSize = True
        Me.chkPavilion.Location = New System.Drawing.Point(80, 25)
        Me.chkPavilion.Name = "chkPavilion"
        Me.chkPavilion.Size = New System.Drawing.Size(71, 21)
        Me.chkPavilion.TabIndex = 1
        Me.chkPavilion.Text = "&Pavilion"
        Me.chkPavilion.UseVisualStyleBackColor = True
        '
        'chkLawn
        '
        Me.chkLawn.AutoSize = True
        Me.chkLawn.Location = New System.Drawing.Point(157, 25)
        Me.chkLawn.Name = "chkLawn"
        Me.chkLawn.Size = New System.Drawing.Size(56, 21)
        Me.chkLawn.TabIndex = 2
        Me.chkLawn.Text = "&Lawn"
        Me.chkLawn.UseVisualStyleBackColor = True
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(26, 52)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(27, 25)
        Me.txtBox.TabIndex = 3
        Me.txtBox.Visible = False
        '
        'txtPavilion
        '
        Me.txtPavilion.Location = New System.Drawing.Point(80, 52)
        Me.txtPavilion.Name = "txtPavilion"
        Me.txtPavilion.Size = New System.Drawing.Size(27, 25)
        Me.txtPavilion.TabIndex = 4
        Me.txtPavilion.Visible = False
        '
        'txtLawn
        '
        Me.txtLawn.Location = New System.Drawing.Point(157, 52)
        Me.txtLawn.Name = "txtLawn"
        Me.txtLawn.Size = New System.Drawing.Size(27, 25)
        Me.txtLawn.TabIndex = 5
        Me.txtLawn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total tickets:"
        '
        'lblTotalTickets
        '
        Me.lblTotalTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTickets.Location = New System.Drawing.Point(51, 173)
        Me.lblTotalTickets.Name = "lblTotalTickets"
        Me.lblTotalTickets.Size = New System.Drawing.Size(88, 29)
        Me.lblTotalTickets.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDue.Location = New System.Drawing.Point(51, 234)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(88, 29)
        Me.lblTotalDue.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(180, 189)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(84, 34)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 295)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalTickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Ticket Miser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLawn As System.Windows.Forms.TextBox
    Friend WithEvents txtPavilion As System.Windows.Forms.TextBox
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents chkLawn As System.Windows.Forms.CheckBox
    Friend WithEvents chkPavilion As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTickets As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
