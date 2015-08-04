Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intFee As Integer
        Dim strStatus As String
        Dim strDay As String

        strStatus = txtMemberStatus.Text.ToUpper
        strDay = txtDay.Text.ToUpper

        If strStatus = "N" Then
            If strDay = "D" Then
                intFee = 25 + 12
            ElseIf strDay = "E" Then
                intFee = 25 + 20
            End If
        Else
            intFee = 25
        End If

        lblFee.Text = intFee.ToString("C2")
    End Sub
End Class
