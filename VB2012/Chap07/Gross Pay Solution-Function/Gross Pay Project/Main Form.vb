' Name:         Gross Pay Project
' Purpose:      Displays an employee's gross pay
' Programmer:   <chris golpashin> on <11-10-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Function CalcGross(ByVal decHoursWkd As Decimal, ByVal decPayRate As Decimal) As Decimal
        ' calculate gross pay for btnCalc_Click

        Dim decGrossPay As Decimal
        decGrossPay = decHoursWkd * decPayRate
        Return decGrossPay
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes with values

        For decHours As Decimal = 0.5D To 40D Step 0.5D
            lstHours.Items.Add(decHours.ToString("N1"))
        Next decHours
        lstHours.SelectedItem = "40.0"

        For decRates As Decimal = 8D To 15D Step 0.5D
            lstRates.Items.Add(decRates.ToString("N2"))
        Next decRates
        lstRates.SelectedIndex = 4

    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged, lstRates.SelectedValueChanged
        ' clear the gross pay

        lblGross.Text = String.Empty

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate gross pay

        Dim decHours As Decimal
        Dim decRate As Decimal
        Dim decGross As Decimal

        Decimal.TryParse(lstHours.SelectedItem.ToString, decHours)
        Decimal.TryParse(lstRates.SelectedItem.ToString, decRate)

        decGross = CalcGross(decHours, decRate)
        lblGross.Text = decGross.ToString("C2")

    End Sub
End Class
