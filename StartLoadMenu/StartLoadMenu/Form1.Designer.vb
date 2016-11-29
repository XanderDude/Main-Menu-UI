<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYahtzeeStartLoad
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
        Me.pnlStartLoad = New System.Windows.Forms.Panel()
        Me.lblStartMenuTitle = New System.Windows.Forms.Label()
        Me.pnlChoosePlayers = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStartNewGame = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblChoosePlayers = New System.Windows.Forms.Label()
        Me.rad1P = New System.Windows.Forms.RadioButton()
        Me.rad2P = New System.Windows.Forms.RadioButton()
        Me.rad3P = New System.Windows.Forms.RadioButton()
        Me.rad4P = New System.Windows.Forms.RadioButton()
        Me.rad5P = New System.Windows.Forms.RadioButton()
        Me.rad6P = New System.Windows.Forms.RadioButton()
        Me.rad7P = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.pnlStartLoad.SuspendLayout()
        Me.pnlChoosePlayers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStartLoad
        '
        Me.pnlStartLoad.Controls.Add(Me.lblHighScore)
        Me.pnlStartLoad.Controls.Add(Me.lblStartMenuTitle)
        Me.pnlStartLoad.Controls.Add(Me.pnlChoosePlayers)
        Me.pnlStartLoad.Controls.Add(Me.btnExit)
        Me.pnlStartLoad.Controls.Add(Me.btnStartNewGame)
        Me.pnlStartLoad.Controls.Add(Me.btnLoad)
        Me.pnlStartLoad.Location = New System.Drawing.Point(13, 13)
        Me.pnlStartLoad.Name = "pnlStartLoad"
        Me.pnlStartLoad.Size = New System.Drawing.Size(599, 417)
        Me.pnlStartLoad.TabIndex = 0
        '
        'lblStartMenuTitle
        '
        Me.lblStartMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMenuTitle.Location = New System.Drawing.Point(221, 10)
        Me.lblStartMenuTitle.Name = "lblStartMenuTitle"
        Me.lblStartMenuTitle.Size = New System.Drawing.Size(149, 40)
        Me.lblStartMenuTitle.TabIndex = 4
        Me.lblStartMenuTitle.Text = "Yahtzee"
        '
        'pnlChoosePlayers
        '
        Me.pnlChoosePlayers.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlChoosePlayers.Controls.Add(Me.btnConfirm)
        Me.pnlChoosePlayers.Controls.Add(Me.rad7P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad6P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad5P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad4P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad3P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad2P)
        Me.pnlChoosePlayers.Controls.Add(Me.rad1P)
        Me.pnlChoosePlayers.Controls.Add(Me.lblChoosePlayers)
        Me.pnlChoosePlayers.Location = New System.Drawing.Point(156, 222)
        Me.pnlChoosePlayers.Name = "pnlChoosePlayers"
        Me.pnlChoosePlayers.Size = New System.Drawing.Size(250, 150)
        Me.pnlChoosePlayers.TabIndex = 3
        Me.pnlChoosePlayers.Visible = False
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(255, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Close Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStartNewGame
        '
        Me.btnStartNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartNewGame.Location = New System.Drawing.Point(295, 94)
        Me.btnStartNewGame.Name = "btnStartNewGame"
        Me.btnStartNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnStartNewGame.TabIndex = 1
        Me.btnStartNewGame.Text = "New Game"
        Me.btnStartNewGame.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Location = New System.Drawing.Point(214, 94)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Game"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblChoosePlayers
        '
        Me.lblChoosePlayers.AutoSize = True
        Me.lblChoosePlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoosePlayers.Location = New System.Drawing.Point(3, 9)
        Me.lblChoosePlayers.Name = "lblChoosePlayers"
        Me.lblChoosePlayers.Size = New System.Drawing.Size(200, 20)
        Me.lblChoosePlayers.TabIndex = 0
        Me.lblChoosePlayers.Text = "Choose Number Of Players"
        '
        'rad1P
        '
        Me.rad1P.Location = New System.Drawing.Point(3, 71)
        Me.rad1P.Name = "rad1P"
        Me.rad1P.Size = New System.Drawing.Size(32, 24)
        Me.rad1P.TabIndex = 1
        Me.rad1P.TabStop = True
        Me.rad1P.Text = "1"
        Me.rad1P.UseVisualStyleBackColor = True
        '
        'rad2P
        '
        Me.rad2P.Location = New System.Drawing.Point(41, 75)
        Me.rad2P.Name = "rad2P"
        Me.rad2P.Size = New System.Drawing.Size(31, 17)
        Me.rad2P.TabIndex = 2
        Me.rad2P.TabStop = True
        Me.rad2P.Text = "2"
        Me.rad2P.UseVisualStyleBackColor = True
        '
        'rad3P
        '
        Me.rad3P.Location = New System.Drawing.Point(78, 75)
        Me.rad3P.Name = "rad3P"
        Me.rad3P.Size = New System.Drawing.Size(31, 17)
        Me.rad3P.TabIndex = 3
        Me.rad3P.TabStop = True
        Me.rad3P.Text = "3"
        Me.rad3P.UseVisualStyleBackColor = True
        '
        'rad4P
        '
        Me.rad4P.Location = New System.Drawing.Point(115, 75)
        Me.rad4P.Name = "rad4P"
        Me.rad4P.Size = New System.Drawing.Size(31, 17)
        Me.rad4P.TabIndex = 4
        Me.rad4P.TabStop = True
        Me.rad4P.Text = "4"
        Me.rad4P.UseVisualStyleBackColor = True
        '
        'rad5P
        '
        Me.rad5P.Location = New System.Drawing.Point(152, 75)
        Me.rad5P.Name = "rad5P"
        Me.rad5P.Size = New System.Drawing.Size(31, 17)
        Me.rad5P.TabIndex = 5
        Me.rad5P.TabStop = True
        Me.rad5P.Text = "5"
        Me.rad5P.UseVisualStyleBackColor = True
        '
        'rad6P
        '
        Me.rad6P.Location = New System.Drawing.Point(189, 75)
        Me.rad6P.Name = "rad6P"
        Me.rad6P.Size = New System.Drawing.Size(31, 17)
        Me.rad6P.TabIndex = 6
        Me.rad6P.TabStop = True
        Me.rad6P.Text = "6"
        Me.rad6P.UseVisualStyleBackColor = True
        '
        'rad7P
        '
        Me.rad7P.Location = New System.Drawing.Point(226, 75)
        Me.rad7P.Name = "rad7P"
        Me.rad7P.Size = New System.Drawing.Size(31, 17)
        Me.rad7P.TabIndex = 7
        Me.rad7P.TabStop = True
        Me.rad7P.Text = "7"
        Me.rad7P.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(99, 111)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'lblHighScore
        '
        Me.lblHighScore.Location = New System.Drawing.Point(211, 174)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(159, 23)
        Me.lblHighScore.TabIndex = 5
        Me.lblHighScore.Text = "Highscore:"
        '
        'frmYahtzeeStartLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.pnlStartLoad)
        Me.Name = "frmYahtzeeStartLoad"
        Me.Text = "Form1"
        Me.pnlStartLoad.ResumeLayout(False)
        Me.pnlChoosePlayers.ResumeLayout(False)
        Me.pnlChoosePlayers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStartLoad As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStartNewGame As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents pnlChoosePlayers As Panel
    Friend WithEvents lblStartMenuTitle As Label
    Friend WithEvents lblChoosePlayers As Label
    Friend WithEvents rad7P As RadioButton
    Friend WithEvents rad6P As RadioButton
    Friend WithEvents rad5P As RadioButton
    Friend WithEvents rad4P As RadioButton
    Friend WithEvents rad3P As RadioButton
    Friend WithEvents rad2P As RadioButton
    Friend WithEvents rad1P As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblHighScore As Label
End Class
