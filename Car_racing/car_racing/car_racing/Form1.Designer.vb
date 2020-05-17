<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy1_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2_mover = New System.Windows.Forms.Timer(Me.components)
        Me.table_score = New System.Windows.Forms.Label()
        Me.speed_incrs = New System.Windows.Forms.Label()
        Me.Pause_game = New System.Windows.Forms.Timer(Me.components)
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.enemy = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rest_game = New System.Windows.Forms.Button()
        Me.Ex_game = New System.Windows.Forms.Button()
        Me.end_game = New System.Windows.Forms.PictureBox()
        Me.paused_text = New System.Windows.Forms.PictureBox()
        Me.player_car = New System.Windows.Forms.PictureBox()
        Me.paused_game = New System.Windows.Forms.PictureBox()
        Me.cont_butt = New System.Windows.Forms.PictureBox()
        Me.Ext_butt = New System.Windows.Forms.PictureBox()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.end_game, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paused_text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paused_game, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cont_butt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ext_butt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'left_mover
        '
        Me.left_mover.Interval = 10
        '
        'right_mover
        '
        Me.right_mover.Interval = 10
        '
        'enemy_mover
        '
        Me.enemy_mover.Enabled = True
        Me.enemy_mover.Interval = 10
        '
        'enemy1_mover
        '
        Me.enemy1_mover.Enabled = True
        Me.enemy1_mover.Interval = 10
        '
        'enemy2_mover
        '
        Me.enemy2_mover.Enabled = True
        Me.enemy2_mover.Interval = 10
        '
        'table_score
        '
        Me.table_score.AutoSize = True
        Me.table_score.BackColor = System.Drawing.Color.Transparent
        Me.table_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.table_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table_score.ForeColor = System.Drawing.Color.Lime
        Me.table_score.Location = New System.Drawing.Point(10, 39)
        Me.table_score.Name = "table_score"
        Me.table_score.Size = New System.Drawing.Size(79, 24)
        Me.table_score.TabIndex = 17
        Me.table_score.Text = "score 0"
        '
        'speed_incrs
        '
        Me.speed_incrs.AutoSize = True
        Me.speed_incrs.BackColor = System.Drawing.Color.Transparent
        Me.speed_incrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.speed_incrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed_incrs.ForeColor = System.Drawing.Color.Lime
        Me.speed_incrs.Location = New System.Drawing.Point(242, 39)
        Me.speed_incrs.Name = "speed_incrs"
        Me.speed_incrs.Size = New System.Drawing.Size(85, 24)
        Me.speed_incrs.TabIndex = 18
        Me.speed_incrs.Text = "speed 0"
        '
        'Pause_game
        '
        Me.Pause_game.Interval = 1
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.Transparent
        Me.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(126, 31)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(42, 87)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 14
        Me.enemy2.TabStop = False
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.Transparent
        Me.enemy1.Image = CType(resources.GetObject("enemy1.Image"), System.Drawing.Image)
        Me.enemy1.Location = New System.Drawing.Point(62, 164)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(42, 86)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 13
        Me.enemy1.TabStop = False
        '
        'enemy
        '
        Me.enemy.BackColor = System.Drawing.Color.Transparent
        Me.enemy.Image = CType(resources.GetObject("enemy.Image"), System.Drawing.Image)
        Me.enemy.Location = New System.Drawing.Point(224, 124)
        Me.enemy.Name = "enemy"
        Me.enemy.Size = New System.Drawing.Size(41, 76)
        Me.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy.TabIndex = 12
        Me.enemy.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox3.Location = New System.Drawing.Point(213, -30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox12.Location = New System.Drawing.Point(213, 403)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox12.TabIndex = 11
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Gold
        Me.PictureBox11.Location = New System.Drawing.Point(163, 403)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox11.TabIndex = 10
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox10.Location = New System.Drawing.Point(110, 403)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox10.TabIndex = 9
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox9.Location = New System.Drawing.Point(213, 277)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Gold
        Me.PictureBox8.Location = New System.Drawing.Point(163, 277)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox7.Location = New System.Drawing.Point(110, 277)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox6.Location = New System.Drawing.Point(213, 124)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Gold
        Me.PictureBox5.Location = New System.Drawing.Point(163, 124)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox4.Location = New System.Drawing.Point(110, 124)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.Location = New System.Drawing.Point(163, -30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(110, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 93)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'rest_game
        '
        Me.rest_game.BackColor = System.Drawing.Color.White
        Me.rest_game.BackgroundImage = CType(resources.GetObject("rest_game.BackgroundImage"), System.Drawing.Image)
        Me.rest_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rest_game.FlatAppearance.BorderSize = 0
        Me.rest_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rest_game.ForeColor = System.Drawing.Color.Red
        Me.rest_game.Location = New System.Drawing.Point(110, 224)
        Me.rest_game.Name = "rest_game"
        Me.rest_game.Size = New System.Drawing.Size(108, 47)
        Me.rest_game.TabIndex = 20
        Me.rest_game.UseVisualStyleBackColor = False
        Me.rest_game.Visible = False
        '
        'Ex_game
        '
        Me.Ex_game.BackColor = System.Drawing.Color.Transparent
        Me.Ex_game.BackgroundImage = CType(resources.GetObject("Ex_game.BackgroundImage"), System.Drawing.Image)
        Me.Ex_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ex_game.FlatAppearance.BorderSize = 0
        Me.Ex_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ex_game.ForeColor = System.Drawing.Color.Red
        Me.Ex_game.Location = New System.Drawing.Point(110, 287)
        Me.Ex_game.Name = "Ex_game"
        Me.Ex_game.Size = New System.Drawing.Size(108, 44)
        Me.Ex_game.TabIndex = 21
        Me.Ex_game.UseVisualStyleBackColor = False
        Me.Ex_game.Visible = False
        '
        'end_game
        '
        Me.end_game.BackColor = System.Drawing.Color.Transparent
        Me.end_game.BackgroundImage = CType(resources.GetObject("end_game.BackgroundImage"), System.Drawing.Image)
        Me.end_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.end_game.Location = New System.Drawing.Point(53, 65)
        Me.end_game.Margin = New System.Windows.Forms.Padding(2)
        Me.end_game.Name = "end_game"
        Me.end_game.Size = New System.Drawing.Size(226, 72)
        Me.end_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.end_game.TabIndex = 22
        Me.end_game.TabStop = False
        Me.end_game.Visible = False
        '
        'paused_text
        '
        Me.paused_text.BackColor = System.Drawing.Color.Transparent
        Me.paused_text.Image = CType(resources.GetObject("paused_text.Image"), System.Drawing.Image)
        Me.paused_text.Location = New System.Drawing.Point(86, 152)
        Me.paused_text.Name = "paused_text"
        Me.paused_text.Size = New System.Drawing.Size(163, 48)
        Me.paused_text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.paused_text.TabIndex = 24
        Me.paused_text.TabStop = False
        Me.paused_text.Visible = False
        '
        'player_car
        '
        Me.player_car.BackColor = System.Drawing.Color.Transparent
        Me.player_car.Image = CType(resources.GetObject("player_car.Image"), System.Drawing.Image)
        Me.player_car.Location = New System.Drawing.Point(131, 350)
        Me.player_car.Name = "player_car"
        Me.player_car.Size = New System.Drawing.Size(33, 63)
        Me.player_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.player_car.TabIndex = 27
        Me.player_car.TabStop = False
        '
        'paused_game
        '
        Me.paused_game.BackColor = System.Drawing.Color.Transparent
        Me.paused_game.Image = CType(resources.GetObject("paused_game.Image"), System.Drawing.Image)
        Me.paused_game.Location = New System.Drawing.Point(288, 1)
        Me.paused_game.Name = "paused_game"
        Me.paused_game.Size = New System.Drawing.Size(32, 35)
        Me.paused_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.paused_game.TabIndex = 28
        Me.paused_game.TabStop = False
        '
        'cont_butt
        '
        Me.cont_butt.BackColor = System.Drawing.Color.Transparent
        Me.cont_butt.Image = CType(resources.GetObject("cont_butt.Image"), System.Drawing.Image)
        Me.cont_butt.Location = New System.Drawing.Point(86, 233)
        Me.cont_butt.Name = "cont_butt"
        Me.cont_butt.Size = New System.Drawing.Size(163, 48)
        Me.cont_butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cont_butt.TabIndex = 29
        Me.cont_butt.TabStop = False
        Me.cont_butt.Visible = False
        '
        'Ext_butt
        '
        Me.Ext_butt.BackColor = System.Drawing.Color.Transparent
        Me.Ext_butt.Image = CType(resources.GetObject("Ext_butt.Image"), System.Drawing.Image)
        Me.Ext_butt.Location = New System.Drawing.Point(86, 296)
        Me.Ext_butt.Name = "Ext_butt"
        Me.Ext_butt.Size = New System.Drawing.Size(163, 48)
        Me.Ext_butt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ext_butt.TabIndex = 30
        Me.Ext_butt.TabStop = False
        Me.Ext_butt.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(332, 458)
        Me.Controls.Add(Me.Ext_butt)
        Me.Controls.Add(Me.cont_butt)
        Me.Controls.Add(Me.paused_game)
        Me.Controls.Add(Me.player_car)
        Me.Controls.Add(Me.paused_text)
        Me.Controls.Add(Me.end_game)
        Me.Controls.Add(Me.Ex_game)
        Me.Controls.Add(Me.rest_game)
        Me.Controls.Add(Me.speed_incrs)
        Me.Controls.Add(Me.table_score)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.enemy)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(332, 458)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "car_racing"
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.end_game, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paused_text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paused_game, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cont_butt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ext_butt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents left_mover As Timer
    Friend WithEvents right_mover As Timer
    Friend WithEvents enemy_mover As Timer
    Friend WithEvents enemy1_mover As Timer
    Friend WithEvents enemy2_mover As Timer
    Friend WithEvents enemy As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents table_score As Label
    Friend WithEvents speed_incrs As Label
    Friend WithEvents Pause_game As Timer
    Friend WithEvents rest_game As Button
    Friend WithEvents Ex_game As Button
    Friend WithEvents end_game As PictureBox
    Friend WithEvents paused_text As PictureBox
    Friend WithEvents player_car As PictureBox
    Friend WithEvents paused_game As PictureBox
    Friend WithEvents cont_butt As PictureBox
    Friend WithEvents Ext_butt As PictureBox
End Class
