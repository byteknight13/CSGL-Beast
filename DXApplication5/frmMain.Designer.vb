Partial Public Class frmMain
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.grdMatches = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.Bandedgridview2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.mnuReload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuExportExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.lblTotalMatches = New DevExpress.XtraBars.BarStaticItem()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.mnuTeamOneBox = New DevExpress.XtraBars.BarEditItem()
        Me.ReposTeamOne = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.mnuTeamTwoBox = New DevExpress.XtraBars.BarEditItem()
        Me.ReposTeamTwo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.mnuFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuClearFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuAdvancedFilter = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.mnuExportToXL = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.mnuExportToPDF = New DevExpress.XtraBars.BarLargeButtonItem()
        Me.mnuTeamOne = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.mnuTeamTwo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.mnuTeamOneEdit = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.mnuTeamTwoEdit = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.tmrStatusLabel = New System.Windows.Forms.Timer()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bandedgridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposTeamOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReposTeamTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardView1
        '
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.grdMatches
        Me.CardView1.Name = "CardView1"
        '
        'grdMatches
        '
        Me.grdMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.grdMatches.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdMatches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMatches.Location = New System.Drawing.Point(0, 55)
        Me.grdMatches.MainView = Me.GridView1
        Me.grdMatches.Name = "grdMatches"
        Me.grdMatches.Size = New System.Drawing.Size(882, 456)
        Me.grdMatches.TabIndex = 0
        Me.grdMatches.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.LayoutView1, Me.Bandedgridview2, Me.CardView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.grdMatches
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.grdMatches
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'Bandedgridview2
        '
        Me.Bandedgridview2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.Bandedgridview2.GridControl = Me.grdMatches
        Me.Bandedgridview2.Name = "Bandedgridview2"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        '
        'AlertControl1
        '
        Me.AlertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mnuHelp, Me.mnuReload, Me.BarButtonItem1, Me.mnuExportToXL, Me.mnuExportToPDF, Me.BarButtonItem2, Me.BarHeaderItem1, Me.mnuTeamOne, Me.mnuTeamTwo, Me.mnuTeamOneEdit, Me.mnuTeamTwoEdit, Me.mnuTeamOneBox, Me.mnuTeamTwoBox, Me.mnuFilter, Me.mnuClearFilter, Me.mnuAdvancedFilter, Me.mnuExportExcel, Me.SkinBarSubItem1, Me.BarButtonItem3, Me.lblTotalMatches})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 20
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.ReposTeamOne, Me.ReposTeamTwo})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarAppearance.Normal.BorderColor = System.Drawing.Color.Black
        Me.Bar2.BarAppearance.Normal.Options.UseBorderColor = True
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuReload, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuExportExcel, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuHelp, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main"
        '
        'mnuReload
        '
        Me.mnuReload.Caption = "Reload Matches"
        Me.mnuReload.Glyph = CType(resources.GetObject("mnuReload.Glyph"), System.Drawing.Image)
        Me.mnuReload.Id = 1
        Me.mnuReload.LargeGlyph = CType(resources.GetObject("mnuReload.LargeGlyph"), System.Drawing.Image)
        Me.mnuReload.Name = "mnuReload"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Check Player Stats"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "View All Items"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'mnuExportExcel
        '
        Me.mnuExportExcel.Caption = "Export To Excel"
        Me.mnuExportExcel.Glyph = CType(resources.GetObject("mnuExportExcel.Glyph"), System.Drawing.Image)
        Me.mnuExportExcel.Id = 16
        Me.mnuExportExcel.LargeGlyph = CType(resources.GetObject("mnuExportExcel.LargeGlyph"), System.Drawing.Image)
        Me.mnuExportExcel.Name = "mnuExportExcel"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Settings"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 18
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'mnuHelp
        '
        Me.mnuHelp.Caption = "View Help"
        Me.mnuHelp.Glyph = CType(resources.GetObject("mnuHelp.Glyph"), System.Drawing.Image)
        Me.mnuHelp.Id = 0
        Me.mnuHelp.LargeGlyph = CType(resources.GetObject("mnuHelp.LargeGlyph"), System.Drawing.Image)
        Me.mnuHelp.Name = "mnuHelp"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lblTotalMatches), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.SkinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'lblTotalMatches
        '
        Me.lblTotalMatches.Caption = "Total Matches In List:"
        Me.lblTotalMatches.Id = 19
        Me.lblTotalMatches.Name = "lblTotalMatches"
        Me.lblTotalMatches.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "Change Skin"
        Me.SkinBarSubItem1.Glyph = CType(resources.GetObject("SkinBarSubItem1.Glyph"), System.Drawing.Image)
        Me.SkinBarSubItem1.Id = 17
        Me.SkinBarSubItem1.LargeGlyph = CType(resources.GetObject("SkinBarSubItem1.LargeGlyph"), System.Drawing.Image)
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Filters"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarHeaderItem1, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuTeamOneBox, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuTeamTwoBox, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuClearFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.mnuAdvancedFilter, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Filters"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "Filter"
        Me.BarHeaderItem1.Id = 6
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'mnuTeamOneBox
        '
        Me.mnuTeamOneBox.Caption = "Team 1:"
        Me.mnuTeamOneBox.Edit = Me.ReposTeamOne
        Me.mnuTeamOneBox.EditValue = "<Null>"
        Me.mnuTeamOneBox.Id = 11
        Me.mnuTeamOneBox.Name = "mnuTeamOneBox"
        Me.mnuTeamOneBox.Width = 100
        '
        'ReposTeamOne
        '
        Me.ReposTeamOne.AutoHeight = False
        Me.ReposTeamOne.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReposTeamOne.DropDownRows = 15
        Me.ReposTeamOne.Name = "ReposTeamOne"
        Me.ReposTeamOne.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'mnuTeamTwoBox
        '
        Me.mnuTeamTwoBox.Caption = "Team 2:"
        Me.mnuTeamTwoBox.Edit = Me.ReposTeamTwo
        Me.mnuTeamTwoBox.EditValue = "<Null>"
        Me.mnuTeamTwoBox.Id = 12
        Me.mnuTeamTwoBox.Name = "mnuTeamTwoBox"
        Me.mnuTeamTwoBox.Width = 100
        '
        'ReposTeamTwo
        '
        Me.ReposTeamTwo.AutoHeight = False
        Me.ReposTeamTwo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReposTeamTwo.DropDownRows = 15
        Me.ReposTeamTwo.Name = "ReposTeamTwo"
        Me.ReposTeamTwo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'mnuFilter
        '
        Me.mnuFilter.Caption = "Filter"
        Me.mnuFilter.Glyph = CType(resources.GetObject("mnuFilter.Glyph"), System.Drawing.Image)
        Me.mnuFilter.Id = 13
        Me.mnuFilter.Name = "mnuFilter"
        '
        'mnuClearFilter
        '
        Me.mnuClearFilter.Caption = "Clear Filter"
        Me.mnuClearFilter.Glyph = CType(resources.GetObject("mnuClearFilter.Glyph"), System.Drawing.Image)
        Me.mnuClearFilter.Id = 14
        Me.mnuClearFilter.LargeGlyph = CType(resources.GetObject("mnuClearFilter.LargeGlyph"), System.Drawing.Image)
        Me.mnuClearFilter.Name = "mnuClearFilter"
        '
        'mnuAdvancedFilter
        '
        Me.mnuAdvancedFilter.Caption = "Show Advanced Filter"
        Me.mnuAdvancedFilter.Glyph = CType(resources.GetObject("mnuAdvancedFilter.Glyph"), System.Drawing.Image)
        Me.mnuAdvancedFilter.Id = 15
        Me.mnuAdvancedFilter.LargeGlyph = CType(resources.GetObject("mnuAdvancedFilter.LargeGlyph"), System.Drawing.Image)
        Me.mnuAdvancedFilter.Name = "mnuAdvancedFilter"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.Black
        Me.barDockControlTop.Appearance.Options.UseBorderColor = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(882, 55)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 511)
        Me.barDockControlBottom.Size = New System.Drawing.Size(882, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 55)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 456)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(882, 55)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 456)
        '
        'mnuExportToXL
        '
        Me.mnuExportToXL.Caption = "Export To EXCEL"
        Me.mnuExportToXL.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.mnuExportToXL.Id = 3
        Me.mnuExportToXL.LargeGlyph = CType(resources.GetObject("mnuExportToXL.LargeGlyph"), System.Drawing.Image)
        Me.mnuExportToXL.Name = "mnuExportToXL"
        '
        'mnuExportToPDF
        '
        Me.mnuExportToPDF.Caption = "Export To PDF"
        Me.mnuExportToPDF.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right
        Me.mnuExportToPDF.Glyph = CType(resources.GetObject("mnuExportToPDF.Glyph"), System.Drawing.Image)
        Me.mnuExportToPDF.Id = 4
        Me.mnuExportToPDF.LargeGlyph = CType(resources.GetObject("mnuExportToPDF.LargeGlyph"), System.Drawing.Image)
        Me.mnuExportToPDF.Name = "mnuExportToPDF"
        '
        'mnuTeamOne
        '
        Me.mnuTeamOne.Caption = "Team 1:"
        Me.mnuTeamOne.Edit = Me.RepositoryItemLookUpEdit1
        Me.mnuTeamOne.Id = 7
        Me.mnuTeamOne.Name = "mnuTeamOne"
        Me.mnuTeamOne.Width = 138
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'mnuTeamTwo
        '
        Me.mnuTeamTwo.Caption = "Team 2:"
        Me.mnuTeamTwo.Edit = Me.RepositoryItemLookUpEdit2
        Me.mnuTeamTwo.Id = 8
        Me.mnuTeamTwo.Name = "mnuTeamTwo"
        Me.mnuTeamTwo.Width = 138
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'mnuTeamOneEdit
        '
        Me.mnuTeamOneEdit.Caption = "Team 1:"
        Me.mnuTeamOneEdit.Edit = Me.RepositoryItemComboBox1
        Me.mnuTeamOneEdit.Id = 9
        Me.mnuTeamOneEdit.Name = "mnuTeamOneEdit"
        Me.mnuTeamOneEdit.Width = 183
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F5)
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'mnuTeamTwoEdit
        '
        Me.mnuTeamTwoEdit.Caption = "Team 2:"
        Me.mnuTeamTwoEdit.Edit = Me.RepositoryItemComboBox2
        Me.mnuTeamTwoEdit.Id = 10
        Me.mnuTeamTwoEdit.Name = "mnuTeamTwoEdit"
        Me.mnuTeamTwoEdit.Width = 185
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'tmrStatusLabel
        '
        Me.tmrStatusLabel.Enabled = True
        Me.tmrStatusLabel.Interval = 500
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(882, 538)
        Me.Controls.Add(Me.grdMatches)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSGL Beast"
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMatches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bandedgridview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposTeamOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReposTeamTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents grdMatches As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents mnuHelp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuReload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuExportToXL As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents mnuExportToPDF As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents mnuTeamOne As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuTeamTwo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuTeamOneEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents mnuTeamTwoEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents mnuTeamOneBox As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ReposTeamOne As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuTeamTwoBox As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ReposTeamTwo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents mnuFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuClearFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuAdvancedFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuExportExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents Bandedgridview2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents lblTotalMatches As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents tmrStatusLabel As System.Windows.Forms.Timer

#End Region

End Class
