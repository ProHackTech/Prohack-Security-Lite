<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWIndow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWIndow))
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.progressDownload = New System.Windows.Forms.ProgressBar()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.lblSelectItems = New System.Windows.Forms.Label()
        Me.flowItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDownTray = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.bgworker_download = New System.ComponentModel.BackgroundWorker()
        Me.btnDownloadAndRun = New System.Windows.Forms.Button()
        Me.lblDownloadStatus = New System.Windows.Forms.Label()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLoading
        '
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.Location = New System.Drawing.Point(278, 100)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(245, 220)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoading.TabIndex = 21
        Me.picLoading.TabStop = False
        Me.picLoading.Visible = False
        '
        'progressDownload
        '
        Me.progressDownload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressDownload.Location = New System.Drawing.Point(42, 416)
        Me.progressDownload.Name = "progressDownload"
        Me.progressDownload.Size = New System.Drawing.Size(714, 10)
        Me.progressDownload.TabIndex = 20
        Me.progressDownload.Visible = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownload.FlatAppearance.BorderSize = 0
        Me.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(206, 324)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(383, 36)
        Me.btnDownload.TabIndex = 19
        Me.btnDownload.TabStop = False
        Me.btnDownload.Text = "JUST DOWNLOAD"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'lblSelectItems
        '
        Me.lblSelectItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSelectItems.AutoSize = True
        Me.lblSelectItems.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSelectItems.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectItems.ForeColor = System.Drawing.Color.White
        Me.lblSelectItems.Location = New System.Drawing.Point(203, 81)
        Me.lblSelectItems.Name = "lblSelectItems"
        Me.lblSelectItems.Size = New System.Drawing.Size(208, 16)
        Me.lblSelectItems.TabIndex = 18
        Me.lblSelectItems.Text = "Select Toggle Items:"
        '
        'flowItems
        '
        Me.flowItems.AutoScroll = True
        Me.flowItems.BackColor = System.Drawing.Color.Transparent
        Me.flowItems.Location = New System.Drawing.Point(206, 100)
        Me.flowItems.Name = "flowItems"
        Me.flowItems.Size = New System.Drawing.Size(383, 218)
        Me.flowItems.TabIndex = 17
        '
        'btnDownTray
        '
        Me.btnDownTray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDownTray.BackColor = System.Drawing.Color.Transparent
        Me.btnDownTray.BackgroundImage = CType(resources.GetObject("btnDownTray.BackgroundImage"), System.Drawing.Image)
        Me.btnDownTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownTray.FlatAppearance.BorderSize = 0
        Me.btnDownTray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDownTray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDownTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownTray.Location = New System.Drawing.Point(701, 11)
        Me.btnDownTray.Name = "btnDownTray"
        Me.btnDownTray.Size = New System.Drawing.Size(25, 25)
        Me.btnDownTray.TabIndex = 16
        Me.btnDownTray.TabStop = False
        Me.btnDownTray.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(732, 11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 15
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(763, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 14
        Me.btnExit.TabStop = False
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Olive
        Me.lblSubTitle.Location = New System.Drawing.Point(61, 36)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(129, 19)
        Me.lblSubTitle.TabIndex = 13
        Me.lblSubTitle.Text = "Downloader"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(61, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(115, 24)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "ProHack"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(43, 43)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 11
        Me.picLogo.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "ProHack Installer Minified"
        Me.NotifyIcon1.BalloonTipTitle = "ProHack Installer"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'bgworker_download
        '
        Me.bgworker_download.WorkerReportsProgress = True
        '
        'btnDownloadAndRun
        '
        Me.btnDownloadAndRun.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDownloadAndRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownloadAndRun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadAndRun.FlatAppearance.BorderSize = 0
        Me.btnDownloadAndRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDownloadAndRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDownloadAndRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownloadAndRun.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadAndRun.ForeColor = System.Drawing.Color.White
        Me.btnDownloadAndRun.Location = New System.Drawing.Point(206, 366)
        Me.btnDownloadAndRun.Name = "btnDownloadAndRun"
        Me.btnDownloadAndRun.Size = New System.Drawing.Size(383, 36)
        Me.btnDownloadAndRun.TabIndex = 22
        Me.btnDownloadAndRun.TabStop = False
        Me.btnDownloadAndRun.Text = "DOWNLOAD and RUN"
        Me.btnDownloadAndRun.UseVisualStyleBackColor = False
        '
        'lblDownloadStatus
        '
        Me.lblDownloadStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDownloadStatus.AutoSize = True
        Me.lblDownloadStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblDownloadStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDownloadStatus.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloadStatus.ForeColor = System.Drawing.Color.White
        Me.lblDownloadStatus.Location = New System.Drawing.Point(39, 397)
        Me.lblDownloadStatus.Name = "lblDownloadStatus"
        Me.lblDownloadStatus.Size = New System.Drawing.Size(158, 16)
        Me.lblDownloadStatus.TabIndex = 23
        Me.lblDownloadStatus.Text = "Download Status"
        '
        'mainWIndow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDownloadStatus)
        Me.Controls.Add(Me.btnDownloadAndRun)
        Me.Controls.Add(Me.picLoading)
        Me.Controls.Add(Me.progressDownload)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.lblSelectItems)
        Me.Controls.Add(Me.flowItems)
        Me.Controls.Add(Me.btnDownTray)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainWIndow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProHack Easy Install"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(115, Byte), Integer))
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLoading As PictureBox
    Friend WithEvents progressDownload As ProgressBar
    Friend WithEvents btnDownload As Button
    Friend WithEvents lblSelectItems As Label
    Friend WithEvents flowItems As FlowLayoutPanel
    Friend WithEvents btnDownTray As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents bgworker_download As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnDownloadAndRun As Button
    Friend WithEvents lblDownloadStatus As Label
End Class
