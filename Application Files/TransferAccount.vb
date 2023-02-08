Public Class TransferAccount
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
        End If
        If ProgressBar1.Value = 1 Then
            Button1.Enabled = False
            Label2.Text = "Importing..."
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Label2.Text = " "
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Accounts.Show()
    End Sub

    Private Sub TransferAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class