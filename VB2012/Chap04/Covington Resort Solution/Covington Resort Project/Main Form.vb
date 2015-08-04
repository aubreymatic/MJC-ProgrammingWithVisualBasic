' Name:         Covington Resort Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   <Chris Golpashin> on <10-15-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        ' selects the contents when the
        ' text box recieves the focus

        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        ' selects the contents when the
        ' text box recieves the focus

        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        ' selects the contents when the
        ' text box recieves the focus

        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        ' selects the contents when the
        ' text box recieves the focus

        txtChildren.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtRooms.KeyPress, txtNights.KeyPress,
        txtAdults.KeyPress, txtChildren.KeyPress
        ' allows the text box to accept only numbers and
        ' the backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            ' calcel the key
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate and display total room charge,
        ' tax, total resort fee, and total due

        ' declare named constants and variables
        Const intMAX_PER_ROOM As Integer = 6
        Const intDAILY_ROOM_CHG As Integer = 284
        Const dblTAX_RATE As Double = 0.1525
        Const intDAILY_RESORT_FEE As Integer = 15
        Const strMSG As String =
            "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequiered As Double
        Dim intTotalRoomChg As Integer
        Dim dblTax As Double
        Dim intTotalResortFee As Integer
        Dim dblTotalDue As Double

        ' store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        ' calculate total number of guests
        intNumGuests = intAdults + intChildren
        ' calculate number of rooms requiered
        dblRoomsRequiered = intNumGuests / intMAX_PER_ROOM

        ' determine wether number of reserved
        ' rooms is adequate and then either display a
        ' message or calculate and display charges
        If intRoomsReserved < dblRoomsRequiered Then
            MessageBox.Show(strMSG, "Covington Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' calculate charges
            intTotalRoomChg = intRoomsReserved *
                intNights * intDAILY_ROOM_CHG
            dblTax = intTotalRoomChg * dblTAX_RATE
            intTotalResortFee = intRoomsReserved *
                intNights * intDAILY_RESORT_FEE
            dblTotalDue = intTotalRoomChg + dblTax + intTotalResortFee

            ' display charges
            lblRoomChg.Text = intTotalRoomChg.ToString("N2")
            lblTax.Text = dblTax.ToString("N2")
            lblResortFee.Text = intTotalResortFee.ToString("N2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If
    End Sub
End Class
