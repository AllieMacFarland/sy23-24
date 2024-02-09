Public Class Form1
    Dim WithEvents CS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.InsertQuarter()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsertDollar()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsertNickle()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsertDime()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(D As Integer, Q As Integer, DM As Integer, N As Integer) Handles CS.CoinReturnEvent
        If D > 0 Then
            Dollars.Visible = True
        Else
            Dollars.Visible = False
        End If
        If Q > 0 Then
            Quarter.Visible = True
        Else
            Quarter.Visible = False
        End If
        If N > 0 Then
            Nickles.Visible = True
        Else
            Nickles.Visible = False
        End If
        If DM > 0 Then
            Dimes.Visible = True
        Else
            Dimes.Visible = False
        End If
    End Sub
End Class
