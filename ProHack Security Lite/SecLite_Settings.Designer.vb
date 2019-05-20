<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SecLite_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecLite_Settings))
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ContextMenu_chklstQuickScan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewExtensionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallTabControl1 = New ProHack_Security_Lite.smallTabControl()
        Me.tabpage_start = New System.Windows.Forms.TabPage()
        Me.btnSaveSettings1 = New System.Windows.Forms.Button()
        Me.groupSettings_MainWindow_Wallpaper = New System.Windows.Forms.GroupBox()
        Me.rbtn_Wallpaper_None = New System.Windows.Forms.RadioButton()
        Me.picPreview_Wallpaper = New System.Windows.Forms.PictureBox()
        Me.lblSetting_MainWindow_Wallpaper2 = New System.Windows.Forms.Label()
        Me.lblSetting_MainWindow_Wallpaper1 = New System.Windows.Forms.Label()
        Me.rbtn_Wallpaper_GIF = New System.Windows.Forms.RadioButton()
        Me.rbtn_Wallpaper_Image = New System.Windows.Forms.RadioButton()
        Me.groupSettings_LoadingScreen = New System.Windows.Forms.GroupBox()
        Me.lbSettings_LoadingScreen2 = New System.Windows.Forms.Label()
        Me.lbSettings_LoadingScreen1 = New System.Windows.Forms.Label()
        Me.rbtn_LoadingScreen_TopMost_No = New System.Windows.Forms.RadioButton()
        Me.rbtn_LoadingScreen_TopMost_Yes = New System.Windows.Forms.RadioButton()
        Me.groupSettings_MainWindow_ContainerEffect = New System.Windows.Forms.GroupBox()
        Me.lblSettings_MainWindow_ContainerEffect2 = New System.Windows.Forms.Label()
        Me.lblSettings_MainWindow_ContainerEffect1 = New System.Windows.Forms.Label()
        Me.rbtn_ContainerEffect_Off = New System.Windows.Forms.RadioButton()
        Me.rbtn_ContainerEffect_On = New System.Windows.Forms.RadioButton()
        Me.groupSettings_FadingEffect = New System.Windows.Forms.GroupBox()
        Me.groupSettings_FadingEffect_EffectType = New System.Windows.Forms.GroupBox()
        Me.rbtn_FadingType_FadeTop = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtn_FadingType_FadeLeft = New System.Windows.Forms.RadioButton()
        Me.rbtn_FadingType_WinDefault = New System.Windows.Forms.RadioButton()
        Me.lblSetting_FadingEffect_Speed = New System.Windows.Forms.Label()
        Me.txtSetting_FadingEffect_Speed = New System.Windows.Forms.TextBox()
        Me.lblSetting_FadingEffect = New System.Windows.Forms.Label()
        Me.rbtn_FadingEffect_Off = New System.Windows.Forms.RadioButton()
        Me.rbtn_FadingEffect_On = New System.Windows.Forms.RadioButton()
        Me.groupSettings_Theme = New System.Windows.Forms.GroupBox()
        Me.lblSetting_Theme = New System.Windows.Forms.Label()
        Me.rbtn_Theme_Light = New System.Windows.Forms.RadioButton()
        Me.rbtn_Theme_Dark = New System.Windows.Forms.RadioButton()
        Me.tabpage_python = New System.Windows.Forms.TabPage()
        Me.btnPythonPackageManager = New System.Windows.Forms.Button()
        Me.btnSaveSettings2 = New System.Windows.Forms.Button()
        Me.btn_browse_python_path = New System.Windows.Forms.Button()
        Me.lbl_python_path = New System.Windows.Forms.Label()
        Me.txt_python_path = New System.Windows.Forms.TextBox()
        Me.tabpage_scanner = New System.Windows.Forms.TabPage()
        Me.groupScanner_Quick = New System.Windows.Forms.GroupBox()
        Me.btnQuickScan_ChooseExtFile = New System.Windows.Forms.Button()
        Me.txtQuickScan_ChooseExtFile = New System.Windows.Forms.TextBox()
        Me.lblQuickScan_ChooseExtFile = New System.Windows.Forms.Label()
        Me.lblQuickScan_ChooseExtFiles = New System.Windows.Forms.Label()
        Me.chklstQuickScan_ChooseExtFiles = New System.Windows.Forms.CheckedListBox()
        Me.chkQuickScan_MultipleExtFiles = New System.Windows.Forms.CheckBox()
        Me.chkQuickScan_ExtBased = New System.Windows.Forms.CheckBox()
        Me.lblScanner_Quick = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu_chklstQuickScan.SuspendLayout()
        Me.SmallTabControl1.SuspendLayout()
        Me.tabpage_start.SuspendLayout()
        Me.groupSettings_MainWindow_Wallpaper.SuspendLayout()
        CType(Me.picPreview_Wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSettings_LoadingScreen.SuspendLayout()
        Me.groupSettings_MainWindow_ContainerEffect.SuspendLayout()
        Me.groupSettings_FadingEffect.SuspendLayout()
        Me.groupSettings_FadingEffect_EffectType.SuspendLayout()
        Me.groupSettings_Theme.SuspendLayout()
        Me.tabpage_python.SuspendLayout()
        Me.tabpage_scanner.SuspendLayout()
        Me.groupScanner_Quick.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblSubTitle.Location = New System.Drawing.Point(78, 45)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(158, 25)
        Me.lblSubTitle.TabIndex = 8
        Me.lblSubTitle.Text = "Lite : Settings"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Olive
        Me.lblTitle.Location = New System.Drawing.Point(77, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 31)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "ProHack Security"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(59, 59)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
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
        Me.btnExit.Location = New System.Drawing.Point(673, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.TabStop = False
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ContextMenu_chklstQuickScan
        '
        Me.ContextMenu_chklstQuickScan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewExtensionsToolStripMenuItem})
        Me.ContextMenu_chklstQuickScan.Name = "ContextMenu_chklstQuickScan"
        Me.ContextMenu_chklstQuickScan.Size = New System.Drawing.Size(158, 26)
        '
        'ViewExtensionsToolStripMenuItem
        '
        Me.ViewExtensionsToolStripMenuItem.Name = "ViewExtensionsToolStripMenuItem"
        Me.ViewExtensionsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewExtensionsToolStripMenuItem.Text = "View Extensions"
        '
        'SmallTabControl1
        '
        Me.SmallTabControl1.Controls.Add(Me.tabpage_start)
        Me.SmallTabControl1.Controls.Add(Me.tabpage_python)
        Me.SmallTabControl1.Controls.Add(Me.tabpage_scanner)
        Me.SmallTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SmallTabControl1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmallTabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.SmallTabControl1.Location = New System.Drawing.Point(0, 81)
        Me.SmallTabControl1.Name = "SmallTabControl1"
        Me.SmallTabControl1.SelectedIndex = 0
        Me.SmallTabControl1.Size = New System.Drawing.Size(710, 395)
        Me.SmallTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.SmallTabControl1.TabIndex = 10
        '
        'tabpage_start
        '
        Me.tabpage_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.tabpage_start.Controls.Add(Me.btnSaveSettings1)
        Me.tabpage_start.Controls.Add(Me.groupSettings_MainWindow_Wallpaper)
        Me.tabpage_start.Controls.Add(Me.groupSettings_LoadingScreen)
        Me.tabpage_start.Controls.Add(Me.groupSettings_MainWindow_ContainerEffect)
        Me.tabpage_start.Controls.Add(Me.groupSettings_FadingEffect)
        Me.tabpage_start.Controls.Add(Me.groupSettings_Theme)
        Me.tabpage_start.Location = New System.Drawing.Point(4, 34)
        Me.tabpage_start.Name = "tabpage_start"
        Me.tabpage_start.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_start.Size = New System.Drawing.Size(702, 357)
        Me.tabpage_start.TabIndex = 0
        Me.tabpage_start.Text = "Start"
        '
        'btnSaveSettings1
        '
        Me.btnSaveSettings1.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSaveSettings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSettings1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings1.FlatAppearance.BorderSize = 0
        Me.btnSaveSettings1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnSaveSettings1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSaveSettings1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings1.ForeColor = System.Drawing.Color.White
        Me.btnSaveSettings1.Location = New System.Drawing.Point(526, 275)
        Me.btnSaveSettings1.Name = "btnSaveSettings1"
        Me.btnSaveSettings1.Size = New System.Drawing.Size(153, 57)
        Me.btnSaveSettings1.TabIndex = 8
        Me.btnSaveSettings1.TabStop = False
        Me.btnSaveSettings1.Text = "Save and Refresh"
        Me.btnSaveSettings1.UseVisualStyleBackColor = False
        '
        'groupSettings_MainWindow_Wallpaper
        '
        Me.groupSettings_MainWindow_Wallpaper.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.rbtn_Wallpaper_None)
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.picPreview_Wallpaper)
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.lblSetting_MainWindow_Wallpaper2)
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.lblSetting_MainWindow_Wallpaper1)
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.rbtn_Wallpaper_GIF)
        Me.groupSettings_MainWindow_Wallpaper.Controls.Add(Me.rbtn_Wallpaper_Image)
        Me.groupSettings_MainWindow_Wallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_MainWindow_Wallpaper.Location = New System.Drawing.Point(526, 21)
        Me.groupSettings_MainWindow_Wallpaper.Name = "groupSettings_MainWindow_Wallpaper"
        Me.groupSettings_MainWindow_Wallpaper.Size = New System.Drawing.Size(153, 236)
        Me.groupSettings_MainWindow_Wallpaper.TabIndex = 5
        Me.groupSettings_MainWindow_Wallpaper.TabStop = False
        Me.groupSettings_MainWindow_Wallpaper.Text = "Theme"
        '
        'rbtn_Wallpaper_None
        '
        Me.rbtn_Wallpaper_None.AutoSize = True
        Me.rbtn_Wallpaper_None.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_Wallpaper_None.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_Wallpaper_None.Location = New System.Drawing.Point(25, 81)
        Me.rbtn_Wallpaper_None.Name = "rbtn_Wallpaper_None"
        Me.rbtn_Wallpaper_None.Size = New System.Drawing.Size(65, 20)
        Me.rbtn_Wallpaper_None.TabIndex = 5
        Me.rbtn_Wallpaper_None.Text = "None"
        Me.rbtn_Wallpaper_None.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Wallpaper_None.UseVisualStyleBackColor = True
        '
        'picPreview_Wallpaper
        '
        Me.picPreview_Wallpaper.Location = New System.Drawing.Point(25, 141)
        Me.picPreview_Wallpaper.Name = "picPreview_Wallpaper"
        Me.picPreview_Wallpaper.Size = New System.Drawing.Size(102, 72)
        Me.picPreview_Wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreview_Wallpaper.TabIndex = 4
        Me.picPreview_Wallpaper.TabStop = False
        '
        'lblSetting_MainWindow_Wallpaper2
        '
        Me.lblSetting_MainWindow_Wallpaper2.AutoSize = True
        Me.lblSetting_MainWindow_Wallpaper2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSetting_MainWindow_Wallpaper2.Location = New System.Drawing.Point(6, 19)
        Me.lblSetting_MainWindow_Wallpaper2.Name = "lblSetting_MainWindow_Wallpaper2"
        Me.lblSetting_MainWindow_Wallpaper2.Size = New System.Drawing.Size(98, 16)
        Me.lblSetting_MainWindow_Wallpaper2.TabIndex = 3
        Me.lblSetting_MainWindow_Wallpaper2.Text = "Wallpaper"
        '
        'lblSetting_MainWindow_Wallpaper1
        '
        Me.lblSetting_MainWindow_Wallpaper1.AutoSize = True
        Me.lblSetting_MainWindow_Wallpaper1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSetting_MainWindow_Wallpaper1.Location = New System.Drawing.Point(6, 0)
        Me.lblSetting_MainWindow_Wallpaper1.Name = "lblSetting_MainWindow_Wallpaper1"
        Me.lblSetting_MainWindow_Wallpaper1.Size = New System.Drawing.Size(108, 16)
        Me.lblSetting_MainWindow_Wallpaper1.TabIndex = 2
        Me.lblSetting_MainWindow_Wallpaper1.Text = "MainWindow"
        '
        'rbtn_Wallpaper_GIF
        '
        Me.rbtn_Wallpaper_GIF.AutoSize = True
        Me.rbtn_Wallpaper_GIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_Wallpaper_GIF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_Wallpaper_GIF.Location = New System.Drawing.Point(25, 107)
        Me.rbtn_Wallpaper_GIF.Name = "rbtn_Wallpaper_GIF"
        Me.rbtn_Wallpaper_GIF.Size = New System.Drawing.Size(55, 20)
        Me.rbtn_Wallpaper_GIF.TabIndex = 1
        Me.rbtn_Wallpaper_GIF.Text = "GIF"
        Me.rbtn_Wallpaper_GIF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Wallpaper_GIF.UseVisualStyleBackColor = True
        '
        'rbtn_Wallpaper_Image
        '
        Me.rbtn_Wallpaper_Image.AutoSize = True
        Me.rbtn_Wallpaper_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_Wallpaper_Image.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_Wallpaper_Image.Location = New System.Drawing.Point(25, 55)
        Me.rbtn_Wallpaper_Image.Name = "rbtn_Wallpaper_Image"
        Me.rbtn_Wallpaper_Image.Size = New System.Drawing.Size(75, 20)
        Me.rbtn_Wallpaper_Image.TabIndex = 0
        Me.rbtn_Wallpaper_Image.Text = "Image"
        Me.rbtn_Wallpaper_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtn_Wallpaper_Image.UseVisualStyleBackColor = True
        '
        'groupSettings_LoadingScreen
        '
        Me.groupSettings_LoadingScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_LoadingScreen.Controls.Add(Me.lbSettings_LoadingScreen2)
        Me.groupSettings_LoadingScreen.Controls.Add(Me.lbSettings_LoadingScreen1)
        Me.groupSettings_LoadingScreen.Controls.Add(Me.rbtn_LoadingScreen_TopMost_No)
        Me.groupSettings_LoadingScreen.Controls.Add(Me.rbtn_LoadingScreen_TopMost_Yes)
        Me.groupSettings_LoadingScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_LoadingScreen.Location = New System.Drawing.Point(19, 241)
        Me.groupSettings_LoadingScreen.Name = "groupSettings_LoadingScreen"
        Me.groupSettings_LoadingScreen.Size = New System.Drawing.Size(200, 91)
        Me.groupSettings_LoadingScreen.TabIndex = 4
        Me.groupSettings_LoadingScreen.TabStop = False
        Me.groupSettings_LoadingScreen.Text = "Theme"
        '
        'lbSettings_LoadingScreen2
        '
        Me.lbSettings_LoadingScreen2.AutoSize = True
        Me.lbSettings_LoadingScreen2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbSettings_LoadingScreen2.Location = New System.Drawing.Point(6, 19)
        Me.lbSettings_LoadingScreen2.Name = "lbSettings_LoadingScreen2"
        Me.lbSettings_LoadingScreen2.Size = New System.Drawing.Size(78, 16)
        Me.lbSettings_LoadingScreen2.TabIndex = 4
        Me.lbSettings_LoadingScreen2.Text = "TopMost"
        '
        'lbSettings_LoadingScreen1
        '
        Me.lbSettings_LoadingScreen1.AutoSize = True
        Me.lbSettings_LoadingScreen1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbSettings_LoadingScreen1.Location = New System.Drawing.Point(6, 0)
        Me.lbSettings_LoadingScreen1.Name = "lbSettings_LoadingScreen1"
        Me.lbSettings_LoadingScreen1.Size = New System.Drawing.Size(148, 16)
        Me.lbSettings_LoadingScreen1.TabIndex = 2
        Me.lbSettings_LoadingScreen1.Text = "Loading Screen"
        '
        'rbtn_LoadingScreen_TopMost_No
        '
        Me.rbtn_LoadingScreen_TopMost_No.AutoSize = True
        Me.rbtn_LoadingScreen_TopMost_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_LoadingScreen_TopMost_No.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_LoadingScreen_TopMost_No.Location = New System.Drawing.Point(110, 52)
        Me.rbtn_LoadingScreen_TopMost_No.Name = "rbtn_LoadingScreen_TopMost_No"
        Me.rbtn_LoadingScreen_TopMost_No.Size = New System.Drawing.Size(45, 20)
        Me.rbtn_LoadingScreen_TopMost_No.TabIndex = 1
        Me.rbtn_LoadingScreen_TopMost_No.Text = "No"
        Me.rbtn_LoadingScreen_TopMost_No.UseVisualStyleBackColor = True
        '
        'rbtn_LoadingScreen_TopMost_Yes
        '
        Me.rbtn_LoadingScreen_TopMost_Yes.AutoSize = True
        Me.rbtn_LoadingScreen_TopMost_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_LoadingScreen_TopMost_Yes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_LoadingScreen_TopMost_Yes.Location = New System.Drawing.Point(38, 52)
        Me.rbtn_LoadingScreen_TopMost_Yes.Name = "rbtn_LoadingScreen_TopMost_Yes"
        Me.rbtn_LoadingScreen_TopMost_Yes.Size = New System.Drawing.Size(55, 20)
        Me.rbtn_LoadingScreen_TopMost_Yes.TabIndex = 0
        Me.rbtn_LoadingScreen_TopMost_Yes.Text = "Yes"
        Me.rbtn_LoadingScreen_TopMost_Yes.UseVisualStyleBackColor = True
        '
        'groupSettings_MainWindow_ContainerEffect
        '
        Me.groupSettings_MainWindow_ContainerEffect.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_MainWindow_ContainerEffect.Controls.Add(Me.lblSettings_MainWindow_ContainerEffect2)
        Me.groupSettings_MainWindow_ContainerEffect.Controls.Add(Me.lblSettings_MainWindow_ContainerEffect1)
        Me.groupSettings_MainWindow_ContainerEffect.Controls.Add(Me.rbtn_ContainerEffect_Off)
        Me.groupSettings_MainWindow_ContainerEffect.Controls.Add(Me.rbtn_ContainerEffect_On)
        Me.groupSettings_MainWindow_ContainerEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_MainWindow_ContainerEffect.Location = New System.Drawing.Point(19, 115)
        Me.groupSettings_MainWindow_ContainerEffect.Name = "groupSettings_MainWindow_ContainerEffect"
        Me.groupSettings_MainWindow_ContainerEffect.Size = New System.Drawing.Size(200, 104)
        Me.groupSettings_MainWindow_ContainerEffect.TabIndex = 4
        Me.groupSettings_MainWindow_ContainerEffect.TabStop = False
        Me.groupSettings_MainWindow_ContainerEffect.Text = "Theme"
        '
        'lblSettings_MainWindow_ContainerEffect2
        '
        Me.lblSettings_MainWindow_ContainerEffect2.AutoSize = True
        Me.lblSettings_MainWindow_ContainerEffect2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSettings_MainWindow_ContainerEffect2.Location = New System.Drawing.Point(6, 19)
        Me.lblSettings_MainWindow_ContainerEffect2.Name = "lblSettings_MainWindow_ContainerEffect2"
        Me.lblSettings_MainWindow_ContainerEffect2.Size = New System.Drawing.Size(168, 16)
        Me.lblSettings_MainWindow_ContainerEffect2.TabIndex = 3
        Me.lblSettings_MainWindow_ContainerEffect2.Text = "Container Effect"
        '
        'lblSettings_MainWindow_ContainerEffect1
        '
        Me.lblSettings_MainWindow_ContainerEffect1.AutoSize = True
        Me.lblSettings_MainWindow_ContainerEffect1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSettings_MainWindow_ContainerEffect1.Location = New System.Drawing.Point(6, 0)
        Me.lblSettings_MainWindow_ContainerEffect1.Name = "lblSettings_MainWindow_ContainerEffect1"
        Me.lblSettings_MainWindow_ContainerEffect1.Size = New System.Drawing.Size(108, 16)
        Me.lblSettings_MainWindow_ContainerEffect1.TabIndex = 2
        Me.lblSettings_MainWindow_ContainerEffect1.Text = "MainWindow"
        '
        'rbtn_ContainerEffect_Off
        '
        Me.rbtn_ContainerEffect_Off.AutoSize = True
        Me.rbtn_ContainerEffect_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_ContainerEffect_Off.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_ContainerEffect_Off.Location = New System.Drawing.Point(110, 58)
        Me.rbtn_ContainerEffect_Off.Name = "rbtn_ContainerEffect_Off"
        Me.rbtn_ContainerEffect_Off.Size = New System.Drawing.Size(55, 20)
        Me.rbtn_ContainerEffect_Off.TabIndex = 1
        Me.rbtn_ContainerEffect_Off.Text = "Off"
        Me.rbtn_ContainerEffect_Off.UseVisualStyleBackColor = True
        '
        'rbtn_ContainerEffect_On
        '
        Me.rbtn_ContainerEffect_On.AutoSize = True
        Me.rbtn_ContainerEffect_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_ContainerEffect_On.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_ContainerEffect_On.Location = New System.Drawing.Point(38, 58)
        Me.rbtn_ContainerEffect_On.Name = "rbtn_ContainerEffect_On"
        Me.rbtn_ContainerEffect_On.Size = New System.Drawing.Size(45, 20)
        Me.rbtn_ContainerEffect_On.TabIndex = 0
        Me.rbtn_ContainerEffect_On.Text = "On"
        Me.rbtn_ContainerEffect_On.UseVisualStyleBackColor = True
        '
        'groupSettings_FadingEffect
        '
        Me.groupSettings_FadingEffect.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_FadingEffect.Controls.Add(Me.groupSettings_FadingEffect_EffectType)
        Me.groupSettings_FadingEffect.Controls.Add(Me.lblSetting_FadingEffect_Speed)
        Me.groupSettings_FadingEffect.Controls.Add(Me.txtSetting_FadingEffect_Speed)
        Me.groupSettings_FadingEffect.Controls.Add(Me.lblSetting_FadingEffect)
        Me.groupSettings_FadingEffect.Controls.Add(Me.rbtn_FadingEffect_Off)
        Me.groupSettings_FadingEffect.Controls.Add(Me.rbtn_FadingEffect_On)
        Me.groupSettings_FadingEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_FadingEffect.Location = New System.Drawing.Point(238, 21)
        Me.groupSettings_FadingEffect.Name = "groupSettings_FadingEffect"
        Me.groupSettings_FadingEffect.Size = New System.Drawing.Size(272, 311)
        Me.groupSettings_FadingEffect.TabIndex = 4
        Me.groupSettings_FadingEffect.TabStop = False
        Me.groupSettings_FadingEffect.Text = "Theme"
        '
        'groupSettings_FadingEffect_EffectType
        '
        Me.groupSettings_FadingEffect_EffectType.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_FadingEffect_EffectType.Controls.Add(Me.rbtn_FadingType_FadeTop)
        Me.groupSettings_FadingEffect_EffectType.Controls.Add(Me.Label2)
        Me.groupSettings_FadingEffect_EffectType.Controls.Add(Me.rbtn_FadingType_FadeLeft)
        Me.groupSettings_FadingEffect_EffectType.Controls.Add(Me.rbtn_FadingType_WinDefault)
        Me.groupSettings_FadingEffect_EffectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_FadingEffect_EffectType.Location = New System.Drawing.Point(19, 152)
        Me.groupSettings_FadingEffect_EffectType.Name = "groupSettings_FadingEffect_EffectType"
        Me.groupSettings_FadingEffect_EffectType.Size = New System.Drawing.Size(234, 135)
        Me.groupSettings_FadingEffect_EffectType.TabIndex = 4
        Me.groupSettings_FadingEffect_EffectType.TabStop = False
        Me.groupSettings_FadingEffect_EffectType.Text = "Theme"
        '
        'rbtn_FadingType_FadeTop
        '
        Me.rbtn_FadingType_FadeTop.AutoSize = True
        Me.rbtn_FadingType_FadeTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_FadingType_FadeTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_FadingType_FadeTop.Location = New System.Drawing.Point(24, 93)
        Me.rbtn_FadingType_FadeTop.Name = "rbtn_FadingType_FadeTop"
        Me.rbtn_FadingType_FadeTop.Size = New System.Drawing.Size(105, 20)
        Me.rbtn_FadingType_FadeTop.TabIndex = 3
        Me.rbtn_FadingType_FadeTop.Text = "Fade Top"
        Me.rbtn_FadingType_FadeTop.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Effect Type"
        '
        'rbtn_FadingType_FadeLeft
        '
        Me.rbtn_FadingType_FadeLeft.AutoSize = True
        Me.rbtn_FadingType_FadeLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_FadingType_FadeLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_FadingType_FadeLeft.Location = New System.Drawing.Point(24, 67)
        Me.rbtn_FadingType_FadeLeft.Name = "rbtn_FadingType_FadeLeft"
        Me.rbtn_FadingType_FadeLeft.Size = New System.Drawing.Size(115, 20)
        Me.rbtn_FadingType_FadeLeft.TabIndex = 1
        Me.rbtn_FadingType_FadeLeft.Text = "Fade Left"
        Me.rbtn_FadingType_FadeLeft.UseVisualStyleBackColor = True
        '
        'rbtn_FadingType_WinDefault
        '
        Me.rbtn_FadingType_WinDefault.AutoSize = True
        Me.rbtn_FadingType_WinDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_FadingType_WinDefault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_FadingType_WinDefault.Location = New System.Drawing.Point(24, 41)
        Me.rbtn_FadingType_WinDefault.Name = "rbtn_FadingType_WinDefault"
        Me.rbtn_FadingType_WinDefault.Size = New System.Drawing.Size(175, 20)
        Me.rbtn_FadingType_WinDefault.TabIndex = 0
        Me.rbtn_FadingType_WinDefault.Text = "Windows Default"
        Me.rbtn_FadingType_WinDefault.UseVisualStyleBackColor = True
        '
        'lblSetting_FadingEffect_Speed
        '
        Me.lblSetting_FadingEffect_Speed.AutoSize = True
        Me.lblSetting_FadingEffect_Speed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSetting_FadingEffect_Speed.Location = New System.Drawing.Point(103, 87)
        Me.lblSetting_FadingEffect_Speed.Name = "lblSetting_FadingEffect_Speed"
        Me.lblSetting_FadingEffect_Speed.Size = New System.Drawing.Size(68, 16)
        Me.lblSetting_FadingEffect_Speed.TabIndex = 4
        Me.lblSetting_FadingEffect_Speed.Text = "Speed:"
        '
        'txtSetting_FadingEffect_Speed
        '
        Me.txtSetting_FadingEffect_Speed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSetting_FadingEffect_Speed.BackColor = System.Drawing.Color.Gray
        Me.txtSetting_FadingEffect_Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSetting_FadingEffect_Speed.ForeColor = System.Drawing.Color.Black
        Me.txtSetting_FadingEffect_Speed.Location = New System.Drawing.Point(19, 106)
        Me.txtSetting_FadingEffect_Speed.Name = "txtSetting_FadingEffect_Speed"
        Me.txtSetting_FadingEffect_Speed.Size = New System.Drawing.Size(234, 23)
        Me.txtSetting_FadingEffect_Speed.TabIndex = 3
        Me.txtSetting_FadingEffect_Speed.TabStop = False
        Me.txtSetting_FadingEffect_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSetting_FadingEffect
        '
        Me.lblSetting_FadingEffect.AutoSize = True
        Me.lblSetting_FadingEffect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSetting_FadingEffect.Location = New System.Drawing.Point(6, 0)
        Me.lblSetting_FadingEffect.Name = "lblSetting_FadingEffect"
        Me.lblSetting_FadingEffect.Size = New System.Drawing.Size(138, 16)
        Me.lblSetting_FadingEffect.TabIndex = 2
        Me.lblSetting_FadingEffect.Text = "Fading Effect"
        '
        'rbtn_FadingEffect_Off
        '
        Me.rbtn_FadingEffect_Off.AutoSize = True
        Me.rbtn_FadingEffect_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_FadingEffect_Off.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_FadingEffect_Off.Location = New System.Drawing.Point(153, 31)
        Me.rbtn_FadingEffect_Off.Name = "rbtn_FadingEffect_Off"
        Me.rbtn_FadingEffect_Off.Size = New System.Drawing.Size(55, 20)
        Me.rbtn_FadingEffect_Off.TabIndex = 1
        Me.rbtn_FadingEffect_Off.Text = "Off"
        Me.rbtn_FadingEffect_Off.UseVisualStyleBackColor = True
        '
        'rbtn_FadingEffect_On
        '
        Me.rbtn_FadingEffect_On.AutoSize = True
        Me.rbtn_FadingEffect_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_FadingEffect_On.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_FadingEffect_On.Location = New System.Drawing.Point(75, 31)
        Me.rbtn_FadingEffect_On.Name = "rbtn_FadingEffect_On"
        Me.rbtn_FadingEffect_On.Size = New System.Drawing.Size(45, 20)
        Me.rbtn_FadingEffect_On.TabIndex = 0
        Me.rbtn_FadingEffect_On.Text = "On"
        Me.rbtn_FadingEffect_On.UseVisualStyleBackColor = True
        '
        'groupSettings_Theme
        '
        Me.groupSettings_Theme.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupSettings_Theme.Controls.Add(Me.lblSetting_Theme)
        Me.groupSettings_Theme.Controls.Add(Me.rbtn_Theme_Light)
        Me.groupSettings_Theme.Controls.Add(Me.rbtn_Theme_Dark)
        Me.groupSettings_Theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupSettings_Theme.Location = New System.Drawing.Point(19, 21)
        Me.groupSettings_Theme.Name = "groupSettings_Theme"
        Me.groupSettings_Theme.Size = New System.Drawing.Size(200, 75)
        Me.groupSettings_Theme.TabIndex = 3
        Me.groupSettings_Theme.TabStop = False
        Me.groupSettings_Theme.Text = "Theme"
        '
        'lblSetting_Theme
        '
        Me.lblSetting_Theme.AutoSize = True
        Me.lblSetting_Theme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSetting_Theme.Location = New System.Drawing.Point(6, 0)
        Me.lblSetting_Theme.Name = "lblSetting_Theme"
        Me.lblSetting_Theme.Size = New System.Drawing.Size(58, 16)
        Me.lblSetting_Theme.TabIndex = 2
        Me.lblSetting_Theme.Text = "Theme"
        '
        'rbtn_Theme_Light
        '
        Me.rbtn_Theme_Light.AutoSize = True
        Me.rbtn_Theme_Light.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_Theme_Light.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_Theme_Light.Location = New System.Drawing.Point(96, 31)
        Me.rbtn_Theme_Light.Name = "rbtn_Theme_Light"
        Me.rbtn_Theme_Light.Size = New System.Drawing.Size(75, 20)
        Me.rbtn_Theme_Light.TabIndex = 1
        Me.rbtn_Theme_Light.Text = "Light"
        Me.rbtn_Theme_Light.UseVisualStyleBackColor = True
        '
        'rbtn_Theme_Dark
        '
        Me.rbtn_Theme_Dark.AutoSize = True
        Me.rbtn_Theme_Dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbtn_Theme_Dark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtn_Theme_Dark.Location = New System.Drawing.Point(24, 31)
        Me.rbtn_Theme_Dark.Name = "rbtn_Theme_Dark"
        Me.rbtn_Theme_Dark.Size = New System.Drawing.Size(65, 20)
        Me.rbtn_Theme_Dark.TabIndex = 0
        Me.rbtn_Theme_Dark.Text = "Dark"
        Me.rbtn_Theme_Dark.UseVisualStyleBackColor = True
        '
        'tabpage_python
        '
        Me.tabpage_python.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.tabpage_python.Controls.Add(Me.btnPythonPackageManager)
        Me.tabpage_python.Controls.Add(Me.btnSaveSettings2)
        Me.tabpage_python.Controls.Add(Me.btn_browse_python_path)
        Me.tabpage_python.Controls.Add(Me.lbl_python_path)
        Me.tabpage_python.Controls.Add(Me.txt_python_path)
        Me.tabpage_python.Location = New System.Drawing.Point(4, 34)
        Me.tabpage_python.Name = "tabpage_python"
        Me.tabpage_python.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_python.Size = New System.Drawing.Size(702, 357)
        Me.tabpage_python.TabIndex = 1
        Me.tabpage_python.Text = "Python"
        '
        'btnPythonPackageManager
        '
        Me.btnPythonPackageManager.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPythonPackageManager.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPythonPackageManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPythonPackageManager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPythonPackageManager.FlatAppearance.BorderSize = 0
        Me.btnPythonPackageManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnPythonPackageManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnPythonPackageManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPythonPackageManager.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPythonPackageManager.ForeColor = System.Drawing.Color.White
        Me.btnPythonPackageManager.Location = New System.Drawing.Point(8, 314)
        Me.btnPythonPackageManager.Name = "btnPythonPackageManager"
        Me.btnPythonPackageManager.Size = New System.Drawing.Size(219, 35)
        Me.btnPythonPackageManager.TabIndex = 11
        Me.btnPythonPackageManager.TabStop = False
        Me.btnPythonPackageManager.Text = "Manage Packages"
        Me.btnPythonPackageManager.UseVisualStyleBackColor = False
        '
        'btnSaveSettings2
        '
        Me.btnSaveSettings2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSaveSettings2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSettings2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings2.FlatAppearance.BorderSize = 0
        Me.btnSaveSettings2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnSaveSettings2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSaveSettings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings2.ForeColor = System.Drawing.Color.White
        Me.btnSaveSettings2.Location = New System.Drawing.Point(475, 314)
        Me.btnSaveSettings2.Name = "btnSaveSettings2"
        Me.btnSaveSettings2.Size = New System.Drawing.Size(219, 35)
        Me.btnSaveSettings2.TabIndex = 10
        Me.btnSaveSettings2.TabStop = False
        Me.btnSaveSettings2.Text = "Save and Refresh"
        Me.btnSaveSettings2.UseVisualStyleBackColor = False
        '
        'btn_browse_python_path
        '
        Me.btn_browse_python_path.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_browse_python_path.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_browse_python_path.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_browse_python_path.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_browse_python_path.FlatAppearance.BorderSize = 0
        Me.btn_browse_python_path.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btn_browse_python_path.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btn_browse_python_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_browse_python_path.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse_python_path.ForeColor = System.Drawing.Color.White
        Me.btn_browse_python_path.Location = New System.Drawing.Point(593, 168)
        Me.btn_browse_python_path.Name = "btn_browse_python_path"
        Me.btn_browse_python_path.Size = New System.Drawing.Size(101, 35)
        Me.btn_browse_python_path.TabIndex = 9
        Me.btn_browse_python_path.TabStop = False
        Me.btn_browse_python_path.Text = "Browse"
        Me.btn_browse_python_path.UseVisualStyleBackColor = False
        '
        'lbl_python_path
        '
        Me.lbl_python_path.AutoSize = True
        Me.lbl_python_path.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_python_path.Location = New System.Drawing.Point(17, 120)
        Me.lbl_python_path.Name = "lbl_python_path"
        Me.lbl_python_path.Size = New System.Drawing.Size(168, 16)
        Me.lbl_python_path.TabIndex = 6
        Me.lbl_python_path.Text = "Python EXE Path:"
        '
        'txt_python_path
        '
        Me.txt_python_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_python_path.BackColor = System.Drawing.Color.Gray
        Me.txt_python_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_python_path.ForeColor = System.Drawing.Color.Black
        Me.txt_python_path.Location = New System.Drawing.Point(20, 139)
        Me.txt_python_path.Name = "txt_python_path"
        Me.txt_python_path.Size = New System.Drawing.Size(674, 23)
        Me.txt_python_path.TabIndex = 5
        Me.txt_python_path.TabStop = False
        Me.txt_python_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabpage_scanner
        '
        Me.tabpage_scanner.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.tabpage_scanner.Controls.Add(Me.groupScanner_Quick)
        Me.tabpage_scanner.Location = New System.Drawing.Point(4, 34)
        Me.tabpage_scanner.Name = "tabpage_scanner"
        Me.tabpage_scanner.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_scanner.Size = New System.Drawing.Size(702, 357)
        Me.tabpage_scanner.TabIndex = 2
        Me.tabpage_scanner.Text = "Scanner"
        '
        'groupScanner_Quick
        '
        Me.groupScanner_Quick.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.groupScanner_Quick.Controls.Add(Me.btnQuickScan_ChooseExtFile)
        Me.groupScanner_Quick.Controls.Add(Me.txtQuickScan_ChooseExtFile)
        Me.groupScanner_Quick.Controls.Add(Me.lblQuickScan_ChooseExtFile)
        Me.groupScanner_Quick.Controls.Add(Me.lblQuickScan_ChooseExtFiles)
        Me.groupScanner_Quick.Controls.Add(Me.chklstQuickScan_ChooseExtFiles)
        Me.groupScanner_Quick.Controls.Add(Me.chkQuickScan_MultipleExtFiles)
        Me.groupScanner_Quick.Controls.Add(Me.chkQuickScan_ExtBased)
        Me.groupScanner_Quick.Controls.Add(Me.lblScanner_Quick)
        Me.groupScanner_Quick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupScanner_Quick.Location = New System.Drawing.Point(21, 22)
        Me.groupScanner_Quick.Name = "groupScanner_Quick"
        Me.groupScanner_Quick.Size = New System.Drawing.Size(659, 194)
        Me.groupScanner_Quick.TabIndex = 4
        Me.groupScanner_Quick.TabStop = False
        Me.groupScanner_Quick.Text = "Theme"
        '
        'btnQuickScan_ChooseExtFile
        '
        Me.btnQuickScan_ChooseExtFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuickScan_ChooseExtFile.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnQuickScan_ChooseExtFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuickScan_ChooseExtFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuickScan_ChooseExtFile.FlatAppearance.BorderSize = 0
        Me.btnQuickScan_ChooseExtFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnQuickScan_ChooseExtFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnQuickScan_ChooseExtFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickScan_ChooseExtFile.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickScan_ChooseExtFile.ForeColor = System.Drawing.Color.White
        Me.btnQuickScan_ChooseExtFile.Location = New System.Drawing.Point(438, 100)
        Me.btnQuickScan_ChooseExtFile.Name = "btnQuickScan_ChooseExtFile"
        Me.btnQuickScan_ChooseExtFile.Size = New System.Drawing.Size(101, 35)
        Me.btnQuickScan_ChooseExtFile.TabIndex = 10
        Me.btnQuickScan_ChooseExtFile.TabStop = False
        Me.btnQuickScan_ChooseExtFile.Text = "Browse"
        Me.btnQuickScan_ChooseExtFile.UseVisualStyleBackColor = False
        '
        'txtQuickScan_ChooseExtFile
        '
        Me.txtQuickScan_ChooseExtFile.BackColor = System.Drawing.Color.Black
        Me.txtQuickScan_ChooseExtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuickScan_ChooseExtFile.ForeColor = System.Drawing.Color.White
        Me.txtQuickScan_ChooseExtFile.Location = New System.Drawing.Point(376, 154)
        Me.txtQuickScan_ChooseExtFile.Name = "txtQuickScan_ChooseExtFile"
        Me.txtQuickScan_ChooseExtFile.Size = New System.Drawing.Size(225, 23)
        Me.txtQuickScan_ChooseExtFile.TabIndex = 8
        Me.txtQuickScan_ChooseExtFile.TabStop = False
        Me.txtQuickScan_ChooseExtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuickScan_ChooseExtFile
        '
        Me.lblQuickScan_ChooseExtFile.AutoSize = True
        Me.lblQuickScan_ChooseExtFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQuickScan_ChooseExtFile.Location = New System.Drawing.Point(373, 66)
        Me.lblQuickScan_ChooseExtFile.Name = "lblQuickScan_ChooseExtFile"
        Me.lblQuickScan_ChooseExtFile.Size = New System.Drawing.Size(228, 16)
        Me.lblQuickScan_ChooseExtFile.TabIndex = 7
        Me.lblQuickScan_ChooseExtFile.Text = "Choose Extension File:"
        '
        'lblQuickScan_ChooseExtFiles
        '
        Me.lblQuickScan_ChooseExtFiles.AutoSize = True
        Me.lblQuickScan_ChooseExtFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblQuickScan_ChooseExtFiles.Location = New System.Drawing.Point(20, 66)
        Me.lblQuickScan_ChooseExtFiles.Name = "lblQuickScan_ChooseExtFiles"
        Me.lblQuickScan_ChooseExtFiles.Size = New System.Drawing.Size(258, 16)
        Me.lblQuickScan_ChooseExtFiles.TabIndex = 6
        Me.lblQuickScan_ChooseExtFiles.Text = "Choose Extension File(s):"
        '
        'chklstQuickScan_ChooseExtFiles
        '
        Me.chklstQuickScan_ChooseExtFiles.BackColor = System.Drawing.Color.Black
        Me.chklstQuickScan_ChooseExtFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chklstQuickScan_ChooseExtFiles.ContextMenuStrip = Me.ContextMenu_chklstQuickScan
        Me.chklstQuickScan_ChooseExtFiles.ForeColor = System.Drawing.Color.Silver
        Me.chklstQuickScan_ChooseExtFiles.FormattingEnabled = True
        Me.chklstQuickScan_ChooseExtFiles.Location = New System.Drawing.Point(23, 85)
        Me.chklstQuickScan_ChooseExtFiles.Name = "chklstQuickScan_ChooseExtFiles"
        Me.chklstQuickScan_ChooseExtFiles.Size = New System.Drawing.Size(265, 92)
        Me.chklstQuickScan_ChooseExtFiles.TabIndex = 5
        Me.chklstQuickScan_ChooseExtFiles.TabStop = False
        '
        'chkQuickScan_MultipleExtFiles
        '
        Me.chkQuickScan_MultipleExtFiles.AutoSize = True
        Me.chkQuickScan_MultipleExtFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkQuickScan_MultipleExtFiles.Location = New System.Drawing.Point(206, 32)
        Me.chkQuickScan_MultipleExtFiles.Name = "chkQuickScan_MultipleExtFiles"
        Me.chkQuickScan_MultipleExtFiles.Size = New System.Drawing.Size(277, 20)
        Me.chkQuickScan_MultipleExtFiles.TabIndex = 4
        Me.chkQuickScan_MultipleExtFiles.TabStop = False
        Me.chkQuickScan_MultipleExtFiles.Text = "Multiple Extensions Files"
        Me.chkQuickScan_MultipleExtFiles.UseVisualStyleBackColor = True
        '
        'chkQuickScan_ExtBased
        '
        Me.chkQuickScan_ExtBased.AutoSize = True
        Me.chkQuickScan_ExtBased.Checked = True
        Me.chkQuickScan_ExtBased.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuickScan_ExtBased.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkQuickScan_ExtBased.Location = New System.Drawing.Point(23, 32)
        Me.chkQuickScan_ExtBased.Name = "chkQuickScan_ExtBased"
        Me.chkQuickScan_ExtBased.Size = New System.Drawing.Size(177, 20)
        Me.chkQuickScan_ExtBased.TabIndex = 3
        Me.chkQuickScan_ExtBased.TabStop = False
        Me.chkQuickScan_ExtBased.Text = "Extension Based"
        Me.chkQuickScan_ExtBased.UseVisualStyleBackColor = True
        '
        'lblScanner_Quick
        '
        Me.lblScanner_Quick.AutoSize = True
        Me.lblScanner_Quick.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblScanner_Quick.Location = New System.Drawing.Point(6, 0)
        Me.lblScanner_Quick.Name = "lblScanner_Quick"
        Me.lblScanner_Quick.Size = New System.Drawing.Size(108, 16)
        Me.lblScanner_Quick.TabIndex = 2
        Me.lblScanner_Quick.Text = "Quick Scan"
        '
        'SecLite_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 476)
        Me.Controls.Add(Me.SmallTabControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecLite_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecLite_Settings"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu_chklstQuickScan.ResumeLayout(False)
        Me.SmallTabControl1.ResumeLayout(False)
        Me.tabpage_start.ResumeLayout(False)
        Me.groupSettings_MainWindow_Wallpaper.ResumeLayout(False)
        Me.groupSettings_MainWindow_Wallpaper.PerformLayout()
        CType(Me.picPreview_Wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSettings_LoadingScreen.ResumeLayout(False)
        Me.groupSettings_LoadingScreen.PerformLayout()
        Me.groupSettings_MainWindow_ContainerEffect.ResumeLayout(False)
        Me.groupSettings_MainWindow_ContainerEffect.PerformLayout()
        Me.groupSettings_FadingEffect.ResumeLayout(False)
        Me.groupSettings_FadingEffect.PerformLayout()
        Me.groupSettings_FadingEffect_EffectType.ResumeLayout(False)
        Me.groupSettings_FadingEffect_EffectType.PerformLayout()
        Me.groupSettings_Theme.ResumeLayout(False)
        Me.groupSettings_Theme.PerformLayout()
        Me.tabpage_python.ResumeLayout(False)
        Me.tabpage_python.PerformLayout()
        Me.tabpage_scanner.ResumeLayout(False)
        Me.groupScanner_Quick.ResumeLayout(False)
        Me.groupScanner_Quick.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblSubTitle As Label
    Private WithEvents lblTitle As Label
    Private WithEvents picLogo As PictureBox
    Private WithEvents btnExit As Button
    Friend WithEvents SmallTabControl1 As smallTabControl
    Friend WithEvents tabpage_start As TabPage
    Friend WithEvents tabpage_python As TabPage
    Friend WithEvents rbtn_Theme_Dark As RadioButton
    Friend WithEvents rbtn_Theme_Light As RadioButton
    Friend WithEvents lblSetting_Theme As Label
    Friend WithEvents groupSettings_Theme As GroupBox
    Friend WithEvents groupSettings_FadingEffect As GroupBox
    Friend WithEvents lblSetting_FadingEffect As Label
    Friend WithEvents rbtn_FadingEffect_Off As RadioButton
    Friend WithEvents rbtn_FadingEffect_On As RadioButton
    Friend WithEvents txtSetting_FadingEffect_Speed As TextBox
    Friend WithEvents groupSettings_MainWindow_ContainerEffect As GroupBox
    Friend WithEvents lblSettings_MainWindow_ContainerEffect1 As Label
    Friend WithEvents rbtn_ContainerEffect_Off As RadioButton
    Friend WithEvents rbtn_ContainerEffect_On As RadioButton
    Friend WithEvents lblSettings_MainWindow_ContainerEffect2 As Label
    Friend WithEvents groupSettings_FadingEffect_EffectType As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtn_FadingType_FadeLeft As RadioButton
    Friend WithEvents rbtn_FadingType_WinDefault As RadioButton
    Friend WithEvents rbtn_FadingType_FadeTop As RadioButton
    Friend WithEvents groupSettings_LoadingScreen As GroupBox
    Friend WithEvents lbSettings_LoadingScreen1 As Label
    Friend WithEvents rbtn_LoadingScreen_TopMost_No As RadioButton
    Friend WithEvents rbtn_LoadingScreen_TopMost_Yes As RadioButton
    Friend WithEvents lbSettings_LoadingScreen2 As Label
    Friend WithEvents groupSettings_MainWindow_Wallpaper As GroupBox
    Friend WithEvents lblSetting_MainWindow_Wallpaper2 As Label
    Friend WithEvents lblSetting_MainWindow_Wallpaper1 As Label
    Friend WithEvents rbtn_Wallpaper_GIF As RadioButton
    Friend WithEvents rbtn_Wallpaper_Image As RadioButton
    Friend WithEvents picPreview_Wallpaper As PictureBox
    Friend WithEvents btnSaveSettings1 As Button
    Friend WithEvents rbtn_Wallpaper_None As RadioButton
    Friend WithEvents lblSetting_FadingEffect_Speed As Label
    Friend WithEvents lbl_python_path As Label
    Friend WithEvents txt_python_path As TextBox
    Friend WithEvents btn_browse_python_path As Button
    Friend WithEvents btnSaveSettings2 As Button
    Friend WithEvents btnPythonPackageManager As Button
    Friend WithEvents tabpage_scanner As TabPage
    Friend WithEvents groupScanner_Quick As GroupBox
    Friend WithEvents lblScanner_Quick As Label
    Friend WithEvents chkQuickScan_ExtBased As CheckBox
    Friend WithEvents chkQuickScan_MultipleExtFiles As CheckBox
    Friend WithEvents chklstQuickScan_ChooseExtFiles As CheckedListBox
    Friend WithEvents lblQuickScan_ChooseExtFiles As Label
    Friend WithEvents lblQuickScan_ChooseExtFile As Label
    Friend WithEvents txtQuickScan_ChooseExtFile As TextBox
    Friend WithEvents btnQuickScan_ChooseExtFile As Button
    Friend WithEvents ContextMenu_chklstQuickScan As ContextMenuStrip
    Friend WithEvents ViewExtensionsToolStripMenuItem As ToolStripMenuItem
End Class
