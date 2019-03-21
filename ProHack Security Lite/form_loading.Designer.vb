<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_loading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_loading))
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelBackground = New System.Windows.Forms.Panel()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLoading
        '
        Me.picLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLoading.Image = CType(resources.GetObject("picLoading.Image"), System.Drawing.Image)
        Me.picLoading.Location = New System.Drawing.Point(21, 70)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(356, 292)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLoading.TabIndex = 0
        Me.picLoading.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Silver
        Me.lblTitle.Location = New System.Drawing.Point(33, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(329, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Loading.. Please Wait"
        '
        'panelBackground
        '
        Me.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBackground.Controls.Add(Me.lblTitle)
        Me.panelBackground.Controls.Add(Me.picLoading)
        Me.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBackground.Location = New System.Drawing.Point(0, 0)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(404, 384)
        Me.panelBackground.TabIndex = 2
        '
        'form_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 384)
        Me.Controls.Add(Me.panelBackground)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_loading"
        Me.TopMost = True
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackground.ResumeLayout(False)
        Me.panelBackground.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLoading As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelBackground As Panel
End Class
