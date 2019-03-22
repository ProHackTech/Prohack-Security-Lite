<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_DetectedInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_DetectedInfo))
        Me.lblHash = New System.Windows.Forms.Label()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txtSeperator = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.picDevil = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        CType(Me.picDevil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHash.Location = New System.Drawing.Point(102, 23)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(51, 20)
        Me.lblHash.TabIndex = 0
        Me.lblHash.Text = "Hash:"
        '
        'txtHash
        '
        Me.txtHash.BackColor = System.Drawing.Color.Black
        Me.txtHash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHash.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtHash.Location = New System.Drawing.Point(159, 24)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.Size = New System.Drawing.Size(301, 19)
        Me.txtHash.TabIndex = 1
        Me.txtHash.Text = "SomeHashValueWillBeOverHereLOLO"
        '
        'txtFile
        '
        Me.txtFile.BackColor = System.Drawing.Color.Black
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFile.Location = New System.Drawing.Point(159, 61)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(301, 19)
        Me.txtFile.TabIndex = 3
        Me.txtFile.Text = "SomeHashValueWillBeOverHereLOLO"
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(102, 60)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(38, 20)
        Me.lblFile.TabIndex = 2
        Me.lblFile.Text = "File:"
        '
        'txtSeperator
        '
        Me.txtSeperator.AutoSize = True
        Me.txtSeperator.Location = New System.Drawing.Point(478, 13)
        Me.txtSeperator.Name = "txtSeperator"
        Me.txtSeperator.Size = New System.Drawing.Size(9, 78)
        Me.txtSeperator.TabIndex = 4
        Me.txtSeperator.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(601, 8)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(64, 20)
        Me.lblOptions.TabIndex = 5
        Me.lblOptions.Text = "Options"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(589, 40)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 40)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'picDevil
        '
        Me.picDevil.Image = CType(resources.GetObject("picDevil.Image"), System.Drawing.Image)
        Me.picDevil.Location = New System.Drawing.Point(20, 20)
        Me.picDevil.Name = "picDevil"
        Me.picDevil.Size = New System.Drawing.Size(60, 60)
        Me.picDevil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDevil.TabIndex = 7
        Me.picDevil.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImage = CType(resources.GetObject("btnInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Location = New System.Drawing.Point(635, 40)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(40, 40)
        Me.btnInfo.TabIndex = 8
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'UC_DetectedInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.picDevil)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.txtSeperator)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.lblHash)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "UC_DetectedInfo"
        Me.Size = New System.Drawing.Size(765, 100)
        CType(Me.picDevil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHash As Label
    Friend WithEvents txtHash As TextBox
    Friend WithEvents txtFile As TextBox
    Friend WithEvents lblFile As Label
    Friend WithEvents txtSeperator As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents picDevil As PictureBox
    Friend WithEvents btnInfo As Button
End Class
