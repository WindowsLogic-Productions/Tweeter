Public Class TweeterProfile
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            errordiag.Label1.Text = "No Twitter profile username has been entered."
            errordiag.ShowDialog()
        Else
            My.Settings.ProfileName = TextBox1.Text
            My.Settings.OCA = 1
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub TweeterProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class