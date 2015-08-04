Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'cloeses the application
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculates the profit
        lblNAP.Text = Val(txtTAR.Text - txtTAE.Text)
        'changes the labels amount into currency
        lblNAP.Text = Format(lblNAP.Text, "Currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the form of data

        txtTAR.Text = String.Empty
        txtTAE.Text = String.Empty
        lblNAP.Text = String.Empty
        'puts the focus at txtTAR
        txtTAR.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'shrinks the form
        Me.Width = Me.Width - 165
        'prints the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        'expands the form
        Me.Width = Me.Width - 165
    End Sub
End Class
