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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMTE = New System.Windows.Forms.Label()
        Me.lblTEY = New System.Windows.Forms.Label()
        Me.txtLoanPay = New System.Windows.Forms.TextBox()
        Me.txtInsurePay = New System.Windows.Forms.TextBox()
        Me.txtOilChange = New System.Windows.Forms.TextBox()
        Me.txtMaint = New System.Windows.Forms.TextBox()
        Me.txtCarWash = New System.Windows.Forms.TextBox()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "loan payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "insurance payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "oil change"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "maintenance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "car washes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "gas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "month's total espenses"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "total expenses for year"
        '
        'lblMTE
        '
        Me.lblMTE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMTE.Location = New System.Drawing.Point(155, 239)
        Me.lblMTE.Name = "lblMTE"
        Me.lblMTE.Size = New System.Drawing.Size(100, 27)
        Me.lblMTE.TabIndex = 13
        '
        'lblTEY
        '
        Me.lblTEY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTEY.Location = New System.Drawing.Point(155, 282)
        Me.lblTEY.Name = "lblTEY"
        Me.lblTEY.Size = New System.Drawing.Size(100, 27)
        Me.lblTEY.TabIndex = 15
        '
        'txtLoanPay
        '
        Me.txtLoanPay.Location = New System.Drawing.Point(155, 23)
        Me.txtLoanPay.Name = "txtLoanPay"
        Me.txtLoanPay.Size = New System.Drawing.Size(100, 23)
        Me.txtLoanPay.TabIndex = 1
        '
        'txtInsurePay
        '
        Me.txtInsurePay.Location = New System.Drawing.Point(155, 53)
        Me.txtInsurePay.Name = "txtInsurePay"
        Me.txtInsurePay.Size = New System.Drawing.Size(100, 23)
        Me.txtInsurePay.TabIndex = 3
        '
        'txtOilChange
        '
        Me.txtOilChange.Location = New System.Drawing.Point(155, 82)
        Me.txtOilChange.Name = "txtOilChange"
        Me.txtOilChange.Size = New System.Drawing.Size(100, 23)
        Me.txtOilChange.TabIndex = 5
        '
        'txtMaint
        '
        Me.txtMaint.Location = New System.Drawing.Point(155, 113)
        Me.txtMaint.Name = "txtMaint"
        Me.txtMaint.Size = New System.Drawing.Size(100, 23)
        Me.txtMaint.TabIndex = 7
        '
        'txtCarWash
        '
        Me.txtCarWash.Location = New System.Drawing.Point(155, 144)
        Me.txtCarWash.Name = "txtCarWash"
        Me.txtCarWash.Size = New System.Drawing.Size(100, 23)
        Me.txtCarWash.TabIndex = 9
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(155, 173)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(100, 23)
        Me.txtGas.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(271, 262)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 23)
        Me.btnCalc.TabIndex = 16
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 357)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.txtCarWash)
        Me.Controls.Add(Me.txtMaint)
        Me.Controls.Add(Me.txtOilChange)
        Me.Controls.Add(Me.txtInsurePay)
        Me.Controls.Add(Me.txtLoanPay)
        Me.Controls.Add(Me.lblTEY)
        Me.Controls.Add(Me.lblMTE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Car Pay Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMTE As System.Windows.Forms.Label
    Friend WithEvents lblTEY As System.Windows.Forms.Label
    Friend WithEvents txtLoanPay As System.Windows.Forms.TextBox
    Friend WithEvents txtInsurePay As System.Windows.Forms.TextBox
    Friend WithEvents txtOilChange As System.Windows.Forms.TextBox
    Friend WithEvents txtMaint As System.Windows.Forms.TextBox
    Friend WithEvents txtCarWash As System.Windows.Forms.TextBox
    Friend WithEvents txtGas As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
