Public Class Form2
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.ShowDialog()
    End Sub
End Class