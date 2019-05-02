Imports System.IO

Public Class custom_scanner

    Dim selectedPaths As New List(Of String)()
    Public malwareDetected As Boolean = False

    Private Sub BgWorker_Scanner_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker_Scanner.DoWork
        ' reusable declares
        Dim FilesAndHashes As New List(Of String)() ' save filepaths and hashes

        ' common declares : comparer
        Dim malware_hash_counter As Integer = 0    ' store count of something
        Dim len_hash_files As Integer = 0          ' store length of hash files


        ' other declares : comparer
        Dim hashfile_lineArray() As String              ' string array to store 2 signature from each line in malware db file
        Dim malware_hash_store As New List(Of String)() ' store malware hashes in list

        Dim filenumbers As Integer = selectedPaths.Count

        For Each filepath In selectedPaths
            Try
                utils.tempStr = utils._MD5_(filepath)
                utils.tempStr = filepath & " |+| " & utils.tempStr
                FilesAndHashes.Add(utils.tempStr)
            Catch ex As Exception : End Try
            utils.tempCounter += 1
            bgWorker_Scanner.ReportProgress(utils.tempCounter * 100 / filenumbers)
        Next
        bgWorker_Scanner.ReportProgress(100)

        ' -- comparison -- '

        ' for each system file hash, compare with malware hash
        ' get all malware hash files from the malware db folder
        Dim malware_hash_files() As String = IO.Directory.GetFiles(Application.StartupPath & "/data/malware_hashes/")
        ' get length of malware hash file array (get the number of files)
        len_hash_files = malware_hash_files.Count
        ' for each malware hash db file, read the file
        ' and compare each hash in the malware db file with each hash from file hash list
        For Each malware_hash_file In malware_hash_files
            ' read the malware hash db file
            utils.reader = New StreamReader(malware_hash_file)
            ' loop over each line
            ' one line comsists of two signatures - packed & unpacked file signatures
            Do
                ' read the line into the temp variable
                utils.tempStr = utils.reader.ReadLine
                ' perform check for value not being null or empty
                ' because in some cases, the variable stores null values and invokes many problems
                If Not String.IsNullOrEmpty(utils.tempStr) Then
                    ' seperate the packaed and unpacked hash
                    ' and add both to hashfile_lineArray
                    hashfile_lineArray = Split(utils.tempStr, ",")
                    ' add both parts in lineArray to malware hash list
                    For Each hashPart In hashfile_lineArray
                        malware_hash_store.Add(hashPart)
                    Next
                End If
                ' update malware_scanrner progressbar
                bgWorker_Scanner.ReportProgress(malware_hash_counter * 100 / len_hash_files)
            Loop Until utils.tempStr Is Nothing ' loop until the variable is nothing (till the end)
            ' cleaning operations
            utils.reader.Close()   ' close file reader
            utils.tempStr = Nothing ' clean the temporary string variable

            ' declares for storing matched hashes and files
            Dim matched_hashes As New List(Of String)()
            Dim matched_files As New List(Of String)()

            ' get length of FilesAndHashes
            len_hash_files = FilesAndHashes.Count
            ' set counter to 0
            utils.tempCounter = 0
            ' for each file hash in list of file hashes
            For Each FileAndHash In FilesAndHashes
                hashfile_lineArray = Split(FileAndHash, " |+| ")
                ' for each malware hash in previous stored malware hash list
                ' compare Hash value from FileAndHash
                For Each malware_hash In malware_hash_store
                    ' if comparison is true, then detected
                    If hashfile_lineArray(1) = malware_hash Then
                        ' add file name to matched list
                        matched_files.Add(hashfile_lineArray(0))
                        ' add hash to matched list
                        matched_hashes.Add(hashfile_lineArray(1))
                        ' mark the status as malware detected in malware_scanner
                        malwareDetected = True
                    End If
                Next
                ' increment the counter for progress status
                utils.tempCounter += 1
                ' show progress in malware_scanner
                bgWorker_Scanner.ReportProgress(utils.tempCounter * 100 / len_hash_files)
            Next

            ' save matches to file ( not adding if statement for malwareDetected because I don't want to \[-_-]/ )
            utils.writer = New StreamWriter(utils.dectected_malware_file)
            ' get length of matched hashes list
            Dim len_detections As Integer = matched_hashes.Count
            ' increment over matched hashes using the length
            For x As Integer = 0 To (len_detections - 1)
                ' concatenate filepath and hash to save into one line
                utils.tempStr = matched_files(x) & " |+| " & matched_hashes(x)
                ' write line in the file with tempString
                utils.writer.WriteLine(utils.tempStr)
            Next
            ' close writer
            utils.writer.Close()
            malware_hash_counter += 1
        Next

        ' collect garbage
        GC.Collect()
    End Sub

    Private Sub BgWorker_Scanner_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker_Scanner.ProgressChanged
        Try
            ProgressBar1.Value = e.ProgressPercentage
        Catch ex As Exception
            utils.invoke_msg(3, "Worker Error", ex.Message.ToString)
        End Try
    End Sub

    Private Sub BgWorker_Scanner_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker_Scanner.RunWorkerCompleted
        ProgressBar1.Value = 100
        If e.Error IsNot Nothing Then
            utils.invoke_msg(2, "Worker Error", e.Error.ToString)
        Else
            ' if normal completed, show detections window
            If malwareDetected = True Then
                malware_informer.Show()
                Me.Close()
            Else
                utils.invoke_msg(1, "You're Safe!", "You seem to be safe :)")
            End If
        End If
        GC.Collect()
        btnSelectFiles.Enabled = True
    End Sub

    Private Sub BtnSelectFiles_Click(sender As Object, e As EventArgs) Handles btnSelectFiles.Click
        Dim x As OpenFileDialog = New OpenFileDialog()
        x.Multiselect = True
        x.ShowDialog()
        Dim result As String() = x.FileNames
        For Each y As String In result
            selectedPaths.Add(y)
        Next

        bgWorker_Scanner.RunWorkerAsync()
        btnSelectFiles.Enabled = False
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If utils.core_FadeEffect = "True" Then
            utils.form_fadeOut(Me)
        End If
        mainWindow.Show()
        Me.Close()
    End Sub
End Class