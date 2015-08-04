Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub DivideByTwo(ByVal dblNumFromUser As Double, ByRef dblTotalDivided As Double)

        Double.TryParse(txtInput.Text, dblNumFromUser)

        dblTotalDivided = dblNumFromUser / 2
        lblNum.Text = dblTotalDivided.ToString
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblNum As Double
        Dim dblTotal As Double

        Call DivideByTwo(dblNum, dblTotal)

    End Sub
End Class
