' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   <Chris Golpashin> on <9-28-14>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    ' class-level variable used
    ' to accumulate the scores
    Private decTotal As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim decScore As Decimal

        decTotal = decTotal + decScore

        lblTotal.Text = Convert.ToString(decTotal)

        txtScore.Focus()
    End Sub
End Class
