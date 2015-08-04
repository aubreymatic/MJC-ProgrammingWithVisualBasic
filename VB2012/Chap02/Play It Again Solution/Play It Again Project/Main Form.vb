' Name:         Play It Again Project
' Purpose:      Calculates the total number
'               of discs sold and the total
'               sales amount
' Programmer:   Chris Golpashin on 9-27-14

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDvds.Text = String.Empty
        txtBlueRays.Text = String.Empty
        lblTotalDiscs.Text = String.Empty
        lblTotalSales.Text = String.Empty
        ' send the focus to the DVDs box
        txtDvds.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sales receipt

        Me.Width = Me.Width - 165
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 165

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of discs sold and total sales

        lblTotalDiscs.Text = Val(txtDvds.Text) + Val(txtBlueRays.Text)
        lblTotalSales.Text = Val(lblTotalDiscs.Text) * 7
        lblTotalSales.Text = Format(lblTotalSales.Text, "Currency")

    End Sub
End Class
