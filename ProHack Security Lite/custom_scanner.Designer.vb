<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class custom_scanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custom_scanner))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.bgWorker_Scanner = New System.ComponentModel.BackgroundWorker()
        Me.btnSelectFiles = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 202)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(268, 20)
        Me.ProgressBar1.TabIndex = 0
        '
        'bgWorker_Scanner
        '
        Me.bgWorker_Scanner.WorkerReportsProgress = True
        '
        'btnSelectFiles
        '
        Me.btnSelectFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFiles.Location = New System.Drawing.Point(12, 83)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(244, 41)
        Me.btnSelectFiles.TabIndex = 1
        Me.btnSelectFiles.Text = "Select Files(s)"
        Me.btnSelectFiles.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(12, 130)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(244, 41)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(116, 40)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Custom Scan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lite"
        '
        'custom_scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(268, 222)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSelectFiles)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "custom_scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "custom_scanner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents bgWorker_Scanner As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnSelectFiles As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
End Class
