Imports System.IO
Imports System.Security.Cryptography
Imports System.Net

Public Class utils

    ' Declares: Malware Detections
    Public Shared detected_filepath As New List(Of String)()
    Public Shared detected_filehash As New List(Of String)()

    ' Declares: Locations
    Public Shared dectected_malware_file As String = Application.StartupPath & "/data/detected.list"
    Public Shared WSIR_file As String = Application.StartupPath & "/data/WSIR.list"
    Public Shared pyModDir As String = Application.StartupPath & "/python_modules/"
    Public Shared confDir As String = Application.StartupPath & "/data/config/"

    ' Declares: Form Movement
    Public Shared isFormMovement As Boolean = False
    Public Shared MouseDownX, MouseDownY As Integer

    ' Declares: Reusable
    Public Shared reader As StreamReader
    Public Shared writer As StreamWriter
    Public Shared tempStr As String
    Public Shared tempCounter As Integer

    ' Declares: Store Configurations
    Public Shared core_conf_names As New List(Of String)()
    Public Shared core_conf_values As New List(Of String)()

    ' Declares: Configuration Variables
    ' Order 1: Core
    ' Order 2: Python
    ' Order 3: Scanner
    '
    ' -- core --
    Public Shared core_Theme As String
    Public Shared core_Wallpaper As String
    Public Shared core_FadeEffect As String
    Public Shared core_FadeEffectType As String
    Public Shared core_FadeEffectSpeed As Integer
    Public Shared core_MainWindowOptionHoverEffect As String
    Public Shared core_LoadingScreenTopmost As String
    Public Shared core_BackgroundGIF As String
    Public Shared core_RunFrom As String
    ' -- python --
    Public Shared python_Path As String
    ' -- scanner --
    Public Shared scanner_ShowDetectionsOnLoad As String
    Public Shared scanner_QuickScan_ExtensionBased As String
    Public Shared scanner_QuickScan_MultipleExtensionFiles As String
    Public Shared scanner_QuickScan_ExtensionFileName As String
    Public Shared scanner_QuickScan_ExtensionFileList As String
    Public Shared scanner_DeepScan_ExtensionBased As String


    ' Method: To read application configurations
    Public Shared Sub read_config()
        tempStr = Nothing
        reader = New StreamReader(confDir & "core.conf")
        Do
            tempStr = reader.ReadLine
            If Not String.IsNullOrWhiteSpace(tempStr) Then
                ' store 2 parts seperated by delimeter "=" into temporary array
                Dim tempArray As String() = tempStr.Split("=")
                ' replace the double quotes with nothing
                tempArray(1) = tempArray(1).Replace("'", "")
                core_conf_names.Add(tempArray(0)) ' add name item
                core_conf_values.Add(tempArray(1)) ' add value item
            End If
        Loop Until tempStr Is Nothing
        reader.Close() : reader.Dispose()

        ' assign configuration to variables
        core_Theme = core_conf_values(0)
        core_Wallpaper = core_conf_values(1)
        core_FadeEffect = core_conf_values(2)
        core_FadeEffectType = core_conf_values(3)
        core_FadeEffectSpeed = Int(core_conf_values(4))
        core_MainWindowOptionHoverEffect = core_conf_values(5)
        core_LoadingScreenTopmost = core_conf_values(6)
        core_BackgroundGIF = core_conf_values(7)
        core_RunFrom = core_conf_values(8)
        python_Path = core_conf_values(9)
        scanner_ShowDetectionsOnLoad = core_conf_values(10)
        scanner_QuickScan_ExtensionBased = core_conf_values(11)
        scanner_QuickScan_MultipleExtensionFiles = core_conf_values(12)
        scanner_QuickScan_ExtensionFileName = core_conf_values(13)
        scanner_QuickScan_ExtensionFileList = core_conf_values(14)
        scanner_DeepScan_ExtensionBased = core_conf_values(15)
    End Sub

    'Method: To save configurations
    Public Shared Sub save_config()
        ' assign configuration to variables
        core_conf_values(0) = core_Theme
        core_conf_values(1) = core_Wallpaper
        core_conf_values(2) = core_FadeEffect
        core_conf_values(3) = core_FadeEffectType
        core_conf_values(4) = core_FadeEffectSpeed
        core_conf_values(5) = core_MainWindowOptionHoverEffect
        core_conf_values(6) = core_LoadingScreenTopmost
        core_conf_values(7) = core_BackgroundGIF
        core_conf_values(8) = core_RunFrom
        core_conf_values(9) = python_Path
        core_conf_values(10) = scanner_ShowDetectionsOnLoad
        core_conf_values(11) = scanner_QuickScan_ExtensionBased
        core_conf_values(12) = scanner_QuickScan_MultipleExtensionFiles
        core_conf_values(13) = scanner_QuickScan_ExtensionFileName
        core_conf_values(14) = scanner_QuickScan_ExtensionFileList
        core_conf_values(15) = scanner_DeepScan_ExtensionBased

        Dim file_path As String = confDir & "core.conf"
        Dim backup_path As String = confDir & "backup_core.conf"
        If File.Exists(file_path) Then
            Try
                File.Delete(file_path)
            Catch ex As Exception : End Try
        End If
        Dim writer As New StreamWriter(confDir & "core.conf")
        For x As Integer = 0 To core_conf_values.Count - 1
            Dim lineStr As String = core_conf_names(x) & "=" & "'" & core_conf_values(x) & "'" + Environment.NewLine
            writer.Write(lineStr)
        Next
        writer.Close() : writer.Dispose()

        ' create backup of the conf file
        If File.Exists(backup_path) Then
            Try
                File.Delete(backup_path)
            Catch ex As Exception : End Try
        End If
        File.Copy(file_path, backup_path)

        GC.Collect()
    End Sub

    'Method: To fade out form
    Public Shared Sub form_fadeOut(form As Form)
        Dim count As Integer
        Dim speed As Integer = core_FadeEffectSpeed

        If core_FadeEffectType = "WindowsDefault" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height - (speed + 5))
                form.Location = New Point(form.Location.X - (speed + 5), form.Location.Y + (speed + 5))
                form.Refresh()
            Next
        ElseIf core_FadeEffectType = "FadeLeft" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height)
                form.Location = New Point(form.Location.X - (speed + 5), form.Location.Y)
                form.Refresh()
            Next
        ElseIf core_FadeEffectType = "FadeTop" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width - (speed + 5), form.Height)
                form.Location = New Point(form.Location.X, form.Location.Y - (speed + 5))
                form.Refresh()
            Next
        End If
        GC.Collect()
    End Sub

    'Method: To fade in form
    Public Shared Sub form_fadeIn(form)
        Dim count As Integer
        Dim speed As Integer = core_FadeEffectSpeed

        If core_FadeEffectType = "WindowsDefault" Then
            For count = 0 To 100 Step speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height + (speed + 5))
                form.Location = New Point(form.Location.X + (speed + 5), form.Location.Y - (speed + 5))
                form.Refresh()
            Next
        ElseIf core_FadeEffectType = "FadeLeft" Then
            For count = 0 To 100 Step speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height)
                form.Location = New Point(form.Location.X + (speed + 5), form.Location.Y)
                form.Refresh()
            Next
        ElseIf core_FadeEffectType = "FadeTop" Then
            For count = 100 To 0 Step -speed
                form.Opacity = count / 100
                form.Size = New Size(form.Width + (speed + 5), form.Height)
                form.Location = New Point(form.Location.X, form.Location.Y + (speed + 5))
                form.Refresh()
            Next
        End If
        GC.Collect()
    End Sub

    ' Form Movevement: On Mouse Down
    Public Shared Sub Form_MouseDown(form As Form, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isFormMovement = True
            MouseDownX = e.X : MouseDownY = e.Y
        End If
    End Sub

    ' Form Movevement: On Mouse Move
    Public Shared Sub Form_MouseMove(form As Form, e As MouseEventArgs)
        If isFormMovement = True Then
            form.Opacity = 0.8
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
        End If
    End Sub

    ' check internet connection
    Public Shared Function _online_status_() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://duckduckgo.com/")
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
        detected_filehash.Clear() : detected_filepath.Clear()
        ' read detections file
        reader = New StreamReader(dectected_malware_file)
        tempStr = Nothing
        Do
            tempStr = reader.ReadLine
            If Not String.IsNullOrEmpty(tempStr) Then
                Dim tempArray() As String = Split(tempStr, " |+| ")
                detected_filepath.Add(tempArray(0))
                detected_filehash.Add(tempArray(1))
            End If
        Loop Until tempStr Is Nothing
        reader.Close() : reader.Dispose()
        Dim totalDetections As Integer = detected_filehash.Count
        For x As Integer = 0 To totalDetections - 1
            createCards(detected_filepath(x), detected_filehash(x), x + 1)
        Next
        GC.Collect()
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
        GC.Collect()
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

End Class
