Public Class utils

    Public Shared isFormMovement As Boolean = False
    Public Shared MouseDownX, MouseDownY As Integer

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

    Public Shared Sub fadeout(form As Form)
        Dim count As Integer : Dim speed As Integer = 20
        For count = 100 To 0 Step -speed
            form.Opacity = count / 100
            form.Location = New Point(form.Location.X, form.Location.Y - (speed + 5))
            form.Refresh()
        Next
    End Sub

    Public Shared Sub changeBtnIcon(btnName As Control, imageName As String)
        Dim iconpath As String = Application.StartupPath & "/res/" + imageName
        Try
            btnName.BackgroundImage = Image.FromFile(iconpath)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class
