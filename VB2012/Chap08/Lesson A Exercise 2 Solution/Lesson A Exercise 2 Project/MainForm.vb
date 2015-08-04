Public Class frmMain

    Private Sub btnPress_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        Dim strWord As String = "In"
        strWord = strWord.Insert(2, "diana")
        lblOutput.Text = strWord
    End Sub
End Class
