' Name:         Discount Calculator Project
' Purpose:      Displays either a 15% discount or a 20% discount
' Programmer:   <Chris Golpashin> on <9-28-14>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisc15_Click(sender As Object, e As EventArgs) Handles btnDisc15.Click

        Dim dblSales As Double
        Dim dblDiscount15 As Double

        Double.TryParse(txtSales.Text, dblSales)

        dblDiscount15 = dblSales * 0.15

        lblDiscount.Text = Convert.ToString(dblDiscount15)
    End Sub

    Private Sub btnDisc20_Click(sender As Object, e As EventArgs) Handles btnDisc20.Click
        Dim dblSales As Double
        Dim dblDiscount20 As Double

        Double.TryParse(txtSales.Text, dblSales)

        dblDiscount20 = dblSales * 0.2

        lblDiscount.Text = Convert.ToString(dblDiscount20)
    End Sub
End Class
