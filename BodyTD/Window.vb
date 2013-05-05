Public Class Window
    Private Sub DrawGrid(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim pen As Pen = New Pen(Color.Red, 10)
        e.Graphics.DrawLine(pen, New Point(10, 10), New Point(100, 100))
        e.Graphics.DrawLine(pen, New Point(10, 100), New Point(100, 10))

        e.Graphics.DrawRectangle(
    End Sub
End Class
