Public Class WallpaperDownloader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://ent.go.zd.fr/GregProject/Wallpapers/gregproject_resources_1_v.2.0.1_christmas.jpg")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://ent.go.zd.fr/GregProject/Wallpapers/image_janvier_2022_v.2.2.0.jfif")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://ent.go.zd.fr/GregProject/Wallpapers/image_nouvel_an_2022_v.2.1.1.jpg")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://ent.go.zd.fr/GregProject/Wallpapers/pexels-johannes-plenio-2850287.jpg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://ent.go.zd.fr/GregProject/Wallpapers/wallpaper%20gp%20v.2.3.1.jpg")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class