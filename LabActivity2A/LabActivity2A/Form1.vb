Public Class Form1
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim intFirst As Integer = txtFirst.Text
        Dim intSecond As Integer = txtSecond.Text
        txtSum.Text = intFirst + intSecond

    End Sub
End Class
