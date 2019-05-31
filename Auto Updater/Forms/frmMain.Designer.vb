<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.lblLatestVersion = New System.Windows.Forms.Label()
        Me.lblLatestVersionValue = New System.Windows.Forms.Label()
        Me.lblCurrentVersionValue = New System.Windows.Forms.Label()
        Me.grpVersion = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.picStatus = New System.Windows.Forms.PictureBox()
        Me.picGBMIcon = New System.Windows.Forms.PictureBox()
        Me.grpVersion.SuspendLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGBMIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 103)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 121)
        Me.TextBox1.TabIndex = 0
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.AutoSize = True
        Me.lblCurrentVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentVersion.Location = New System.Drawing.Point(15, 25)
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(98, 13)
        Me.lblCurrentVersion.TabIndex = 1
        Me.lblCurrentVersion.Text = "Current Version:"
        '
        'lblLatestVersion
        '
        Me.lblLatestVersion.AutoSize = True
        Me.lblLatestVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatestVersion.Location = New System.Drawing.Point(15, 52)
        Me.lblLatestVersion.Name = "lblLatestVersion"
        Me.lblLatestVersion.Size = New System.Drawing.Size(92, 13)
        Me.lblLatestVersion.TabIndex = 2
        Me.lblLatestVersion.Text = "Latest Version:"
        '
        'lblLatestVersionValue
        '
        Me.lblLatestVersionValue.AutoSize = True
        Me.lblLatestVersionValue.Location = New System.Drawing.Point(119, 52)
        Me.lblLatestVersionValue.Name = "lblLatestVersionValue"
        Me.lblLatestVersionValue.Size = New System.Drawing.Size(40, 13)
        Me.lblLatestVersionValue.TabIndex = 4
        Me.lblLatestVersionValue.Text = "0.0.0.0"
        '
        'lblCurrentVersionValue
        '
        Me.lblCurrentVersionValue.AutoSize = True
        Me.lblCurrentVersionValue.Location = New System.Drawing.Point(119, 25)
        Me.lblCurrentVersionValue.Name = "lblCurrentVersionValue"
        Me.lblCurrentVersionValue.Size = New System.Drawing.Size(40, 13)
        Me.lblCurrentVersionValue.TabIndex = 3
        Me.lblCurrentVersionValue.Text = "0.0.0.0"
        '
        'grpVersion
        '
        Me.grpVersion.Controls.Add(Me.picStatus)
        Me.grpVersion.Controls.Add(Me.btnUpdate)
        Me.grpVersion.Controls.Add(Me.lblCurrentVersionValue)
        Me.grpVersion.Controls.Add(Me.lblLatestVersionValue)
        Me.grpVersion.Controls.Add(Me.lblCurrentVersion)
        Me.grpVersion.Controls.Add(Me.lblLatestVersion)
        Me.grpVersion.Location = New System.Drawing.Point(145, 12)
        Me.grpVersion.Name = "grpVersion"
        Me.grpVersion.Size = New System.Drawing.Size(327, 85)
        Me.grpVersion.TabIndex = 5
        Me.grpVersion.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(246, 34)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'picStatus
        '
        Me.picStatus.BackColor = System.Drawing.Color.Transparent
        Me.picStatus.Image = Global.Auto_Updater.My.Resources.Resources.UpdateAvailable
        Me.picStatus.Location = New System.Drawing.Point(212, 31)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(28, 28)
        Me.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picStatus.TabIndex = 6
        Me.picStatus.TabStop = False
        '
        'picGBMIcon
        '
        Me.picGBMIcon.Image = CType(resources.GetObject("picGBMIcon.Image"), System.Drawing.Image)
        Me.picGBMIcon.Location = New System.Drawing.Point(12, 96)
        Me.picGBMIcon.Name = "picGBMIcon"
        Me.picGBMIcon.Size = New System.Drawing.Size(128, 128)
        Me.picGBMIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGBMIcon.TabIndex = 7
        Me.picGBMIcon.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.grpVersion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picGBMIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Updater"
        Me.grpVersion.ResumeLayout(False)
        Me.grpVersion.PerformLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGBMIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCurrentVersion As Label
    Friend WithEvents lblLatestVersion As Label
    Friend WithEvents lblLatestVersionValue As Label
    Friend WithEvents lblCurrentVersionValue As Label
    Friend WithEvents grpVersion As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents picStatus As PictureBox
    Friend WithEvents picGBMIcon As PictureBox
End Class
