Public Class TweeterAbout
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TweeterAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load version number and licence.
        Variables.ParseVariables(VerInfo)
        Variables.ParseVariables(Copyright)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://windowslogic.co.uk/appagreement.php")
    End Sub

    Private Sub MoreButton_Click(sender As Object, e As EventArgs) Handles MoreButton.Click
        TweeterDedicate.ShowDialog()
    End Sub
End Class