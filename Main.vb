Imports System.IO.Ports

Public Class MAIN

    Public mySerialPort As New SerialPort("COM24")
    Public data As New List(Of String)
    Public flag As Boolean = False

    Public pathstr As New List(Of Char)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Windows state
        Me.WindowState = FormWindowState.Maximized

        'Position of controls
        Me.pb1.Left = 145 / 1200 * Width
        Me.pb2.Left = 800 / 1200 * Width
        Me.lblTitle.Left = 345 / 1200 * Width
        Me.lblTitle2.Left = 333 / 1200 * Width
        Me.grpReceive.Left = 35 / 1200 * Width
        Me.grpRemoteControl.Left = 645 / 1200 * Width
        Me.grpSend.Left = 340 / 1200 * Width

        USART_Initialize()

        AddHandler mySerialPort.DataReceived, AddressOf react

        mySerialPort.Open()

        Timer1.Interval = 500
        Timer1.Start()

        Transmit(mySerialPort, "E")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If flag = True Then
            Me.lbADC.Items.Clear()

            For Each i As Object In data
                Me.lbADC.Items.Add(i)
            Next
            flag = False
        End If
    End Sub

    Private Sub ButtonSpeed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Transmit(mySerialPort, Chr(Me.Motor1.Value))    'motor1

        Transmit(mySerialPort, Chr(Me.Moter2.Value))    'motor2

    End Sub


    '============================================================================================


    Private Sub react(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)

        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        data.Add(Asc(indata))
        flag = True

    End Sub

    Private Sub USART_Initialize()
        mySerialPort.BaudRate = 9600
        mySerialPort.Parity = Parity.None
        mySerialPort.StopBits = StopBits.One
        mySerialPort.DataBits = 8
        mySerialPort.Handshake = Handshake.None
    End Sub

    Private Sub Transmit(ByVal serial As SerialPort, ByVal data As String)
        Try
            If serial.IsOpen = False Then
                serial.Open()
            End If
            serial.RtsEnable = True     'Sets the RTS pin HIGH 
            serial.Write(data)
            'serial.Close()

        Catch ex As Exception
            'serial.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSetpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetpath.Click
        RobotPath.ShowDialog()
    End Sub

    Private Sub btnADC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADC.Click
        For Each ele In pathstr
            MsgBox(ele)
        Next
    End Sub

    Private Sub btnTransmitPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransmitPath.Click
        Me.Opacity = 20
        'RTS.Show()

        'transmit the path directions
        For Each ele In pathstr
            Transmit(mySerialPort, ele)
            For i As Integer = 0 To 10000000
                'do nothing
            Next
        Next

    End Sub
End Class
