' Name:         Savings Project
' Purpose:      Display a savings account balance
' Programmer:   <Chris Golpashin> on <11-8-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate account balance

        Dim dblBalance As Double
        Dim dblRate As Double
        Dim dblInterest As Double
        Dim intYears As Integer

        Double.TryParse(txtDeposit.Text, dblBalance)
        Double.TryParse(txtRate.Text, dblRate)
        If dblBalance > 0 AndAlso dblRate > 0 Then
            Do While dblBalance < 250000

                dblInterest = dblBalance * dblRate
                dblBalance = dblBalance + dblInterest
                intYears = intYears + 1
            Loop
        End If

        lblBalance.Text = "You will have " &
            dblBalance.ToString("C2") &
            " in " & intYears.ToString & " years."
    End Sub

    Private Sub txtDeposit_Enter(sender As Object, e As EventArgs) Handles txtDeposit.Enter
        txtDeposit.SelectAll()
    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtDeposit.KeyPress, txtRate.KeyPress
        ' allows the text box to accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged, txtRate.TextChanged
        lblBalance.Text = String.Empty
    End Sub
End Class
