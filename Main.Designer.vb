<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtpath = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.lbADC = New System.Windows.Forms.ListBox
        Me.Motor1 = New System.Windows.Forms.NumericUpDown
        Me.Moter2 = New System.Windows.Forms.NumericUpDown
        Me.grpReceive = New System.Windows.Forms.GroupBox
        Me.lblPath = New System.Windows.Forms.Label
        Me.lblADCValues = New System.Windows.Forms.Label
        Me.grpSend = New System.Windows.Forms.GroupBox
        Me.btnSetpath = New System.Windows.Forms.Button
        Me.btnADC = New System.Windows.Forms.Button
        Me.lblMotor2 = New System.Windows.Forms.Label
        Me.lblMotor1 = New System.Windows.Forms.Label
        Me.grpRemoteControl = New System.Windows.Forms.GroupBox
        Me.pb2 = New System.Windows.Forms.PictureBox
        Me.pb1 = New System.Windows.Forms.PictureBox
        Me.lblTitle2 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblTitle3 = New System.Windows.Forms.Label
        Me.btnTransmitPath = New System.Windows.Forms.Button
        CType(Me.Motor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Moter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReceive.SuspendLayout()
        Me.grpSend.SuspendLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txtpath
        '
        Me.txtpath.Location = New System.Drawing.Point(78, 41)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(198, 33)
        Me.txtpath.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Navy
        Me.btnSend.Location = New System.Drawing.Point(147, 121)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(89, 35)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'lbADC
        '
        Me.lbADC.FormattingEnabled = True
        Me.lbADC.ItemHeight = 25
        Me.lbADC.Location = New System.Drawing.Point(138, 105)
        Me.lbADC.Name = "lbADC"
        Me.lbADC.Size = New System.Drawing.Size(120, 129)
        Me.lbADC.TabIndex = 2
        '
        'Motor1
        '
        Me.Motor1.Location = New System.Drawing.Point(147, 36)
        Me.Motor1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Motor1.Name = "Motor1"
        Me.Motor1.Size = New System.Drawing.Size(64, 33)
        Me.Motor1.TabIndex = 4
        '
        'Moter2
        '
        Me.Moter2.Location = New System.Drawing.Point(147, 82)
        Me.Moter2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Moter2.Name = "Moter2"
        Me.Moter2.Size = New System.Drawing.Size(64, 33)
        Me.Moter2.TabIndex = 5
        '
        'grpReceive
        '
        Me.grpReceive.BackColor = System.Drawing.Color.Transparent
        Me.grpReceive.Controls.Add(Me.lblPath)
        Me.grpReceive.Controls.Add(Me.lblADCValues)
        Me.grpReceive.Controls.Add(Me.lbADC)
        Me.grpReceive.Controls.Add(Me.txtpath)
        Me.grpReceive.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReceive.ForeColor = System.Drawing.Color.White
        Me.grpReceive.Location = New System.Drawing.Point(34, 310)
        Me.grpReceive.Name = "grpReceive"
        Me.grpReceive.Size = New System.Drawing.Size(282, 323)
        Me.grpReceive.TabIndex = 6
        Me.grpReceive.TabStop = False
        Me.grpReceive.Text = "RECEIVE"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPath.ForeColor = System.Drawing.Color.White
        Me.lblPath.Location = New System.Drawing.Point(18, 49)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(40, 19)
        Me.lblPath.TabIndex = 4
        Me.lblPath.Text = "path"
        '
        'lblADCValues
        '
        Me.lblADCValues.AutoSize = True
        Me.lblADCValues.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblADCValues.ForeColor = System.Drawing.Color.White
        Me.lblADCValues.Location = New System.Drawing.Point(18, 111)
        Me.lblADCValues.Name = "lblADCValues"
        Me.lblADCValues.Size = New System.Drawing.Size(104, 19)
        Me.lblADCValues.TabIndex = 3
        Me.lblADCValues.Text = "ADC VALUES"
        '
        'grpSend
        '
        Me.grpSend.BackColor = System.Drawing.Color.Transparent
        Me.grpSend.Controls.Add(Me.btnTransmitPath)
        Me.grpSend.Controls.Add(Me.btnSetpath)
        Me.grpSend.Controls.Add(Me.btnADC)
        Me.grpSend.Controls.Add(Me.lblMotor2)
        Me.grpSend.Controls.Add(Me.btnSend)
        Me.grpSend.Controls.Add(Me.lblMotor1)
        Me.grpSend.Controls.Add(Me.Motor1)
        Me.grpSend.Controls.Add(Me.Moter2)
        Me.grpSend.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSend.ForeColor = System.Drawing.Color.White
        Me.grpSend.Location = New System.Drawing.Point(340, 310)
        Me.grpSend.Name = "grpSend"
        Me.grpSend.Size = New System.Drawing.Size(282, 323)
        Me.grpSend.TabIndex = 7
        Me.grpSend.TabStop = False
        Me.grpSend.Text = "SEND"
        '
        'btnSetpath
        '
        Me.btnSetpath.BackColor = System.Drawing.Color.Navy
        Me.btnSetpath.Location = New System.Drawing.Point(32, 204)
        Me.btnSetpath.Name = "btnSetpath"
        Me.btnSetpath.Size = New System.Drawing.Size(224, 35)
        Me.btnSetpath.TabIndex = 9
        Me.btnSetpath.Text = "SET PATH"
        Me.btnSetpath.UseVisualStyleBackColor = False
        '
        'btnADC
        '
        Me.btnADC.BackColor = System.Drawing.Color.Navy
        Me.btnADC.Location = New System.Drawing.Point(32, 163)
        Me.btnADC.Name = "btnADC"
        Me.btnADC.Size = New System.Drawing.Size(224, 35)
        Me.btnADC.TabIndex = 8
        Me.btnADC.Text = "SET ADC VALUES"
        Me.btnADC.UseVisualStyleBackColor = False
        '
        'lblMotor2
        '
        Me.lblMotor2.AutoSize = True
        Me.lblMotor2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor2.ForeColor = System.Drawing.Color.White
        Me.lblMotor2.Location = New System.Drawing.Point(28, 90)
        Me.lblMotor2.Name = "lblMotor2"
        Me.lblMotor2.Size = New System.Drawing.Size(116, 19)
        Me.lblMotor2.TabIndex = 7
        Me.lblMotor2.Text = "% Duty Cycle2"
        '
        'lblMotor1
        '
        Me.lblMotor1.AutoSize = True
        Me.lblMotor1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor1.ForeColor = System.Drawing.Color.White
        Me.lblMotor1.Location = New System.Drawing.Point(28, 41)
        Me.lblMotor1.Name = "lblMotor1"
        Me.lblMotor1.Size = New System.Drawing.Size(113, 19)
        Me.lblMotor1.TabIndex = 6
        Me.lblMotor1.Text = "% Duty Cycle1"
        '
        'grpRemoteControl
        '
        Me.grpRemoteControl.BackColor = System.Drawing.Color.Transparent
        Me.grpRemoteControl.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRemoteControl.ForeColor = System.Drawing.Color.White
        Me.grpRemoteControl.Location = New System.Drawing.Point(646, 173)
        Me.grpRemoteControl.Name = "grpRemoteControl"
        Me.grpRemoteControl.Size = New System.Drawing.Size(486, 460)
        Me.grpRemoteControl.TabIndex = 7
        Me.grpRemoteControl.TabStop = False
        Me.grpRemoteControl.Text = "REMOTE CONTROL"
        '
        'pb2
        '
        Me.pb2.Image = Global.MiniProject_13.My.Resources.Resources.AI_lowres
        Me.pb2.Location = New System.Drawing.Point(798, 27)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(173, 117)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 18
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.Image = Global.MiniProject_13.My.Resources.Resources.AI_lowres
        Me.pb1.Location = New System.Drawing.Point(143, 27)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(173, 117)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 17
        Me.pb1.TabStop = False
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Goudy Stout", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle2.Location = New System.Drawing.Point(347, 97)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(423, 26)
        Me.lblTitle2.TabIndex = 16
        Me.lblTitle2.Text = "INTELLIGENT SYSTEMS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Stout", 20.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(345, 44)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(431, 37)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "LOCALIZATION..."
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle3.Font = New System.Drawing.Font("Goudy Stout", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle3.Location = New System.Drawing.Point(27, 221)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(374, 64)
        Me.lblTitle3.TabIndex = 19
        Me.lblTitle3.Text = "PARAMETERS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMMUNICATED"
        '
        'btnTransmitPath
        '
        Me.btnTransmitPath.BackColor = System.Drawing.Color.Navy
        Me.btnTransmitPath.Location = New System.Drawing.Point(32, 245)
        Me.btnTransmitPath.Name = "btnTransmitPath"
        Me.btnTransmitPath.Size = New System.Drawing.Size(224, 35)
        Me.btnTransmitPath.TabIndex = 10
        Me.btnTransmitPath.Text = "TRANSMIT PATH"
        Me.btnTransmitPath.UseVisualStyleBackColor = False
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniProject_13.My.Resources.Resources._394817
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.lblTitle3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpSend)
        Me.Controls.Add(Me.grpRemoteControl)
        Me.Controls.Add(Me.grpReceive)
        Me.Name = "MAIN"
        Me.Text = "REMOTE CONTROL"
        CType(Me.Motor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Moter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReceive.ResumeLayout(False)
        Me.grpReceive.PerformLayout()
        Me.grpSend.ResumeLayout(False)
        Me.grpSend.PerformLayout()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lbADC As System.Windows.Forms.ListBox
    Friend WithEvents Motor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Moter2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpReceive As System.Windows.Forms.GroupBox
    Friend WithEvents grpSend As System.Windows.Forms.GroupBox
    Friend WithEvents grpRemoteControl As System.Windows.Forms.GroupBox
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents lblADCValues As System.Windows.Forms.Label
    Friend WithEvents lblMotor2 As System.Windows.Forms.Label
    Friend WithEvents lblMotor1 As System.Windows.Forms.Label
    Friend WithEvents btnADC As System.Windows.Forms.Button
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle3 As System.Windows.Forms.Label
    Friend WithEvents btnSetpath As System.Windows.Forms.Button
    Friend WithEvents btnTransmitPath As System.Windows.Forms.Button

End Class
