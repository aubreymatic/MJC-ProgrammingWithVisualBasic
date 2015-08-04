' Name:         Product Project
' Purpose:      Displays the product IDs entered by the user
' Programmer:   <chris golpashin> on <12-11-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds a product ID to a list

        Dim strId As String

        ' remove any leading and trailing spaces
        strId = txtId.Text.Trim
        ' verify length
        If strId.Length = 5 Then
            lstId.Items.Add(strId.ToUpper)
        Else
            MessageBox.Show("The ID must contain 5 characters. ",
                            "Product ID", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

        txtId.Focus()
    End Sub

End Class
