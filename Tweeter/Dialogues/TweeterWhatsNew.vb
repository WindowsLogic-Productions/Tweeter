Public Class TweeterWhatsNew
    Private Sub TweeterWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            ListBox1.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class