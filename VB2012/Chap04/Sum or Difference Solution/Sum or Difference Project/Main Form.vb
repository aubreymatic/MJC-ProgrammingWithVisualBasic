' Name:         Sum or Difference Project
' Purpose:      Display the sum of two numbers or
'               the difference between both numbers
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtOperation.TextChanged, txtFirst.TextChanged, txtSecond.TextChanged
        ' clear lblAnswer

        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate either a sum or a difference

        Dim strOperation As String
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblAnswer As Double

        ' store input in variables
        strOperation = txtOperation.Text
        Double.TryParse(txtFirst.Text, dblNum1)
        Double.TryParse(txtSecond.Text, dblNum2)

        ' calculate and display the sum or difference
        If strOperation = "1" Then
            dblAnswer = dblNum1 + dblNum2
            lblAnswer.Text =
                "Sum: " & Convert.ToString(dblAnswer)
        End If
    End Sub
End Class
