Public Class UC_Item

    Public Property isChecked As Boolean = False

    Private Sub toggle_color()
        If isChecked = True Then
            Me.BackColor = Color.Black
            Me.txtName.BackColor = Color.Black
            Me.txtName.ForeColor = Color.White
            isChecked = False
        Else
            Me.BackColor = Color.FromArgb(64, 64, 64)
            Me.txtName.BackColor = Color.FromArgb(64, 64, 64)
            Me.txtName.ForeColor = Color.Black
            isChecked = True
        End If
    End Sub

    Private Sub UC_Item_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        toggle_color()
    End Sub

    Private Sub TxtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        toggle_color()
    End Sub

End Class
