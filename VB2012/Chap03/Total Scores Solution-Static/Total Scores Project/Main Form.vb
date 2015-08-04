' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   <Chris Golpashin> on <9-28-14>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' totals the scores entered by the user 

        ' declare variables
        Dim decScore As Decimal
        Static decTotal As Decimal

        ' total the scores
        Decimal.TryParse(txtScore.Text, decScore)
        decTotal = decTotal + decScore
        ' display the total
        lblTotal.Text = Convert.ToString(decTotal)
        ' set the focus
        txtScore.Focus()

    End Sub
End Class
