Public Class frmImage 

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmItems.tmrFormMonitor.Enabled = False
        Me.Dispose()
    End Sub
End Class