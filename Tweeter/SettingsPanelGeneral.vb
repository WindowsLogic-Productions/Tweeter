Public Class SettingsPanelGeneral
#Region "Load Settings"
    Private Sub TweeterSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load Startup settings.
        If My.Settings.Startup = 0 Then
            NothingButton.Checked = True
        End If

        If My.Settings.Startup = 1 Then
            SystemTrayButton.Checked = True
        End If

        If My.Settings.Startup = 2 Then
            SettingsPanelButton.Checked = True
        End If

        'Load profile settings.
        If My.Settings.OCA = 0 Then
            GPText.Text = "No Profile Username Set"
        Else
            GPText.Text = My.Settings.ProfileName
            GPSetButton.Enabled = False
        End If

        'Load System Tray Minimising settings.
        If My.Settings.SysTrayMinimise = 0 Then
            SysTrayMinimise.Checked = True
        End If

        If My.Settings.SysTrayMinimise = 1 Then
            SysTrayMinimise.Checked = False
        End If

        'Load Tweetdeck settings.
        If My.Settings.UseTweetdeck = 0 Then
            UseTweetdeck.Checked = True
        End If

        If My.Settings.UseTweetdeck = 1 Then
            UseTweetdeck.Checked = False
        End If

        'Load update settings.
        If My.Settings.Updates = 0 Then
            EnableUpdates.Checked = True
        End If

        If My.Settings.Updates = 1 Then
            DisableUpdates.Checked = True
        End If
    End Sub
#End Region
#Region "Start-Up"
    Private Sub NothingButton_CheckedChanged(sender As Object, e As EventArgs) Handles NothingButton.CheckedChanged
        If NothingButton.Checked = True Then
            My.Settings.Startup = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub SystemTrayButton_CheckedChanged(sender As Object, e As EventArgs) Handles SystemTrayButton.CheckedChanged
        If SystemTrayButton.Checked = True Then
            My.Settings.Startup = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub SettingsPanelButton_CheckedChanged(sender As Object, e As EventArgs) Handles SettingsPanelButton.CheckedChanged
        If SettingsPanelButton.Checked = True Then
            My.Settings.Startup = 2
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Profile"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        GPSetButton.Enabled = True
    End Sub

    Private Sub GPSetButton_Click(sender As Object, e As EventArgs)
        If GPText.Text = Nothing Then
            errordiag.Label1.Text = "No Twitter profile username has been entered."
            errordiag.ShowDialog()
        Else
            My.Settings.ProfileName = GPText.Text()
            My.Settings.OCA = 1
            My.Settings.Save()
            GPSetButton.Enabled = False
            GPSetLabel.Visible = True
        End If

    End Sub
#End Region
#Region "Personalisation"
    Private Sub SysTrayMinimise_CheckedChanged(sender As Object, e As EventArgs)
        If SysTrayMinimise.Checked = True Then
            My.Settings.SysTrayMinimise = 0
            My.Settings.Save()
        ElseIf SysTrayMinimise.Checked = False Then
            My.Settings.SysTrayMinimise = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub UseTweetdeck_CheckedChanged(sender As Object, e As EventArgs) Handles UseTweetdeck.CheckedChanged
        If UseTweetdeck.Checked = True Then
            TweeterMain.ToolStrip1.Visible = False
            TweeterMain.AppMenuButton.Visible = True
            TweeterMain.ComposeButton.Visible = False
            TweeterMain.GeckoWebBrowser1.Dock = Dock.Fill
            TweeterMain.GeckoWebBrowser1.Navigate("https://tweetdeck.twitter.com")
            TweeterMain.Panel1.Visible = False
            My.Settings.UseTweetdeck = 0
            My.Settings.Save()
        ElseIf UseTweetdeck.Checked = False Then
            TweeterMain.ToolStrip1.Visible = True
            TweeterMain.Panel1.Visible = True
            TweeterMain.ComposeButton.Visible = True
            TweeterMain.AppMenuButton.Visible = False
            TweeterMain.ComposeButton.Visible = True
            TweeterMain.GeckoWebBrowser1.Dock = Dock.None
            TweeterMain.GeckoWebBrowser1.Navigate("https://twitter.com")
            My.Settings.UseTweetdeck = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub CustomColourButton_Click(sender As Object, e As EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Updates"
    Private Sub EnableUpdates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableUpdates.CheckedChanged
        If EnableUpdates.Checked = True Then
            My.Settings.Updates = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub DisableUpdates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableUpdates.CheckedChanged
        If DisableUpdates.Checked = True Then
            My.Settings.Updates = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub
#End Region
End Class