Imports Microsoft.Win32

Public Class mainWIndow
    Private isFormMovement As Boolean = False
    Private MouseDownX, MouseDownY As Integer

    Private Sub app_exit()
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' product = ProHack Security Lite
        txtProductName.Text = "ProHack Security Lite"

        ' select all dependencies
        For i As Integer = 0 To checkList_Dependency.Items.Count - 1
            checkList_Dependency.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        app_exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnFinalize_Click(sender As Object, e As EventArgs) Handles btnFinalize.Click
        For i As Integer = 0 To checkList_Dependency.Items.Count - 1
            If checkList_Dependency.GetItemCheckState(i) = CheckState.Checked Then
                Select Case i
                    Case 0 ' .net 4.7.2
                        Process.Start("http://go.microsoft.com/fwlink/?linkid=863265")
                    Case 1 ' python 3
                        Process.Start("https://www.python.org/ftp/python/3.7.3/python-3.7.3.exe")
                    Case 2 ' universal c runtime
                        Process.Start("https://www.microsoft.com/en-us/download/confirmation.aspx?id=48234")
                    Case 3 ' powershell
                        Process.Start("https://github.com/powershell/powershell")
                    Case 4 ' Git for windows
                        Process.Start("https://github.com/git-for-windows/git/releases/download/v2.21.0.windows.1/Git-2.21.0-64-bit.exe")
                End Select
            End If
        Next
    End Sub

    Private Sub MainWIndow_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isFormMovement = True Then
            Me.Cursor = Cursors.SizeAll
            Me.Location = New Point(Me.Location.X + (e.X - MouseDownX), Me.Location.Y + (e.Y - MouseDownY))
        End If
    End Sub

    Private Sub MainWIndow_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isFormMovement = False
            Me.Cursor = Cursors.Default
            Me.Opacity = 1
        End If
    End Sub

    Private Sub MainWIndow_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isFormMovement = True
            MouseDownX = e.X : MouseDownY = e.Y
            Me.Opacity = 0.8
        End If
    End Sub
End Class
