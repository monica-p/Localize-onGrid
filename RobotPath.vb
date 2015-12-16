Imports System.Windows.Forms
Public Class RobotPath

    'global variables

    Dim orientation As String
    Dim gridMaxX As Integer = 500
    Dim gridMaxY As Integer = 500


    'conter for elements added in list boxes, used to undo the wrong step, remove last element from list box
    Dim counter As Integer = 0

    'VARIABLES USED TO DRAW PATH
    Dim oldX As Integer = 0
    Dim oldY As Integer = 0
    Dim newX As Integer = 0
    Dim newY As Integer = 0
    Dim coordinate As String = ""


    '=================================== Control Functions ================================================================


    Private Sub RobotPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Direction control box invisible
        Me.grpPATH.Visible = False

        Me.btnSet.Enabled = False
        Me.btnReset.Enabled = False
        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = False


    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim numItems As Integer = Me.lbDirection.Items.Count
        For i As Integer = 0 To numItems - 1
            MAIN.pathstr.Add(Convert.ToString(lbDirection.Items(i)))
        Next
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("R")
        'MAIN.pathstr.Add("L")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")
        'MAIN.pathstr.Add("S")

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid.Click
        Me.btnSet.Enabled = True
        Me.btnReset.Enabled = True
        Me.grpPATH.Visible = True

        drawGrid()

    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        'enable UL button only
        Me.btnUL.Enabled = True
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = False

        'increase counter
        Me.counter += 1

        Me.lbDirection.Items.Add("L")

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.Red, 5)

        If Me.orientation = "E" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        ElseIf Me.orientation = "S" Then
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        ElseIf Me.orientation = "W" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "N" Then
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        End If
    End Sub

    Private Sub btnStraight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStraight.Click
        'enable US button only
        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = True

        'increase counter
        Me.counter += 1

        Me.lbDirection.Items.Add("S")

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.Red, 5)

        If Me.orientation = "E" Then
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        ElseIf Me.orientation = "S" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "W" Then
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        ElseIf Me.orientation = "N" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        End If

    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        'enable UR button only
        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = True
        Me.btnUS.Enabled = False

        'increase counter
        Me.counter += 1

        Me.lbDirection.Items.Add("R")

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.Red, 5)

        If Me.orientation = "E" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "S" Then
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        ElseIf Me.orientation = "W" Then
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        ElseIf Me.orientation = "N" Then
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.coordinate = "(" + Convert.ToString(newX) + " , " + Convert.ToString(newY) + ")"
            Me.lbCoordinates.Items.Add(Me.coordinate)
            Node(newX, newY)
            'validation(newX, newY)
            If Me.newX = CInt(Me.txtGoalX.Text) And Me.newY = CInt(Me.txtGoalY.Text) Then
                MsgBox("GOAL ACHIEVED")
                Me.btnRight.Enabled = False
                Me.btnLeft.Enabled = False
                Me.btnStraight.Enabled = False
            End If
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        End If
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.Green, 1)

        If Me.txtStartX.Text = "" Or Me.txtStartY.Text = "" Or Me.txtGoalY.Text = "" Or Me.txtGoalY.Text = "" Or Me.txtOrientation.Text = "" Then
            MsgBox("DATA MISSING")
        Else
            Me.orientation = Me.txtOrientation.Text
            Me.oldX = CInt(Me.txtStartX.Text)
            Me.oldY = CInt(Me.txtStartY.Text)
            'Me.validation(oldX, oldY)
        End If

        Pathgraphics.DrawLine(Pathpen, CInt(Me.txtStartX.Text), CInt(Me.txtStartY.Text), CInt(Me.txtGoalX.Text), CInt(Me.txtGoalY.Text))
    End Sub


    Private Sub btnUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUS.Click
        counter -= 1

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.White, 5)

        If Me.orientation = "E" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        ElseIf Me.orientation = "S" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "W" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        ElseIf Me.orientation = "N" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        End If

        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = False
    End Sub

    Private Sub btnUL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUL.Click
        counter -= 1

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.White, 5)

        If Me.orientation = "N" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        ElseIf Me.orientation = "E" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "S" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        ElseIf Me.orientation = "W" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        End If

        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = False
    End Sub

    Private Sub btnUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUR.Click
        counter -= 1

        Dim Pathgraphics As Graphics = Me.CreateGraphics
        Dim Pathpen As Pen
        Pathpen = New Pen(Color.White, 5)

        If Me.orientation = "S" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY - 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "E"
        ElseIf Me.orientation = "W" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX + 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "S"
        ElseIf Me.orientation = "N" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX
            Me.newY = Me.oldY + 50
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "W"
        ElseIf Me.orientation = "E" Then
            Me.lbNodes.Items.RemoveAt(counter - 1)
            Me.lbCoordinates.Items.RemoveAt(counter - 1)
            Me.lbDirection.Items.RemoveAt(counter - 1)
            Me.newX = Me.oldX - 50
            Me.newY = Me.oldY
            Pathgraphics.DrawLine(Pathpen, oldX, oldY, newX, newY)
            Me.oldX = Me.newX
            Me.oldY = Me.newY
            Me.orientation = "N"
        End If

        Me.btnUL.Enabled = False
        Me.btnUR.Enabled = False
        Me.btnUS.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        reset()

    End Sub


    '================================================Helper functions======================================================
    ''' <summary>
    ''' Adds ideal type of node to list box
    ''' </summary>
    ''' <param name="coX"></param>
    ''' <param name="coY"></param>
    ''' <remarks></remarks>
    Private Sub Node(ByVal coX, ByVal coY)
        Dim idealNodeType As String

        If (coX = 0 And coY = gridMaxY) Or (coX = gridMaxX And coY = gridMaxY) Or (coX = gridMaxX And coY = 0) Or (coX = 0 And coY = 0) Then
            idealNodeType = "L"
            Me.lbNodes.Items.Add(idealNodeType)
        ElseIf coX = 0 Or coY = 0 Or coX = gridMaxX Or coY = gridMaxY Then
            idealNodeType = "T"
            Me.lbNodes.Items.Add(idealNodeType)
        ElseIf (coX Mod 10 <> 0) Or (coY Mod 10 <> 0) Then
            idealNodeType = "not a node"
            Me.lbNodes.Items.Add(idealNodeType)
        Else
            idealNodeType = "Plus"
            Me.lbNodes.Items.Add(idealNodeType)
        End If
    End Sub

    ''' <summary>
    ''' Draw grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub drawGrid()
        Dim mygraphics As Graphics = Me.CreateGraphics
        Dim mypen As Pen

        'declaration of used varialbes to draw Grid
        Dim x1 As Integer = 50
        Dim y1 As Integer = 0
        Dim x2 As Integer = 50
        Dim y2 As Integer = Me.Height - 100
        Dim hx1 As Integer = 0
        Dim hy1 As Integer = 50
        Dim hx2 As Integer = Me.Width - 450
        Dim hy2 As Integer = 50
        Dim thick As Integer = 5
        mypen = New Pen(Color.White, thick)

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

    ''' <summary>
    ''' Reset all the parameters
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub reset()

        Dim mygraphics As Graphics = Me.CreateGraphics
        Dim pathpen As Pen

        pathpen = New Pen(Color.Black, 1)

        'erase path
        mygraphics.DrawLine(pathpen, CInt(Me.txtStartX.Text), CInt(Me.txtStartY.Text), CInt(Me.txtGoalX.Text), CInt(Me.txtGoalY.Text))

        'redraw grid
        drawGrid()

        'empty text boxes
        Me.txtGoalX.Text = " "
        Me.txtGoalY.Text = ""
        Me.txtStartX.Text = ""
        Me.txtStartY.Text = ""
        Me.txtOrientation.Text = ""

        'disable controls
        Me.grpPATH.Visible = False
        Me.btnSet.Enabled = False

        'Empty list boxes
        For i As Integer = 0 To counter - 1
            Me.lbDirection.Items.RemoveAt(counter - 1 - i)
            Me.lbCoordinates.Items.RemoveAt(counter - 1 - i)
            Me.lbNodes.Items.RemoveAt(counter - 1 - i)
        Next

    End Sub

    ''' <summary>
    ''' Validates the direction
    ''' 
    ''' *** where to call still in confusion ***
    ''' </summary>
    ''' <param name="coX"></param>
    ''' <param name="coY"></param>
    ''' <remarks></remarks>
    Private Sub validation(ByVal coX, ByVal coY)

        If coX = gridMaxX And orientation = "E" Then
            Me.btnStraight.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And orientation = "N" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And orientation = "S" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
        ElseIf coY = gridMaxY And orientation = "S" Then
            Me.btnStraight.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coY = gridMaxY And orientation = "E" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coY = gridMaxY And orientation = "W" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
        ElseIf coY = 0 And orientation = "N" Then
            Me.btnStraight.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coY = 0 And orientation = "E" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
        ElseIf coY = 0 And orientation = "W" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = 0 And orientation = "N" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
        ElseIf coX = 0 And orientation = "S" Then
            Me.btnLeft.Enabled = True
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
        ElseIf coX = 0 And orientation = "W" Then
            Me.btnStraight.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = 0 And coY = 0 And orientation = "E" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
        ElseIf coX = 0 And coY = gridMaxY And orientation = "E" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And coY = gridMaxY And orientation = "E" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And coY = 0 And orientation = "E" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = False
        ElseIf coX = 0 And coY = 0 And orientation = "W" Then
            Me.btnLeft.Enabled = True
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = False
        ElseIf coX = 0 And coY = gridMaxY And orientation = "W" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = False
        ElseIf coX = gridMaxX And coY = gridMaxY And orientation = "W" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = False
        ElseIf coX = gridMaxX And coY = 0 And orientation = "W" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = 0 And coY = 0 And orientation = "N" Then
            Me.btnLeft.Enabled = False
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = False
        ElseIf coX = 0 And coY = gridMaxY And orientation = "N" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = False
        ElseIf coX = gridMaxX And coY = gridMaxY And orientation = "N" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And coY = 0 And orientation = "N" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = True
        ElseIf coX = 0 And coY = 0 And orientation = "S" Then
            Me.btnLeft.Enabled = True
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = True
        ElseIf coX = 0 And coY = gridMaxY And orientation = "S" Then
            Me.btnRight.Enabled = False
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = True
        ElseIf coX = gridMaxX And coY = gridMaxY And orientation = "S" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = False
            Me.btnLeft.Enabled = False
        ElseIf coX = gridMaxX And coY = 0 And orientation = "S" Then
            Me.btnRight.Enabled = True
            Me.btnStraight.Enabled = True
            Me.btnLeft.Enabled = False
        End If
    End Sub

End Class
