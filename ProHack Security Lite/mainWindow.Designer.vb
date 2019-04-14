<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tabControl_Options = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage_Scans = New System.Windows.Forms.TabPage()
        Me.btnScan_Custom = New System.Windows.Forms.Button()
        Me.btnScan_Deep = New System.Windows.Forms.Button()
        Me.btnScan_Quick = New System.Windows.Forms.Button()
        Me.TabPage_WebUtils = New System.Windows.Forms.TabPage()
        Me.TabPage_Tools = New System.Windows.Forms.TabPage()
        Me.tabSelector_Options = New MaterialSkin.Controls.MaterialTabSelector()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.btnGithub = New System.Windows.Forms.Button()
        Me.btnTabControl_Hide = New System.Windows.Forms.Button()
        Me.pnl_opt_tools = New System.Windows.Forms.Panel()
        Me.btn_opt_tools = New System.Windows.Forms.Button()
        Me.pic_opt_tools = New System.Windows.Forms.PictureBox()
        Me.pnl_opt_webutils = New System.Windows.Forms.Panel()
        Me.btn_opt_webutils = New System.Windows.Forms.Button()
        Me.pic_opt_webutils = New System.Windows.Forms.PictureBox()
        Me.pnl_opt_scan = New System.Windows.Forms.Panel()
        Me.btn_opt_scan = New System.Windows.Forms.Button()
        Me.pic_opt_scan = New System.Windows.Forms.PictureBox()
        Me.bgWorker_QuickQuery = New System.ComponentModel.BackgroundWorker()
        Me.btnShowSettings = New System.Windows.Forms.Button()
        Me.bgWorker_Updater = New System.ComponentModel.BackgroundWorker()
        Me.check_focused = New System.Windows.Forms.Timer(Me.components)
        Me.Schedule_WSIR_Query = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_Options.SuspendLayout()
        Me.TabPage_Scans.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.pnl_opt_tools.SuspendLayout()
        CType(Me.pic_opt_tools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_opt_webutils.SuspendLayout()
        CType(Me.pic_opt_webutils, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_opt_scan.SuspendLayout()
        CType(Me.pic_opt_scan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle.Font = New System.Drawing.Font("Arial Nova", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblSubTitle.Location = New System.Drawing.Point(128, 68)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(49, 26)
        Me.lblSubTitle.TabIndex = 5
        Me.lblSubTitle.Text = "Lite"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Arial Nova", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Olive
        Me.lblTitle.Location = New System.Drawing.Point(127, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 33)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "ProHack Security"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 100)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(952, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimize.TabIndex = 7
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(983, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.TabStop = False
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tabControl_Options
        '
        Me.tabControl_Options.Controls.Add(Me.TabPage_Scans)
        Me.tabControl_Options.Controls.Add(Me.TabPage_WebUtils)
        Me.tabControl_Options.Controls.Add(Me.TabPage_Tools)
        Me.tabControl_Options.Depth = 0
        Me.tabControl_Options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabControl_Options.Location = New System.Drawing.Point(0, 563)
        Me.tabControl_Options.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabControl_Options.Name = "tabControl_Options"
        Me.tabControl_Options.SelectedIndex = 0
        Me.tabControl_Options.Size = New System.Drawing.Size(1020, 10)
        Me.tabControl_Options.TabIndex = 8
        '
        'TabPage_Scans
        '
        Me.TabPage_Scans.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TabPage_Scans.Controls.Add(Me.btnScan_Custom)
        Me.TabPage_Scans.Controls.Add(Me.btnScan_Deep)
        Me.TabPage_Scans.Controls.Add(Me.btnScan_Quick)
        Me.TabPage_Scans.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Scans.Name = "TabPage_Scans"
        Me.TabPage_Scans.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Scans.Size = New System.Drawing.Size(1012, 0)
        Me.TabPage_Scans.TabIndex = 0
        Me.TabPage_Scans.Text = "SCANS"
        '
        'btnScan_Custom
        '
        Me.btnScan_Custom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnScan_Custom.BackColor = System.Drawing.Color.Transparent
        Me.btnScan_Custom.BackgroundImage = CType(resources.GetObject("btnScan_Custom.BackgroundImage"), System.Drawing.Image)
        Me.btnScan_Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScan_Custom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan_Custom.FlatAppearance.BorderSize = 0
        Me.btnScan_Custom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnScan_Custom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnScan_Custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan_Custom.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan_Custom.Location = New System.Drawing.Point(682, -22)
        Me.btnScan_Custom.Name = "btnScan_Custom"
        Me.btnScan_Custom.Size = New System.Drawing.Size(200, 46)
        Me.btnScan_Custom.TabIndex = 12
        Me.btnScan_Custom.TabStop = False
        Me.btnScan_Custom.UseVisualStyleBackColor = False
        '
        'btnScan_Deep
        '
        Me.btnScan_Deep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnScan_Deep.BackColor = System.Drawing.Color.Transparent
        Me.btnScan_Deep.BackgroundImage = CType(resources.GetObject("btnScan_Deep.BackgroundImage"), System.Drawing.Image)
        Me.btnScan_Deep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScan_Deep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan_Deep.FlatAppearance.BorderSize = 0
        Me.btnScan_Deep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnScan_Deep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnScan_Deep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan_Deep.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan_Deep.Location = New System.Drawing.Point(405, -22)
        Me.btnScan_Deep.Name = "btnScan_Deep"
        Me.btnScan_Deep.Size = New System.Drawing.Size(200, 46)
        Me.btnScan_Deep.TabIndex = 11
        Me.btnScan_Deep.TabStop = False
        Me.btnScan_Deep.UseVisualStyleBackColor = False
        '
        'btnScan_Quick
        '
        Me.btnScan_Quick.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnScan_Quick.BackColor = System.Drawing.Color.Transparent
        Me.btnScan_Quick.BackgroundImage = CType(resources.GetObject("btnScan_Quick.BackgroundImage"), System.Drawing.Image)
        Me.btnScan_Quick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScan_Quick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan_Quick.FlatAppearance.BorderSize = 0
        Me.btnScan_Quick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnScan_Quick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnScan_Quick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScan_Quick.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan_Quick.Location = New System.Drawing.Point(131, -22)
        Me.btnScan_Quick.Name = "btnScan_Quick"
        Me.btnScan_Quick.Size = New System.Drawing.Size(200, 46)
        Me.btnScan_Quick.TabIndex = 10
        Me.btnScan_Quick.TabStop = False
        Me.btnScan_Quick.UseVisualStyleBackColor = False
        '
        'TabPage_WebUtils
        '
        Me.TabPage_WebUtils.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TabPage_WebUtils.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_WebUtils.Name = "TabPage_WebUtils"
        Me.TabPage_WebUtils.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_WebUtils.Size = New System.Drawing.Size(1012, 0)
        Me.TabPage_WebUtils.TabIndex = 1
        Me.TabPage_WebUtils.Text = "WEB UTILS"
        '
        'TabPage_Tools
        '
        Me.TabPage_Tools.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TabPage_Tools.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Tools.Name = "TabPage_Tools"
        Me.TabPage_Tools.Size = New System.Drawing.Size(1012, 0)
        Me.TabPage_Tools.TabIndex = 2
        Me.TabPage_Tools.Text = "TOOLS"
        '
        'tabSelector_Options
        '
        Me.tabSelector_Options.BaseTabControl = Me.tabControl_Options
        Me.tabSelector_Options.Depth = 0
        Me.tabSelector_Options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabSelector_Options.Location = New System.Drawing.Point(0, 452)
        Me.tabSelector_Options.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabSelector_Options.Name = "tabSelector_Options"
        Me.tabSelector_Options.Size = New System.Drawing.Size(1020, 34)
        Me.tabSelector_Options.TabIndex = 9
        Me.tabSelector_Options.Text = "MaterialTabSelector1"
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.panelFooter.Controls.Add(Me.btnWebsite)
        Me.panelFooter.Controls.Add(Me.btnEmail)
        Me.panelFooter.Controls.Add(Me.btnTwitter)
        Me.panelFooter.Controls.Add(Me.btnGithub)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 486)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(1020, 77)
        Me.panelFooter.TabIndex = 13
        '
        'btnWebsite
        '
        Me.btnWebsite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnWebsite.BackColor = System.Drawing.Color.Transparent
        Me.btnWebsite.BackgroundImage = CType(resources.GetObject("btnWebsite.BackgroundImage"), System.Drawing.Image)
        Me.btnWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWebsite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWebsite.FlatAppearance.BorderSize = 0
        Me.btnWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebsite.Location = New System.Drawing.Point(601, 25)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(30, 30)
        Me.btnWebsite.TabIndex = 16
        Me.btnWebsite.TabStop = False
        Me.btnWebsite.UseVisualStyleBackColor = False
        '
        'btnEmail
        '
        Me.btnEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEmail.BackColor = System.Drawing.Color.Transparent
        Me.btnEmail.BackgroundImage = CType(resources.GetObject("btnEmail.BackgroundImage"), System.Drawing.Image)
        Me.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmail.FlatAppearance.BorderSize = 0
        Me.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmail.Location = New System.Drawing.Point(530, 25)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(30, 30)
        Me.btnEmail.TabIndex = 15
        Me.btnEmail.TabStop = False
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'btnTwitter
        '
        Me.btnTwitter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTwitter.BackColor = System.Drawing.Color.Transparent
        Me.btnTwitter.BackgroundImage = CType(resources.GetObject("btnTwitter.BackgroundImage"), System.Drawing.Image)
        Me.btnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTwitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTwitter.FlatAppearance.BorderSize = 0
        Me.btnTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTwitter.Location = New System.Drawing.Point(456, 25)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(30, 30)
        Me.btnTwitter.TabIndex = 14
        Me.btnTwitter.TabStop = False
        Me.btnTwitter.UseVisualStyleBackColor = False
        '
        'btnGithub
        '
        Me.btnGithub.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGithub.BackColor = System.Drawing.Color.Transparent
        Me.btnGithub.BackgroundImage = CType(resources.GetObject("btnGithub.BackgroundImage"), System.Drawing.Image)
        Me.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGithub.FlatAppearance.BorderSize = 0
        Me.btnGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGithub.Location = New System.Drawing.Point(384, 25)
        Me.btnGithub.Name = "btnGithub"
        Me.btnGithub.Size = New System.Drawing.Size(30, 30)
        Me.btnGithub.TabIndex = 13
        Me.btnGithub.TabStop = False
        Me.btnGithub.UseVisualStyleBackColor = False
        '
        'btnTabControl_Hide
        '
        Me.btnTabControl_Hide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTabControl_Hide.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnTabControl_Hide.BackgroundImage = CType(resources.GetObject("btnTabControl_Hide.BackgroundImage"), System.Drawing.Image)
        Me.btnTabControl_Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTabControl_Hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTabControl_Hide.FlatAppearance.BorderSize = 0
        Me.btnTabControl_Hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnTabControl_Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnTabControl_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTabControl_Hide.Location = New System.Drawing.Point(983, 461)
        Me.btnTabControl_Hide.Name = "btnTabControl_Hide"
        Me.btnTabControl_Hide.Size = New System.Drawing.Size(25, 25)
        Me.btnTabControl_Hide.TabIndex = 14
        Me.btnTabControl_Hide.TabStop = False
        Me.btnTabControl_Hide.UseVisualStyleBackColor = False
        '
        'pnl_opt_tools
        '
        Me.pnl_opt_tools.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_opt_tools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_opt_tools.Controls.Add(Me.btn_opt_tools)
        Me.pnl_opt_tools.Controls.Add(Me.pic_opt_tools)
        Me.pnl_opt_tools.Location = New System.Drawing.Point(686, 186)
        Me.pnl_opt_tools.Name = "pnl_opt_tools"
        Me.pnl_opt_tools.Size = New System.Drawing.Size(200, 200)
        Me.pnl_opt_tools.TabIndex = 17
        '
        'btn_opt_tools
        '
        Me.btn_opt_tools.BackColor = System.Drawing.Color.Black
        Me.btn_opt_tools.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_opt_tools.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_opt_tools.FlatAppearance.BorderSize = 0
        Me.btn_opt_tools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_opt_tools.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_opt_tools.Location = New System.Drawing.Point(0, 146)
        Me.btn_opt_tools.Name = "btn_opt_tools"
        Me.btn_opt_tools.Size = New System.Drawing.Size(200, 54)
        Me.btn_opt_tools.TabIndex = 6
        Me.btn_opt_tools.TabStop = False
        Me.btn_opt_tools.Text = "TOOLS"
        Me.btn_opt_tools.UseVisualStyleBackColor = False
        '
        'pic_opt_tools
        '
        Me.pic_opt_tools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_opt_tools.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_opt_tools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_opt_tools.Image = CType(resources.GetObject("pic_opt_tools.Image"), System.Drawing.Image)
        Me.pic_opt_tools.Location = New System.Drawing.Point(0, 0)
        Me.pic_opt_tools.Name = "pic_opt_tools"
        Me.pic_opt_tools.Size = New System.Drawing.Size(200, 140)
        Me.pic_opt_tools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_opt_tools.TabIndex = 0
        Me.pic_opt_tools.TabStop = False
        '
        'pnl_opt_webutils
        '
        Me.pnl_opt_webutils.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_opt_webutils.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_opt_webutils.Controls.Add(Me.btn_opt_webutils)
        Me.pnl_opt_webutils.Controls.Add(Me.pic_opt_webutils)
        Me.pnl_opt_webutils.Location = New System.Drawing.Point(409, 186)
        Me.pnl_opt_webutils.Name = "pnl_opt_webutils"
        Me.pnl_opt_webutils.Size = New System.Drawing.Size(200, 200)
        Me.pnl_opt_webutils.TabIndex = 16
        '
        'btn_opt_webutils
        '
        Me.btn_opt_webutils.BackColor = System.Drawing.Color.Black
        Me.btn_opt_webutils.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_opt_webutils.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_opt_webutils.FlatAppearance.BorderSize = 0
        Me.btn_opt_webutils.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_webutils.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_webutils.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_opt_webutils.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_opt_webutils.Location = New System.Drawing.Point(0, 146)
        Me.btn_opt_webutils.Name = "btn_opt_webutils"
        Me.btn_opt_webutils.Size = New System.Drawing.Size(200, 54)
        Me.btn_opt_webutils.TabIndex = 6
        Me.btn_opt_webutils.TabStop = False
        Me.btn_opt_webutils.Text = "WEB UTILITIES"
        Me.btn_opt_webutils.UseVisualStyleBackColor = False
        '
        'pic_opt_webutils
        '
        Me.pic_opt_webutils.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_opt_webutils.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_opt_webutils.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_opt_webutils.Image = CType(resources.GetObject("pic_opt_webutils.Image"), System.Drawing.Image)
        Me.pic_opt_webutils.Location = New System.Drawing.Point(0, 0)
        Me.pic_opt_webutils.Name = "pic_opt_webutils"
        Me.pic_opt_webutils.Size = New System.Drawing.Size(200, 140)
        Me.pic_opt_webutils.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_opt_webutils.TabIndex = 0
        Me.pic_opt_webutils.TabStop = False
        '
        'pnl_opt_scan
        '
        Me.pnl_opt_scan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnl_opt_scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_opt_scan.Controls.Add(Me.btn_opt_scan)
        Me.pnl_opt_scan.Controls.Add(Me.pic_opt_scan)
        Me.pnl_opt_scan.Location = New System.Drawing.Point(135, 186)
        Me.pnl_opt_scan.Name = "pnl_opt_scan"
        Me.pnl_opt_scan.Size = New System.Drawing.Size(200, 200)
        Me.pnl_opt_scan.TabIndex = 15
        '
        'btn_opt_scan
        '
        Me.btn_opt_scan.BackColor = System.Drawing.Color.Black
        Me.btn_opt_scan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_opt_scan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_opt_scan.FlatAppearance.BorderSize = 0
        Me.btn_opt_scan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_scan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btn_opt_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_opt_scan.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_opt_scan.Location = New System.Drawing.Point(0, 146)
        Me.btn_opt_scan.Name = "btn_opt_scan"
        Me.btn_opt_scan.Size = New System.Drawing.Size(200, 54)
        Me.btn_opt_scan.TabIndex = 6
        Me.btn_opt_scan.TabStop = False
        Me.btn_opt_scan.Text = "SCANS"
        Me.btn_opt_scan.UseVisualStyleBackColor = False
        '
        'pic_opt_scan
        '
        Me.pic_opt_scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pic_opt_scan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_opt_scan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_opt_scan.Image = CType(resources.GetObject("pic_opt_scan.Image"), System.Drawing.Image)
        Me.pic_opt_scan.Location = New System.Drawing.Point(0, 0)
        Me.pic_opt_scan.Name = "pic_opt_scan"
        Me.pic_opt_scan.Size = New System.Drawing.Size(200, 140)
        Me.pic_opt_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_opt_scan.TabIndex = 0
        Me.pic_opt_scan.TabStop = False
        '
        'bgWorker_QuickQuery
        '
        Me.bgWorker_QuickQuery.WorkerSupportsCancellation = True
        '
        'btnShowSettings
        '
        Me.btnShowSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnShowSettings.BackgroundImage = CType(resources.GetObject("btnShowSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnShowSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowSettings.FlatAppearance.BorderSize = 0
        Me.btnShowSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShowSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowSettings.Location = New System.Drawing.Point(909, 12)
        Me.btnShowSettings.Name = "btnShowSettings"
        Me.btnShowSettings.Size = New System.Drawing.Size(25, 25)
        Me.btnShowSettings.TabIndex = 18
        Me.btnShowSettings.TabStop = False
        Me.btnShowSettings.UseVisualStyleBackColor = False
        '
        'bgWorker_Updater
        '
        '
        'check_focused
        '
        '
        'Schedule_WSIR_Query
        '
        Me.Schedule_WSIR_Query.Interval = 60000
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 573)
        Me.Controls.Add(Me.btnShowSettings)
        Me.Controls.Add(Me.pnl_opt_tools)
        Me.Controls.Add(Me.pnl_opt_webutils)
        Me.Controls.Add(Me.pnl_opt_scan)
        Me.Controls.Add(Me.btnTabControl_Hide)
        Me.Controls.Add(Me.tabSelector_Options)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.tabControl_Options)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProHack Security Lite"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_Options.ResumeLayout(False)
        Me.TabPage_Scans.ResumeLayout(False)
        Me.panelFooter.ResumeLayout(False)
        Me.pnl_opt_tools.ResumeLayout(False)
        CType(Me.pic_opt_tools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_opt_webutils.ResumeLayout(False)
        CType(Me.pic_opt_webutils, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_opt_scan.ResumeLayout(False)
        CType(Me.pic_opt_scan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblSubTitle As Label
    Private WithEvents lblTitle As Label
    Private WithEvents picLogo As PictureBox
    Private WithEvents btnMinimize As Button
    Private WithEvents btnExit As Button
    Friend WithEvents tabControl_Options As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage_Scans As TabPage
    Friend WithEvents TabPage_WebUtils As TabPage
    Friend WithEvents tabSelector_Options As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TabPage_Tools As TabPage
    Private WithEvents panelFooter As Panel
    Private WithEvents btnWebsite As Button
    Private WithEvents btnEmail As Button
    Private WithEvents btnTwitter As Button
    Private WithEvents btnGithub As Button
    Private WithEvents btnTabControl_Hide As Button
    Private WithEvents pnl_opt_tools As Panel
    Private WithEvents btn_opt_tools As Button
    Private WithEvents pic_opt_tools As PictureBox
    Private WithEvents pnl_opt_webutils As Panel
    Private WithEvents btn_opt_webutils As Button
    Private WithEvents pic_opt_webutils As PictureBox
    Private WithEvents pnl_opt_scan As Panel
    Private WithEvents btn_opt_scan As Button
    Private WithEvents pic_opt_scan As PictureBox
    Private WithEvents btnScan_Custom As Button
    Private WithEvents btnScan_Deep As Button
    Private WithEvents btnScan_Quick As Button
    Friend WithEvents bgWorker_QuickQuery As System.ComponentModel.BackgroundWorker
    Private WithEvents btnShowSettings As Button
    Friend WithEvents bgWorker_Updater As System.ComponentModel.BackgroundWorker
    Friend WithEvents check_focused As Timer
    Friend WithEvents Schedule_WSIR_Query As Timer
End Class
