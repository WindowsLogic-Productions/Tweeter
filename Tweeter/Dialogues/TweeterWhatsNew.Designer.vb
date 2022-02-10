<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TweeterWhatsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TweeterWhatsNew))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~Version 4.0.0.0~", "1. Added 'Tweet' button to top bar.", "2. Added ability to tweet from system tray.", "3. Redesigned 'Settings Panel'.", "4. ", "", "~Version 3.1.1.1~ (A few more small fixes.)", "1. Fixed a bug that caused 'Go to user...' to show up in the taskbar.", "2. Reduces RAM usage when minimising the application to the system tray or taskba" &
                "r.", "3. Added shortcut keys for Twitter Ads and Analytics.", "(You can view them in the 'Keyboard Shortcuts'.)", "4. Performance improvements.", "", "~Version 3.1.1.0~ (Fixed for modern Twitter.)", "1. Updated GeckoFX to 60.0.55.", "2. Fixed Tweeter for use with the new Twitter layout.", "3. Added option to set profile username in 'Settings Panel'.", "4. Performance improvements.", "", "~Version 3.1.0.1~ (A few small fixes to keep everything running smoothly.)", "1. Updated GeckoFX to 60.0.44.", "2. Added tooltips.", "3. Performance improvements.", "", "~Version 3.1.0.0~ (3.0 Service Pack 1)", "1. Fixed an bug where the 'Twitter settings' menu option under 'Account' did noth" &
                "ing.", "2. Removed link to my Twitter profile.", "3. System tray menu now looks the same as the other menus.", "4. Added 'Settings Panel' option to the system tray menu.", "5. Added sound to 'Error' dialogues.", "6. Fixed a bug where the set user colour would not appear on the 'About' dialogue" &
                ".", "7. Renamed 'Feedback' window.", "", "~Version 3.0.0.0~", "1. Added ability to change accent colour.", "2. Added ability to use Tweetdeck instead of Twitter.", "3. 'Go to user...' now functions as an application protocol.", "4. Updated icon set.", "5. Fixed a bug where system tray icon text would not update if the page name was " &
                "under 25", "characters.", "", "~Version 2.0.1.0~", "1. Fixed a bug which stopped the title bar from being updated.", "2. System tray icon now shows where you are on Twitter/how many unread tweets you" &
                " have.", "3. Updated Tweeter icon.", "4. Added a button so you can follow me.", "5. Redesigned 'About' dialogue.", "", "~Version 2.0.0.0~", "1. Added ability to run Tweeter in the background.", "2. Redesigned top bar so that everything you care about is just a click away.", "3. Tweeter now shows where you are on Twitter.", "4. Fixed a bug where the 'Refresh' button wouldn't work.", "5. Added personalisation settings.", "6. Added the ability to make Tweeter minimise at start-up.", "", "~Version 1.0.0.1~", "1. Fixed a bug where the update toggle would not work.", "", "~Version 1.0.0.0~", "1. Initial release.", "2. Browse Twitter in an easy to use window."})
        Me.ListBox1.Location = New System.Drawing.Point(0, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 312)
        Me.ListBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 53)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "See what's changed in the application..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tweeter.My.Resources.Resources.Twitter
        Me.PictureBox1.Location = New System.Drawing.Point(487, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'TweeterWhatsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 364)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TweeterWhatsNew"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What's New?"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
