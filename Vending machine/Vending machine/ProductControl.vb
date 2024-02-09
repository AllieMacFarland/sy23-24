Public Class ProductControl
    Public Property ProductID As String
    Public Property Price As Decimal
    Public Property Count As Integer
    Public Property Picture As Image

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Picture
        IDLabel.Text = ProductID
        PriceLabel.Text = Price.ToString("C2")
    End Sub
End Class
