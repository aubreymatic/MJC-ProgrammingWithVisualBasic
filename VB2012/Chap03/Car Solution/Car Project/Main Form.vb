' Chris Golpashin - 9-29-14

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblLoanPay As Double
        Dim dblInsurancePay As Double
        Dim dblOilChange As Double
        Dim dblMaint As Double
        Dim dblCarWash As Double
        Dim dblGas As Double
        Dim dblMTE As Double
        Dim dblTEY As Double

        Double.TryParse(txtLoanPay.Text, dblLoanPay)
        Double.TryParse(txtInsurePay.Text, dblInsurancePay)
        Double.TryParse(txtOilChange.Text, dblOilChange)
        Double.TryParse(txtMaint.Text, dblMaint)
        Double.TryParse(txtCarWash.Text, dblCarWash)
        Double.TryParse(txtGas.Text, dblGas)

        dblMTE = dblLoanPay + dblInsurancePay + dblOilChange + dblMaint + dblCarWash + dblGas
        dblTEY = dblMTE * 12

        lblMTE.Text = dblMTE.ToString("C2")
        lblTEY.Text = dblTEY.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoanPay.Text = String.Empty
        txtInsurePay.Text = String.Empty
        txtOilChange.Text = String.Empty
        txtMaint.Text = String.Empty
        txtCarWash.Text = String.Empty
        txtGas.Text = String.Empty
        lblMTE.Text = String.Empty
        lblTEY.Text = String.Empty

        txtLoanPay.Focus()
    End Sub
End Class
