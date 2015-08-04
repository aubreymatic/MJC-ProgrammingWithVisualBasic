﻿' Name:         Savings Project
' Purpose:      Display a savings account balance
'               for each of 5 years using rates
'               from 3% to 7% in increments of 1%
' Programmer:   <chris golpashin> on <11-9-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate account balances for each of
        ' five years, using rates from 3% to 7%
        ' in increments of 1%

        ' ***************Before completing this application, check the Errata Sheet document posted at www.cengagebrain.com

        Dim dblBalance As Double
        Dim dblInterest As Double

        Double.TryParse(txtDeposit.Text, dblBalance)

        txtBalance.Text = "Year" & ControlChars.Tab &
            "Rate" & ControlChars.Tab & "Balance" &
            ControlChars.NewLine

        ' calculate and display account balances 
        For intYear As Integer = 1 To 5
            txtBalance.Text = txtBalance.Text &
                intYear.ToString & ControlChars.NewLine
            For decRate As Decimal = 0.03D To 0.06D Step 0.01D
                dblInterest = dblBalance * decRate
                dblBalance = dblBalance + dblInterest

                txtBalance.Text = txtBalance.Text &
                    ControlChars.Tab & decRate.ToString("P0") &
                    ControlChars.Tab & dblBalance.ToString("C2") &
                    ControlChars.NewLine
            Next decRate
        Next intYear
    End Sub

    Private Sub txtDeposit_Enter(sender As Object, e As EventArgs) Handles txtDeposit.Enter
        txtDeposit.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtDeposit.KeyPress
        ' allows the text box to accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged
        txtBalance.Text = String.Empty
    End Sub
End Class
