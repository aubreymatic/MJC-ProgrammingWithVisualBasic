' Name:         Covington Resort Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, total parking fee, 
'               and total due
' Programmer:   <Chris Golpashin> on <10-16-14>

Option Explicit On
Option Strict On
Option Infer Off

Public Class radAtrium

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        ' selects the contents when the 
        ' text box receives the focus

        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        ' selects the contents when the 
        ' text box receives the focus

        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        ' selects the contents when the 
        ' text box receives the focus

        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        ' selects the contents when the 
        ' text box receives the focus

        txtChildren.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                           ) Handles txtRooms.KeyPress, txtNights.KeyPress,
                       txtAdults.KeyPress, txtChildren.KeyPress, txtNumVehicles.KeyPress
        ' allows the text box to accept only numbers and
        ' the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged,
        radQueen.CheckedChanged, radKing.CheckedChanged,
        chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblParkingFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate and display total room charge,
        ' tax, total resort fee, total parking fee,
        ' and total due

        ' declare named constants and variables
        Const intMAX_PER_ROOM As Integer = 6
        Const intDAILY_ROOM_CHG_QUEEN_STAND As Integer = 284
        Const intDAILY_ROOM_CHG_QUEEN_ATRIUM As Integer = 325
        Const intDAILY_ROOM_CHG_KING_STAND As Integer = 290
        Const intDAILY_ROOM_CHG_KING_ATRIUM As Integer = 350
        Const dblDAILY_PARKING_FEE As Double = 12.75
        Const dblTAX_RATE As Double = 0.1525
        Const intDAILY_RESORT_FEE As Integer = 15
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim intNumVehicles As Integer
        Dim dblParkingFee As Double
        Dim intDailyRoomChg As Integer
        Dim intTotalRoomChg As Integer
        Dim dblTax As Double
        Dim intTotalResortFee As Integer
        Dim dblTotalDue As Double
        Dim blnIsNumVehiclesOk As Boolean

        ' store input in variables
        Integer.TryParse(txtRooms.Text, intRoomsReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)
        blnIsNumVehiclesOk = Integer.TryParse(txtNumVehicles.Text, intNumVehicles)

        ' calculate total number of guests
        intNumGuests = intAdults + intChildren
        ' calculate number of rooms required
        dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

        ' determine whether number of reserved 
        ' rooms is adequate and then either display a
        ' message or calculate and display the charges
        If intRoomsReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Covington Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            ' calculate charges
            If radQueen.Checked Then
                If radStandard.Checked Then
                    intDailyRoomChg = intDAILY_ROOM_CHG_QUEEN_STAND
                Else
                    intDailyRoomChg = intDAILY_ROOM_CHG_QUEEN_ATRIUM
                End If
            Else
                If radStandard.Checked Then
                    intDailyRoomChg = intDAILY_ROOM_CHG_KING_STAND
                Else
                    intDailyRoomChg = intDAILY_ROOM_CHG_KING_ATRIUM
                End If
            End If
            intTotalRoomChg = intRoomsReserved *
                intNights * intDailyRoomChg
            dblTax = intTotalRoomChg * dblTAX_RATE
            intTotalResortFee = intRoomsReserved *
                intNights * intDAILY_RESORT_FEE
            If chkParkingFee.Checked AndAlso blnIsNumVehiclesOk Then
                dblParkingFee = intNights * dblDAILY_PARKING_FEE * intNumVehicles
            End If
            dblTotalDue = intTotalRoomChg +
                dblTax + intTotalResortFee

            ' display charges
            lblRoomChg.Text = intTotalRoomChg.ToString("N2")
            lblTax.Text = dblTax.ToString("N2")
            lblResortFee.Text = intTotalResortFee.ToString("N2")
            lblParkingFee.Text = dblParkingFee.ToString("N2")
            lblTotalDue.Text = dblTotalDue.ToString("C2")
        End If
    End Sub

    Private Sub chkParkingFee_Click(sender As Object, e As EventArgs) Handles chkParkingFee.Click
        If chkParkingFee.Checked Then
            txtNumVehicles.Text = "1"
        End If
    End Sub
End Class
