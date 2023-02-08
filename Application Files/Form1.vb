Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        BetaAccess.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        PatchNotes.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Accounts.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Nous vous annonçons que nous mettons fin aux mises à jour du logiciel. C'est à dire que le logiciel n'aura pas de nouvelles fonctionnalités et des patchs majeurs.", "Alerte aux utilisateurs ! (1/2)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        MessageBox.Show("C'est à dire aussi que les téléchargements et les comptes sur le serveur ne seront pas accessible. Merci de votre compréhension. L'Univers des Jeux Vidéos, Inc. 😎", "Alerte aux utilisateurs ! (2/2)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = "Updating..."
        Label3.Text = Date.Now.ToLongDateString
        Label1.Text = Date.Now.ToLongTimeString
        Label8.Text = "Last Version : 2.7.0 | Version Inconnue !"
        Label7.Text = "Impossible de contacter le serveur..."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Updates.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RefreshServerInfo.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        WallpaperDownloader.Show()
    End Sub
End Class
