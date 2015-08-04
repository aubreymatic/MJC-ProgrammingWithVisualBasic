' Name:         Kettleson Project
' Purpose:      Display the annual bonus
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        ' clear annual bonus

        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the annual bonus

        Dim dblSales As Double
        Dim dblBonus As Double

        ' store sales in a variable
        Double.TryParse(txtSales.Text, dblSales)

        ' calculates and display bonus
        If dblSales > 15000 Then
            dblBonus = dblSales * 0.02
        Else
            dblBonus = dblSales * 0.015
        End If
        lblBonus.Text = dblBonus.ToString("C2")
    End Sub
End Class
