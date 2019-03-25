Imports System.IO
Imports System.Net
Imports System.IO.Compression

Public Class mainWindow
    Dim updateSuccess As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bgWorker_Update.IsBusy Then
            Try
                bgWorker_Update.CancelAsync()
                Application.Exit()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not bgWorker_Update.IsBusy Then
            bgWorker_Update.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgWorker_Update_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker_Update.DoWork
        Dim curVersion As Integer
        Dim latestVersion As Integer
        Dim reader As StreamReader
        Dim folderRoot As String = Application.StartupPath & "/../../../../"

        ' read current version file
        reader = New StreamReader(folderRoot & "versions.txt")
        Dim line As String
        Do
            line = reader.ReadLine
            If Not String.IsNullOrEmpty(line) Then
                line = line.Replace(".", "")
                curVersion = Int(line)
            End If
        Loop Until line Is Nothing
        reader.Close()
        reader.Dispose()
        bgWorker_Update.ReportProgress(25)

        ' get latest version from online file
        Dim address As String = "https://prohack.tech/Products/Security-Lite/versions.txt"
        Dim client As WebClient = New WebClient()
        reader = New StreamReader(client.OpenRead(address))
        Dim tempVersion = reader.ReadToEnd
        tempVersion = tempVersion.Replace(".", "")
        latestVersion = Int(tempVersion)
        reader.Close()
        reader.Dispose()
        bgWorker_Update.ReportProgress(50)

        ' compare versions
        If curVersion < latestVersion Then
            ' delete files in main folder
            Dim curDirectory As String = folderRoot
            For Each file In Directory.GetFiles(curDirectory, ".", SearchOption.TopDirectoryOnly)
                Try
                    IO.File.Delete(file)
                Catch ex As Exception
                    Try
                        FileSystem.Kill(file)
                    Catch exx As Exception
                        Dim tempStr As String = "Can't delete: " & file.ToString
                        MsgBox(tempStr)
                    End Try
                End Try
            Next
            'delete /res/ folder
            curDirectory = folderRoot & "res"
            Try
                Directory.Delete(curDirectory, True)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            'delete /data/ folder
            curDirectory = folderRoot & "data"
            Try
                Directory.Delete(curDirectory, True)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            bgWorker_Update.ReportProgress(75)

            'download latest version compressed
            Dim latest_saveAs As String = folderRoot & "latest.zip"
            Try
                My.Computer.Network.DownloadFile("https://prohack.tech/Products/Security-Lite/latest.zip", latest_saveAs)
                ' unzip
                Try
                    ZipFile.ExtractToDirectory(latest_saveAs, folderRoot)
                    ' delete zip
                    Try
                        File.Delete(latest_saveAs)
                    Catch ex As Exception : End Try
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Catch ex As Exception
                MsgBox("Error download update!")
                Exit Sub
            End Try
            bgWorker_Update.ReportProgress(100)
        Else
            MsgBox("You have the latest version!")
        End If
    End Sub

    Private Sub bgWorker_Update_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker_Update.ProgressChanged
        Try
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception : End Try
    End Sub

    Private Sub bgWorker_Update_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker_Update.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Operation Cancelled!")
        ElseIf e.Error IsNot Nothing Then
            MsgBox(e.Error.Message.ToString)
        Else
            updateSuccess = True
            MsgBox("Prohack Security Lite got updated!")
        End If
    End Sub

    Private Sub bgCheckCancelled()
        If bgWorker_Update.CancellationPending = True Then
            If bgWorker_Update.IsBusy Then
                Try
                    bgWorker_Update.CancelAsync()
                Catch ex As Exception : End Try
            End If
        End If
    End Sub


    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set update success as false (intented to check is update has been checked. If it's checked, that means it's updated)
        updateSuccess = False
        'read version number from file
        Dim versionString As String = Nothing
        Dim reader As StreamReader = New StreamReader(Application.StartupPath & "/versions.txt")
        Dim line As String
        Do
            line = reader.ReadLine()
            If Not String.IsNullOrEmpty(line) Then
                versionString = line.ToString
            End If
        Loop Until line Is Nothing
        lblVersion.Text = "Updater v" & versionString
    End Sub
End Class
