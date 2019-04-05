Public Class SecLite_Settings
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

        Dim ugly_blue As Color
        ugly_blue = Color.FromArgb(0, 192, 192)

        ' Theme
        Select Case mainWindow.theme
            Case "dark"
                rbtn_Theme_Dark.Checked = True
            Case "light"
                rbtn_Theme_Light.Checked = True
        End Select

        ' MainWindow Containner Effect
        Select Case mainWindow.optionsHoverEffect_Status
            Case "on"
                rbtn_ContainerEffect_On.Checked = True
            Case "off"
                rbtn_ContainerEffect_Off.Checked = True
        End Select

        ' Loading Screen TopMost
        Select Case mainWindow.loadingScreenTopMost
            Case "true"
                rbtn_LoadingScreen_TopMost_Yes.Checked = True
            Case "false"
                rbtn_LoadingScreen_TopMost_No.Checked = True
        End Select

        ' Fading Effect
        Select Case mainWindow.fadeEffect_Status
            Case "on"
                rbtn_FadingEffect_On.Checked = True
            Case "off"
                rbtn_FadingEffect_Off.Checked = True
        End Select

        ' Fading Effect Speed
        txtSetting_FadingEffect_Speed.Text = mainWindow.fadeEffect_Speed

        ' Fade Effect Type
        Select Case mainWindow.fadeEffect_Type
            Case "WindowsDefault"
                rbtn_FadingType_WinDefault.Checked = True
            Case "FadeLeft"
                rbtn_FadingType_FadeLeft.Checked = True
            Case "FadeTop"
                rbtn_FadingType_FadeTop.Checked = True
        End Select

        ' Wallpaper Settings + Pic Preview
        If mainWindow.wallpaper = "gif" Then
            rbtn_Wallpaper_GIF.Checked = True
            Try
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & mainWindow.bgGif)
            Catch ex As Exception : End Try
        ElseIf mainWindow.wallpaper = "none" Then
            rbtn_Wallpaper_None.Checked = True
            picPreview_Wallpaper.Image = Nothing
            picPreview_Wallpaper.BackColor = mainWindow.BackColor
        Else
            rbtn_Wallpaper_Image.Checked = True
            Try
                picPreview_Wallpaper.Image = Image.FromFile(Application.StartupPath & "/res/common_controls/wallpapers/" & mainWindow.wallpaper)
            Catch ex As Exception : End Try
        End If

        ' Coloring checked items [NOT WORKING :< ]
        For Each rbtnControl In Me.Controls
            If rbtnControl.GetType Is GetType(RadioButton) Then
                If DirectCast(rbtnControl, RadioButton).Checked Then
                    rbtnControl.ForeColor = Color.Lime
                Else
                    rbtnControl.ForeColor = ugly_blue
                End If
            End If
        Next

    End Sub

    Private Sub SecLite_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_loading.Show()
        load_config()
        form_loading.Close()
    End Sub
End Class