Public Class ItemInfo
    Public Property picture As Image
        Set(value As Image)
            PictureBox1.Image = value
        End Set
        Get
            Return PictureBox1.Image
        End Get
    End Property
End Class
