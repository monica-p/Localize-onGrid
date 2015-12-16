Imports System.Drawing.Graphics

Public Class RTS
    

    Private Sub RTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal

        Dim mygraphics As Graphics = Me.CreateGraphics
        Dim mypen As Pen
        mypen = New Pen(Color.White, 5)

        Dim x1 As Integer = 50
        Dim y1 As Integer = 0
        Dim x2 As Integer = 50
        Dim y2 As Integer = Me.Height
        Dim hx1 As Integer = 0
        Dim hy1 As Integer = 50
        Dim hx2 As Integer = Me.Width
        Dim hy2 As Integer = 50

        'Drawing grid

        'vertical lines of grid
        mygraphics.DrawLine(mypen, x1, y1, x2, y2)
        mygraphics.DrawLine(mypen, x1 + (1 * x1), y1, x2 + (1 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (2 * x1), y1, x2 + (2 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (3 * x1), y1, x2 + (3 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (4 * x1), y1, x2 + (4 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (5 * x1), y1, x2 + (5 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (6 * x1), y1, x2 + (6 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (7 * x1), y1, x2 + (7 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (8 * x1), y1, x2 + (8 * x1), y2)
        mygraphics.DrawLine(mypen, x1 + (9 * x1), y1, x2 + (9 * x1), y2)

        ' Horizontal lines
        mygraphics.DrawLine(mypen, hx1, hy1, hx2, hy2)
        mygraphics.DrawLine(mypen, hx1, hy1 + (1 * hy1), hx2, hy2 + (1 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (2 * hy1), hx2, hy2 + (2 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (3 * hy1), hx2, hy2 + (3 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (4 * hy1), hx2, hy2 + (4 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (5 * hy1), hx2, hy2 + (5 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (6 * hy1), hx2, hy2 + (6 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (7 * hy1), hx2, hy2 + (7 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (8 * hy1), hx2, hy2 + (8 * hy1))
        mygraphics.DrawLine(mypen, hx1, hy1 + (9 * hy1), hx2, hy2 + (9 * hy1))
    End Sub
End Class