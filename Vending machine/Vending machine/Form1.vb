﻿Public Class Form1
    Dim CS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.InsertQuarter()
        Label1.Text = CS.Total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsertDollar()
        Label1.Text = CS.Total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsertNickle()
        Label1.Text = CS.Total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsertDime()
        Label1.Text = CS.Total
    End Sub
End Class
