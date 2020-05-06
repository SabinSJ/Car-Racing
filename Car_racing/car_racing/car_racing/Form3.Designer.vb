<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Start_button = New System.Windows.Forms.Button()
        Me.List_Player = New System.Windows.Forms.ComboBox()
        Me.Enter_Name = New System.Windows.Forms.TextBox()
        Me.back_butt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start_button
        '
        Me.Start_button.BackColor = System.Drawing.Color.Transparent
        Me.Start_button.FlatAppearance.BorderSize = 0
        Me.Start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_button.ForeColor = System.Drawing.Color.DarkGray
        Me.Start_button.Location = New System.Drawing.Point(155, 254)
        Me.Start_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Start_button.Name = "Start_button"
        Me.Start_button.Size = New System.Drawing.Size(100, 33)
        Me.Start_button.TabIndex = 0
        Me.Start_button.Text = "Play"
        Me.Start_button.UseVisualStyleBackColor = False
        '
        'List_Player
        '
        Me.List_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.List_Player.FormattingEnabled = True
        Me.List_Player.Location = New System.Drawing.Point(82, 106)
        Me.List_Player.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.List_Player.Name = "List_Player"
        Me.List_Player.Size = New System.Drawing.Size(174, 21)
        Me.List_Player.TabIndex = 1
        '
        'Enter_Name
        '
        Me.Enter_Name.Location = New System.Drawing.Point(82, 175)
        Me.Enter_Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Enter_Name.Name = "Enter_Name"
        Me.Enter_Name.Size = New System.Drawing.Size(174, 20)
        Me.Enter_Name.TabIndex = 2
        '
        'back_butt
        '
        Me.back_butt.BackColor = System.Drawing.Color.Transparent
        Me.back_butt.FlatAppearance.BorderSize = 0
        Me.back_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_butt.ForeColor = System.Drawing.Color.DarkGray
        Me.back_butt.Location = New System.Drawing.Point(82, 254)
        Me.back_butt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.back_butt.Name = "back_butt"
        Me.back_butt.Size = New System.Drawing.Size(69, 33)
        Me.back_butt.TabIndex = 3
        Me.back_butt.Text = "Back"
        Me.back_butt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Location = New System.Drawing.Point(125, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Log In"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(320, 427)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back_butt)
        Me.Controls.Add(Me.Enter_Name)
        Me.Controls.Add(Me.List_Player)
        Me.Controls.Add(Me.Start_button)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(336, 466)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_button As Button
    Friend WithEvents List_Player As ComboBox
    Friend WithEvents Enter_Name As TextBox
    Friend WithEvents back_butt As Button
    Friend WithEvents Label1 As Label
End Class
