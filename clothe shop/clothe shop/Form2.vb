Public Class Form2
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F6 As New Form6
        Me.Hide()
        F6.ItemInfo1.picture = Button1.BackgroundImage
        F6.ShowDialog()
    End Sub
End Class