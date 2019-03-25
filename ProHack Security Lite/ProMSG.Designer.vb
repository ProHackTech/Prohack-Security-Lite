<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProMSG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProMSG))
        Me.picPriority = New System.Windows.Forms.PictureBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.RichTextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnRefreshApp = New System.Windows.Forms.Button()
        Me.btnHelpRefreshInfo = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.picPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPriority
        '
        Me.picPriority.BackColor = System.Drawing.Color.Black
        Me.picPriority.Image = CType(resources.GetObject("picPriority.Image"), System.Drawing.Image)
        Me.picPriority.Location = New System.Drawing.Point(12, 3)
        Me.picPriority.Name = "picPriority"
        Me.picPriority.Size = New System.Drawing.Size(35, 36)
        Me.picPriority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPriority.TabIndex = 0
        Me.picPriority.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Black
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(53, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(138, 22)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.TabStop = False
        Me.txtTitle.Text = "Information"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(563, 8)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtMsg
        '
        Me.txtMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMsg.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.ForeColor = System.Drawing.Color.Black
        Me.txtMsg.Location = New System.Drawing.Point(12, 54)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ReadOnly = True
        Me.txtMsg.Size = New System.Drawing.Size(576, 337)
        Me.txtMsg.TabIndex = 3
        Me.txtMsg.TabStop = False
        Me.txtMsg.Text = "Some message over here"
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(386, 403)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(114, 35)
        Me.btnReport.TabIndex = 4
        Me.btnReport.TabStop = False
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnRefreshApp
        '
        Me.btnRefreshApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshApp.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRefreshApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefreshApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshApp.FlatAppearance.BorderSize = 0
        Me.btnRefreshApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnRefreshApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRefreshApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshApp.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshApp.ForeColor = System.Drawing.Color.White
        Me.btnRefreshApp.Location = New System.Drawing.Point(12, 403)
        Me.btnRefreshApp.Name = "btnRefreshApp"
        Me.btnRefreshApp.Size = New System.Drawing.Size(148, 35)
        Me.btnRefreshApp.TabIndex = 5
        Me.btnRefreshApp.TabStop = False
        Me.btnRefreshApp.Text = "Refresh App"
        Me.btnRefreshApp.UseVisualStyleBackColor = False
        '
        'btnHelpRefreshInfo
        '
        Me.btnHelpRefreshInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelpRefreshInfo.BackColor = System.Drawing.Color.White
        Me.btnHelpRefreshInfo.BackgroundImage = CType(resources.GetObject("btnHelpRefreshInfo.BackgroundImage"), System.Drawing.Image)
        Me.btnHelpRefreshInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelpRefreshInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelpRefreshInfo.FlatAppearance.BorderSize = 0
        Me.btnHelpRefreshInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHelpRefreshInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHelpRefreshInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelpRefreshInfo.Location = New System.Drawing.Point(166, 408)
        Me.btnHelpRefreshInfo.Name = "btnHelpRefreshInfo"
        Me.btnHelpRefreshInfo.Size = New System.Drawing.Size(25, 25)
        Me.btnHelpRefreshInfo.TabIndex = 6
        Me.btnHelpRefreshInfo.TabStop = False
        Me.btnHelpRefreshInfo.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(506, 403)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 35)
        Me.btnOk.TabIndex = 7
        Me.btnOk.TabStop = False
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'ProMSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnHelpRefreshInfo)
        Me.Controls.Add(Me.btnRefreshApp)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.picPriority)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProMSG"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProHack Message"
        Me.TopMost = True
        CType(Me.picPriority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPriority As PictureBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMsg As RichTextBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnRefreshApp As Button
    Friend WithEvents btnHelpRefreshInfo As Button
    Friend WithEvents btnOk As Button
End Class
