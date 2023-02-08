Public Class CreateAccount
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Accounts.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Saved !")
        My.Settings.pseudo = TextBox1.Text
        My.Settings.email = TextBox2.Text
        My.Settings.password = TextBox3.Text
        My.Settings.confirmed_password = TextBox4.Text
        My.Settings.phone_number = TextBox5.Text
        My.Settings.country = TextBox6.Text
        My.Settings.states = TextBox7.Text
        My.Settings.address_or_city = TextBox8.Text
        Accounts.TextBox1.Enabled = True
        Accounts.TextBox2.Enabled = True
        Accounts.Label1.Enabled = True
        Accounts.Label2.Enabled = True
        Accounts.Button1.Enabled = True
        Me.Close()
        DownlaodAccountDLL.Timer1.Start()
        DownlaodAccountDLL.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        MessageBox.Show("It's laggy no ?")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class