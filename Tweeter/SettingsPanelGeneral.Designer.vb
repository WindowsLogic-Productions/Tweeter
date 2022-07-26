<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPanelGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelGeneral))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.UseTweetdeck = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SysTrayMinimise = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SettingsPanelButton = New System.Windows.Forms.RadioButton()
        Me.SystemTrayButton = New System.Windows.Forms.RadioButton()
        Me.NothingButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UpdateBox = New System.Windows.Forms.GroupBox()
        Me.EnableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DisableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.UpdateBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 179)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Tweeter"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.UseTweetdeck)
        Me.GroupBox6.Controls.Add(Me.PictureBox8)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 85)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(397, 59)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TweetDeck"
        '
        'UseTweetdeck
        '
        Me.UseTweetdeck.AutoSize = True
        Me.UseTweetdeck.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UseTweetdeck.Location = New System.Drawing.Point(44, 35)
        Me.UseTweetdeck.Name = "UseTweetdeck"
        Me.UseTweetdeck.Size = New System.Drawing.Size(107, 18)
        Me.UseTweetdeck.TabIndex = 7
        Me.UseTweetdeck.Text = "Use Tweetdeck"
        Me.UseTweetdeck.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Force Tweeter to use TweetDeck instead of regular Twitter."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SysTrayMinimise)
        Me.GroupBox4.Controls.Add(Me.PictureBox7)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 73)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Minimising"
        '
        'SysTrayMinimise
        '
        Me.SysTrayMinimise.AutoSize = True
        Me.SysTrayMinimise.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SysTrayMinimise.Location = New System.Drawing.Point(44, 49)
        Me.SysTrayMinimise.Name = "SysTrayMinimise"
        Me.SysTrayMinimise.Size = New System.Drawing.Size(151, 18)
        Me.SysTrayMinimise.TabIndex = 2
        Me.SysTrayMinimise.Text = "Minimise to system tray"
        Me.SysTrayMinimise.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(342, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "When minimising Tweeter, it will hide itself in the system tray and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "run in the b" &
    "ackground."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(409, 179)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Start-up"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.SettingsPanelButton)
        Me.GroupBox3.Controls.Add(Me.SystemTrayButton)
        Me.GroupBox3.Controls.Add(Me.NothingButton)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 59)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Start-up"
        '
        'SettingsPanelButton
        '
        Me.SettingsPanelButton.AutoSize = True
        Me.SettingsPanelButton.Location = New System.Drawing.Point(271, 36)
        Me.SettingsPanelButton.Name = "SettingsPanelButton"
        Me.SettingsPanelButton.Size = New System.Drawing.Size(98, 17)
        Me.SettingsPanelButton.TabIndex = 3
        Me.SettingsPanelButton.TabStop = True
        Me.SettingsPanelButton.Text = "Settings Panel"
        Me.SettingsPanelButton.UseVisualStyleBackColor = True
        '
        'SystemTrayButton
        '
        Me.SystemTrayButton.AutoSize = True
        Me.SystemTrayButton.Location = New System.Drawing.Point(121, 36)
        Me.SystemTrayButton.Name = "SystemTrayButton"
        Me.SystemTrayButton.Size = New System.Drawing.Size(144, 17)
        Me.SystemTrayButton.TabIndex = 2
        Me.SystemTrayButton.TabStop = True
        Me.SystemTrayButton.Text = "Minimise to system tray"
        Me.SystemTrayButton.UseVisualStyleBackColor = True
        '
        'NothingButton
        '
        Me.NothingButton.AutoSize = True
        Me.NothingButton.Location = New System.Drawing.Point(47, 36)
        Me.NothingButton.Name = "NothingButton"
        Me.NothingButton.Size = New System.Drawing.Size(68, 17)
        Me.NothingButton.TabIndex = 1
        Me.NothingButton.TabStop = True
        Me.NothingButton.Text = "Nothing"
        Me.NothingButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Set how you want Tweeter to start."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.UpdateBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 179)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Updates"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'UpdateBox
        '
        Me.UpdateBox.Controls.Add(Me.PictureBox1)
        Me.UpdateBox.Controls.Add(Me.PictureBox2)
        Me.UpdateBox.Controls.Add(Me.EnableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label1)
        Me.UpdateBox.Controls.Add(Me.DisableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label2)
        Me.UpdateBox.Location = New System.Drawing.Point(6, 6)
        Me.UpdateBox.Name = "UpdateBox"
        Me.UpdateBox.Size = New System.Drawing.Size(376, 98)
        Me.UpdateBox.TabIndex = 14
        Me.UpdateBox.TabStop = False
        Me.UpdateBox.Text = "Update Settings"
        '
        'EnableUpdates
        '
        Me.EnableUpdates.AutoSize = True
        Me.EnableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EnableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUpdates.Location = New System.Drawing.Point(44, 21)
        Me.EnableUpdates.Name = "EnableUpdates"
        Me.EnableUpdates.Size = New System.Drawing.Size(165, 18)
        Me.EnableUpdates.TabIndex = 1
        Me.EnableUpdates.Text = "Enable automatic updates"
        Me.EnableUpdates.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Check for updates when starting."
        '
        'DisableUpdates
        '
        Me.DisableUpdates.AutoSize = True
        Me.DisableUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisableUpdates.Location = New System.Drawing.Point(44, 59)
        Me.DisableUpdates.Name = "DisableUpdates"
        Me.DisableUpdates.Size = New System.Drawing.Size(168, 18)
        Me.DisableUpdates.TabIndex = 2
        Me.DisableUpdates.Text = "Disable automatic updates"
        Me.DisableUpdates.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(41, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Do not check for updates."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 11
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(252, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change general settings..."
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.Tweeter.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(48, 48)
        Me.BackButton.TabIndex = 15
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Tweeter.My.Resources.Resources.Twitter
        Me.PictureBox8.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 1
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Tweeter.My.Resources.Resources.Minimise
        Me.PictureBox7.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Tweeter.My.Resources.Resources.Start_up
        Me.PictureBox5.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tweeter.My.Resources.Resources.Updates_On
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tweeter.My.Resources.Resources.Updates_Off
        Me.PictureBox2.Location = New System.Drawing.Point(6, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'SettingsPanelGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsPanelGeneral"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > General"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.UpdateBox.ResumeLayout(False)
        Me.UpdateBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UpdateBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnableUpdates As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DisableUpdates As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SettingsPanelButton As RadioButton
    Friend WithEvents SystemTrayButton As RadioButton
    Friend WithEvents NothingButton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents UseTweetdeck As CheckBox
    Friend WithEvents SysTrayMinimise As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
End Class
