' Name:         New Pay Project
' Purpose:      Calculates an employee's new pay
' Programmer:   <Chris Golpashin> on <10-16-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearNewPay(sender As Object, e As EventArgs) Handles txtOld.TextChanged, txtRate.TextChanged
        lblNew.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the new pay

        Dim dblOld As Double
        Dim dblRate As Double
        Dim dblNew As Double
        Dim blnIsOldOk As Boolean
        Dim blnIsRateOk As Boolean

        ' determine whether the conversions were successful
        If blnIsOldOk AndAlso blnIsRateOk Then

            ' convert the input to numbers
            blnIsOldOk = Double.TryParse(txtOld.Text, dblOld)
            blnIsRateOk = Double.TryParse(txtRate.Text, dblRate)

            ' calculate and display the new pay
            dblNew = dblOld + dblOld * dblRate
            lblNew.Text = dblNew.ToString("C2")
        Else
            lblNew.Text = "Invalid data"
        End If
        ' set the focus
        txtOld.Focus()
    End Sub
End Class
