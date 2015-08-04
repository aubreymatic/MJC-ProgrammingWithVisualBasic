' Name:         Lowest and Highest Project
' Purpose:      Display the lowest and highest of two scores
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtScore1.TextChanged, txtScore2.TextChanged
        ' clear message

        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' display the lowest and highest scores

        Dim intScore1 As Integer
        Dim intScore2 As Integer

        ' store input in variables
        Integer.TryParse(txtScore1.Text, intScore1)
        Integer.TryParse(txtScore2.Text, intScore2)

        ' swap scores, if necessary
        If intScore1 > intScore2 Then
            Dim intTemp As Integer
            intTemp = intScore1
            intScore1 = intScore2
            intScore2 = intTemp
        End If

        ' display lowest and highest scores
        lblMessage.Text = "Lowest score: " &
            Convert.ToString(intScore1) &
            ControlChars.NewLine &
            "Highest score: " &
            Convert.ToString(intScore2)
    End Sub
End Class
