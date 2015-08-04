Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' cloeses the program
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' variables
        Dim intQuantity As Integer
        Dim dblPrice As Double
        Dim dblTotal As Double
        Const dblDiscount As Double = 0.1
        Dim dblDiscountAmount As Double
        Dim dblTotalDue As Double

        ' puts the values of the textboxes into the variables
        Integer.TryParse(txtQuantity.Text, intQuantity)
        Double.TryParse(txtPrice.Text, dblPrice)

        ' checks to see if you are a wholesaler and if you are you get a 10% discount
        If MessageBox.Show("Are you a wwholesaler?", "",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            ' calculates the total amount
            dblTotal = dblPrice * intQuantity

            ' calculates 10% of a discount on the total
            dblDiscountAmount = dblTotal * dblDiscount

            ' subtracts the discount from the total and puts it into the total due variable
            dblTotalDue = dblTotal - dblDiscountAmount

            ' displays the discount ammount and total due
            lblDiscount.Text = dblDiscountAmount.ToString("C2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        Else
            ' calculates the total due
            dblTotalDue = intQuantity * dblPrice

            ' displays the discount ammount and total due
            lblTotalDue.Text = dblTotalDue.ToString("C2")
            lblDiscount.Text = dblDiscountAmount.ToString("C2")
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, txtPrice.TextChanged
        ' clears labels when data is changed in textboxes
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub
End Class
