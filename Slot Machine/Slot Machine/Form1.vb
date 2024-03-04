Imports System.Net
Imports System.Security.Cryptography

Public Class Form1
    Dim CS As New Coin_Slot
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Spin.Click
        WheelControl1.Spin()
        WheelControl2.Spin()
        WheelControl3.Spin()
        Timer1.Enabled = True
        CS.Spin()
        Label4.Text = CS.Total.ToString("C2")
        Prize.Text = CS.Total.ToString("C2")
        If Label4.Text < 1 Then
            TextBox1.Text = "Please add money"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsertDollar()
        Label4.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CS.InsertQuarter()
        Label4.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsertDime()
        Label4.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.InsertNickle()
        Label4.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = WheelControl1.ItemValue
        Label2.Text = WheelControl2.ItemValue
        Label3.Text = WheelControl3.ItemValue
        If WheelControl1.ItemValue = 0 And WheelControl2.ItemValue = 0 And WheelControl3.ItemValue = 0 Then
            Prize.Text = 2500
        End If
        If WheelControl1.ItemValue = 1 And WheelControl2.ItemValue = 1 And WheelControl3.ItemValue = 1 Then
            Prize.Text = 5000
        End If
        If WheelControl1.ItemValue = 2 And WheelControl2.ItemValue = 2 And WheelControl3.ItemValue = 2 Then
            Prize.Text = 10000
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If WheelControl1.ItemValue = WheelControl2.ItemValue And WheelControl2.ItemValue = WheelControl3.ItemValue Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = Prize.Text
    End Sub
End Class
