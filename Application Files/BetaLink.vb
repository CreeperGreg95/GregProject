Public Class BetaLink
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/CreeperGreg95/GregProject-Beta/releases")
    End Sub

    Private Sub BetaLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.pseudo
    End Sub
End Class