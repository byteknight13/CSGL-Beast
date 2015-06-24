Public Class frmItems
    Public sPicFilePath As String = String.Empty

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gridview2_Click(sender As Object, e As EventArgs) Handles gridview2.Click
        For Each row In gridview2.GetSelectedRows
            sPicFilePath = String.Format("{0}\{1}.jpg", filepathIcons, gridview2.GetRowCellValue(row, "name"))
            frmImage.PictureBox1.Image = Image.FromFile(sPicFilePath)
        Next
    End Sub

    'UNCOMMENT THE HANDLES TO MAKE IT WORK
    Private Sub gridview2_DoubleClick(sender As Object, e As EventArgs) 'Handles gridview2.DoubleClick

        If sPicFilePath <> "" Then
            Try
                Dim frm As New frmImage()
                With frm
                    .ShowInTaskbar = False
                    .PictureBox1.Image = Image.FromFile(sPicFilePath)
                    .Show()
                End With
            Catch ex As Exception
                Debug.WriteLine(String.Format("GridViewDoubleClick: {0}"), ex.Message)
            End Try

        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridControl1.DataSource = GetWeaponList("http://csgolounge.com/api/schema.php")
        SaveImagesFromWeaponList()
        For i = 0 To gridview2.Columns.Count - 1
            gridview2.Columns.Item(i).OptionsColumn.AllowEdit = False
        Next
        FormatColumnHeaders()
        Debug.WriteLine("Done.")
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFormMonitor.Enabled = True
        frmImage.Show(Me)
    End Sub

    Private Sub tmrFormMonitor_Tick(sender As Object, e As EventArgs) Handles tmrFormMonitor.Tick
        If frmImage.Visible = True Then
            Dim px As Integer = Me.Location.X + Me.Width + 5
            Dim py As Integer = Me.Location.Y
            If Not (frmImage.Location = New Point(px, py)) Then
                frmImage.Location = New Point(px, py)
            End If
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuShowImage.ItemClick
        If frmImage.Visible = False Then
            frmImage.StartPosition = FormStartPosition.CenterParent
            frmImage.Show(Me)
            mnuShowImage.Caption = "Hide Images"
            'tmrFormMonitor.Enabled = True
        ElseIf frmImage.Visible = True Then
            'tmrFormMonitor.Enabled = False
            frmImage.Dispose()
            mnuShowImage.Caption = "Show Images"
        End If

    End Sub

    Private Sub frmItems_Move(sender As Object, e As EventArgs) Handles Me.Move
        Dim px As Integer = Me.Location.X + Me.Width + 5
        Dim py As Integer = Me.Location.Y
        If Not (frmImage.Location = New Point(px, py)) Then
            frmImage.Location = New Point(px, py)
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuExportExcel.ItemClick
        Dim fd As New SaveFileDialog
        fd.Filter = "*.xlsx|.xlsx"
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridControl1.ExportToXlsx(fd.FileName)
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class
