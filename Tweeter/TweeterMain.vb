Imports Gecko

Public Class TweeterMain
#Region "Load Settings"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Xpcom.Initialize("Firefox")

    End Sub

    Private Sub TweeterMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.Update_Settings()

        ToolStrip1.Parent = HubBackground
        Panel1.Parent = HubBackground
        ComposeButton.Parent = Panel1
        ToolStrip1.BackColor = Color.FromArgb(200, Color.White)
        Panel1.BackColor = Color.FromArgb(200, Color.White)
        ComposeButton.BackColor = Color.FromArgb(0, Color.White)

        'Load Twitter version.
        If My.Settings.UseTweetdeck = 0 Then
            GeckoWebBrowser1.Navigate("https://tweetdeck.twitter.com")
            ToolStrip1.Visible = False
            ComposeButton.Visible = False
            AppMenuButton.Visible = True
            Panel1.Visible = False
            GeckoWebBrowser1.Dock = DockStyle.Fill
        End If

        If My.Settings.UseTweetdeck = 1 Then
            GeckoWebBrowser1.Navigate("https://twitter.com")
            ToolStrip1.Visible = True
            ComposeButton.Visible = True
            AppMenuButton.Visible = False
            Panel1.Visible = True
            GeckoWebBrowser1.Dock = DockStyle.None
        End If

        Me.KeyPreview = True

        Timer1.Enabled = True

        'Load startup settings.
        If My.Settings.Startup = 0 Then
            WindowState = FormWindowState.Minimized
        ElseIf My.Settings.Startup = 1 Then
        End If

        'Load background settings.
        If My.Settings.DHBHUC = 0 Then
            HubBackground.Image = My.Resources.Background
        End If

        If My.Settings.DHBHUC = 1 Then
            HubBackground.Image = Nothing
        End If

        If My.Settings.DHBHUC = 2 Then
            HubBackground.Load(My.Settings.CB1)
        End If
    End Sub
#End Region
#Region "System Tray"
    Private Sub SysTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SysTrayIcon.MouseDoubleClick
            Try
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                SysTrayIcon.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TweeterMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            If My.Settings.SysTrayMinimise = 0 Then
                If WindowState = FormWindowState.Minimized Then
                    Me.Visible = False
                    SysTrayIcon.Visible = True
                    SysTrayIcon.ShowBalloonTip(1, "Tweeter - Notification", "Tweeter is now running in the background.", ToolTipIcon.Info)
                GC.Collect()
            End If
            ElseIf My.Settings.SysTrayMinimise = 1 Then
            GC.Collect()
        End If
        End Sub

        Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Restore_TMO.Click
            Try
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                SysTrayIcon.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Exit_TMO.Click
            Me.Close()
        End Sub
#End Region
#Region "Tool Bar"
        Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles Back_TSB.Click
            GeckoWebBrowser1.GoBack()
        End Sub

        Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles Forward_TSB.Click
            GeckoWebBrowser1.GoForward()
        End Sub

        Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles Refresh_TSB.Click
            GeckoWebBrowser1.Reload()
        End Sub

        Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles Home_TSB.Click
            GeckoWebBrowser1.Navigate("https://twitter.com")
        End Sub

        Private Sub NotificationButton_Click(sender As Object, e As EventArgs) Handles Notification_TSB.Click
            GeckoWebBrowser1.Navigate("https://twitter.com/i/notifications")
        End Sub

        Private Sub MessagesButton_Click(sender As Object, e As EventArgs) Handles Messages_TSB.Click
            GeckoWebBrowser1.Navigate("https://twitter.com/messages")
        End Sub

        Private Sub ProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Profile_TSM.Click
        If My.Settings.OCA = 0 Then
            TweeterProfile.ShowDialog()
        ElseIf My.Settings.OCA = 1 Then
            GeckoWebBrowser1.Navigate("https://twitter.com/" + My.Settings.ProfileName)
        End If
    End Sub

        Private Sub LikesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Likes_TSM.Click
        If My.Settings.OCA = 0 Then
            TweeterProfile.ShowDialog()
        ElseIf My.Settings.OCA = 1 Then
            GeckoWebBrowser1.Navigate("https://twitter.com/" + My.Settings.ProfileName + "/likes/")
        End If

    End Sub

        Private Sub ListsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Lists_TSM.Click
        If My.Settings.OCA = 0 Then
            TweeterProfile.ShowDialog()
        ElseIf My.Settings.OCA = 1 Then
            GeckoWebBrowser1.Navigate("https://twitter.com/" + My.Settings.ProfileName + "/lists/")
        End If
    End Sub

        Private Sub MentionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Mentions_TSM.Click
            GeckoWebBrowser1.Navigate("https://twitter.com/mentions")
        End Sub

        Private Sub GoToUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GoToUser_TSM.Click
            TweeterGTU.ShowDialog()
        End Sub

        Private Sub TwitterAdsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TwitterAds_TSM.Click
            GeckoWebBrowser1.Navigate("https://ads.twitter.com/")
        End Sub

    Private Sub AnalyticsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Analytics_TSM.Click
        GeckoWebBrowser1.Navigate("https://analytics.twitter.com")
    End Sub

    Private Sub TwitterSettings_TSM_Click(sender As Object, e As EventArgs) Handles TwitterSettings_TSM.Click
        GeckoWebBrowser1.Navigate("https://twitter.com/settings")
    End Sub

    Private Sub KeyboardShortcutsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeyboardShortcutsToolStripMenuItem1.Click
            TweeterShortcuts.ShowDialog()
        End Sub

        Private Sub HelpCentreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpCentreToolStripMenuItem1.Click
            GeckoWebBrowser1.Navigate("https://help.twitter.com/")
        End Sub

        Private Sub AboutTwitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutTwitterToolStripMenuItem1.Click
            GeckoWebBrowser1.Navigate("https://about.twitter.com")
        End Sub

        Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
            GeckoWebBrowser1.Navigate("https://twitter.com/logout")
        End Sub

        Private Sub SettingsPanel_TSM_Click(sender As Object, e As EventArgs) Handles SettingsPanel_TSM.Click
        SettingsPanelGeneral.ShowDialog()
    End Sub

    Private Sub UpdateLogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhatsNew_TSM.Click
        TweeterWhatsNew.ShowDialog()
    End Sub

    Private Sub SendFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendFeedbackToolStripMenuItem.Click
        TweeterFeedback.ShowDialog()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdates_TSM.Click
        Updater.ShowDialog()
    End Sub

    Private Sub Help_TSM_Click(sender As Object, e As EventArgs) Handles Help_TSM.Click
        TweeterHelp.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles About_TSM.Click
        TweeterAbout.ShowDialog()
    End Sub

    Private Sub Exit_MMO_Click(sender As Object, e As EventArgs) Handles Exit_TSM.Click
        Me.Close()
    End Sub
#End Region
#Region "Tweetdeck App Menu"
    Private Sub AppMenuButton_Click(sender As Object, e As EventArgs) Handles AppMenuButton.Click
        TweetdeckAppMenu.Show(AppMenuButton, AppMenuButton.Width, 0)
    End Sub

    Private Sub SettingsPanelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem1.Click
        SettingsPanelGeneral.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem1.Click
        Updater.ShowDialog()
    End Sub

    Private Sub WhatsNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsNewToolStripMenuItem.Click
        TweeterWhatsNew.ShowDialog()
    End Sub

    Private Sub SendFeedbackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SendFeedbackToolStripMenuItem1.Click
        TweeterFeedback.ShowDialog()
    End Sub

    Private Sub AboutTweeterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTweeterToolStripMenuItem.Click
        TweeterAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions"


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = GeckoWebBrowser1.DocumentTitle & " - Tweeter"
        Try
            If GeckoWebBrowser1.DocumentTitle.Length > 25 Then
                Dim source As String = GeckoWebBrowser1.DocumentTitle
                Dim cutdown As String = source.Substring(0, 25)
                SysTrayIcon.Text = "Tweeter - " & cutdown & "..."
            Else
                Dim source As String = GeckoWebBrowser1.DocumentTitle
                SysTrayIcon.Text = "Tweeter - " & source
            End If
        Catch ex As Exception
            errordiag.Label1.Text = "Could not update system tray icon text."
            errordiag.ShowDialog()
        End Try
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        SettingsPanelGeneral.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ComposeButton.Click
        GeckoWebBrowser1.Navigate("https://twitter.com/compose/tweet")
    End Sub

    Private Sub TweetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TweetToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("https://twitter.com/compose/tweet")
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub SysTrayMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SysTrayMenu.Opening
        If My.Settings.UseTweetdeck = 0 Then
            TweetToolStripMenuItem.Enabled = False
            TweetToolStripMenuItem.ToolTipText = "Tweeting from system tray is unavailable on TweetDeck."
        Else
            TweetToolStripMenuItem.Enabled = True
        End If
    End Sub

#End Region
End Class
