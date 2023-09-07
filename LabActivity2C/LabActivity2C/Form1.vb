Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub cmdCoins_Click(sender As Object, e As EventArgs) Handles cmdCoins.Click
        Dim intChange As Integer = txtln.Text * 100
        lbl100.Text = "pound coins = " & intChange \ 100
        intChange = intChange Mod 100
        lbl50.Text = "50p coins = " & intChange \ 50
        intChange = intChange Mod 50
        lbl20.Text = "20p coins = " & intChange \ 20
        intChange = intChange Mod 20
        lbl10.Text = "10p coins = " & intChange \ 10
        intChange = intChange Mod 10
        lbl5.Text = "5p coins = " & intChange \ 5
        intChange = intChange Mod 5
        lbl2.Text = "2p coins = " & intChange \ 2
        intChange = intChange Mod 2
        lbl1.Text = "1p coins = " & intChange
    End Sub
End Class
