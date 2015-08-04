' Name:         Gross Pay Project
' Purpose:      Display the gross pay
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        ' clear gross pay

        lblGross.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the gross pay

        Const dblRATE As Double = 10.75
        Dim dblHours As Double
        Dim dblGross As Double

        ' store hours in a variable
        Double.TryParse(txtHours.Text, dblHours)

        If dblHours >= 0 AndAlso dblHours <= 40 Then
            ' calculate and display gross pay
            dblGross = dblHours * dblRATE
            lblGross.Text = dblGross.ToString("C2")
        Else
            lblGross.Text = "Incorrect number of hours"
        End If
    End Sub
End Class
