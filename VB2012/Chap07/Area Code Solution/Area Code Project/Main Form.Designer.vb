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
        Me.cboAreaCodes = New System.Windows.Forms.ComboBox()
        Me.lblDisplayState = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboAreaCodes
        '
        Me.cboAreaCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAreaCodes.FormattingEnabled = True
        Me.cboAreaCodes.Location = New System.Drawing.Point(29, 66)
        Me.cboAreaCodes.Name = "cboAreaCodes"
        Me.cboAreaCodes.Size = New System.Drawing.Size(121, 28)
        Me.cboAreaCodes.TabIndex = 0
        '
        'lblDisplayState
        '
        Me.lblDisplayState.BackColor = System.Drawing.SystemColors.Info
        Me.lblDisplayState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayState.Location = New System.Drawing.Point(236, 66)
        Me.lblDisplayState.Name = "lblDisplayState"
        Me.lblDisplayState.Size = New System.Drawing.Size(132, 62)
        Me.lblDisplayState.TabIndex = 1
        Me.lblDisplayState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area Codes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "State:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 181)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDisplayState)
        Me.Controls.Add(Me.cboAreaCodes)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Area Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAreaCodes As System.Windows.Forms.ComboBox
    Friend WithEvents lblDisplayState As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
