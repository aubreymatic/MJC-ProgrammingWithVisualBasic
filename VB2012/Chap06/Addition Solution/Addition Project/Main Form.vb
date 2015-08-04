' Name:         Addition Project
' Purpose:      Display the sum of the numbers entered
' Programmer:   <Chris Golpashin> on <11-9-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level accumulator
    Private intSum As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allow the text box to accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblSum.Text = String.Empty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' accumalates the numbers
        ' entered by the user

        Dim intNum As Integer

        ' display number in the list
        txtList.Text = txtList.Text &
            txtNumber.Text & ControlChars.NewLine

        ' convert input to a number
        Integer.TryParse(txtNumber.Text, intNum)
        ' add the number to the sum
        intSum = intSum + intNum
        ' display the sum
        lblSum.Text = intSum.ToString()
        ' send the focuss and select the text
        txtNumber.Focus()
        txtNumber.SelectAll()
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        ' resets the accumulator, clears screen, sets focus

        intSum = 0
        txtNumber.Text = String.Empty
        txtList.Text = String.Empty
        lblSum.Text = String.Empty
        txtNumber.Focus()

    End Sub
End Class
