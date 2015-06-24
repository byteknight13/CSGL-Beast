Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Drawing.Imaging

Module modFunctions
    Public filepathMatches As String = Application.StartupPath & "\data\matches.csg"
    Public filepathIcons As String = Application.StartupPath & "\data\icons"
    Public PlayerStatsCollection As New List(Of PlayerStats)

    ''' <summary>
    ''' Jsons the key to list.
    ''' </summary>
    ''' <param name="source">The source.</param>
    ''' <param name="token">The token.</param>
    ''' <returns></returns>
    Function JSONKeyToList(ByVal source As String, ByVal token As String) As List(Of String)
        Dim webSrc As System.Net.WebClient = New System.Net.WebClient()
        Dim TokenValueList As New List(Of String)
        Try
            Dim src As String = webSrc.DownloadString(source).ToString
            Dim allData As JObject = JObject.Parse(src)
            For i = 15 To allData.Count - 16
                Try
                    TokenValueList.Add(allData(i).Value(Of JToken)(token).ToString())
                    'setPrgBarValue(ProgressBar1, (i \ (allData.Count - 1)) * 100)
                Catch ex As Exception
                    Debug.WriteLine("JSON ERROR")
                End Try
            Next
            Return TokenValueList
        Finally
            If webSrc IsNot Nothing Then
                CType(webSrc, IDisposable).Dispose()
            End If
        End Try
    End Function

    ''' <summary>
    ''' Json to data table.
    ''' </summary>
    ''' <param name="url">The url where JSON will be retrieved.</param>
    ''' <returns></returns>
    Public Function JSONToDataTable(ByVal url As String, ByVal local As Boolean) As DataTable
        Dim web As System.Net.WebClient = New System.Net.WebClient()

        If local = False Then
            Dim src As String = web.DownloadString(url).ToString
            src = src.Replace(String.Format("{0}c{0}", Chr(34)), String.Format("{0}NONE{0}", Chr(34)))
            src = src.Replace(String.Format("{0}match{0}", Chr(34)), String.Format("{0}Match ID{0}", Chr(34)))
            src = src.Replace(String.Format("{0}when{0}", Chr(34)), String.Format("{0}Match Date{0}", Chr(34)))
            src = src.Replace(String.Format("{0}a{0}", Chr(34)), String.Format("{0}Team 1{0}", Chr(34)))
            src = src.Replace(String.Format("{0}b{0}", Chr(34)), String.Format("{0}Team 2{0}", Chr(34)))
            src = src.Replace(String.Format("{0}format{0}", Chr(34)), String.Format("{0}Best Of{0}", Chr(34)))
            src = src.Replace(String.Format("{0}event{0}", Chr(34)), String.Format("{0}Event{0}", Chr(34)))
            src = src.Replace(String.Format("{0}closed{0}", Chr(34)), String.Format("{0}Closed{0}", Chr(34)))
            src = src.Replace(String.Format("{0}winner{0}", Chr(34)), String.Format("{0}Winner{0}", Chr(34)))

            Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src.Trim, (GetType(DataTable))), DataTable)
            'Dim dtvalue As DataTable = JsonConvert.DeserializeObject(Of DataTable)(src)
            If dtValue.Rows.Count <> 0 Then Debug.WriteLine("DT Contains Data")
            Return dtValue

        ElseIf local = True Then
            Dim src As String = System.IO.File.ReadAllText(filepathMatches)
            Dim dtValue As DataTable = DirectCast(JsonConvert.DeserializeObject(src, (GetType(DataTable))), DataTable)
            Return dtValue
        Else
            Return Nothing
        End If

    End Function

    ''' <summary>
    ''' Formats the grid view cells.
    ''' </summary>
    Public Sub FormatGridViewCells()
        For i = 0 To frmMain.GridView1.DataRowCount - 1
            If frmMain.GridView1.GetRowCellValue(i, "Winner").ToString = "Team 1" Then frmMain.GridView1.SetRowCellValue(i, "Winner", frmMain.GridView1.GetRowCellValue(i, "Team 1"))
            If frmMain.GridView1.GetRowCellValue(i, "Winner").ToString = "Team 2" Then frmMain.GridView1.SetRowCellValue(i, "Winner", frmMain.GridView1.GetRowCellValue(i, "Team 2"))
            If frmMain.GridView1.GetRowCellValue(i, "Closed").ToString = "1" Then frmMain.GridView1.SetRowCellValue(i, "Closed", "YES")
            If frmMain.GridView1.GetRowCellValue(i, "Closed").ToString = "0" Then frmMain.GridView1.SetRowCellValue(i, "Closed", "NO")
        Next
    End Sub

    ''' <summary>
    ''' Gets the player stats to list.
    ''' </summary>
    ''' <param name="playerid">The playerid.</param>
    ''' <returns></returns>
    Public Function GetPlayerStatsToList(ByVal playerid As String) As PlayerStats
        Dim PlayerStats As New PlayerStats
        Dim web As System.Net.WebClient = New System.Net.WebClient()
        Dim websrc As String = web.DownloadString("https://api.import.io/store/data/e329dabc-b5f1-4916-bba1-86e3fbd827cf/_query?input/webpage/url=http%3A%2F%2Fwww.hltv.org%2F%3Fpageid%3D173%26statsfilter%3D1792%26playerid%3D" & playerid & "&_user=d6b3cb98-2ba2-4ad9-9ca5-4b356b6cfa05&_apikey=d6b3cb98-2ba2-4ad9-9ca5-4b356b6cfa05%3A%2BkZ7Qxjs%2FVYfAFESPjrJBgp37JvKo%2FRvMsxZa2aRNST5jR%2FvqnsOyNS7I%2B0CfdFSudOhHgEGrmJkVtBNWOumQg%3D%3D")
        Dim stats As String = Split(websrc, "[")(2).Split(CChar("]"))(0).Replace(Chr(34), String.Empty)
        Debug.WriteLine(stats)
        Dim statsSplit As String() = Split(stats, ",")
        With PlayerStats
            .TotalKills = statsSplit(0)
            .HeadshotPercentage = statsSplit(1)
            .TotalDeaths = statsSplit(2)
            .KDRatio = statsSplit(3)
            .MapsPlayed = statsSplit(4)
            .RoundsPlayed = statsSplit(5)
            .AverageKillsPerRound = statsSplit(6)
            .AverageAssistsPerRound = statsSplit(7)
            .AverageDeathsPerRound = statsSplit(8)
        End With
        PlayerStatsCollection.Add(PlayerStats)

        Return PlayerStats
    End Function

    Public Function GetListOfWeaponsToList(ByVal url As String, ByVal saveitems As Boolean) As List(Of String)

        Dim web As System.Net.WebClient = New System.Net.WebClient()
        Dim src As String = web.DownloadString(url).ToString

        Dim jobj As JObject = JObject.Parse(src)
        Dim lst As New List(Of Dictionary(Of String, String))
        For Each item In jobj
            Dim newdic As New Dictionary(Of String, String)
            Dim newval As IList(Of JToken) = jobj(item.Key).Children.ToList
            Dim i As Integer = 0
            For Each item1 In newval
                'Debug.WriteLine(item1.Root.ToString & " | " & item1.Value(Of JToken).ToString)
                i += 1
                If i <= 1 Then
                    Debug.WriteLine(item1.Value(Of JToken).ToString)
                End If
            Next
            Debug.WriteLine(i.ToString)
            i = 0
            newdic.Add(item.Key.ToString, item.Value.ToString)
            'Debug.WriteLine(newdic.Keys(0).ToString & " | " & item.Value.ToString)
            lst.Add(newdic)

        Next

        Dim jsonArray As New List(Of Dictionary(Of String, String))
        Debug.WriteLine(lst.Item(0).ToString)

    End Function

    Public Function GetWeaponList(ByVal url As String) As DataTable
        Try
            Dim web As System.Net.WebClient = New System.Net.WebClient()
            Dim jsonString As String = web.DownloadString(url)
            Dim jsSerializer As New System.Web.Script.Serialization.JavaScriptSerializer() 'read json into a string
            Dim dict As Dictionary(Of String, Object)
            dict = jsSerializer.Deserialize(Of Dictionary(Of String, Object))(jsonString)
            Dim dt As New DataTable
            With dt ' set the column types as you see fit
                .Columns.Add("name", GetType(String))
                .Columns.Add("stattrak", GetType(Object))
                .Columns.Add("star", GetType(Object))
                .Columns.Add("souvenir", GetType(Object))
                .Columns.Add("sort", GetType(Object))
                .Columns.Add("exterior", GetType(Object))
                .Columns.Add("quality", GetType(Object))
                .Columns.Add("icon", GetType(Object))
                .Columns.Add("worth", GetType(Double))
                .Columns.Add("betable", GetType(Object))
                '.Columns.Add("binary", GetType(Byte()))
            End With
            Dim dr As DataRow
            For Each row As Dictionary(Of String, Object) In dict.Values
                dr = dt.NewRow
                For Each kvp As KeyValuePair(Of String, Object) In row
                    dr.Item(kvp.Key) = kvp.Value
                Next
                dt.Rows.Add(dr)
            Next
            
            web.Dispose()
            Return dt
        Catch ex As Exception
            Debug.WriteLine(String.Format("GetWeaponList: {0}", ex.Message))
        End Try
    End Function
    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    Public Sub FormatColumnHeaders()
        For Each column As DevExpress.XtraGrid.Columns.GridColumn In frmItems.gridview2.Columns
            column.Caption = UppercaseFirstLetter(column.Caption)
        Next
    End Sub

    Public Sub SaveImagesFromWeaponList()
        Dim webclient As New System.Net.WebClient
        For i = 0 To frmItems.gridview2.RowCount - 1
            Try
                Dim imgkey As String = frmItems.gridview2.GetRowCellDisplayText(i, "icon")
                Dim imgname As String = frmItems.gridview2.GetRowCellDisplayText(i, "name")
                imgname = imgname.Replace("★", String.Empty).Replace("|", String.Empty).Trim
                frmItems.gridview2.SetRowCellValue(i, "name", imgname)
                Dim imgurl As String = String.Format("https://steamcommunity-a.akamaihd.net/economy/image/{0}", imgkey)
                If Not (System.IO.File.Exists(String.Format("{0}\{1}.jpg", filepathIcons, imgname))) AndAlso Not (String.IsNullOrWhiteSpace(imgname)) Then
                    Debug.WriteLine("Found icon not in directory. Downloading now...")
                    webclient.DownloadFile(imgurl, String.Format("{0}\{1}.jpg", filepathIcons, imgname))
                End If
                webclient.Dispose()
            Catch ex As Exception
                Debug.WriteLine(String.Format("SaveImagesFromWeaponList: {0}", ex.Message))
            End Try
        Next
        Debug.WriteLine("Done downloading images.")
    End Sub

    Public Function JSONToArray(ByVal source As String, ByVal local As Boolean) As List(Of Dictionary(Of String, String))
        Dim web As System.Net.WebClient = New System.Net.WebClient()

        If local = False Then
            Dim src As String = web.DownloadString(source).ToString
            Dim ret As List(Of Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(src)
            'Dim dtvalue As DataTable = JsonConvert.DeserializeObject(Of DataTable)(src)
            'Debug.WriteLineIf(Not (ret.Rows.Count <> 0), "dtValue cotains data.")

            For Each item In ret
                Debug.WriteLine(String.Format("{0} {1}", item.Keys(0), item.Values(0)))
            Next

            Return ret
            'ElseIf local = True Then
            '    Dim src As String = System.IO.File.ReadAllText(filepathMatches)
            '    Dim ret As Array = DirectCast(JsonConvert.DeserializeObject(src, (GetType(DataTable))), DataTable)
            '    Return ret
        Else
            Return Nothing
        End If

    End Function

    Public Sub ShowAlert(ByVal msg As String, ByVal title As String, ByVal owner As Windows.Forms.Form)
        Using alert As New DevExpress.XtraBars.Alerter.AlertControl
            Dim info As DevExpress.XtraBars.Alerter.AlertInfo = New DevExpress.XtraBars.Alerter.AlertInfo(title, msg)
            alert.AutoHeight = True
            alert.ControlBoxPosition = DevExpress.XtraBars.Alerter.AlertFormControlBoxPosition.Top
            'alert.FormLocation = AlertFormLocation.BottomLeft
            alert.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal
            alert.Show(owner, info)
        End Using
    End Sub

    ''' <summary>
    ''' Gets the binary of an image.
    ''' </summary>
    ''' <param name="image">The image.</param>
    ''' <param name="format">The format wanted (NOTHING IF KEEP ORIGINAL).</param>
    ''' <returns></returns>
    Public Function GetBinary(ByVal image As Image, ByVal format As ImageFormat) As Byte()
        Using ms As New System.IO.MemoryStream
            If (format Is Nothing) Then
                format = image.RawFormat ' use image original format
            End If
            image.Save(ms, format)
            Return ms.ToArray()
        End Using
    End Function

    ''' <summary>
    ''' Makes the images into a binary array.
    ''' </summary>
    Public Sub MakeImagesBinary()
        Dim binIMG As Byte()
        Dim bmpIMG As Image = Nothing
        For i = 0 To frmItems.gridview2.RowCount - 1
            If Not frmItems.gridview2.GetRowCellValue(i, "icon").ToString <> "" Then
                Continue For
            End If
            Try
                Dim sPicFilePath As String = String.Format("{0}\{1}.jpg", filepathIcons, frmItems.gridview2.GetRowCellValue(i, "name"))
                bmpIMG = Image.FromFile(sPicFilePath)
                Debug.WriteLine(String.Format("bmpIMG Dimensions: {0}", bmpIMG.Size))
                binIMG = GetBinary(bmpIMG, ImageFormat.Jpeg)
                frmItems.gridview2.SetRowCellValue(i, "binary", binIMG)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Next
    End Sub


End Module
