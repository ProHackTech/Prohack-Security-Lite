Public Class SecLite_Settings

    Dim blue As Color = Color.FromArgb(0, 192, 192)
    Dim lime As Color = Color.Lime
    Dim isSaved As Boolean = False

    Private Sub BtnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown_hover.png")
        Catch ex As Exception
            utils.invoke_msg(2, "Icon Error", ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnExit_MouseMove(sender As Object, e As MouseEventArgs) Handles btnExit.MouseMove
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown.png")
        Catch ex As Exception
            utils.invoke_msg(2, "Icon Error", ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If mainWindow.fadeEffect_Status = "on" Then
            utils.form_fadeOut(Me)
        End If
        Me.Close()
        mainWindow.Show()
    End Sub

    Private Sub load_config()
        ' Theme
        Select Case mainWindow.theme
            Case "dark"
                rbtn_Theme_Dark.Checked = True
                rbtn_Theme_Dark.ForeColor = lime
                rbtn_Theme_Light.ForeColor = blue
            Case "light"
                rbtn_Theme_Light.Checked = True
                rbtn_Theme_Dark.ForeColor = blue
                rbtn_Theme_Light.ForeColor = lime
        End Select

        ' MainWindow Containner Effect
        Select Case mainWindow.optionsHoverEffect_Status
            Case "on"
                rbtn_ContainerEffect_On.Checked = True
                rbtn_ContainerEffect_On.ForeColor = lime
                rbtn_ContainerEffect_Off.ForeColor = blue
            Case "off"
                rbtn_ContainerEffect_Off.Checked = True
                rbtn_ContainerEffect_On.ForeColor = blue
                rbtn_ContainerEffect_Off.ForeColor = lime
        End Select

        ' Loading Screen TopMost
        Select Case mainWindow.loadingScreenTopMost
            Case "true"
                rbtn_LoadingScreen_TopMost_Yes.Checked = True
                rbtn_LoadingScreen_TopMost_Yes.ForeColor = lime
                rbtn_LoadingScreen_TopMost_No.ForeColor = blue
            Case "false"
                rbtn_LoadingScreen_TopMost_No.Checked = True
                rbtn_LoadingScreen_TopMost_Yes.ForeColor = blue
                rbtn_LoadingScreen_TopMost_No.ForeColor = lime
        End Select

        ' Fading Effect
        Select Case mainWindow.fadeEffect_Status
            Case "on"
                rbtn_FadingEffect_On.Checked = True
                rbtn_FadingEffect_On.ForeColor = lime
                rbtn_FadingEffect_Off.ForeColor = blue
            Case "off"
                rbtn_FadingEffect_Off.Checked = True
                rbtn_FadingEffect_On.ForeColor = blue
                rbtn_FadingEffect_Off.ForeColor = lime
        End Select

        ' Fading Effect Speed
        txtSetting_FadingEffect_Speed.Text = mainWindow.fadeEffect_Speed

        ' Fade Effect Type
        Select Case mainWindow.fadeEffect_Type
            Case "WindowsDefault"
                rbtn_FadingType_WinDefault.Checked = True
                rbtn_FadingType_WinDefault.ForeColor = lime
                rbtn_FadingType_FadeLeft.ForeColor = blue
                rbtn_FadingType_FadeTop.ForeColor = blue
            Case "FadeLeft"
                rbtn_FadingType_FadeLeft.Checked = True
                rbtn_FadingType_WinDefault.ForeColor = blue
                rbtn_FadingType_FadeLeft.ForeColor = lime
                rbtn_FadingType_FadeTop.ForeColor = blue
            Case "FadeTop"
                rbtn_FadingType_FadeTop.Checked = True
                rbtn_FadingType_WinDefault.ForeColor = blue
                rbtn_FadingType_FadeLeft.ForeColor = blue
                rbtn_FadingType_FadeTop.ForeColor = lime
        End Select

        ' Wallpaper Settings + Pic Preview
        If mainWindow.wallpaper = "gif" Then
            rbtn_Wallpaper_GIF.Checked = True
            rbtn_Wallpaper_GIF.ForeColor = lime
            rbtn_Wallpaper_None.ForeColor = blue
            rbtn_Wallpaper_Image.ForeColor = blue
            Try
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & mainWindow.bgGif)
            Catch ex As Exception : End Try
        ElseIf mainWindow.wallpaper = "none" Then
            rbtn_Wallpaper_None.Checked = True
            rbtn_Wallpaper_GIF.ForeColor = blue
            rbtn_Wallpaper_None.ForeColor = lime
            rbtn_Wallpaper_Image.ForeColor = blue
            picPreview_Wallpaper.Image = Nothing
            picPreview_Wallpaper.BackColor = mainWindow.BackColor
        Else
            rbtn_Wallpaper_Image.Checked = True
            rbtn_Wallpaper_GIF.ForeColor = blue
            rbtn_Wallpaper_None.ForeColor = blue
            rbtn_Wallpaper_Image.ForeColor = lime
            Try
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & mainWindow.wallpaper)
            Catch ex As Exception : End Try
        End If

        ''coloring checked items [not working :< ]
        'For Each rbtncontrol In Me.Controls
        '    If rbtncontrol.GetType Is GetType(RadioButton) Then
        '        If DirectCast(rbtncontrol, RadioButton).Checked Then
        '            rbtncontrol.forecolor = Color.Lime
        '        Else
        '            rbtncontrol.forecolor = ugly_blue
        '        End If
        '    End If
        'Next

    End Sub

    Private Sub SecLite_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_loading.Show()
        load_config()
        form_loading.Close()
    End Sub

    Private Sub Rbtn_Theme_Dark_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Theme_Dark.CheckedChanged
        mainWindow.theme = "dark"
        rbtn_Theme_Dark.ForeColor = lime
        rbtn_Theme_Light.ForeColor = blue
    End Sub

    Private Sub Rbtn_Theme_Light_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Theme_Light.CheckedChanged
        mainWindow.theme = "light"
        rbtn_Theme_Dark.ForeColor = blue
        rbtn_Theme_Light.ForeColor = lime
    End Sub

    Private Sub Rbtn_ContainerEffect_On_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_ContainerEffect_On.CheckedChanged
        mainWindow.optionsHoverEffect_Status = "on"
        rbtn_ContainerEffect_On.ForeColor = lime
        rbtn_ContainerEffect_Off.ForeColor = blue
    End Sub

    Private Sub Rbtn_ContainerEffect_Off_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_ContainerEffect_Off.CheckedChanged
        mainWindow.optionsHoverEffect_Status = "off"
        rbtn_ContainerEffect_On.ForeColor = blue
        rbtn_ContainerEffect_Off.ForeColor = lime
    End Sub

    Private Sub Rbtn_LoadingScreen_TopMost_Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_LoadingScreen_TopMost_Yes.CheckedChanged
        mainWindow.loadingScreenTopMost = "true"
        rbtn_LoadingScreen_TopMost_Yes.ForeColor = lime
        rbtn_LoadingScreen_TopMost_No.ForeColor = blue
    End Sub

    Private Sub Rbtn_LoadingScreen_TopMost_No_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_LoadingScreen_TopMost_No.CheckedChanged
        mainWindow.loadingScreenTopMost = "false"
        rbtn_LoadingScreen_TopMost_Yes.ForeColor = blue
        rbtn_LoadingScreen_TopMost_No.ForeColor = lime
    End Sub

    Private Sub Rbtn_FadingEffect_On_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingEffect_On.CheckedChanged
        mainWindow.fadeEffect_Status = "on"
        rbtn_FadingEffect_On.ForeColor = lime
        rbtn_FadingEffect_Off.ForeColor = blue
    End Sub

    Private Sub Rbtn_FadingEffect_Off_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingEffect_Off.CheckedChanged
        mainWindow.fadeEffect_Status = "off"
        rbtn_FadingEffect_On.ForeColor = blue
        rbtn_FadingEffect_Off.ForeColor = lime
    End Sub

    Private Sub Rbtn_FadingType_WinDefault_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_WinDefault.CheckedChanged
        mainWindow.fadeEffect_Type = "WindowsDefault"
        rbtn_FadingType_WinDefault.ForeColor = lime
        rbtn_FadingType_FadeLeft.ForeColor = blue
        rbtn_FadingType_FadeTop.ForeColor = blue
    End Sub

    Private Sub Rbtn_FadingType_FadeLeft_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_FadeLeft.CheckedChanged
        mainWindow.fadeEffect_Type = "FadeLeft"
        rbtn_FadingType_WinDefault.ForeColor = blue
        rbtn_FadingType_FadeLeft.ForeColor = lime
        rbtn_FadingType_FadeTop.ForeColor = blue
    End Sub

    Private Sub Rbtn_FadingType_FadeTop_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_FadeTop.CheckedChanged
        mainWindow.fadeEffect_Type = "FadeTop"
        rbtn_FadingType_WinDefault.ForeColor = blue
        rbtn_FadingType_FadeLeft.ForeColor = blue
        rbtn_FadingType_FadeTop.ForeColor = lime
    End Sub

    Private Sub Rbtn_Wallpaper_None_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Wallpaper_None.CheckedChanged
        mainWindow.wallpaper = "none"
        picPreview_Wallpaper.Image = Nothing
        rbtn_Wallpaper_Image.ForeColor = blue
        rbtn_Wallpaper_None.ForeColor = lime
        rbtn_Wallpaper_GIF.ForeColor = blue
    End Sub

    Private Sub Rbtn_Wallpaper_GIF_Click(sender As Object, e As EventArgs) Handles rbtn_Wallpaper_GIF.Click
        Dim ofd As New OpenFileDialog
        Dim imgpath As String = Nothing
        Dim wallpaperDir = Application.StartupPath & "/res/common_controls/wallpapers/"
        ofd.Title = "Choose An Image"
        ofd.Filter = "GIF Animation|*.gif"
        ofd.InitialDirectory = wallpaperDir
        ofd.FileName = Nothing
        If ofd.ShowDialog() = DialogResult.OK Then
            imgpath = ofd.FileName
            If System.IO.File.Exists(imgpath) = True Then
                Dim imgpathArray As String() = Split(imgpath, "\")
                Dim imgpathArrLen As Integer = imgpathArray.Length()
                Dim imagename As String = imgpathArray(imgpathArrLen - 1)
                System.IO.File.Copy(imgpath, wallpaperDir & imagename)
                mainWindow.wallpaper = imagename
                picPreview_Wallpaper.Image = Image.FromFile(wallpaperDir & imagename)
                rbtn_Wallpaper_Image.ForeColor = blue
                rbtn_Wallpaper_None.ForeColor = blue
                rbtn_Wallpaper_GIF.ForeColor = lime
            Else
                utils.invoke_msg(2, "File Error", "Wallpaper file not found")
            End If
        End If
    End Sub

    Private Sub Rbtn_Wallpaper_Image_Click(sender As Object, e As EventArgs) Handles rbtn_Wallpaper_Image.Click
        Dim ofd As New OpenFileDialog
        Dim imgpath As String = Nothing
        Dim wallpaperDir = Application.StartupPath & "/res/common_controls/wallpapers/"
        ofd.Title = "Choose An Image"
        ofd.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp"
        ofd.InitialDirectory = wallpaperDir
        ofd.FileName = Nothing
        If ofd.ShowDialog() = DialogResult.OK Then
            imgpath = ofd.FileName
            If System.IO.File.Exists(imgpath) = True Then
                Dim imgpathArray As String() = Split(imgpath, "\")
                Dim imgpathArrLen As Integer = imgpathArray.Length()
                Dim imagename As String = imgpathArray(imgpathArrLen - 1)
                If Not System.IO.File.Exists(wallpaperDir & imagename) Then
                    System.IO.File.Copy(imgpath, wallpaperDir & imagename)
                End If
                mainWindow.wallpaper = imagename
                picPreview_Wallpaper.Image = Image.FromFile(wallpaperDir & imagename)
                rbtn_Wallpaper_Image.ForeColor = lime
                rbtn_Wallpaper_None.ForeColor = blue
                rbtn_Wallpaper_GIF.ForeColor = blue
            Else
                    utils.invoke_msg(2, "File Error", "Wallpaper file not found")
            End If
        End If
    End Sub

    Private Sub TxtSetting_FadingEffect_Speed_TextChanged(sender As Object, e As EventArgs) Handles txtSetting_FadingEffect_Speed.TextChanged
        mainWindow.fadeEffect_Speed = txtSetting_FadingEffect_Speed.Text
    End Sub

    Private Sub BtnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        utils.save_settings()
        utils.refresh_app()
    End Sub
End Class