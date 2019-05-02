Public Class SecLite_Settings

    Public settings_isChanged As Boolean
    Dim blue As Color = Color.FromArgb(0, 192, 192)
    Dim lime As Color = Color.Lime

    Private Sub BtnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown_hover.png")
        Catch ex As Exception
            utils.invoke_msg(2, "Icon Error", ex.Message.ToString)
        End Try
    End Sub

    Private Sub window_exit()
        If utils.core_FadeEffect = "True" Then
            utils.form_fadeOut(Me)
        End If
        GC.Collect()
        Me.Close()
        mainWindow.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If settings_isChanged = False Then
            window_exit()
        Else
            Dim result As Integer = MessageBox.Show("Settings have been changed! Save them?", "Unsaved Settings", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MsgBox("Cancelled. Not Closing.")
            ElseIf result = DialogResult.No Then
                window_exit()
            ElseIf result = DialogResult.Yes Then
                save_settings_invoke()
            End If
        End If
    End Sub

    Private Sub load_config()

        ' -- load start configuration --'

        ' Theme
        Select Case utils.core_Theme
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
        Select Case utils.core_MainWindowOptionHoverEffect
            Case "True"
                rbtn_ContainerEffect_On.Checked = True
                rbtn_ContainerEffect_On.ForeColor = lime
                rbtn_ContainerEffect_Off.ForeColor = blue
            Case "False"
                rbtn_ContainerEffect_Off.Checked = True
                rbtn_ContainerEffect_On.ForeColor = blue
                rbtn_ContainerEffect_Off.ForeColor = lime
        End Select

        ' Loading Screen TopMost
        Select Case utils.core_LoadingScreenTopmost
            Case "True"
                rbtn_LoadingScreen_TopMost_Yes.Checked = True
                rbtn_LoadingScreen_TopMost_Yes.ForeColor = lime
                rbtn_LoadingScreen_TopMost_No.ForeColor = blue
            Case "False"
                rbtn_LoadingScreen_TopMost_No.Checked = True
                rbtn_LoadingScreen_TopMost_Yes.ForeColor = blue
                rbtn_LoadingScreen_TopMost_No.ForeColor = lime
        End Select

        ' Fading Effect
        Select Case utils.core_FadeEffect
            Case "True"
                rbtn_FadingEffect_On.Checked = True
                rbtn_FadingEffect_On.ForeColor = lime
                rbtn_FadingEffect_Off.ForeColor = blue
            Case "False"
                rbtn_FadingEffect_Off.Checked = True
                rbtn_FadingEffect_On.ForeColor = blue
                rbtn_FadingEffect_Off.ForeColor = lime
        End Select

        ' Fading Effect Speed
        txtSetting_FadingEffect_Speed.Text = utils.core_FadeEffectSpeed

        ' Fade Effect Type
        Select Case utils.core_FadeEffectType
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
        If utils.core_Wallpaper = "gif" Then
            rbtn_Wallpaper_GIF.Checked = True
            rbtn_Wallpaper_GIF.ForeColor = lime
            rbtn_Wallpaper_None.ForeColor = blue
            rbtn_Wallpaper_Image.ForeColor = blue
            Try
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & utils.core_BackgroundGIF)
            Catch ex As Exception : End Try
        ElseIf utils.core_Wallpaper = "none" Then
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
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & utils.core_Wallpaper)
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

        ' -- load python configuration --'
        txt_python_path.Text = utils.python_Path

    End Sub

    Private Sub SecLite_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_loading.Show()
        load_config()
        form_loading.Close()
        Me.BackgroundImage = mainWindow.BackgroundImage
        settings_isChanged = False
    End Sub

    Private Sub Rbtn_Theme_Dark_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Theme_Dark.CheckedChanged
        utils.core_Theme = "dark"
        rbtn_Theme_Dark.ForeColor = lime
        rbtn_Theme_Light.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_Theme_Light_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Theme_Light.CheckedChanged
        utils.core_Theme = "light"
        rbtn_Theme_Dark.ForeColor = blue
        rbtn_Theme_Light.ForeColor = lime
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_ContainerEffect_On_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_ContainerEffect_On.CheckedChanged
        utils.core_MainWindowOptionHoverEffect = "True"
        rbtn_ContainerEffect_On.ForeColor = lime
        rbtn_ContainerEffect_Off.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_ContainerEffect_Off_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_ContainerEffect_Off.CheckedChanged
        utils.core_MainWindowOptionHoverEffect = "False"
        rbtn_ContainerEffect_On.ForeColor = blue
        rbtn_ContainerEffect_Off.ForeColor = lime
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_LoadingScreen_TopMost_Yes_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_LoadingScreen_TopMost_Yes.CheckedChanged
        utils.core_LoadingScreenTopmost = "True"
        rbtn_LoadingScreen_TopMost_Yes.ForeColor = lime
        rbtn_LoadingScreen_TopMost_No.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_LoadingScreen_TopMost_No_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_LoadingScreen_TopMost_No.CheckedChanged
        utils.core_LoadingScreenTopmost = "False"
        rbtn_LoadingScreen_TopMost_Yes.ForeColor = blue
        rbtn_LoadingScreen_TopMost_No.ForeColor = lime
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_FadingEffect_On_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingEffect_On.CheckedChanged
        utils.core_FadeEffect = "True"
        rbtn_FadingEffect_On.ForeColor = lime
        rbtn_FadingEffect_Off.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_FadingEffect_Off_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingEffect_Off.CheckedChanged
        utils.core_FadeEffect = "False"
        rbtn_FadingEffect_On.ForeColor = blue
        rbtn_FadingEffect_Off.ForeColor = lime
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_FadingType_WinDefault_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_WinDefault.CheckedChanged
        utils.core_FadeEffectType = "WindowsDefault"
        rbtn_FadingType_WinDefault.ForeColor = lime
        rbtn_FadingType_FadeLeft.ForeColor = blue
        rbtn_FadingType_FadeTop.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_FadingType_FadeLeft_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_FadeLeft.CheckedChanged
        utils.core_FadeEffectType = "FadeLeft"
        rbtn_FadingType_WinDefault.ForeColor = blue
        rbtn_FadingType_FadeLeft.ForeColor = lime
        rbtn_FadingType_FadeTop.ForeColor = blue
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_FadingType_FadeTop_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_FadingType_FadeTop.CheckedChanged
        utils.core_FadeEffectType = "FadeTop"
        rbtn_FadingType_WinDefault.ForeColor = blue
        rbtn_FadingType_FadeLeft.ForeColor = blue
        rbtn_FadingType_FadeTop.ForeColor = lime
        settings_isChanged = True
    End Sub

    Private Sub Rbtn_Wallpaper_None_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Wallpaper_None.CheckedChanged
        utils.core_Wallpaper = "none"
        picPreview_Wallpaper.Image = Nothing
        rbtn_Wallpaper_Image.ForeColor = blue
        rbtn_Wallpaper_None.ForeColor = lime
        rbtn_Wallpaper_GIF.ForeColor = blue
        settings_isChanged = True
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
                utils.core_Wallpaper = imagename
                picPreview_Wallpaper.Image = Image.FromFile(wallpaperDir & imagename)
                rbtn_Wallpaper_Image.ForeColor = blue
                rbtn_Wallpaper_None.ForeColor = blue
                rbtn_Wallpaper_GIF.ForeColor = lime
            Else
                utils.invoke_msg(2, "File Error", "Wallpaper file not found")
            End If
        End If
        settings_isChanged = True
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
                utils.core_Wallpaper = imagename
                picPreview_Wallpaper.Image = Image.FromFile(wallpaperDir & imagename)
                Me.BackgroundImage = picPreview_Wallpaper.Image
                rbtn_Wallpaper_Image.ForeColor = lime
                rbtn_Wallpaper_None.ForeColor = blue
                rbtn_Wallpaper_GIF.ForeColor = blue
            Else
                utils.invoke_msg(2, "File Error", "Wallpaper file not found")
            End If
        End If
        settings_isChanged = True
    End Sub

    Private Sub TxtSetting_FadingEffect_Speed_TextChanged(sender As Object, e As EventArgs) Handles txtSetting_FadingEffect_Speed.TextChanged
        ' declare temp variable for easiness
        Dim spd As String = txtSetting_FadingEffect_Speed.Text

        ' check if not null, empty - fixes type error
        If Not String.IsNullOrEmpty(spd) Then
            ' convert to integer 32 and apply
            utils.core_FadeEffectSpeed = Convert.ToInt32(spd)
        End If
        settings_isChanged = True
    End Sub

    Private Sub save_settings_invoke()
        utils.save_config()
        utils.refresh_app()
        MsgBox("UNDER PROGRESS - testing cycle")
    End Sub

    Private Sub BtnSaveSettings1_Click(sender As Object, e As EventArgs) Handles btnSaveSettings1.Click
        save_settings_invoke()
    End Sub

    Private Sub SecLite_Settings_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        utils.Form_MouseDown(Me, e)
    End Sub

    Private Sub SecLite_Settings_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        utils.Form_MouseMove(Me, e)
    End Sub

    Private Sub SecLite_Settings_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        utils.Form_MouseUp(Me, e)
    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        Try
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/common_controls/shutdown.png")
        Catch ex As Exception
            utils.invoke_msg(2, "Icon Error", ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnSaveSettings2_Click(sender As Object, e As EventArgs) Handles btnSaveSettings2.Click
        save_settings_invoke()
    End Sub

    Private Sub Btn_browse_python_path_Click(sender As Object, e As EventArgs) Handles btn_browse_python_path.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Python EXE Path"
        ofd.Filter = "EXE File (*.exe)|*.exe"
        ofd.FileName = String.Empty
        If ofd.ShowDialog = DialogResult.OK Then
            txt_python_path.Text = ofd.FileName
            settings_isChanged = True
        Else
            MsgBox("FileBrowse Cancelled")
        End If
    End Sub

    Private Sub Txt_python_path_TextChanged(sender As Object, e As EventArgs) Handles txt_python_path.TextChanged
        If Not String.IsNullOrEmpty(txt_python_path.Text) Then
            utils.python_Path = txt_python_path.Text
        End If
        settings_isChanged = True
    End Sub
End Class