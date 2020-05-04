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
        Me.Start_button = New System.Windows.Forms.Button()
        Me.List_Player = New System.Windows.Forms.ComboBox()
        Me.Enter_Name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.error_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start_button
        '
        Me.Start_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Start_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_button.ForeColor = System.Drawing.Color.Red
        Me.Start_button.Location = New System.Drawing.Point(235, 337)
        Me.Start_button.Name = "Start_button"
        Me.Start_button.Size = New System.Drawing.Size(96, 41)
        Me.Start_button.TabIndex = 0
        Me.Start_button.Text = "Start"
        Me.Start_button.UseVisualStyleBackColor = False
        '
        'List_Player
        '
        Me.List_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.List_Player.FormattingEnabled = True
        Me.List_Player.Location = New System.Drawing.Point(101, 130)
        Me.List_Player.Name = "List_Player"
        Me.List_Player.Size = New System.Drawing.Size(230, 24)
        Me.List_Player.TabIndex = 1
        '
        'Enter_Name
        '
        Me.Enter_Name.Location = New System.Drawing.Point(101, 214)
        Me.Enter_Name.Name = "Enter_Name"
        Me.Enter_Name.Size = New System.Drawing.Size(230, 22)
        Me.Enter_Name.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(101, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'error_name
        '
        Me.error_name.AutoSize = True
        Me.error_name.BackColor = System.Drawing.Color.White
        Me.error_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_name.ForeColor = System.Drawing.Color.Red
        Me.error_name.Location = New System.Drawing.Point(140, 270)
        Me.error_name.Name = "error_name"
        Me.error_name.Size = New System.Drawing.Size(149, 29)
        Me.error_name.TabIndex = 4
        Me.error_name.Text = "Insert name"
        Me.error_name.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(152, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Log In"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(425, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.error_name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Enter_Name)
        Me.Controls.Add(Me.List_Player)
        Me.Controls.Add(Me.Start_button)
        Me.MinimumSize = New System.Drawing.Size(443, 564)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_button As Button
    Friend WithEvents List_Player As ComboBox
    Friend WithEvents Enter_Name As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents error_name As Label
    Friend WithEvents Label1 As Label
End Class
