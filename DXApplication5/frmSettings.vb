Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkSaveOnEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveOnEdit.CheckedChanged
        My.Settings.SaveOnExit = chkSaveOnEdit.Checked
    End Sub
End Class
