<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotPath
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.btnGrid = New System.Windows.Forms.Button
        Me.lbDirection = New System.Windows.Forms.ListBox
        Me.btnLeft = New System.Windows.Forms.Button
        Me.btnRight = New System.Windows.Forms.Button
        Me.btnStraight = New System.Windows.Forms.Button
        Me.grpPATH = New System.Windows.Forms.GroupBox
        Me.btnUL = New System.Windows.Forms.Button
        Me.btnUS = New System.Windows.Forms.Button
        Me.btnUR = New System.Windows.Forms.Button
        Me.lbNodes = New System.Windows.Forms.ListBox
        Me.lbCoordinates = New System.Windows.Forms.ListBox
        Me.btnCompute = New System.Windows.Forms.Button
        Me.txtStartY = New System.Windows.Forms.TextBox
        Me.lblStartX = New System.Windows.Forms.Label
        Me.txtStartX = New System.Windows.Forms.TextBox
        Me.lblStartY = New System.Windows.Forms.Label
        Me.txtGoalY = New System.Windows.Forms.TextBox
        Me.lblGoalX = New System.Windows.Forms.Label
        Me.txtGoalX = New System.Windows.Forms.TextBox
        Me.lblGoalY = New System.Windows.Forms.Label
        Me.lblGoal = New System.Windows.Forms.Label
        Me.lblStart = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        Me.lblDirection = New System.Windows.Forms.Label
        Me.lblEast = New System.Windows.Forms.Label
        Me.lblSouth = New System.Windows.Forms.Label
        Me.lblWest = New System.Windows.Forms.Label
        Me.lblNorth = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.lblOrientation = New System.Windows.Forms.Label
        Me.txtOrientation = New System.Windows.Forms.TextBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpPATH.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(786, 531)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'btnGrid
        '
        Me.btnGrid.Location = New System.Drawing.Point(838, 12)
        Me.btnGrid.Name = "btnGrid"
        Me.btnGrid.Size = New System.Drawing.Size(84, 23)
        Me.btnGrid.TabIndex = 1
        Me.btnGrid.Text = "GRID"
        Me.btnGrid.UseVisualStyleBackColor = True
        '
        'lbDirection
        '
        Me.lbDirection.FormattingEnabled = True
        Me.lbDirection.Location = New System.Drawing.Point(14, 118)
        Me.lbDirection.Name = "lbDirection"
        Me.lbDirection.Size = New System.Drawing.Size(70, 160)
        Me.lbDirection.TabIndex = 9
        '
        'btnLeft
        '
        Me.btnLeft.ForeColor = System.Drawing.Color.Black
        Me.btnLeft.Location = New System.Drawing.Point(19, 71)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(69, 36)
        Me.btnLeft.TabIndex = 10
        Me.btnLeft.Text = "LEFT"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.ForeColor = System.Drawing.Color.Black
        Me.btnRight.Location = New System.Drawing.Point(208, 71)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(70, 36)
        Me.btnRight.TabIndex = 11
        Me.btnRight.Text = "RIGHT"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnStraight
        '
        Me.btnStraight.ForeColor = System.Drawing.Color.Black
        Me.btnStraight.Location = New System.Drawing.Point(103, 13)
        Me.btnStraight.Name = "btnStraight"
        Me.btnStraight.Size = New System.Drawing.Size(94, 29)
        Me.btnStraight.TabIndex = 12
        Me.btnStraight.Text = "STRAIGHT"
        Me.btnStraight.UseVisualStyleBackColor = True
        '
        'grpPATH
        '
        Me.grpPATH.Controls.Add(Me.btnUL)
        Me.grpPATH.Controls.Add(Me.btnUS)
        Me.grpPATH.Controls.Add(Me.btnUR)
        Me.grpPATH.Controls.Add(Me.lbNodes)
        Me.grpPATH.Controls.Add(Me.lbDirection)
        Me.grpPATH.Controls.Add(Me.lbCoordinates)
        Me.grpPATH.Controls.Add(Me.btnCompute)
        Me.grpPATH.Controls.Add(Me.btnStraight)
        Me.grpPATH.Controls.Add(Me.btnRight)
        Me.grpPATH.Controls.Add(Me.btnLeft)
        Me.grpPATH.ForeColor = System.Drawing.Color.White
        Me.grpPATH.Location = New System.Drawing.Point(651, 207)
        Me.grpPATH.Name = "grpPATH"
        Me.grpPATH.Size = New System.Drawing.Size(290, 321)
        Me.grpPATH.TabIndex = 13
        Me.grpPATH.TabStop = False
        Me.grpPATH.Text = "SETTING PATH"
        '
        'btnUL
        '
        Me.btnUL.ForeColor = System.Drawing.Color.Black
        Me.btnUL.Location = New System.Drawing.Point(94, 78)
        Me.btnUL.Name = "btnUL"
        Me.btnUL.Size = New System.Drawing.Size(43, 22)
        Me.btnUL.TabIndex = 21
        Me.btnUL.Text = "UL"
        Me.btnUL.UseVisualStyleBackColor = True
        '
        'btnUS
        '
        Me.btnUS.ForeColor = System.Drawing.Color.Black
        Me.btnUS.Location = New System.Drawing.Point(128, 50)
        Me.btnUS.Name = "btnUS"
        Me.btnUS.Size = New System.Drawing.Size(43, 22)
        Me.btnUS.TabIndex = 20
        Me.btnUS.Text = "US"
        Me.btnUS.UseVisualStyleBackColor = True
        '
        'btnUR
        '
        Me.btnUR.ForeColor = System.Drawing.Color.Black
        Me.btnUR.Location = New System.Drawing.Point(159, 78)
        Me.btnUR.Name = "btnUR"
        Me.btnUR.Size = New System.Drawing.Size(43, 22)
        Me.btnUR.TabIndex = 19
        Me.btnUR.Text = "UR"
        Me.btnUR.UseVisualStyleBackColor = True
        '
        'lbNodes
        '
        Me.lbNodes.FormattingEnabled = True
        Me.lbNodes.Location = New System.Drawing.Point(203, 118)
        Me.lbNodes.Name = "lbNodes"
        Me.lbNodes.Size = New System.Drawing.Size(81, 160)
        Me.lbNodes.TabIndex = 15
        '
        'lbCoordinates
        '
        Me.lbCoordinates.FormattingEnabled = True
        Me.lbCoordinates.Location = New System.Drawing.Point(90, 118)
        Me.lbCoordinates.Name = "lbCoordinates"
        Me.lbCoordinates.Size = New System.Drawing.Size(107, 160)
        Me.lbCoordinates.TabIndex = 14
        '
        'btnCompute
        '
        Me.btnCompute.ForeColor = System.Drawing.Color.Black
        Me.btnCompute.Location = New System.Drawing.Point(103, 293)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(88, 22)
        Me.btnCompute.TabIndex = 13
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtStartY
        '
        Me.txtStartY.Location = New System.Drawing.Point(862, 51)
        Me.txtStartY.Name = "txtStartY"
        Me.txtStartY.Size = New System.Drawing.Size(56, 20)
        Me.txtStartY.TabIndex = 16
        '
        'lblStartX
        '
        Me.lblStartX.AutoSize = True
        Me.lblStartX.ForeColor = System.Drawing.Color.White
        Me.lblStartX.Location = New System.Drawing.Point(759, 54)
        Me.lblStartX.Name = "lblStartX"
        Me.lblStartX.Size = New System.Drawing.Size(14, 13)
        Me.lblStartX.TabIndex = 18
        Me.lblStartX.Text = "X"
        '
        'txtStartX
        '
        Me.txtStartX.Location = New System.Drawing.Point(779, 51)
        Me.txtStartX.Name = "txtStartX"
        Me.txtStartX.Size = New System.Drawing.Size(56, 20)
        Me.txtStartX.TabIndex = 17
        '
        'lblStartY
        '
        Me.lblStartY.AutoSize = True
        Me.lblStartY.ForeColor = System.Drawing.Color.White
        Me.lblStartY.Location = New System.Drawing.Point(846, 54)
        Me.lblStartY.Name = "lblStartY"
        Me.lblStartY.Size = New System.Drawing.Size(14, 13)
        Me.lblStartY.TabIndex = 19
        Me.lblStartY.Text = "Y"
        '
        'txtGoalY
        '
        Me.txtGoalY.Location = New System.Drawing.Point(866, 101)
        Me.txtGoalY.Name = "txtGoalY"
        Me.txtGoalY.Size = New System.Drawing.Size(56, 20)
        Me.txtGoalY.TabIndex = 20
        '
        'lblGoalX
        '
        Me.lblGoalX.AutoSize = True
        Me.lblGoalX.ForeColor = System.Drawing.Color.White
        Me.lblGoalX.Location = New System.Drawing.Point(759, 104)
        Me.lblGoalX.Name = "lblGoalX"
        Me.lblGoalX.Size = New System.Drawing.Size(14, 13)
        Me.lblGoalX.TabIndex = 22
        Me.lblGoalX.Text = "X"
        '
        'txtGoalX
        '
        Me.txtGoalX.Location = New System.Drawing.Point(779, 101)
        Me.txtGoalX.Name = "txtGoalX"
        Me.txtGoalX.Size = New System.Drawing.Size(56, 20)
        Me.txtGoalX.TabIndex = 21
        '
        'lblGoalY
        '
        Me.lblGoalY.AutoSize = True
        Me.lblGoalY.ForeColor = System.Drawing.Color.White
        Me.lblGoalY.Location = New System.Drawing.Point(846, 104)
        Me.lblGoalY.Name = "lblGoalY"
        Me.lblGoalY.Size = New System.Drawing.Size(14, 13)
        Me.lblGoalY.TabIndex = 23
        Me.lblGoalY.Text = "Y"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.ForeColor = System.Drawing.Color.White
        Me.lblGoal.Location = New System.Drawing.Point(690, 101)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(49, 24)
        Me.lblGoal.TabIndex = 24
        Me.lblGoal.Text = "Goal"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(690, 51)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(46, 24)
        Me.lblStart.TabIndex = 25
        Me.lblStart.Text = "Start"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(838, 178)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(84, 23)
        Me.btnSet.TabIndex = 26
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.ForeColor = System.Drawing.Color.White
        Me.lblDirection.Location = New System.Drawing.Point(585, 275)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(15, 13)
        Me.lblDirection.TabIndex = 27
        Me.lblDirection.Text = "D"
        '
        'lblEast
        '
        Me.lblEast.AutoSize = True
        Me.lblEast.ForeColor = System.Drawing.Color.White
        Me.lblEast.Location = New System.Drawing.Point(631, 275)
        Me.lblEast.Name = "lblEast"
        Me.lblEast.Size = New System.Drawing.Size(14, 13)
        Me.lblEast.TabIndex = 28
        Me.lblEast.Text = "E"
        '
        'lblSouth
        '
        Me.lblSouth.AutoSize = True
        Me.lblSouth.ForeColor = System.Drawing.Color.White
        Me.lblSouth.Location = New System.Drawing.Point(585, 335)
        Me.lblSouth.Name = "lblSouth"
        Me.lblSouth.Size = New System.Drawing.Size(14, 13)
        Me.lblSouth.TabIndex = 29
        Me.lblSouth.Text = "S"
        '
        'lblWest
        '
        Me.lblWest.AutoSize = True
        Me.lblWest.ForeColor = System.Drawing.Color.White
        Me.lblWest.Location = New System.Drawing.Point(531, 275)
        Me.lblWest.Name = "lblWest"
        Me.lblWest.Size = New System.Drawing.Size(18, 13)
        Me.lblWest.TabIndex = 30
        Me.lblWest.Text = "W"
        '
        'lblNorth
        '
        Me.lblNorth.AutoSize = True
        Me.lblNorth.ForeColor = System.Drawing.Color.White
        Me.lblNorth.Location = New System.Drawing.Point(585, 220)
        Me.lblNorth.Name = "lblNorth"
        Me.lblNorth.Size = New System.Drawing.Size(15, 13)
        Me.lblNorth.TabIndex = 31
        Me.lblNorth.Text = "N"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(944, 572)
        Me.ShapeContainer1.TabIndex = 32
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 598
        Me.LineShape4.X2 = 633
        Me.LineShape4.Y1 = 284
        Me.LineShape4.Y2 = 284
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 548
        Me.LineShape3.X2 = 583
        Me.LineShape3.Y1 = 283
        Me.LineShape3.Y2 = 283
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 591
        Me.LineShape2.X2 = 591
        Me.LineShape2.Y1 = 290
        Me.LineShape2.Y2 = 332
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 591
        Me.LineShape1.X2 = 591
        Me.LineShape1.Y1 = 236
        Me.LineShape1.Y2 = 278
        '
        'lblOrientation
        '
        Me.lblOrientation.AutoSize = True
        Me.lblOrientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrientation.ForeColor = System.Drawing.Color.White
        Me.lblOrientation.Location = New System.Drawing.Point(690, 150)
        Me.lblOrientation.Name = "lblOrientation"
        Me.lblOrientation.Size = New System.Drawing.Size(84, 24)
        Me.lblOrientation.TabIndex = 33
        Me.lblOrientation.Text = "Direction"
        '
        'txtOrientation
        '
        Me.txtOrientation.Location = New System.Drawing.Point(779, 150)
        Me.txtOrientation.Name = "txtOrientation"
        Me.txtOrientation.Size = New System.Drawing.Size(56, 20)
        Me.txtOrientation.TabIndex = 34
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(738, 178)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 23)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'RobotPath
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(944, 572)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtOrientation)
        Me.Controls.Add(Me.lblOrientation)
        Me.Controls.Add(Me.lblNorth)
        Me.Controls.Add(Me.lblWest)
        Me.Controls.Add(Me.lblSouth)
        Me.Controls.Add(Me.lblEast)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.txtGoalY)
        Me.Controls.Add(Me.lblGoalX)
        Me.Controls.Add(Me.txtGoalX)
        Me.Controls.Add(Me.lblGoalY)
        Me.Controls.Add(Me.txtStartY)
        Me.Controls.Add(Me.grpPATH)
        Me.Controls.Add(Me.lblStartX)
        Me.Controls.Add(Me.txtStartX)
        Me.Controls.Add(Me.btnGrid)
        Me.Controls.Add(Me.lblStartY)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RobotPath"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RobotPath"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpPATH.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents btnGrid As System.Windows.Forms.Button
    Friend WithEvents lbDirection As System.Windows.Forms.ListBox
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnStraight As System.Windows.Forms.Button
    Friend WithEvents grpPATH As System.Windows.Forms.GroupBox
    Friend WithEvents txtStartY As System.Windows.Forms.TextBox
    Friend WithEvents lblStartX As System.Windows.Forms.Label
    Friend WithEvents txtStartX As System.Windows.Forms.TextBox
    Friend WithEvents lblStartY As System.Windows.Forms.Label
    Friend WithEvents txtGoalY As System.Windows.Forms.TextBox
    Friend WithEvents lblGoalX As System.Windows.Forms.Label
    Friend WithEvents txtGoalX As System.Windows.Forms.TextBox
    Friend WithEvents lblGoalY As System.Windows.Forms.Label
    Friend WithEvents lblGoal As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents lblEast As System.Windows.Forms.Label
    Friend WithEvents lblSouth As System.Windows.Forms.Label
    Friend WithEvents lblWest As System.Windows.Forms.Label
    Friend WithEvents lblNorth As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblOrientation As System.Windows.Forms.Label
    Friend WithEvents txtOrientation As System.Windows.Forms.TextBox
    Friend WithEvents lbCoordinates As System.Windows.Forms.ListBox
    Friend WithEvents lbNodes As System.Windows.Forms.ListBox
    Friend WithEvents btnUR As System.Windows.Forms.Button
    Friend WithEvents btnUL As System.Windows.Forms.Button
    Friend WithEvents btnUS As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
