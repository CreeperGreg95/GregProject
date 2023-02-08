Public Class Updates
    Private Sub Updates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Form1.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class