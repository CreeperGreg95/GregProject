Public Class RefreshingServer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        End If
        If ProgressBar1.Value = 2 Then
            Form1.Label8.Text = "Refreshing, please wait..."
        End If
        If ProgressBar1.Value = 90 Then
            Form1.Label8.Text = "You are up-to-date (No updates available)"
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form1.Label8.Text = "Last Version : 2.2.1 | You are up-to-date !"
            Me.Close()
        End If
    End Sub

    Private Sub RefreshingServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class