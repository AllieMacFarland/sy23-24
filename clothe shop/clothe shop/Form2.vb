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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim F6 As New Form6
        Me.Hide()
        F6.ItemInfo1.picture = Button2.Image
        F6.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim F6 As New Form6
        Me.Hide()
        F6.ItemInfo1.picture = Button3.Image
        F6.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim F6 As New Form6
        Me.Hide()
        F6.ItemInfo1.picture = Button4.Image
        F6.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub
End Class