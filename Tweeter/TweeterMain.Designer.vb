<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TweeterMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TweeterMain))
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.RightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TweetdeckAppMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Back_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Forward_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Refresh_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Home_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Notification_TSB = New System.Windows.Forms.ToolStripButton()
        Me.Messages_TSB = New System.Windows.Forms.ToolStripButton()
        Me.More_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Profile_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Likes_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lists_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mentions_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToUser_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Account_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TwitterAds_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Analytics_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TwitterSettings_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardShortcutsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTwitterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Application_TSB = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SettingsPanel_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdates_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNew_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Help_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.About_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit_TSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComposeButton = New System.Windows.Forms.Button()
        Me.AppMenuButton = New System.Windows.Forms.Button()
        Me.HubBackground = New System.Windows.Forms.PictureBox()
        Me.Restore_TMO = New System.Windows.Forms.ToolStripMenuItem()
        Me.TweetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exit_TMO = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTweeterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SysTrayMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TweetdeckAppMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.SysTrayIcon.BalloonTipTitle = "Information"
        Me.SysTrayIcon.ContextMenuStrip = Me.SysTrayMenu
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        Me.SysTrayIcon.Text = "Tweeter"
        Me.SysTrayIcon.Visible = True
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Restore_TMO, Me.ToolStripSeparator4, Me.TweetToolStripMenuItem, Me.SettingsPanelToolStripMenuItem, Me.ToolStripSeparator13, Me.Exit_TMO})
        Me.SysTrayMenu.Name = "SysTrayMenu"
        Me.SysTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SysTrayMenu.Size = New System.Drawing.Size(165, 168)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(161, 6)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Back_TSB, Me.Forward_TSB, Me.Refresh_TSB, Me.ToolStripSeparator5, Me.Home_TSB, Me.Notification_TSB, Me.Messages_TSB, Me.More_TSB, Me.ToolStripSeparator6, Me.Account_TSB, Me.ToolStripSeparator8, Me.Application_TSB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(700, 39)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser1.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.GeckoWebBrowser1.ContextMenuStrip = Me.RightClickMenu
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = True
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 37)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.NoDefaultContextMenu = True
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(892, 524)
        Me.GeckoWebBrowser1.TabIndex = 5
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'RightClickMenu
        '
        Me.RightClickMenu.Name = "ContextMenuStrip1"
        Me.RightClickMenu.Size = New System.Drawing.Size(61, 4)
        '
        'TweetdeckAppMenu
        '
        Me.TweetdeckAppMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanelToolStripMenuItem1, Me.ToolStripSeparator12, Me.CheckForUpdatesToolStripMenuItem1, Me.WhatsNewToolStripMenuItem, Me.SendFeedbackToolStripMenuItem1, Me.ToolStripSeparator11, Me.HelpToolStripMenuItem, Me.AboutTweeterToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.TweetdeckAppMenu.Name = "ContextMenuStrip1"
        Me.TweetdeckAppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TweetdeckAppMenu.Size = New System.Drawing.Size(228, 288)
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(224, 6)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(224, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(224, 6)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ComposeButton)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 39)
        Me.Panel1.TabIndex = 9
        '
        'Back_TSB
        '
        Me.Back_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Back_TSB.Image = Global.Tweeter.My.Resources.Resources.Back
        Me.Back_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Back_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Back_TSB.Name = "Back_TSB"
        Me.Back_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Back_TSB.Text = "Back"
        '
        'Forward_TSB
        '
        Me.Forward_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Forward_TSB.Image = Global.Tweeter.My.Resources.Resources.Forward
        Me.Forward_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Forward_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Forward_TSB.Name = "Forward_TSB"
        Me.Forward_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Forward_TSB.Text = "Forward"
        '
        'Refresh_TSB
        '
        Me.Refresh_TSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Refresh_TSB.Image = Global.Tweeter.My.Resources.Resources.Refresh
        Me.Refresh_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Refresh_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh_TSB.Name = "Refresh_TSB"
        Me.Refresh_TSB.Size = New System.Drawing.Size(36, 36)
        Me.Refresh_TSB.Text = "Refresh"
        '
        'Home_TSB
        '
        Me.Home_TSB.Image = Global.Tweeter.My.Resources.Resources.Home
        Me.Home_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Home_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Home_TSB.Name = "Home_TSB"
        Me.Home_TSB.Size = New System.Drawing.Size(76, 36)
        Me.Home_TSB.Text = "Home"
        Me.Home_TSB.ToolTipText = "Go to your Twitter home feed."
        '
        'Notification_TSB
        '
        Me.Notification_TSB.Image = Global.Tweeter.My.Resources.Resources.Notification
        Me.Notification_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Notification_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Notification_TSB.Name = "Notification_TSB"
        Me.Notification_TSB.Size = New System.Drawing.Size(111, 36)
        Me.Notification_TSB.Text = "Notifications"
        Me.Notification_TSB.ToolTipText = "Go to your Twitter notifications."
        '
        'Messages_TSB
        '
        Me.Messages_TSB.Image = Global.Tweeter.My.Resources.Resources.Mail
        Me.Messages_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Messages_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Messages_TSB.Name = "Messages_TSB"
        Me.Messages_TSB.Size = New System.Drawing.Size(94, 36)
        Me.Messages_TSB.Text = "Messages"
        Me.Messages_TSB.ToolTipText = "Go to your Twitter messages."
        '
        'More_TSB
        '
        Me.More_TSB.BackColor = System.Drawing.Color.Transparent
        Me.More_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Profile_TSM, Me.Likes_TSM, Me.Lists_TSM, Me.Mentions_TSM, Me.GoToUser_TSM})
        Me.More_TSB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.More_TSB.Image = Global.Tweeter.My.Resources.Resources.More
        Me.More_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.More_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.More_TSB.Name = "More_TSB"
        Me.More_TSB.Size = New System.Drawing.Size(80, 36)
        Me.More_TSB.Text = "More"
        Me.More_TSB.ToolTipText = "View more options."
        '
        'Profile_TSM
        '
        Me.Profile_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Profile_TSM.Image = Global.Tweeter.My.Resources.Resources.Social
        Me.Profile_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Profile_TSM.Name = "Profile_TSM"
        Me.Profile_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Profile_TSM.Size = New System.Drawing.Size(191, 38)
        Me.Profile_TSM.Text = "Profile"
        Me.Profile_TSM.ToolTipText = "Go to your Twitter profile."
        '
        'Likes_TSM
        '
        Me.Likes_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Likes_TSM.Image = Global.Tweeter.My.Resources.Resources.Donate
        Me.Likes_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Likes_TSM.Name = "Likes_TSM"
        Me.Likes_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.Likes_TSM.Size = New System.Drawing.Size(191, 38)
        Me.Likes_TSM.Text = "Likes"
        Me.Likes_TSM.ToolTipText = "Go to all the posts you've liked."
        '
        'Lists_TSM
        '
        Me.Lists_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Lists_TSM.Image = Global.Tweeter.My.Resources.Resources.Copy
        Me.Lists_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Lists_TSM.Name = "Lists_TSM"
        Me.Lists_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Lists_TSM.Size = New System.Drawing.Size(191, 38)
        Me.Lists_TSM.Text = "Lists"
        Me.Lists_TSM.ToolTipText = "Go to your Twitter lists."
        '
        'Mentions_TSM
        '
        Me.Mentions_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.Mentions_TSM.Image = Global.Tweeter.My.Resources.Resources.Mention
        Me.Mentions_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Mentions_TSM.Name = "Mentions_TSM"
        Me.Mentions_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Mentions_TSM.Size = New System.Drawing.Size(191, 38)
        Me.Mentions_TSM.Text = "Mentions"
        Me.Mentions_TSM.ToolTipText = "Go to your Twitter mentions."
        '
        'GoToUser_TSM
        '
        Me.GoToUser_TSM.BackColor = System.Drawing.SystemColors.Control
        Me.GoToUser_TSM.Image = Global.Tweeter.My.Resources.Resources.GoToUser
        Me.GoToUser_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GoToUser_TSM.Name = "GoToUser_TSM"
        Me.GoToUser_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.GoToUser_TSM.Size = New System.Drawing.Size(191, 38)
        Me.GoToUser_TSM.Text = "Go to user..."
        Me.GoToUser_TSM.ToolTipText = "Go to a specified Twitter user's profile."
        '
        'Account_TSB
        '
        Me.Account_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TwitterAds_TSM, Me.Analytics_TSM, Me.ToolStripSeparator7, Me.TwitterSettings_TSM, Me.KeyboardShortcutsToolStripMenuItem1, Me.HelpCentreToolStripMenuItem1, Me.AboutTwitterToolStripMenuItem1, Me.ToolStripSeparator10, Me.LogOutToolStripMenuItem1})
        Me.Account_TSB.Image = Global.Tweeter.My.Resources.Resources.Process
        Me.Account_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Account_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Account_TSB.Name = "Account_TSB"
        Me.Account_TSB.Size = New System.Drawing.Size(97, 36)
        Me.Account_TSB.Text = "Account"
        Me.Account_TSB.ToolTipText = "Control your Twitter account."
        '
        'TwitterAds_TSM
        '
        Me.TwitterAds_TSM.BackColor = System.Drawing.Color.White
        Me.TwitterAds_TSM.Image = CType(resources.GetObject("TwitterAds_TSM.Image"), System.Drawing.Image)
        Me.TwitterAds_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TwitterAds_TSM.Name = "TwitterAds_TSM"
        Me.TwitterAds_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.TwitterAds_TSM.Size = New System.Drawing.Size(296, 38)
        Me.TwitterAds_TSM.Text = "Twitter ads"
        Me.TwitterAds_TSM.ToolTipText = "Go to the Twitter Ads website."
        '
        'Analytics_TSM
        '
        Me.Analytics_TSM.Image = Global.Tweeter.My.Resources.Resources.Analytics
        Me.Analytics_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Analytics_TSM.Name = "Analytics_TSM"
        Me.Analytics_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Analytics_TSM.Size = New System.Drawing.Size(296, 38)
        Me.Analytics_TSM.Text = "Analytics"
        Me.Analytics_TSM.ToolTipText = "View and manage your analytics and widespread impressions."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(293, 6)
        '
        'TwitterSettings_TSM
        '
        Me.TwitterSettings_TSM.Image = Global.Tweeter.My.Resources.Resources.Twitter_Settings
        Me.TwitterSettings_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TwitterSettings_TSM.Name = "TwitterSettings_TSM"
        Me.TwitterSettings_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.TwitterSettings_TSM.Size = New System.Drawing.Size(296, 38)
        Me.TwitterSettings_TSM.Text = "Twitter settings"
        Me.TwitterSettings_TSM.ToolTipText = "View and manage your Twitter settings."
        '
        'KeyboardShortcutsToolStripMenuItem1
        '
        Me.KeyboardShortcutsToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Keyboard
        Me.KeyboardShortcutsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.KeyboardShortcutsToolStripMenuItem1.Name = "KeyboardShortcutsToolStripMenuItem1"
        Me.KeyboardShortcutsToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.OemQuestion), System.Windows.Forms.Keys)
        Me.KeyboardShortcutsToolStripMenuItem1.Size = New System.Drawing.Size(296, 38)
        Me.KeyboardShortcutsToolStripMenuItem1.Text = "Keyboard shortcuts"
        Me.KeyboardShortcutsToolStripMenuItem1.ToolTipText = "View all the Twitter keyboard shortcuts."
        '
        'HelpCentreToolStripMenuItem1
        '
        Me.HelpCentreToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Question
        Me.HelpCentreToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpCentreToolStripMenuItem1.Name = "HelpCentreToolStripMenuItem1"
        Me.HelpCentreToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.HelpCentreToolStripMenuItem1.Size = New System.Drawing.Size(296, 38)
        Me.HelpCentreToolStripMenuItem1.Text = "Help centre"
        Me.HelpCentreToolStripMenuItem1.ToolTipText = "Go to the Twitter help centre."
        '
        'AboutTwitterToolStripMenuItem1
        '
        Me.AboutTwitterToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Information
        Me.AboutTwitterToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutTwitterToolStripMenuItem1.Name = "AboutTwitterToolStripMenuItem1"
        Me.AboutTwitterToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.AboutTwitterToolStripMenuItem1.Size = New System.Drawing.Size(296, 38)
        Me.AboutTwitterToolStripMenuItem1.Text = "About Twitter"
        Me.AboutTwitterToolStripMenuItem1.ToolTipText = "Learn more about Twitter."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(293, 6)
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.LogOut
        Me.LogOutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(296, 38)
        Me.LogOutToolStripMenuItem1.Text = "Log out"
        Me.LogOutToolStripMenuItem1.ToolTipText = "Log out of the current Twitter user."
        '
        'Application_TSB
        '
        Me.Application_TSB.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanel_TSM, Me.ToolStripSeparator1, Me.CheckForUpdates_TSM, Me.WhatsNew_TSM, Me.SendFeedbackToolStripMenuItem, Me.ToolStripSeparator2, Me.Help_TSM, Me.About_TSM, Me.ToolStripSeparator9, Me.Exit_TSM})
        Me.Application_TSB.Image = Global.Tweeter.My.Resources.Resources.NewWindow
        Me.Application_TSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Application_TSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Application_TSB.Name = "Application_TSB"
        Me.Application_TSB.Size = New System.Drawing.Size(113, 36)
        Me.Application_TSB.Text = "Application"
        Me.Application_TSB.ToolTipText = "Control Tweeter and its settings."
        '
        'SettingsPanel_TSM
        '
        Me.SettingsPanel_TSM.Image = Global.Tweeter.My.Resources.Resources.Settings
        Me.SettingsPanel_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanel_TSM.Name = "SettingsPanel_TSM"
        Me.SettingsPanel_TSM.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsPanel_TSM.Size = New System.Drawing.Size(227, 38)
        Me.SettingsPanel_TSM.Text = "Settings Panel"
        Me.SettingsPanel_TSM.ToolTipText = "Customise the settings of Tweeter."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(224, 6)
        '
        'CheckForUpdates_TSM
        '
        Me.CheckForUpdates_TSM.Image = Global.Tweeter.My.Resources.Resources.Update
        Me.CheckForUpdates_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdates_TSM.Name = "CheckForUpdates_TSM"
        Me.CheckForUpdates_TSM.Size = New System.Drawing.Size(227, 38)
        Me.CheckForUpdates_TSM.Text = "Check for updates..."
        Me.CheckForUpdates_TSM.ToolTipText = "Check if you have the latest version."
        '
        'WhatsNew_TSM
        '
        Me.WhatsNew_TSM.Image = Global.Tweeter.My.Resources.Resources.Changes
        Me.WhatsNew_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WhatsNew_TSM.Name = "WhatsNew_TSM"
        Me.WhatsNew_TSM.Size = New System.Drawing.Size(227, 38)
        Me.WhatsNew_TSM.Text = "What's new?"
        Me.WhatsNew_TSM.ToolTipText = "See what's changed."
        '
        'SendFeedbackToolStripMenuItem
        '
        Me.SendFeedbackToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Feedback
        Me.SendFeedbackToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem"
        Me.SendFeedbackToolStripMenuItem.Size = New System.Drawing.Size(227, 38)
        Me.SendFeedbackToolStripMenuItem.Text = "Send feedback..."
        Me.SendFeedbackToolStripMenuItem.ToolTipText = "Tell us what you think."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(224, 6)
        '
        'Help_TSM
        '
        Me.Help_TSM.Image = Global.Tweeter.My.Resources.Resources.Question
        Me.Help_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Help_TSM.Name = "Help_TSM"
        Me.Help_TSM.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.Help_TSM.Size = New System.Drawing.Size(227, 38)
        Me.Help_TSM.Text = "Help"
        Me.Help_TSM.ToolTipText = "Open the Tweeter help documentation."
        '
        'About_TSM
        '
        Me.About_TSM.Image = Global.Tweeter.My.Resources.Resources.Information
        Me.About_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.About_TSM.Name = "About_TSM"
        Me.About_TSM.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.About_TSM.Size = New System.Drawing.Size(227, 38)
        Me.About_TSM.Text = "About Tweeter"
        Me.About_TSM.ToolTipText = "View legal information about Tweeter."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(224, 6)
        '
        'Exit_TSM
        '
        Me.Exit_TSM.Image = Global.Tweeter.My.Resources.Resources._Exit
        Me.Exit_TSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Exit_TSM.Name = "Exit_TSM"
        Me.Exit_TSM.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Exit_TSM.Size = New System.Drawing.Size(227, 38)
        Me.Exit_TSM.Text = "Exit"
        Me.Exit_TSM.ToolTipText = "End the application process."
        '
        'ComposeButton
        '
        Me.ComposeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComposeButton.FlatAppearance.BorderSize = 0
        Me.ComposeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComposeButton.Image = Global.Tweeter.My.Resources.Resources.Twitter_Compose
        Me.ComposeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComposeButton.Location = New System.Drawing.Point(815, 0)
        Me.ComposeButton.Name = "ComposeButton"
        Me.ComposeButton.Size = New System.Drawing.Size(77, 39)
        Me.ComposeButton.TabIndex = 7
        Me.ComposeButton.Text = "Tweet"
        Me.ComposeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.ComposeButton, "Compose a new Tweet.")
        Me.ComposeButton.UseVisualStyleBackColor = True
        Me.ComposeButton.Visible = False
        '
        'AppMenuButton
        '
        Me.AppMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AppMenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.AppMenuButton.FlatAppearance.BorderSize = 0
        Me.AppMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AppMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AppMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppMenuButton.Image = Global.Tweeter.My.Resources.Resources.NewWindow
        Me.AppMenuButton.Location = New System.Drawing.Point(9, 511)
        Me.AppMenuButton.Name = "AppMenuButton"
        Me.AppMenuButton.Size = New System.Drawing.Size(42, 42)
        Me.AppMenuButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.AppMenuButton, "Application Menu")
        Me.AppMenuButton.UseVisualStyleBackColor = False
        Me.AppMenuButton.Visible = False
        '
        'HubBackground
        '
        Me.HubBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HubBackground.Image = Global.Tweeter.My.Resources.Resources.Background
        Me.HubBackground.Location = New System.Drawing.Point(0, 0)
        Me.HubBackground.Name = "HubBackground"
        Me.HubBackground.Size = New System.Drawing.Size(892, 561)
        Me.HubBackground.TabIndex = 8
        Me.HubBackground.TabStop = False
        '
        'Restore_TMO
        '
        Me.Restore_TMO.Image = Global.Tweeter.My.Resources.Resources.Restore
        Me.Restore_TMO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Restore_TMO.Name = "Restore_TMO"
        Me.Restore_TMO.Size = New System.Drawing.Size(164, 38)
        Me.Restore_TMO.Text = "Restore"
        '
        'TweetToolStripMenuItem
        '
        Me.TweetToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Twitter_Compose
        Me.TweetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TweetToolStripMenuItem.Name = "TweetToolStripMenuItem"
        Me.TweetToolStripMenuItem.Size = New System.Drawing.Size(164, 38)
        Me.TweetToolStripMenuItem.Text = "Tweet"
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Settings
        Me.SettingsPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(164, 38)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel"
        '
        'Exit_TMO
        '
        Me.Exit_TMO.Image = Global.Tweeter.My.Resources.Resources._Exit
        Me.Exit_TMO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Exit_TMO.Name = "Exit_TMO"
        Me.Exit_TMO.Size = New System.Drawing.Size(164, 38)
        Me.Exit_TMO.Text = "Exit"
        '
        'SettingsPanelToolStripMenuItem1
        '
        Me.SettingsPanelToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Settings
        Me.SettingsPanelToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanelToolStripMenuItem1.Name = "SettingsPanelToolStripMenuItem1"
        Me.SettingsPanelToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsPanelToolStripMenuItem1.Size = New System.Drawing.Size(227, 38)
        Me.SettingsPanelToolStripMenuItem1.Text = "Settings Panel"
        '
        'CheckForUpdatesToolStripMenuItem1
        '
        Me.CheckForUpdatesToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Update
        Me.CheckForUpdatesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdatesToolStripMenuItem1.Name = "CheckForUpdatesToolStripMenuItem1"
        Me.CheckForUpdatesToolStripMenuItem1.Size = New System.Drawing.Size(227, 38)
        Me.CheckForUpdatesToolStripMenuItem1.Text = "Check for updates..."
        '
        'WhatsNewToolStripMenuItem
        '
        Me.WhatsNewToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Changes
        Me.WhatsNewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WhatsNewToolStripMenuItem.Name = "WhatsNewToolStripMenuItem"
        Me.WhatsNewToolStripMenuItem.Size = New System.Drawing.Size(227, 38)
        Me.WhatsNewToolStripMenuItem.Text = "What's new?"
        '
        'SendFeedbackToolStripMenuItem1
        '
        Me.SendFeedbackToolStripMenuItem1.Image = Global.Tweeter.My.Resources.Resources.Feedback
        Me.SendFeedbackToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendFeedbackToolStripMenuItem1.Name = "SendFeedbackToolStripMenuItem1"
        Me.SendFeedbackToolStripMenuItem1.Size = New System.Drawing.Size(227, 38)
        Me.SendFeedbackToolStripMenuItem1.Text = "Send feedback..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Question
        Me.HelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(227, 38)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutTweeterToolStripMenuItem
        '
        Me.AboutTweeterToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources.Information
        Me.AboutTweeterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutTweeterToolStripMenuItem.Name = "AboutTweeterToolStripMenuItem"
        Me.AboutTweeterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutTweeterToolStripMenuItem.Size = New System.Drawing.Size(227, 38)
        Me.AboutTweeterToolStripMenuItem.Text = "About Tweeter"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Tweeter.My.Resources.Resources._Exit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(227, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TweeterMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AppMenuButton)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Controls.Add(Me.HubBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(908, 600)
        Me.Name = "TweeterMain"
        Me.Text = "Tweeter"
        Me.SysTrayMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TweetdeckAppMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.HubBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SysTrayIcon As NotifyIcon
    Friend WithEvents SysTrayMenu As ContextMenuStrip
    Friend WithEvents Restore_TMO As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Exit_TMO As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Back_TSB As ToolStripButton
    Friend WithEvents Forward_TSB As ToolStripButton
    Friend WithEvents Refresh_TSB As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Home_TSB As ToolStripButton
    Friend WithEvents Notification_TSB As ToolStripButton
    Friend WithEvents Messages_TSB As ToolStripButton
    Friend WithEvents More_TSB As ToolStripDropDownButton
    Friend WithEvents Likes_TSM As ToolStripMenuItem
    Friend WithEvents Lists_TSM As ToolStripMenuItem
    Friend WithEvents Mentions_TSM As ToolStripMenuItem
    Friend WithEvents GoToUser_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Account_TSB As ToolStripDropDownButton
    Friend WithEvents TwitterAds_TSM As ToolStripMenuItem
    Friend WithEvents Analytics_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Application_TSB As ToolStripDropDownButton
    Friend WithEvents WhatsNew_TSM As ToolStripMenuItem
    Friend WithEvents About_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents Exit_TSM As ToolStripMenuItem
    Friend WithEvents KeyboardShortcutsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpCentreToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutTwitterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents LogOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckForUpdates_TSM As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents SettingsPanel_TSM As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TwitterSettings_TSM As ToolStripMenuItem
    Friend WithEvents AppMenuButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TweetdeckAppMenu As ContextMenuStrip
    Friend WithEvents SettingsPanelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WhatsNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents AboutTweeterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Help_TSM As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendFeedbackToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Profile_TSM As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ComposeButton As Button
    Friend WithEvents TweetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightClickMenu As ContextMenuStrip
    Friend WithEvents HubBackground As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
