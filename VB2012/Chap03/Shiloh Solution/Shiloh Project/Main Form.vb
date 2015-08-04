' Name:         Shiloh Project
' Purpose:      Displays a 1% bonus
' Programmer:   <Chris Golpashin> on <9-28-14>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen for next calculation

        txtId.Text = String.Empty
        txtSales.Text = String.Empty
        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the interface

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblAnual As Double
        Dim dblBonus As Double
        Double.TryParse(txtSales.Text, dblAnual)
        dblBonus = dblAnual * 0.01
        lblBonus.Text = Format(dblBonus, "Currency")

    End Sub
End Class
