Public Class UC_Extras

    Private Sub bgToggle(ByVal val As Boolean)
        Dim imgDef As Image = Image.FromFile(Application.StartupPath & "/res/UC_Extras/bg.png")
        Dim imgOver As Image = Image.FromFile(Application.StartupPath & "/res/UC_Extras/bg_hover.png")
        If val = True Then
            Me.BackgroundImage = imgOver
            txtName.BackColor = Color.FromArgb(49, 49, 49)
        Else
            Me.BackgroundImage = imgDef
            txtName.BackColor = Color.Black
        End If
    End Sub

    Private Sub UC_Extras_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        bgToggle(True)
    End Sub

    Private Sub UC_Extras_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        bgToggle(False)
    End Sub

    Private Sub TxtName_MouseEnter(sender As Object, e As EventArgs) Handles txtName.MouseEnter
        bgToggle(True)
    End Sub

    Private Sub TxtName_MouseLeave(sender As Object, e As EventArgs) Handles txtName.MouseLeave
        bgToggle(False)
    End Sub
End Class
