Public Class TweeterGTU
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            errordiag.Label1.Text = "No username has been entered."
            errordiag.ShowDialog()
        Else
            TweeterMain.GeckoWebBrowser1.Navigate("https://twitter.com/" & TextBox1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub TweeterGTU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class