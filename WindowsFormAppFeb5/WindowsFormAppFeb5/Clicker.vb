Public Class Clicker
    Public Property count As Integer
    Public Property incroment As Integer = 1
    Public Sub click()
        count = count + incroment
    End Sub
    Public Sub reset()
        count = 0
    End Sub
End Class
