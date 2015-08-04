' Name:         Jerrili Project
' Purpose:      Display the total owed
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQuantity.TextChanged
        ' clear total owed

        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate total owed

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblTotal As Double
        Dim dblDiscount As Double

        ' store user input in variables
        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        ' calculate total owned
        dblTotal = dblPrice * intQuantity
        ' subtract discount, if necessary
        If intQuantity > 10 Then
            dblDiscount = dblTotal * 0.2
            dblTotal = dblTotal - dblDiscount
        End If
        ' display total owed
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub
End Class
