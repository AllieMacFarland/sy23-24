﻿Public Class Form1
    Dim c As New Clicker
    Dim c2 As New Clicker
    Dim c3 As New Clicker
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        c.incroment = NumericUpDown1.Value
        c.click()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        c.reset()
        TextBox1.Text = c.count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        c2.incroment = NumericUpDown2.Value
        c2.click()
        TextBox2.Text = c2.count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        c2.reset()
        TextBox2.Text = c2.count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        c3.incroment = NumericUpDown3.Value
        c3.click()
        TextBox3.Text = c3.count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        c3.reset()
        TextBox3.Text = c3.count
    End Sub
End Class
