Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox.CheckedChanged
        ' displays the textbox if checkbox is checked
        If chkBox.Checked Then
            txtBox.Visible = True
        Else
            txtBox.Visible = False
        End If
    End Sub

    Private Sub chkPavilion_CheckedChanged(sender As Object, e As EventArgs) Handles chkPavilion.CheckedChanged
        ' displays the textbox if checkbox is checked
        If chkPavilion.Checked Then
            txtPavilion.Visible = True
        Else
            txtPavilion.Visible = False
        End If
    End Sub

    Private Sub chkLawn_CheckedChanged(sender As Object, e As EventArgs) Handles chkLawn.CheckedChanged
        ' displays the textbox if checkbox is checked
        If chkLawn.Checked Then
            txtLawn.Visible = True
        Else
            txtLawn.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' stores tickets in variable
        Dim intBoxTickets As Integer
        Dim intPavilionTickets As Integer
        Dim intLawnTickets As Integer
        Dim intTotalTickets As Integer

        Dim dblTotalDue As Double
        Dim blnIsBoxOk As Boolean
        Dim blnIsPavilionOk As Boolean
        Dim blnIsLawnOk As Boolean

        'checks if any number in entered
        blnIsBoxOk = Integer.TryParse(txtBox.Text, intBoxTickets)
        blnIsPavilionOk = Integer.TryParse(txtPavilion.Text, intPavilionTickets)
        blnIsLawnOk = Integer.TryParse(txtLawn.Text, intLawnTickets)

        ' checks to see if there is a number in the textboxes and the calculates the total due
        If blnIsBoxOk Then
            dblTotalDue = intBoxTickets * 75 + dblTotalDue
        End If
        If blnIsPavilionOk Then
            dblTotalDue = intPavilionTickets * 30 + dblTotalDue
        End If
        If blnIsLawnOk Then
            dblTotalDue = intLawnTickets * 21 + dblTotalDue
        End If

        ' adds all the tickets to a variable
        intTotalTickets = intBoxTickets + intPavilionTickets + intLawnTickets

        ' displays the total tickets ordered and total due
        lblTotalTickets.Text = intTotalTickets.ToString
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtBox.KeyPress, txtPavilion.KeyPress, txtLawn.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            ' calcel the key
            e.Handled = True
        End If
    End Sub
End Class
