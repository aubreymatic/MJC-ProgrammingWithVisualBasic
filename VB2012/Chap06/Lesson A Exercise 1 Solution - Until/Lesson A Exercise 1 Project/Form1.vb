Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intTotal As Integer = 10
        Do Until intTotal <= 0
            lblOutput.Text = lblOutput.Text & ControlChars.NewLine & intTotal
            intTotal = intTotal - 1
        Loop
    End Sub
End Class
