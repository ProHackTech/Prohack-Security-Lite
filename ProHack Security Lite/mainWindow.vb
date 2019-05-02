Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class mainWindow

    ' general declares
    Public Shared scanType As String

    Sub New()
        InitializeComponent() 'initialize form
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True) ' double buffering of form for visual performance
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        toggle_tabControlOptions(False) ' toggle tab control and hide it
        utils.read_config()
        init_setter() ' run the setting initialization before form loads
    End Sub

    'Method: To apply form settings
    Private Sub init_setter()
        'apply configurations
        Dim imgpath As String ' image path variable
        If utils.core_Wallpaper = "gif" Then
            Try
                imgpath = Application.StartupPath & "/res/common_controls/wallpapers/" & utils.core_BackgroundGIF ' generate image path
                ' create background picture handler
                Dim bgpic As New PictureBox
                With bgpic
                    .Image = Image.FromFile(imgpath)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    AddHandler .MouseDown, AddressOf gitHandler_MouseDown
                    AddHandler .MouseMove, AddressOf gitHandler_MouseMove
                    AddHandler .MouseUp, AddressOf gitHandler_MouseUp
                End With
                Me.Controls.Add(bgpic)
                bgpic.Show() : bgpic.Visible = True
                bgpic.Dock = DockStyle.Fill : bgpic.SendToBack()
            Catch ex As Exception
                utils.invoke_msg(2, "Image Error1", ex.Message.ToString)
            End Try
        ElseIf utils.core_Wallpaper = "none" Then ' if wallpaper is not named "none" & "gif" then,
            Me.BackgroundImage = Nothing ' background image empty
        Else
            Try
                imgpath = Application.StartupPath & "/res/common_controls/wallpapers/" & utils.core_Wallpaper ' generate image path
                Me.BackgroundImage = Image.FromFile(imgpath) ' apply image
            Catch ex As Exception
                utils.invoke_msg(2, "Image Error2", ex.Message.ToString)
            End Try ' end
        End If
    End Sub

    ' Gif Background Movement Handler: MouseDown
    Private Sub gitHandler_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
        utils.Form_MouseDown(Me, e)
    End Sub

    ' Gif Background Movement Handler: MouseMove
    Private Sub gitHandler_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        utils.Form_MouseMove(Me, e)
    End Sub

    ' Gif Background Movement Handler: MouseUp
    Private Sub gitHandler_MouseUp(ByVal sender As Object, ByVal e As EventArgs)
        utils.Form_MouseUp(Me, e)
    End Sub

    ' Method: To toggle tabControl Options
    Private Sub toggle_tabControlOptions(show As Boolean)
        Select Case show 'if tab control show
            Case True
                tabControl_Options.Show()
                tabSelector_Options.Show()
                btnTabControl_Hide.Show()
                tabSelector_Options.Location = New Point(0, 389)
                btnTabControl_Hide.Location = New Point(990, 370)
                btnTabControl_Hide.BringToFront()
                panelFooter.Hide()
                tabControl_Options.Size = New Size(1020, 150)
            Case False 'if tab control hide
                tabControl_Options.Hide()
                tabSelector_Options.Hide()
                btnTabControl_Hide.Hide()
                panelFooter.Show()
        End Select
    End Sub

    'Method: To perform clean icon change
    Private Sub change_icon(sender As Control, icon As String)
        Dim path As String = "res/" + icon
        Try
            sender.BackgroundImage = Image.FromFile(path)
        Catch ex As Exception
            utils.invoke_msg(2, "Icon Error", ex.Message.ToString)
        End Try
    End Sub

    'Method: To toggle button hover size change
    Private Sub btnHover_toggleZoom(sender As Control, zoom As Boolean)
        Dim num As Integer = 4
        Select Case zoom
            Case True
                sender.Size = New Size(sender.Width + num, sender.Height + num)
                sender.Location = New Point(sender.Location.X - num, sender.Location.Y - num)
            Case False
                sender.Size = New Size(sender.Width - num, sender.Height - num)
                sender.Location = New Point(sender.Location.X + num, sender.Location.Y + num)
        End Select
    End Sub


    'Method: To exit application
    Private Sub app_exit()
        Try
            If bgWorker_QuickQuery.IsBusy Then
                bgWorker_QuickQuery.CancelAsync()
            End If
        Catch ex As Exception
            utils.invoke_msg(3, "Worker Error", ex.Message.ToString)
        End Try
        If utils.core_FadeEffect = "True" Then
            utils.form_fadeOut(Me)
        End If
        Application.Exit()
    End Sub

    'Method: To animate options hover button size change
    Private Sub toggle_opt_hover(sender As Control, toHover As Boolean)
        Dim curWidth As Integer = sender.Width : Dim curHeight As Integer = sender.Height
        Dim speed As Integer = 5
        If utils.core_MainWindowOptionHoverEffect = "True" Then
            Select Case toHover
                Case True
                    sender.BackColor = Color.RoyalBlue
                    For i As Integer = 0 To speed
                        curHeight += 2
                        sender.Size = New Size(curWidth, curHeight)
                        Me.Refresh()
                    Next
                Case False
                    sender.BackColor = Color.Black
                    sender.Size = New Size(200, 54)
            End Select
        Else
            Select Case toHover
                Case True
                    sender.BackColor = Color.RoyalBlue
                    sender.Size = New Size(200, 70)
                Case False
                    sender.BackColor = Color.Black
                    sender.Size = New Size(200, 54)
            End Select
        End If
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        change_icon(btnExit, "common_controls/shutdown_hover.png")
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        change_icon(btnExit, "common_controls/shutdown.png")
    End Sub

    Private Sub btnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        change_icon(btnMinimize, "common_controls/minimize_hover.png")
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        change_icon(btnMinimize, "common_controls/minimize.png")
    End Sub

    Private Sub btnGithub_MouseEnter(sender As Object, e As EventArgs) Handles btnGithub.MouseEnter
        btnHover_toggleZoom(btnGithub, True)
    End Sub

    Private Sub btnGithub_MouseLeave(sender As Object, e As EventArgs) Handles btnGithub.MouseLeave
        btnHover_toggleZoom(btnGithub, False)
    End Sub

    Private Sub btnTwitter_MouseEnter(sender As Object, e As EventArgs) Handles btnTwitter.MouseEnter
        btnHover_toggleZoom(btnTwitter, True)
    End Sub

    Private Sub btnTwitter_MouseLeave(sender As Object, e As EventArgs) Handles btnTwitter.MouseLeave
        btnHover_toggleZoom(btnTwitter, False)
    End Sub

    Private Sub btnEmail_MouseEnter(sender As Object, e As EventArgs) Handles btnEmail.MouseEnter
        btnHover_toggleZoom(btnEmail, True)
    End Sub

    Private Sub btnEmail_MouseLeave(sender As Object, e As EventArgs) Handles btnEmail.MouseLeave
        btnHover_toggleZoom(btnEmail, False)
    End Sub

    Private Sub btnWebsite_MouseEnter(sender As Object, e As EventArgs) Handles btnWebsite.MouseEnter
        btnHover_toggleZoom(btnWebsite, True)
    End Sub

    Private Sub btnWebsite_MouseLeave(sender As Object, e As EventArgs) Handles btnWebsite.MouseLeave
        btnHover_toggleZoom(btnWebsite, False)
    End Sub

    Private Sub pic_opt_scan_MouseEnter(sender As Object, e As EventArgs) Handles pic_opt_scan.MouseEnter
        toggle_opt_hover(btn_opt_scan, True)
    End Sub

    Private Sub pic_opt_scan_MouseLeave(sender As Object, e As EventArgs) Handles pic_opt_scan.MouseLeave
        toggle_opt_hover(btn_opt_scan, False)
    End Sub

    Private Sub pic_opt_webutils_MouseEnter(sender As Object, e As EventArgs) Handles pic_opt_webutils.MouseEnter
        toggle_opt_hover(btn_opt_webutils, True)
    End Sub

    Private Sub pic_opt_webutils_MouseLeave(sender As Object, e As EventArgs) Handles pic_opt_webutils.MouseLeave
        toggle_opt_hover(btn_opt_webutils, False)
    End Sub

    Private Sub pic_opt_tools_MouseEnter(sender As Object, e As EventArgs) Handles pic_opt_tools.MouseEnter
        toggle_opt_hover(btn_opt_tools, True)
    End Sub

    Private Sub pic_opt_tools_MouseLeave(sender As Object, e As EventArgs) Handles pic_opt_tools.MouseLeave
        toggle_opt_hover(btn_opt_tools, False)
    End Sub

    Private Sub btnTabControl_Hide_MouseEnter(sender As Object, e As EventArgs) Handles btnTabControl_Hide.MouseEnter
        change_icon(btnTabControl_Hide, "mainWindow/collapse_hover.png")
    End Sub

    Private Sub btnTabControl_Hide_MouseLeave(sender As Object, e As EventArgs) Handles btnTabControl_Hide.MouseLeave
        change_icon(btnTabControl_Hide, "mainWindow/collapse.png")
    End Sub

    Private Sub btnShowSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnShowSettings.MouseEnter
        change_icon(btnShowSettings, "common_controls/settings_hover.png")
    End Sub

    Private Sub btnShowSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnShowSettings.MouseLeave
        change_icon(btnShowSettings, "common_controls/settings.png")
    End Sub

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' show loading screen
        form_loading.Show() : Me.Opacity = 0.1
        If utils.core_LoadingScreenTopmost = "True" Then
            form_loading.TopMost = True
        Else
            form_loading.TopMost = False
        End If
        bgWorker_QuickQuery.WorkerSupportsCancellation = True
        ' start WSI schedule manager
        Schedule_WSIR_Query.Start()
        ' start WSI query worker
        bgWorker_QuickQuery.RunWorkerAsync()
        ' auto update check
        bgWorker_Updater.RunWorkerAsync()
        ' populus flows : webutils, tools
        bgWorker_FlowPopulus.RunWorkerAsync()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        app_exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If utils.core_FadeEffect = "True" Then
            utils.form_fadeOut(Me)
            check_focused.Start()
        End If
        Me.WindowState = FormWindowState.Minimized
        toggle_tabControlOptions(False)
    End Sub

    Private Sub btnTabControl_Hide_Click(sender As Object, e As EventArgs) Handles btnTabControl_Hide.Click
        toggle_tabControlOptions(False)
        tabControl_Options.Dock = DockStyle.Bottom
    End Sub

    Private Sub pic_opt_scan_Click(sender As Object, e As EventArgs) Handles pic_opt_scan.Click
        btn_opt_scan.PerformClick()
    End Sub

    Private Sub pic_opt_webutils_Click(sender As Object, e As EventArgs) Handles pic_opt_webutils.Click
        btn_opt_webutils.PerformClick()
    End Sub

    Private Sub pic_opt_tools_Click(sender As Object, e As EventArgs) Handles pic_opt_tools.Click
        btn_opt_tools.PerformClick()
    End Sub

    Private Sub btn_opt_scan_Click(sender As Object, e As EventArgs) Handles btn_opt_scan.Click
        toggle_tabControlOptions(True)
        tabControl_Options.SelectedIndex = 0
    End Sub

    Private Sub btn_opt_webutils_Click(sender As Object, e As EventArgs) Handles btn_opt_webutils.Click
        toggle_tabControlOptions(True)
        tabControl_Options.SelectedIndex = 1
    End Sub

    Private Sub btn_opt_tools_Click(sender As Object, e As EventArgs) Handles btn_opt_tools.Click
        toggle_tabControlOptions(True)
        tabControl_Options.SelectedIndex = 2
    End Sub

    Private Sub bgWorker_QuickQuery_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker_QuickQuery.DoWork
        Dim queryResults As New List(Of String)()
        Dim file_extensions As New List(Of String)()

        'read extentions list
        Dim fpath As String = Application.StartupPath & "/data/file_extensions_cat/common_file_types.list"
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fpath)
        Dim line As String
        Do
            line = reader.ReadLine
            If Not String.IsNullOrEmpty(line) Then
                file_extensions.Add(line)
            End If
        Loop Until line Is Nothing
        reader.Close()

        'query windows search indexer
        Dim connection As New OleDbConnection("Provider=Search.CollatorDSO;Extended Properties=""Application=Windows""")
        For Each extension As String In file_extensions
            If Not String.IsNullOrEmpty(extension) Then
                Dim query As String = "SELECT System.ItemUrl FROM SystemIndex WHERE System.ItemName Like '%" + extension + "'"
                connection.Open()
                Dim command As New OleDbCommand(query, connection)

                'reading results
                Using result = command.ExecuteReader() ' execurity command and store in result variable
                    Dim temp_query As String = "" ' for storing temp query
                    While result.Read() ' read result
                        temp_query = result(0).ToString() ' convert result to string
                        temp_query = temp_query.Remove(0, 5) ' remove "file:" from filepath
                        If temp_query.EndsWith(extension) Then
                            queryResults.Add(temp_query) ' add filepaths to list
                        End If
                    End While
                End Using
                connection.Close() ' close connection
            End If
        Next

        ' save query results to file
        File.WriteAllLines(utils.WSIR_file, queryResults) ' save filepath list to file
    End Sub

    Private Sub bgWorker_QuickQuery_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker_QuickQuery.RunWorkerCompleted
        bgWorker_QuickQuery.CancelAsync()
        If form_loading.Visible = True Then
            form_loading.Close()
        End If
        If Not Me.Opacity = 1.0 Then
            Me.Opacity = 1.0
        End If
        GC.Collect() 'garbage collection
    End Sub

    Private Sub btnShowSettings_Click(sender As Object, e As EventArgs) Handles btnShowSettings.Click
        ' application settings
        SecLite_Settings.Show()
        Me.Hide()
        toggle_tabControlOptions(False)
    End Sub

    Private Sub btnScan_Quick_Click(sender As Object, e As EventArgs) Handles btnScan_Quick.Click
        scanType = "Quick"
        Me.Hide()
        malware_scanner.Show()
        toggle_tabControlOptions(False)
    End Sub

    Private Sub btnScan_Deep_Click(sender As Object, e As EventArgs) Handles btnScan_Deep.Click
        scanType = "Deep"
        Me.Hide()
        malware_scanner.Show()
        toggle_tabControlOptions(False)
    End Sub

    Private Sub btnScan_Custom_Click(sender As Object, e As EventArgs) Handles btnScan_Custom.Click
        Me.Hide()
        custom_scanner.Show()
        toggle_tabControlOptions(False)
    End Sub

    Private Sub BgWorker_FlowPopulus_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker_FlowPopulus.DoWork
        ' common declares for file reading
        Dim reader As StreamReader
        Dim tempStr As String = Nothing
        Dim file_webutils As String = Application.StartupPath & "/data/webutils.list"
        Dim file_tools As String = Application.StartupPath & "/data/tools.list"

        ' storing names and paths
        Dim utils_names As New List(Of String)()
        Dim utils_paths As New List(Of String)()
        Dim tools_names As New List(Of String)()
        Dim tools_paths As New List(Of String)()

        ' read items: web utils
        reader = New StreamReader(file_webutils)
        Do
            tempStr = reader.ReadLine
            If Not String.IsNullOrEmpty(tempStr) Then
                Dim tempArray As String() = tempStr.Split(">")
                utils_names.Add(tempArray(0))
                utils_paths.Add(tempArray(1))
            End If
        Loop Until tempStr Is Nothing
        reader.Close()

        ' populus webutils
        BeginInvoke(CType(Sub()
                              _populus_items("webutils", utils_names, utils_paths)
                          End Sub, MethodInvoker))

        ' read items: tools
        reader = New StreamReader(file_tools)
        Do
            tempStr = reader.ReadLine
            If Not String.IsNullOrEmpty(tempStr) Then
                Dim tempArray As String() = tempStr.Split(">")
                tools_names.Add(tempArray(0))
                tools_paths.Add(tempArray(1))
            End If
        Loop Until tempStr Is Nothing
        reader.Close()
        reader.Dispose()

        ' populus tools
        BeginInvoke(CType(Sub()
                              _populus_items("tools", tools_names, tools_paths)
                          End Sub, MethodInvoker))

    End Sub

    Private Sub _populus_items(ByVal itemType As String, ByVal names As List(Of String), ByVal paths As List(Of String))
        If itemType = "tools" Then
            For i As Integer = 0 To names.Count - 1
                Dim uctools As New UC_Extras
                uctools.Tag = "uctools" & i
                uctools.txtName.Text = names(i)
                flow_tools.Controls.Add(uctools)
                uctools.Visible = True
                uctools.Show()
            Next
        Else
            For i As Integer = 0 To names.Count - 1
                Dim ucutils As New UC_Extras
                ucutils.Tag = "ucutils" & i
                ucutils.txtName.Text = names(i)
                flow_webutils.Controls.Add(ucutils)
                ucutils.Visible = True
                ucutils.Show()
            Next
        End If
    End Sub

    Private Sub BtnToTray_MouseEnter(sender As Object, e As EventArgs) Handles btnToTray.MouseEnter
        change_icon(btnToTray, "common_controls/totray_hover.png")
    End Sub

    Private Sub BtnToTray_MouseLeave(sender As Object, e As EventArgs) Handles btnToTray.MouseLeave
        change_icon(btnToTray, "common_controls/totray.png")
    End Sub

    Private Sub BtnToTray_Click(sender As Object, e As EventArgs) Handles btnToTray.Click
        Me.ShowInTaskbar = False
        Me.Hide()
        PSLNotify.Visible = True
    End Sub

    Private Sub PSLNotify_Click(sender As Object, e As EventArgs) Handles PSLNotify.Click
        Me.ShowInTaskbar = True
        Me.Show()
        PSLNotify.Visible = False
    End Sub

    Private Sub MainWindow_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        toggle_tabControlOptions(False)
    End Sub

    Private Sub mainWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        utils.Form_MouseDown(Me, e)
        toggle_tabControlOptions(False)
    End Sub

    Private Sub mainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        utils.Form_MouseMove(Me, e)
    End Sub

    Private Sub mainWindow_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        utils.Form_MouseUp(Me, e)
    End Sub

    Private Sub check_focused_Tick(sender As Object, e As EventArgs) Handles check_focused.Tick
        If Me.WindowState = FormWindowState.Normal Then
            utils.form_fadeIn(Me)
            Me.Opacity = 1
            check_focused.Stop()
        End If
    End Sub

    Private Sub bgWorker_Updater_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker_Updater.DoWork
        Dim curversion, newversion As Integer
        Dim updater_version, updater_newversion As Integer

        ' check the current updater version
        Dim reader As StreamReader
        Dim tempStr As String = Nothing
        reader = New StreamReader(Application.StartupPath & "/updater/versions.txt")
        tempStr = reader.ReadToEnd
        tempStr = tempStr.Replace(".", "")
        updater_version = Int(tempStr)
        reader.Close() : reader.Dispose()

        ' check the new updater version
        Dim address As String = "https://prohack.tech/Products/Security-Lite/updater_versions.txt"
        Dim client As WebClient = New WebClient()
        Try
            reader = New StreamReader(client.OpenRead(address))
        Catch ex As Exception
            Exit Sub
        End Try
        tempStr = reader.ReadToEnd
        tempStr = tempStr.Replace(".", "")
        updater_newversion = Int(tempStr)
        reader.Close() : reader.Dispose()

        ' compare updater versions
        If updater_newversion > updater_version Then
            ' ask if user wants to update
            Dim askresult = MessageBox.Show("New Updater Version Available! Update?", "Update Updater?", MessageBoxButtons.YesNoCancel)
            If askresult = DialogResult.Yes Then
                ' download new updater
                Dim latest_saveAs As String = Application.StartupPath & "/updater.zip"
                Try
                    My.Computer.Network.DownloadFile("https://prohack.tech/Products/Security-Lite/updater.zip", latest_saveAs)
                    Try
                        ' delete old updater folder
                        Try
                            System.IO.Directory.Delete(Application.StartupPath & "/updater/", True)
                        Catch ex As Exception : End Try
                        ' extract
                        System.IO.Compression.ZipFile.ExtractToDirectory(latest_saveAs, Application.StartupPath)
                        ' delete zip
                        Try
                            File.Delete(latest_saveAs)
                            MsgBox("Updater Updated!")
                        Catch ex As Exception : End Try
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                    Exit Sub
                End Try
            ElseIf askresult = DialogResult.No Or askresult = DialogResult.Cancel Then : End If
        End If

        ' read current version
        reader = New StreamReader(Application.StartupPath & "/versions.txt")
        tempStr = reader.ReadToEnd
        tempStr = tempStr.Replace(".", "")
        curversion = Int(tempStr)
        reader.Close() : reader.Dispose()

        ' read new version
        Dim address_mainread As String = "https://prohack.tech/Products/Security-Lite/versions.txt"
        Dim client_mainread As WebClient = New WebClient()
        reader = New StreamReader(client_mainread.OpenRead(address_mainread))
        tempStr = reader.ReadToEnd
        tempStr = tempStr.Replace(".", "")
        newversion = Int(tempStr)
        reader.Close() : reader.Dispose()

        ' compare versions
        If newversion > curversion Then
            Dim askresult = MessageBox.Show("New App Version Available! Start Updater?", "Update App?", MessageBoxButtons.YesNoCancel)
            Dim updater_path As String = Application.StartupPath
            If askresult = DialogResult.Yes Then
                ' start updater
                If utils.core_RunFrom = "debug" Then
                    updater_path += "/updater/updater/bin/debug/updater.exe"
                    Process.Start(updater_path)
                    Application.Exit()
                ElseIf utils.core_RunFrom = "release" Then
                    updater_path += "/updater/updater.exe"
                    Process.Start(updater_path)
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    Private Sub Schedule_WSIR_Query_Tick(sender As Object, e As EventArgs) Handles Schedule_WSIR_Query.Tick
        ' if malware_scanner is not scanning, then
        ' perform WSIR query as scheduled

        ' if scanning status is false
        If malware_scanner.isScanning = False Then
            ' perform another check for reducing problems
            ' if malware scanner background worker is not working
            If Not malware_scanner.bgWorker_Scanner.IsBusy Then
                ' if WSI query worker is not working
                If Not bgWorker_QuickQuery.IsBusy Then
                    ' run WSI worker
                    bgWorker_QuickQuery.RunWorkerAsync()
                End If
            End If
        End If
    End Sub
End Class
