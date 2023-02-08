Public Class BetaAccess
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("An error has occured and we couldn't go to the beta, sorry !")
        End If
        If TextBox1.Text = My.Settings.pseudo And TextBox2.Text = My.Settings.password Then
            Me.Close()
            BetaLink.Show()
        Else
            MessageBox.Show("Verify your informations or recreate an account.")
        End If
    End Sub

    Private Sub BetaAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class