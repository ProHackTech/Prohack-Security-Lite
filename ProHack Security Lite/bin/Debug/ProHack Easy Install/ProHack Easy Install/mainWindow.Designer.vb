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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWIndow))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.checkList_Dependency = New System.Windows.Forms.CheckedListBox()
        Me.lblExtraDependency = New System.Windows.Forms.Label()
        Me.btnFinalize = New System.Windows.Forms.Button()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(12, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(35, 35)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(53, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(155, 20)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "ProHack Easy Install"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(591, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "[ x ]"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(542, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(43, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "[ _ ]"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(259, 87)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(102, 20)
        Me.lblProduct.TabIndex = 4
        Me.lblProduct.Text = "Your Product"
        '
        'checkList_Dependency
        '
        Me.checkList_Dependency.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.checkList_Dependency.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.checkList_Dependency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkList_Dependency.ForeColor = System.Drawing.Color.Navy
        Me.checkList_Dependency.FormattingEnabled = True
        Me.checkList_Dependency.Items.AddRange(New Object() {".NET Framework 4.7.2 Runtime", "Python 3", "Universal C Runtime (For Poweshell Install)", "Powershell", "Git For Windows"})
        Me.checkList_Dependency.Location = New System.Drawing.Point(17, 203)
        Me.checkList_Dependency.Name = "checkList_Dependency"
        Me.checkList_Dependency.ScrollAlwaysVisible = True
        Me.checkList_Dependency.Size = New System.Drawing.Size(585, 147)
        Me.checkList_Dependency.TabIndex = 0
        '
        'lblExtraDependency
        '
        Me.lblExtraDependency.AutoSize = True
        Me.lblExtraDependency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraDependency.Location = New System.Drawing.Point(13, 170)
        Me.lblExtraDependency.Name = "lblExtraDependency"
        Me.lblExtraDependency.Size = New System.Drawing.Size(112, 20)
        Me.lblExtraDependency.TabIndex = 6
        Me.lblExtraDependency.Text = "Dependencies"
        '
        'btnFinalize
        '
        Me.btnFinalize.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFinalize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalize.FlatAppearance.BorderSize = 0
        Me.btnFinalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFinalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalize.ForeColor = System.Drawing.Color.White
        Me.btnFinalize.Location = New System.Drawing.Point(239, 356)
        Me.btnFinalize.Name = "btnFinalize"
        Me.btnFinalize.Size = New System.Drawing.Size(143, 39)
        Me.btnFinalize.TabIndex = 7
        Me.btnFinalize.Text = "Install"
        Me.btnFinalize.UseVisualStyleBackColor = False
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductName.Location = New System.Drawing.Point(17, 110)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(585, 19)
        Me.txtProductName.TabIndex = 8
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mainWIndow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 407)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.btnFinalize)
        Me.Controls.Add(Me.lblExtraDependency)
        Me.Controls.Add(Me.checkList_Dependency)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainWIndow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProHack Easy Install"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents lblProduct As Label
    Friend WithEvents checkList_Dependency As CheckedListBox
    Friend WithEvents lblExtraDependency As Label
    Friend WithEvents btnFinalize As Button
    Friend WithEvents txtProductName As TextBox
End Class
