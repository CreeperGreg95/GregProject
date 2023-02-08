Public Class DownlaodAccountDLL
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        End If
        If ProgressBar1.Value = 1 Then
            Label2.Text = "Downloading..."
        End If
        If ProgressBar1.Value = 2 Then
            My.Computer.Network.DownloadFile("https://ent.go.zd.fr/GregProject/AccountAPI/account.api", "C:\GP\v.1.5\newapi\beforedll\account.api")
            My.Computer.FileSystem.DeleteFile("C:\GP\v.1.5\newapi\beforedll\account.api",
            FileIO.RecycleOption.DeletePermanently,
            FileIO.UIOption.OnlyErrorDialogs)
        End If
        If ProgressBar1.Value = 99 Then
            TransferAccount.Show()
            Me.Close()
            TransferAccount.Timer1.Start()
        End If
    End Sub

    Private Sub DownlaodAccountDLL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class