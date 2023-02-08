Public Class Accounts
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto:gregproject@gmail.com")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("This isn't an account that ?")
        ElseIf TextBox1.Text = My.Settings.pseudo And TextBox2.Text = My.Settings.password Then
            MessageBox.Show("Saved !")
            Me.Close()
        Else MessageBox.Show("The account infos are busy")
            Me.Close()
            CreateAccount.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Enabled = True
        Label2.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Me.Enabled = True
    End Sub

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class