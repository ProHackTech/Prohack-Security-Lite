Imports System.IO

Public Class ProMSG

    Public _priority_ As Integer 'informational = 1, critical = 2, error = 3

    Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown_hover.png")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown.png")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnHelpRefreshInfo_MouseEnter(sender As Object, e As EventArgs) Handles btnHelpRefreshInfo.MouseEnter
        Try
            btnHelpRefreshInfo.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/helpQuestion_hover.png")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnHelpRefreshInfo_MouseLeave(sender As Object, e As EventArgs) Handles btnHelpRefreshInfo.MouseLeave
        Try
            btnHelpRefreshInfo.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/helpQuestion.png")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        form_loading.Show()
        Me.Opacity = 0.5

        'os information
        Dim os_name As String = My.Computer.Info.OSFullName
        Dim os_platform As String = My.Computer.Info.OSPlatform
        Dim os_version As String = My.Computer.Info.OSVersion

        'read version of prohack security lite
        Dim reader As StreamReader = New StreamReader(Application.StartupPath & "/versions.txt")
        Dim line As String = ""
        Dim curVersion As String = ""
        Do
            line = reader.ReadLine
            If Not String.IsNullOrEmpty(line) Then
                curVersion = line
            End If
        Loop Until line Is Nothing
        reader.Close()
        reader.Dispose()

        'update report
        Dim tempStr As String = txtMsg.Text
        txtMsg.Clear()
        txtMsg.Text = "//-- COPY THIS, AND SEND EMAIL --//" + Environment.NewLine
        txtMsg.Text += "Os_Name:" + os_name + Environment.NewLine + "Os_platform: " + os_platform + Environment.NewLine + "Os_Version: " + os_version + Environment.NewLine
        txtMsg.Text += "Security-Lite_Version: v" + curVersion + Environment.NewLine + "//-- Error Message --//" + Environment.NewLine
        txtMsg.Text += tempStr + Environment.NewLine + "//-- Eng Error --//"

        form_loading.Close()
        Me.Opacity = 1

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        utils.form_fadeOut(Me)
        GC.Collect()
        Me.Close()
    End Sub

    Private Sub btnRefreshApp_Click(sender As Object, e As EventArgs) Handles btnRefreshApp.Click
        Dim updater_path As String = Application.StartupPath
        If mainWindow.run_from = "debug" Then
            updater_path += "/updater/updater/bin/debug/updater.exe"
            Process.Start(updater_path)
            Application.Exit()
        ElseIf mainWindow.run_from = "release" Then
            updater_path += "/updater/updater.exe"
            Process.Start(updater_path)
            Application.Exit()
        End If
    End Sub

    Private Sub btnHelpRefreshInfo_Click(sender As Object, e As EventArgs) Handles btnHelpRefreshInfo.Click
        MsgBox("Re-Update the app")
    End Sub

    Private Sub ProMSG_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        utils.Form_MouseDown(Me, e)
    End Sub

    Private Sub ProMSG_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        utils.Form_MouseMove(Me, e)
    End Sub

    Private Sub ProMSG_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        utils.Form_MouseUp(Me, e)
    End Sub
End Class