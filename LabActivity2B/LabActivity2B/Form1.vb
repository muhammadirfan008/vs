Public Class Form1

    Private Const PI = 3.14159


    Private Sub cmdCal_Click(sender As Object, e As EventArgs) Handles cmdCal.Click
        Dim dblRadius As Double = txtRadius.Text
        txtCirc.Text = 2 * PI * dblRadius
        txtArea.Text = PI * dblRadius ^ 2


    End Sub
End Class
