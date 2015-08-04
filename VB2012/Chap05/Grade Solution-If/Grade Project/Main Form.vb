' Name:         Grade Project
' Purpose:      Displays a message based on a letter grade
' Programmer:   <Chris Golpashin> on <10-16-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtGrade_Enter(sender As Object, e As EventArgs) Handles txtGrade.Enter
        txtGrade.SelectAll()
    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays a message corresponding to a grade

        Dim strGrade As String

        strGrade = txtGrade.Text.ToUpper
        If strGrade = "A" Then
            lblMsg.Text = "Excellent"
        ElseIf strGrade = "B" Then
            lblMsg.Text = "Above Average"
        ElseIf strGrade = "C" Then
            lblMsg.Text = "Average"
        ElseIf strGrade = "D" OrElse strGrade = "F" Then
            lblMsg.Text = "Below Average"
        Else
            lblMsg.Text = "Incorrect Grade"
        End If
    End Sub
End Class
