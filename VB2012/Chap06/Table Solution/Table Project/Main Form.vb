Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        For intNum As Integer = 1 To 4 Step 1
            lblOutput.Text = lblOutput.Text & ControlChars.NewLine &
            1 * intNum & " " &
            ControlChars.Tab & 2 * intNum & " " & ControlChars.Tab &
            ControlChars.Tab & 3 * intNum & " " & ControlChars.Tab &
            ControlChars.Tab & 4 * intNum & " " & ControlChars.Tab &
            ControlChars.Tab & 5 * intNum & " " & ControlChars.Tab &
            ControlChars.NewLine & ControlChars.Tab
        Next intNum
    End Sub
End Class
