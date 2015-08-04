Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes form
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Variables to contain data
        Dim strCommType As String
        Dim dblSales As Double
        Dim dblCommission As Double

        ' converts text in textbox to all uppercase
        strCommType = txtCommType.Text.ToUpper

        ' puts sales amount into variable
        Double.TryParse(txtSales.Text, dblSales)

        ' calculates commision ammount
        If strCommType = "PRIME" Then
            dblCommission = dblSales * 0.025
        Else
            dblCommission = dblSales * 0.02
        End If

        ' displays commision in label and is displayed in dollars
        lblComm.Text = dblCommission.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears all data from form
        txtCommType.Text = String.Empty
        txtSales.Text = String.Empty
        lblComm.Text = String.Empty
    End Sub
End Class
