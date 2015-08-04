' Name:         Cerruti Project
' Purpose:      Displays gross pay, taxes, and net pay
' Programmer:   <chris golpashin> on <11-11-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' GetFwt function
    Private Function GetFwt(ByVal strMarital As String, ByVal intNumAllow As Integer, ByVal dblWeekPay As Double) As Double
        ' calculates and returns the FWT

        Const dblONE_ALLOW As Double = 73.08
        Dim dblTaxWages As Double
        Dim dblTax As Double

        ' calculate taxable wages
        dblTaxWages = dblWeekPay - intNumAllow * dblONE_ALLOW

        ' determine marital status and then calculate FWT
        If strMarital = "S" Then
            Select Case dblTaxWages
                Case Is <= 41
                    dblTax = 0
                Case Is <= 209
                    dblTax = 0.1 * (dblTaxWages - 41)
                Case Is <= 721
                    dblTax = 16.8 + 0.15 * (dblTaxWages - 209)
                Case Is <= 1688
                    dblTax = 93.6 + 0.25 * (dblTaxWages - 721)
                Case Is <= 3477
                    dblTax = 335.35 + 0.28 * (dblTaxWages - 1688)
                Case Is <= 7510
                    dblTax = 836.27 + 0.33 * (dblTaxWages - 3477)
                Case Else
                    dblTax = 2167.16 + 0.35 * (dblTaxWages - 7510)
            End Select
        Else        ' strMarital = "M"
            Select Case dblTaxWages
                Case Is <= 156
                    dblTax = 0
                Case Is <= 490
                    dblTax = 0.1 * (dblTaxWages - 156)
                Case Is <= 1515
                    dblTax = 33.4 + 0.15 * (dblTaxWages - 490)
                Case Is <= 2900
                    dblTax = 187.15 + 0.25 * (dblTaxWages - 1515)
                Case Is <= 4338
                    dblTax = 533.4 + 0.28 * (dblTaxWages - 2900)
                Case Is <= 7624
                    dblTax = 936.04 + 0.33 * (dblTaxWages - 4338)
                Case Else
                    dblTax = 2020.42 + 0.35 * (dblTaxWages - 7624)
            End Select
        End If

        Return dblTax
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        ' select the existing text

        txtName.SelectAll()
    End Sub

    Private Sub cboAllowances_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAllowances.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
        lstRates.SelectedValueChanged, radSingle.CheckedChanged, radMarried.CheckedChanged,
        txtName.TextChanged, cboAllowances.TextChanged

        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblNet.Text = String.Empty
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' verify that the user wants to exit the application

        Dim dlgButton As DialogResult
        dlgButton =
            MessageBox.Show("Do you want to exit?",
                            "Cerruti Company", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Exclamation)

        ' if the No button was selected, dont close the form
        If dlgButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes and combo box with values
        ' then select a default value in each

        For dblHours As Double = 0 To 55 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours

        For dblRates As Double = 7.5 To 15.5 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N2"))
        Next dblRates

        For intAllow As Integer = 0 To 10
            cboAllowances.Items.Add(intAllow.ToString)
        Next intAllow

        lstHours.SelectedItem = "40.0"
        lstRates.SelectedItem = "9.50"
        cboAllowances.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays gross pay, taxes, and net pay

        Const dblFICA_RATE As Double = 0.0765
        Dim strStatus As String
        Dim dblHours As Double
        Dim dblPayRate As Double
        Dim intAllowances As Integer
        Dim dblGross As Double
        Dim dblFwt As Double
        Dim dblFica As Double
        Dim dblNet As Double

        dblHours = Convert.ToDouble(lstHours.SelectedItem.ToString)
        dblPayRate = Convert.ToDouble(lstRates.SelectedItem.ToString)
        intAllowances = Convert.ToInt32(cboAllowances.Text)

        ' calculate gross pay
        If dblHours <= 40 Then
            dblGross = dblHours * dblPayRate
        Else
            dblGross = 40 * dblPayRate + (dblHours - 40) * dblPayRate * 1.5
        End If

        ' get the FWT
        dblFwt = GetFwt(strStatus, intAllowances, dblGross)

        ' calculate FICA tax
        dblFica = dblGross * dblFICA_RATE

        ' round gross pay, FWT, and FICA tax
        'dblGross = Math.Round(dblGross, 2)
        'dblFwt = Math.Round(dblFwt, 2)
        'dblFica = Math.Round(dblFica, 2)

        ' calculate net pay
        dblNet = dblGross - dblFwt - dblFica

        ' display calculated amounts
        lblGross.Text = dblGross.ToString("N2")
        lblFwt.Text = dblFwt.ToString("N2")
        lblFica.Text = dblFica.ToString("N2")
        lblNet.Text = dblNet.ToString("N2")
    End Sub
End Class
