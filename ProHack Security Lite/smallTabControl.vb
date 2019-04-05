Public Class smallTabControl
    Inherits TabControl

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(250, 30)
    End Sub

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Top
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)
        Dim color_theme As String

        ' set color theme: | dark/light -- SET YOUR THEME HERE --
        color_theme = "dark"

        ' dark theme colors
        Dim dankGrey As Color
        Dim duskGrey As Color
        Dim dankGrey_Brush As Brush
        Dim duskGrey_Brush As Brush
        dankGrey = Color.FromArgb(37, 37, 38)
        duskGrey = Color.FromArgb(63, 63, 70)
        dankGrey_Brush = New SolidBrush(dankGrey)
        duskGrey_Brush = New SolidBrush(duskGrey)

        ' light theme colors
        Dim dankLight As Color
        Dim duskLight As Color
        Dim dankLight_Brush As Brush
        Dim duskLight_Brush As Brush
        dankLight = Color.FromArgb(178, 194, 202)
        duskLight = Color.FromArgb(255, 231, 147)
        dankLight_Brush = New SolidBrush(dankLight)
        duskLight_Brush = New SolidBrush(duskLight)

        If color_theme = "dark" Then
            G.Clear(Color.Black)
        ElseIf color_theme = "light" Then
            G.Clear(Color.LightGray)
        End If

        For i = 0 To TabCount - 1
            Dim TabRectangle As Rectangle = GetTabRect(i)
            If i = SelectedIndex Then ' If tab selected
                If color_theme = "dark" Then
                    G.FillRectangle(duskGrey_Brush, TabRectangle)
                    G.DrawString(TabPages(i).Text, Font, Brushes.White, TabRectangle, New StringFormat With
                                 {
                                    .Alignment = StringAlignment.Center,
                                    .LineAlignment = StringAlignment.Center
                                 })
                ElseIf color_theme = "light" Then
                    G.FillRectangle(duskLight_Brush, TabRectangle)
                    G.DrawString(TabPages(i).Text, Font, Brushes.Black, TabRectangle, New StringFormat With
                                 {
                                    .Alignment = StringAlignment.Center,
                                    .LineAlignment = StringAlignment.Center
                                 })
                End If
            Else ' If tab not selected
                If color_theme = "dark" Then
                    G.FillRectangle(dankGrey_Brush, TabRectangle)
                    G.DrawString(TabPages(i).Text, Font, Brushes.Silver, TabRectangle, New StringFormat With
                             {
                                .Alignment = StringAlignment.Center,
                                .LineAlignment = StringAlignment.Center
                             })
                ElseIf color_theme = "light" Then
                    G.FillRectangle(dankLight_Brush, TabRectangle)
                    G.DrawString(TabPages(i).Text, Font, Brushes.Blue, TabRectangle, New StringFormat With
                             {
                                .Alignment = StringAlignment.Center,
                                .LineAlignment = StringAlignment.Center
                             })
                End If
            End If
        Next

        e.Graphics.DrawImage(B.Clone, 0, 0)
        G.Dispose()
        B.Dispose()
        MyBase.OnPaint(e)
    End Sub
End Class
