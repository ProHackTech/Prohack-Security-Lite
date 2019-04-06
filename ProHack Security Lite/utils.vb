Imports System.IO
Imports System.Security.Cryptography
Imports System.Net

Public Class utils

    Public Shared detected_filepath As New List(Of String)()
    Public Shared detected_filehash As New List(Of String)()
    Public Shared dectected_malware_file As String = Application.StartupPath & "/data/detected.list"
    Public Shared WSIR_file As String = Application.StartupPath & "/data/WSIR.list"
    Public Shared isFormMovement As Boolean = False
    Public Shared MouseDownX, MouseDownY As Integer

    'Method: To fade out form
    Public Shared Sub form_fadeOut(form As Form)
        Dim count As Integer : Dim speed As Integer = mainWindow.fadeEffect_Speed

        If mainWindow.fadeEffect_Type = "WindowsDefault" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height - (speed + 5))
                form.Location = New Point(form.Location.X - (speed + 5), form.Location.Y + (speed + 5))
                form.Refresh()
            Next
        ElseIf mainWindow.fadeEffect_Type = "FadeLeft" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height)
                form.Location = New Point(form.Location.X - (speed + 5), form.Location.Y)
                form.Refresh()
            Next
        ElseIf mainWindow.fadeEffect_Type = "FadeTop" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height)
                form.Location = New Point(form.Location.X, form.Location.Y - (speed + 5))
                form.Refresh()
            Next
        End If
    End Sub

    'Method: To fade in form
    Public Shared Sub form_fadeIn(form)
        Dim count As Integer : Dim speed As Integer = mainWindow.fadeEffect_Speed

        If mainWindow.fadeEffect_Type = "WindowsDefault" Then
            For count = 0 To 100 Step speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height + (speed + 5))
                form.Location = New Point(form.Location.X + (speed + 5), form.Location.Y - (speed + 5))
                form.Refresh()
            Next
        ElseIf mainWindow.fadeEffect_Type = "FadeLeft" Then
            For count = 0 To 100 Step speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height)
                form.Location = New Point(form.Location.X + (speed + 5), form.Location.Y)
                form.Refresh()
            Next
        ElseIf mainWindow.fadeEffect_Type = "FadeTop" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height)
                form.Location = New Point(form.Location.X, form.Location.Y + (speed + 5))
                form.Refresh()
            Next
        End If
    End Sub

    ' Form Movevement: On Mouse Down
    Public Shared Sub Form_MouseDown(form As Form, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isFormMovement = True
            MouseDownX = e.X : MouseDownY = e.Y
            form.Opacity = 0.8
            form.Size = New Size(form.Size.Width + 10, form.Size.Height + 10)
        End If
    End Sub

    ' Form Movevement: On Mouse Move
    Public Shared Sub Form_MouseMove(form As Form, e As MouseEventArgs)
        If isFormMovement = True Then
            form.Cursor = Cursors.SizeAll
            form.Location = New Point(form.Location.X + (e.X - MouseDownX), form.Location.Y + (e.Y - MouseDownY))
        End If
    End Sub

    ' Form Movevement: On Mouse Up
    Public Shared Sub Form_MouseUp(form As Form, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isFormMovement = False
            form.Cursor = Cursors.Default
            form.Opacity = 1
            form.Size = New Size(form.Size.Width - 10, form.Size.Height - 10)
        End If
    End Sub

    ' check internet connection
    Public Shared Function _online_status_() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://https://duckduckgo.com/")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' generate md5 hash for file
    Public Shared Function _MD5_(ByVal file_name As String)
        Dim hash = MD5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = _print_byte_(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    ' printing byte array
    Public Shared Function _print_byte_(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    ' custom message dialog creation
    Public Shared Sub invoke_msg(level As Integer, title As String, msg As String)
        ProMSG.Show()
        ProMSG._priority_ = level
        Select Case level
            Case 1 ' informatinoal
                Try
                    ProMSG.picPriority.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/ProMSG/informational.png")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Case 2 ' critical
                Try
                    ProMSG.picPriority.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/ProMSG/critical.png")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Case 3 ' error
                Try
                    ProMSG.picPriority.BackgroundImage = Image.FromFile(Application.StartupPath & "/res/ProMSG/high.png")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
        End Select
        ProMSG.txtTitle.Text = title
        ProMSG.txtMsg.Text = msg
    End Sub

    ' check and list detections
    Public Shared Sub _check_detections_()
        ' perform clear
        removeCards()
        detected_filehash.Clear()
        detected_filepath.Clear()
        ' read detections file
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(dectected_malware_file)
        Dim line As String
        Do
            line = reader.ReadLine
            If Not String.IsNullOrEmpty(line) Then
                Dim tempArray() As String = Split(line, " |+| ")
                detected_filepath.Add(tempArray(0))
                detected_filehash.Add(tempArray(1))
            End If
        Loop Until line Is Nothing
        reader.Close()
        reader.Dispose()
        Dim totalDetections As Integer = detected_filehash.Count
        For x As Integer = 0 To totalDetections - 1
            createCards(detected_filepath(x), detected_filehash(x), x + 1)
        Next
    End Sub

    ' create UC_Detected controls in flowlayoutpanel for malware informer
    Public Shared Sub createCards(file As String, hash As String, num As Integer)
        malware_informer.flowDetections.SuspendLayout()
        Try
            Dim ucdetected As New UC_Detected
            ucdetected.txtFile.Text = file
            ucdetected.txtHash.Text = hash
            ucdetected.txtNumber.Text = num
            malware_informer.flowDetections.Controls.Add(ucdetected)
        Catch ex As Exception
            utils.invoke_msg(3, "Worker Error", ex.Message.ToString)
        End Try
        malware_informer.flowDetections.ResumeLayout()
    End Sub

    ' remove UC_Detected controls from flowlayoutpanel for malware informer
    Public Shared Sub removeCards()
        malware_informer.flowDetections.SuspendLayout()
        If malware_informer.flowDetections.Controls.Count > 0 Then
            For i As Integer = malware_informer.flowDetections.Controls.Count - 1 To 0
                Dim c As Control = malware_informer.flowDetections.Controls(i)
                c.Dispose()
            Next
            GC.Collect()
        End If
        malware_informer.flowDetections.ResumeLayout()
    End Sub

    ' refresh application
    Public Shared Sub refresh_app()
        Process.Start("starter.bat")
        Application.Exit()
    End Sub

    ' save application settings
    Public Shared Sub save_settings()
        Dim configpath As String = Application.StartupPath & "/data/start_config"
        If File.Exists(configpath) Then
            File.Delete(configpath)
        End If
        Dim st As StreamWriter = New StreamWriter(configpath)
        st.WriteLine("Theme:" & mainWindow.theme)
        st.WriteLine("Wallpaper:" & mainWindow.wallpaper)
        st.WriteLine("Fading Effect:" & mainWindow.fadeEffect_Status)
        st.WriteLine("Main Window Options Button Hover Effect:" & mainWindow.optionsHoverEffect_Status)
        st.WriteLine("Is Loading Screen TopMost?:" & mainWindow.loadingScreenTopMost)
        st.WriteLine("Background GIF Animation:" & mainWindow.bgGif)
        st.WriteLine("Fade Effect Type:" & mainWindow.fadeEffect_Type)
        st.WriteLine("Fade Effect Speed(More means faster):" & mainWindow.fadeEffect_Speed)
        st.Close()
        st.Dispose()
    End Sub

End Class
