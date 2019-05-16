Imports System.IO
Imports System.Net

Public Class mainWIndow

    Public itemNames As New List(Of String)()
    Public itemLinks As New List(Of String)()
    Public downloadableURLS As New List(Of String)()
    Private isRun As Boolean

    Sub New()
        InitializeComponent()

        ' set double buffering
        Me.DoubleBuffered = True

        ' run method
        read_downloads()
    End Sub

    ' Method: To read downloads file and populate global lists
    Public Sub read_downloads()
        Dim reader As StreamReader
        Dim lineInFile As String = Nothing
        Dim itemName, itemLink As String

        ' clean existing list
        itemNames.Clear()
        itemLinks.Clear()

        ' read downloads file
        reader = New StreamReader(Application.StartupPath & "/downloads.list")
        Do
            lineInFile = reader.ReadLine
            If Not String.IsNullOrEmpty(lineInFile) Then
                Dim tempLineArray = Split(lineInFile, " <:> ")
                itemName = tempLineArray(0)
                itemLink = tempLineArray(1)
                itemNames.Add(itemName)
                itemLinks.Add(itemLink)
            End If
        Loop Until lineInFile Is Nothing
    End Sub

    ' Method: To create user controls for flowItems
    Public Sub create_flowItemControls()
        Dim UCItem As UC_Item

        ' suspend flow layout
        flowItems.SuspendLayout()

        'clear existing flow controls
        flowItems.Controls.Clear()

        ' loop over itemNames
        For i As Integer = 0 To itemNames.Count - 1
            ' initiate new UC_Item instence control
            UCItem = New UC_Item

            ' generate control tag
            UCItem.Tag = "UCItem" & i

            ' add text to control textbox
            UCItem.txtName.Text = itemNames(i).ToString

            ' add control to flowlayoutpanel
            flowItems.Controls.Add(UCItem)

            ' ensure control is visible (not required at all!)
            UCItem.Show() : UCItem.Visible = True

            ' add click event handler to new control
            AddHandler(UCItem.Click), AddressOf UCItem_Click
        Next

        ' resume flow layout
        flowItems.ResumeLayout()
    End Sub

    ' Click event for user controls
    Private Sub UCItem_Click(sender As Object, ByVal e As EventArgs)
        Dim tempTag As String = CType(sender, UC_Item).Tag
        Dim itemID As Integer = tempTag.Remove(0, 6)
        Dim tempLink As String = itemLinks(itemID)

        If CType(sender, UC_Item).isChecked = True Then
            downloadableURLS.Add(tempLink)
        ElseIf CType(sender, UC_Item).isChecked = False Then
            Dim indexOfLink As Integer = downloadableURLS.FindIndex(Function(value As String)
                                                                        Return value = tempLink
                                                                    End Function)
            downloadableURLS.RemoveAt(indexOfLink)
        End If
    End Sub

    ' Method: To exit the application
    Private Sub app_exit()
        Application.Exit()
    End Sub

    ' Method: To minimize the application
    Private Sub app_minimize()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' Method: To toggle the form like XFCE desktop environment app toolbars
    ' That sattisfying minify size mode :-)
    Private Sub xfce_type_border_toggle()
        Dim sizeH As Integer = Me.Size.Height

        flowItems.Hide()
        SuspendLayout()

        If sizeH = 450 Then
            For sizeH = 450 To 65 Step -10
                Me.Size = New Size(Me.Size.Width, sizeH)
            Next
            Me.Size = New Size(Me.Size.Width, 65)
        Else
            For sizeH = 65 To 450 Step 10
                Me.Size = New Size(Me.Size.Width, sizeH)
            Next
            Me.Size = New Size(Me.Size.Width, 450)
        End If

        flowItems.Show()
        ResumeLayout()
    End Sub

    Private Sub BtnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        utils.changeBtnIcon(btnExit, "exit_hover.png")
    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        utils.changeBtnIcon(btnExit, "exit.png")
    End Sub

    Private Sub BtnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        utils.changeBtnIcon(btnMinimize, "minimize_hover.png")
    End Sub

    Private Sub BtnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        utils.changeBtnIcon(btnMinimize, "minimize.png")
    End Sub

    Private Sub BtnDownTray_MouseEnter(sender As Object, e As EventArgs) Handles btnDownTray.MouseEnter
        utils.changeBtnIcon(btnDownTray, "traydown_hover.png")
    End Sub

    Private Sub BtnDownTray_MouseLeave(sender As Object, e As EventArgs) Handles btnDownTray.MouseLeave
        utils.changeBtnIcon(btnDownTray, "traydown.png")
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        app_minimize()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        utils.fadeout(Me)
        app_exit()
    End Sub

    Private Sub MainWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        utils.Form_MouseDown(Me, e)
    End Sub

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        utils.Form_MouseMove(Me, e)
    End Sub

    Private Sub MainWindow_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        utils.Form_MouseUp(Me, e)
    End Sub

    Private Sub BtnDownTray_Click(sender As Object, e As EventArgs) Handles btnDownTray.Click
        Me.ShowInTaskbar = False
        Me.Hide()
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        Me.Show()
        Me.ShowInTaskbar = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub MainWindow_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        xfce_type_border_toggle()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_flowItemControls()
        lblDownloadStatus.Hide()
    End Sub

    Private Sub start_download()
        progressDownload.Visible = True
        lblDownloadStatus.Show()
        If Not bgworker_download.IsBusy Then
            bgworker_download.RunWorkerAsync()
            btnDownload.Visible = False
            btnDownloadAndRun.Visible = False
            picLoading.Visible = True
            picLoading.Image = Image.FromFile(Application.StartupPath & "/res/loading.gif")
            flowItems.Visible = False
        End If
    End Sub

    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        start_download()
        isRun = False
    End Sub

    Private Sub Bgworker_download_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgworker_download.DoWork
        Dim downloadURL As Uri
        Dim downloadName As String
        Dim numDownloads As Integer = downloadableURLS.Count

        Dim count As Integer = 0

        ' download the files
        For Each url In downloadableURLS
            downloadURL = New Uri(url, UriKind.Absolute)
            Dim tempArr() As String = Split(url, "/")
            downloadName = Application.StartupPath & "/downloads/" & tempArr(tempArr.Count - 1)

            If File.Exists(downloadName) Then
                Try
                    File.Delete(downloadName)
                Catch ex As Exception
                    Dim tempstr As String = downloadName & "EXISTS!"
                    MsgBox(tempstr)
                    Exit Sub
                End Try
            End If
            Try
                Dim client As New WebClient
                client.DownloadFile(downloadURL, downloadName)
            Catch ex As Exception : End Try
            If isRun = True Then
                Try
                    Process.Start(downloadName)
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            End If
            count += 1
            bgworker_download.ReportProgress(count * 100 / numDownloads)
        Next
    End Sub

    Private Sub Bgworker_download_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgworker_download.ProgressChanged
        Try
            progressDownload.Value = e.ProgressPercentage
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Bgworker_download_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgworker_download.RunWorkerCompleted
        btnDownload.Visible = True
        btnDownloadAndRun.Visible = True
        picLoading.Image = Nothing
        picLoading.Visible = False
        flowItems.Visible = True
        progressDownload.Value = 0
        progressDownload.Visible = False
        lblDownloadStatus.Hide()
        MsgBox("Downloaded!")
    End Sub

    Private Sub BtnDownloadAndRun_Click(sender As Object, e As EventArgs) Handles btnDownloadAndRun.Click
        start_download()
        isRun = True
    End Sub
End Class
