Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboAreaCodes.Items.Add("907")
        cboAreaCodes.Items.Add("302")
        cboAreaCodes.Items.Add("808")
        cboAreaCodes.Items.Add("208")
        cboAreaCodes.Items.Add("207")
    End Sub

    Private Sub cboAreaCodes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAreaCodes.SelectedValueChanged
        Dim strSelectZip As String
        strSelectZip = cboAreaCodes.SelectedItem

        Select Case strSelectZip
            Case 907
                lblDisplayState.Text = "Alaska"
            Case 302
                lblDisplayState.Text = "Delaware"
            Case 808
                lblDisplayState.Text = "Hawaii"
            Case 208
                lblDisplayState.Text = "Idaho"
            Case 207
                lblDisplayState.Text = "Maine"
        End Select
    End Sub
End Class
