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
    Public Shared core_conf As New List(Of String)()
    Public Shared python_conf As New List(Of String)()
    Public Shared scanner_conf As New List(Of String)()

    ' Declares: Configuration Variables
    ' Order 1: Core
    ' Order 2: Python
    ' Order 3: Scanner
    '
    ' -- core --
    Public Shared core_Theme As String
    Public Shared core_Wallpaper As String
    Public Shared core_FadeEffect As Boolean
    Public Shared core_FadeEffectType As String
    Public Shared core_FadeEffectSpeed As Integer
    Public Shared core_MainWindowOptionHoverEffect As Boolean
    Public Shared core_LoadingScreenTopmost As Boolean
    Public Shared core_BackgroundGIF As String
    Public Shared core_RunFrom As String
    ' -- python --
    Public Shared python_Path As String
    ' -- scanner --
    Public Shared scanner_ShowDetectionsOnLoad As Boolean

    ' Method: To read application configurations
    Public Shared Sub read_config(ByVal file_name As String)
        ' form the file path
        Dim file_path = confDir & file_name & ".conf"

        tempStr = Nothing
        reader = New StreamReader(file_path)
        Do
            tempStr = reader.ReadLine
            If Not String.IsNullOrWhiteSpace(tempStr) Then
                ' store 2 parts seperated by delimeter "=" into temporary array
                Dim tempArray As String() = tempStr.Split("=")
                ' replace the double quotes with nothing
                tempArray(1) = tempArray(1).Replace("""", "")
                ' decide which list to store the value in
                ' depending on the file_name / config file
                Select Case file_name
                    Case "core"
                        core_conf.Add(tempArray(0)) ' add name item
                        core_conf.Add(tempArray(1)) ' add value item
                    Case "python"
                        python_conf.Add(tempArray(0)) ' add name item
                        python_conf.Add(tempArray(1)) ' add value item
                    Case "scanner"
                        scanner_conf.Add(tempArray(0)) ' add name item
                        scanner_conf.Add(tempArray(1)) ' add value item
                End Select
            End If
        Loop Until tempStr Is Nothing
        reader.Close()
        reader.Dispose()

        ' apply configurations based on file
        ' even index = configuration name
        ' odd index = configuration value
        Select Case file_name
            Case "core"
                core_Theme = core_conf(1)
                core_Wallpaper = core_conf(3)
                core_FadeEffect = core_conf(5)
                core_FadeEffectType = core_conf(7)
                core_FadeEffectSpeed = core_conf(9)
                core_MainWindowOptionHoverEffect = core_conf(11)
                core_LoadingScreenTopmost = core_conf(13)
                core_BackgroundGIF = core_conf(15)
                core_RunFrom = core_conf(17)
            Case "python"
                python_Path = python_conf(1)
            Case "scanner"
                scanner_ShowDetectionsOnLoad = scanner_conf(1)
        End Select
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
        detected_filehash.Clear()
        detected_filepath.Clear()
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
        reader.Close()
        reader.Dispose()
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
