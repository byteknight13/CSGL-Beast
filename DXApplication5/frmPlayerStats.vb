Public Class frmPlayerStats

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim playerID As String
        If mnutxtPlayerID.EditValue.ToString <> "" Then
            playerID = mnutxtPlayerID.EditValue.ToString
        Else
            MsgBox("Please enter a player ID.")
            Exit Sub
        End If

        Dim PlayerStats As PlayerStats = GetPlayerStatsToList(playerID)
        Dim dt As New DataTable
        prpPlayerStats.SelectedObject = PlayerStats
    End Sub

    Private Sub frmPlayerStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ShowAlert("Enter the HLTV player ID in the box and click search!", "Player Stats Help", Me)
    End Sub
End Class
