' Name:         Voter Project
' Purpose:      Displays a message based on the user's age and registration status.
' Programmer:   <Chris Golpashin> on <10-16-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAge_Enter(sender As Object, e As EventArgs) Handles txtAge.Enter
        txtAge.SelectAll()
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        ' allows only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays a message

        Const strTOO_YOUNG As String = "You are too young to vote."
        Const strMUST_REGISTER As String =
            "You must register before you can vote."
        Const strCAN_VOTE As String = "You can vote."
        Const strPROMPT As String = "Are you registered to vote."
        Dim intAge As Integer
        Dim dlgButton As DialogResult

        Integer.TryParse(txtAge.Text, intAge)

        If intAge >= 18 Then
            dlgButton = MessageBox.Show(strPROMPT,
                                        "Voter Eligibility", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Exclamation)
            If dlgButton = Windows.Forms.DialogResult.Yes Then
                lblMsg.Text = strCAN_VOTE
            Else
                lblMsg.Text = strMUST_REGISTER
            End If
        Else
            lblMsg.Text = strTOO_YOUNG
        End If
    End Sub
End Class
