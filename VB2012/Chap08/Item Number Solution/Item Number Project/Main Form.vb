' Name:         Item Number Project
' Purpose:      Verifies an item number's format
' Programmer:   <chris golpashin> on <12-11-4>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItemNum_Enter(sender As Object, e As EventArgs) Handles txtItemNum.Enter
        txtItemNum.SelectAll()
    End Sub

    Private Sub txtItemNum_TextChanged(sender As Object, e As EventArgs) Handles txtItemNum.TextChanged
        lblVerification.Text = String.Empty
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim strItemNum As String
        strItemNum = txtItemNum.Text

        If strItemNum Like "[0-9][0-9][0-9][-][A-Z][-][0-9][0-9]" Then
            lblVerification.Text = "This is the correct format."
        Else
            lblVerification.Text = "This is the wrong format."
        End If
    End Sub
End Class
