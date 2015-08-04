Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstCities_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstCities.SelectedValueChanged
        Dim strSelectCity As String
        strSelectCity = lstCities.SelectedItem

        Select Case strSelectCity
            Case "Algonquin"
                lblZip.Text = 60102
            Case "Barrington"
                lblZip.Text = "60010, 60011"
            Case "Crystal Lake"
                lblZip.Text = 60012
            Case "Glen Ellyn"
                lblZip.Text = "60137, 60138"
            Case "Park Ridge"
                lblZip.Text = 60068
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstCities.Items.Add("Algonquin")
        lstCities.Items.Add("Barrington")
        lstCities.Items.Add("Crystal Lake")
        lstCities.Items.Add("Glen Ellyn")
        lstCities.Items.Add("Park Ridge")
    End Sub
End Class
