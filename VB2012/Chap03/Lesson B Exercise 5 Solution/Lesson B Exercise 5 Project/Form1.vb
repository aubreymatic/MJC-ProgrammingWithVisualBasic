Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Const strFirst As String = "Karl "
        Const strMiddle As String = "G. "
        Const strLast As String = "Perillo, "
        Const strNickname As String = "KG."

        lblMsg.Text = "My name is " & strFirst & strMiddle & strLast & "but you can call me " & strNickname
    End Sub
End Class
