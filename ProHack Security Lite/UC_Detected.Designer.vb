<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Detected
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Detected))
        Me.picEvil = New System.Windows.Forms.PictureBox()
        Me.picHash = New System.Windows.Forms.PictureBox()
        Me.picFile = New System.Windows.Forms.PictureBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.lblSeperator1 = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        Me.lblSeperator2 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.picIgnore = New System.Windows.Forms.PictureBox()
        Me.picTrash = New System.Windows.Forms.PictureBox()
        CType(Me.picEvil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIgnore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTrash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picEvil
        '
        Me.picEvil.Image = CType(resources.GetObject("picEvil.Image"), System.Drawing.Image)
        Me.picEvil.Location = New System.Drawing.Point(20, 20)
        Me.picEvil.Name = "picEvil"
        Me.picEvil.Size = New System.Drawing.Size(50, 50)
        Me.picEvil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEvil.TabIndex = 0
        Me.picEvil.TabStop = False
        '
        'picHash
        '
        Me.picHash.Image = CType(resources.GetObject("picHash.Image"), System.Drawing.Image)
        Me.picHash.Location = New System.Drawing.Point(101, 8)
        Me.picHash.Name = "picHash"
        Me.picHash.Size = New System.Drawing.Size(35, 35)
        Me.picHash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHash.TabIndex = 1
        Me.picHash.TabStop = False
        '
        'picFile
        '
        Me.picFile.Image = CType(resources.GetObject("picFile.Image"), System.Drawing.Image)
        Me.picFile.Location = New System.Drawing.Point(101, 49)
        Me.picFile.Name = "picFile"
        Me.picFile.Size = New System.Drawing.Size(35, 35)
        Me.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFile.TabIndex = 2
        Me.picFile.TabStop = False
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFile.Location = New System.Drawing.Point(142, 18)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(302, 19)
        Me.txtFile.TabIndex = 3
        Me.txtFile.TabStop = False
        '
        'txtHash
        '
        Me.txtHash.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtHash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHash.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtHash.Location = New System.Drawing.Point(142, 58)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.ReadOnly = True
        Me.txtHash.Size = New System.Drawing.Size(302, 19)
        Me.txtHash.TabIndex = 4
        Me.txtHash.TabStop = False
        Me.txtHash.Text = "000a6d40eee7814b8243a0d8c19f94c3"
        '
        'lblSeperator1
        '
        Me.lblSeperator1.AutoSize = True
        Me.lblSeperator1.ForeColor = System.Drawing.Color.Gray
        Me.lblSeperator1.Location = New System.Drawing.Point(450, 6)
        Me.lblSeperator1.Name = "lblSeperator1"
        Me.lblSeperator1.Size = New System.Drawing.Size(9, 78)
        Me.lblSeperator1.TabIndex = 5
        Me.lblSeperator1.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(725, 8)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions.TabIndex = 6
        Me.lblOptions.Text = "Options"
        '
        'picInfo
        '
        Me.picInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picInfo.Image = CType(resources.GetObject("picInfo.Image"), System.Drawing.Image)
        Me.picInfo.Location = New System.Drawing.Point(740, 42)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(35, 35)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfo.TabIndex = 9
        Me.picInfo.TabStop = False
        '
        'lblSeperator2
        '
        Me.lblSeperator2.AutoSize = True
        Me.lblSeperator2.ForeColor = System.Drawing.Color.Gray
        Me.lblSeperator2.Location = New System.Drawing.Point(560, 6)
        Me.lblSeperator2.Name = "lblSeperator2"
        Me.lblSeperator2.Size = New System.Drawing.Size(9, 78)
        Me.lblSeperator2.TabIndex = 10
        Me.lblSeperator2.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNumber.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.White
        Me.txtNumber.Location = New System.Drawing.Point(465, 33)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.ReadOnly = True
        Me.txtNumber.Size = New System.Drawing.Size(89, 19)
        Me.txtNumber.TabIndex = 11
        Me.txtNumber.TabStop = False
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picIgnore
        '
        Me.picIgnore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picIgnore.Image = CType(resources.GetObject("picIgnore.Image"), System.Drawing.Image)
        Me.picIgnore.Location = New System.Drawing.Point(806, 42)
        Me.picIgnore.Name = "picIgnore"
        Me.picIgnore.Size = New System.Drawing.Size(35, 35)
        Me.picIgnore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIgnore.TabIndex = 8
        Me.picIgnore.TabStop = False
        '
        'picTrash
        '
        Me.picTrash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTrash.Image = CType(resources.GetObject("picTrash.Image"), System.Drawing.Image)
        Me.picTrash.Location = New System.Drawing.Point(675, 42)
        Me.picTrash.Name = "picTrash"
        Me.picTrash.Size = New System.Drawing.Size(35, 35)
        Me.picTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTrash.TabIndex = 7
        Me.picTrash.TabStop = False
        '
        'UC_Detected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblSeperator2)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.picIgnore)
        Me.Controls.Add(Me.picTrash)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblSeperator1)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.picFile)
        Me.Controls.Add(Me.picHash)
        Me.Controls.Add(Me.picEvil)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UC_Detected"
        Me.Size = New System.Drawing.Size(955, 100)
        CType(Me.picEvil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIgnore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTrash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEvil As PictureBox
    Friend WithEvents picHash As PictureBox
    Friend WithEvents picFile As PictureBox
    Friend WithEvents txtFile As TextBox
    Friend WithEvents txtHash As TextBox
    Friend WithEvents lblSeperator1 As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents picInfo As PictureBox
    Friend WithEvents lblSeperator2 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents picIgnore As PictureBox
    Friend WithEvents picTrash As PictureBox
End Class
