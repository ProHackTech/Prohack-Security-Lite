Imports System.Data.OleDb
Imports System.IO
Imports System.Threading

Public Class mainWindow

    Public Shared scanType As String
    Dim form_settings(5) As String
    Public theme As String : Dim wallpaper As String : Dim fadeEffect_Status : Dim optionsHoverEffect_Status
    Dim loadingScreenTopMost As String : Dim bgGif As String

    Sub New()
        InitializeComponent() 'initialize form
        Me.DoubleBuffered = True ' double buffering of form for visual performance
        toggle_tabControlOptions(False) ' toggle tab control and hide it
        form_init_setter() ' run the setting initialization before form loads
    End Sub

    'Method: To apply theme settings
    Private Sub form_init_setter()
        'read theme settings
        Dim fpath = Application.StartupPath & "/data/mainWindow_Settings.conf" 'filepath
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(fpath) 'open text file reader
        Dim line As String 'declare variable for stroing string
        For x As Integer = 0 To 6
            line = reader.ReadLine 'read line into variable
            If Not String.IsNullOrEmpty(line) Then ' if line is not null or empty
                Dim lineArray As String() = line.Split(New Char() {":"c}) ' split by delimeter
                form_settings(x) = lineArray(1) ' take the second part after ':'
            End If
        Next : reader.Close() ' close reader

        ' set global variables - for easiness
        theme = form_settings(0) ' theme setting
        wallpaper = form_settings(1) ' wallpaper setting
        fadeEffect_Status = form_settings(2) ' fade effect setting
        optionsHoverEffect_Status = form_settings(3) ' options button hover setting
        loadingScreenTopMost = form_settings(4) ' option to toggle loading screen topmost
        bgGif = form_settings(5) ' gif image for animated background

        'apply theme settings
        Dim imgpath As String ' image path variable
        If wallpaper = "gif" Then
            Try
                imgpath = Application.StartupPath & "/res/common_controls/wallpapers/" & bgGif ' generate image path
                ' create background picture handler
                Dim bgpic As New PictureBox
                bgpic.Image = Image.FromFile(imgpath)
                bgpic.SizeMode = PictureBoxSizeMode.StretchImage
                Me.Controls.Add(bgpic)
                bgpic.Show() : bgpic.Visible = True
                bgpic.Dock = DockStyle.Fill : bgpic.SendToBack()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf wallpaper IsNot "none" And wallpaper IsNot "gif" Then ' if wallpaper is not named "none" & "gif" then,
            Try
                imgpath = Application.StartupPath & "/res/common_controls/wallpapers/" & wallpaper ' generate image path
                Me.BackgroundImage = Image.FromFile(imgpath) ' apply image
            Catch ex As Exception : End Try ' end
        Else
            Me.BackgroundImage = Nothing ' background image empty
        End If
    End Sub

    ' Method: To toggle tabControl Options
    Private Sub toggle_tabControlOptions(show As Boolean)
        Select Case show 'if tab control show
            Case True
                tabControl_Options.Size = New Size(1020, 150)
                tabControl_Options.Show()
                tabSelector_Options.Show()
                btnTabControl_Hide.Show()
                tabSelector_Options.Location = New Point(0, 389)
                btnTabControl_Hide.Location = New Point(990, 370)
                btnTabControl_Hide.BringToFront()
                panelFooter.Hide()
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
            MsgBox(ex.ToString())
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

    'Method: To fade out form
    Private Sub form_fadeOut()
        If fadeEffect_Status = "on" Then
            Dim iCount As Integer
            For iCount = 90 To 10 Step -120
                Me.Opacity = iCount / 100
                Me.Refresh()
                Thread.Sleep(50)
            Next
        Else : End If
    End Sub

    'Method: To exit application
    Private Sub app_exit()
        Try
            If bgWorker_QuickQuery.IsBusy Then
                bgWorker_QuickQuery.CancelAsync()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        form_fadeOut()
        Application.Exit()
    End Sub

    'Method: To animate options hover button size change
    Private Sub toggle_opt_hover(sender As Control, toHover As Boolean)
        Dim curWidth As Integer = sender.Width : Dim curHeight As Integer = sender.Height
        Dim speed As Integer = 5
        If optionsHoverEffect_Status = "on" Then
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

#Region "Control Hovers"
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
#End Region

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' loading settings
        form_loading.Show() : Me.Opacity = 0.1
        If loadingScreenTopMost = "true" Then
            form_loading.TopMost = True
        Else
            form_loading.TopMost = False
        End If
        bgWorker_QuickQuery.RunWorkerAsync()
        bgWorker_QuickQuery.WorkerSupportsCancellation = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        app_exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnTabControl_Hide_Click(sender As Object, e As EventArgs) Handles btnTabControl_Hide.Click
        toggle_tabControlOptions(False)
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
        Dim filepath As String = Application.StartupPath & "/data/win_searchIndex_results.list"
        File.WriteAllLines(filepath, queryResults) ' save filepath list to file

    End Sub

    Private Sub bgWorker_QuickQuery_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker_QuickQuery.RunWorkerCompleted
        bgWorker_QuickQuery.CancelAsync()
        form_loading.Close() : Me.Opacity = 1
        GC.Collect() 'garbage collection
    End Sub

    Private Sub btnShowSettings_Click(sender As Object, e As EventArgs) Handles btnShowSettings.Click
        toggle_tabControlOptions(True)
        tabControl_Options.SelectedIndex = 3
    End Sub

    Private Sub btnScan_Quick_Click(sender As Object, e As EventArgs) Handles btnScan_Quick.Click
        scanType = "Quick"
        Me.Hide()
        malware_scanner.Show()
    End Sub

    Private Sub btnScan_Deep_Click(sender As Object, e As EventArgs) Handles btnScan_Deep.Click
        scanType = "Deep"
        Me.Hide()
        malware_scanner.Show()
    End Sub

    Private Sub btnScan_Custom_Click(sender As Object, e As EventArgs) Handles btnScan_Custom.Click
        scanType = "Custom"
        Me.Hide()
        malware_scanner.Show()
    End Sub
End Class
