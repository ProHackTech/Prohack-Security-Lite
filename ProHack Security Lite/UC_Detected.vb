Imports System.IO

Public Class UC_Detected

    Private Sub toggle_btnHover(btn As Control, isHover As Boolean)
        If isHover = True Then
            btn.Size = New Size(btn.Size.Width + 4, btn.Size.Height + 4)
            btn.Location = New Point(btn.Location.X - 4, btn.Location.Y - 4)
        Else
            btn.Size = New Size(btn.Size.Width - 4, btn.Size.Height - 4)
            btn.Location = New Point(btn.Location.X + 4, btn.Location.Y + 4)
        End If
    End Sub

    Private Sub picTrash_MouseEnter(sender As Object, e As EventArgs) Handles picTrash.MouseEnter
        toggle_btnHover(picTrash, True)
    End Sub

    Private Sub picTrash_MouseLeave(sender As Object, e As EventArgs) Handles picTrash.MouseLeave
        toggle_btnHover(picTrash, False)
    End Sub

    Private Sub picInfo_MouseEnter(sender As Object, e As EventArgs) Handles picInfo.MouseEnter
        toggle_btnHover(picInfo, True)
    End Sub

    Private Sub picInfo_MouseLeave(sender As Object, e As EventArgs) Handles picInfo.MouseLeave
        toggle_btnHover(picInfo, False)
    End Sub

    Private Sub picIgnore_MouseEnter(sender As Object, e As EventArgs) Handles picIgnore.MouseEnter
        toggle_btnHover(picIgnore, True)
    End Sub

    Private Sub picIgnore_MouseLeave(sender As Object, e As EventArgs) Handles picIgnore.MouseLeave
        toggle_btnHover(picIgnore, False)
    End Sub

    Private Sub picTrash_Click(sender As Object, e As EventArgs) Handles picTrash.Click\
        ' ---- FIX ERRORS -----'

        Dim tempfile As String = txtFile.Text

        ' find index of hash value (filename will be the same index)
        Dim index As Integer = utils.detected_filepath.FindIndex(Function(x As String) x.Contains(tempfile))

        ' try deleting the infected file from the system
        Try
            File.Delete(utils.detected_filepath(index))

            ' remove filename and hash at stored index
            utils.detected_filepath.RemoveAt(index)
            utils.detected_filehash.RemoveAt(index)

            utils.invoke_msg(1, "Success!", "Infected file was deleted from system successfully!")
        Catch ex As Exception
            utils.invoke_msg(2, "Remove Error", ex.Message.ToString)
        End Try

        ' save list - not adding in try because No.
        Dim writer As New IO.StreamWriter(Application.StartupPath & "/data/detected.list")
        Dim lenDetections As Integer = utils.detected_filehash.Count
        For x As Integer = 0 To lenDetections - 1
            Dim tempString As String = utils.detected_filepath(x) & " |+| " & utils.detected_filehash(x)
            writer.WriteLine(tempString)
        Next
        writer.Close()
        writer.Dispose()
        malware_informer.perform_check()
    End Sub

    Private Sub picInfo_Click(sender As Object, e As EventArgs) Handles picInfo.Click

    End Sub

    Private Sub picIgnore_Click(sender As Object, e As EventArgs) Handles picIgnore.Click
        ' find a way.. 
    End Sub
End Class
