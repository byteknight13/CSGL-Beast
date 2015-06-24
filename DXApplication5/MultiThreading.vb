Public Class MultiThreading
    Private Delegate Sub SetGridDataSourceDelegate(ByVal owner As Windows.Forms.Form, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal dt As DataTable)
    Public Sub SetGridDataSource(ByVal owner As Windows.Forms.Form, ByVal grid As Object, ByVal dt As DataTable)
        If owner.InvokeRequired Then
            Dim del As New SetGridDataSourceDelegate(AddressOf SetGridDataSource)
            owner.Invoke(del, New Object() {owner, grid, dt})
        Else
            grid.datasource = dt
        End If
    End Sub


End Class
