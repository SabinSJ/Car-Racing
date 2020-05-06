<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exit_butt = New System.Windows.Forms.Button()
        Me.hist_butt = New System.Windows.Forms.Button()
        Me.start_butt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Location = New System.Drawing.Point(111, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'exit_butt
        '
        Me.exit_butt.BackColor = System.Drawing.Color.Transparent
        Me.exit_butt.FlatAppearance.BorderSize = 0
        Me.exit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.ForeColor = System.Drawing.Color.DarkGray
        Me.exit_butt.Location = New System.Drawing.Point(111, 278)
        Me.exit_butt.MinimumSize = New System.Drawing.Size(92, 32)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(92, 34)
        Me.exit_butt.TabIndex = 2
        Me.exit_butt.Text = "Exit"
        Me.exit_butt.UseVisualStyleBackColor = False
        '
        'hist_butt
        '
        Me.hist_butt.BackColor = System.Drawing.Color.Transparent
        Me.hist_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.hist_butt.FlatAppearance.BorderSize = 0
        Me.hist_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hist_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hist_butt.ForeColor = System.Drawing.Color.DarkGray
        Me.hist_butt.Location = New System.Drawing.Point(111, 228)
        Me.hist_butt.MinimumSize = New System.Drawing.Size(92, 32)
        Me.hist_butt.Name = "hist_butt"
        Me.hist_butt.Size = New System.Drawing.Size(92, 32)
        Me.hist_butt.TabIndex = 3
        Me.hist_butt.Text = "History"
        Me.hist_butt.UseVisualStyleBackColor = False
        '
        'start_butt
        '
        Me.start_butt.BackColor = System.Drawing.Color.Transparent
        Me.start_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.start_butt.FlatAppearance.BorderSize = 0
        Me.start_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_butt.ForeColor = System.Drawing.Color.DarkGray
        Me.start_butt.Location = New System.Drawing.Point(111, 174)
        Me.start_butt.MinimumSize = New System.Drawing.Size(92, 32)
        Me.start_butt.Name = "start_butt"
        Me.start_butt.Size = New System.Drawing.Size(92, 35)
        Me.start_butt.TabIndex = 1
        Me.start_butt.Text = "Start"
        Me.start_butt.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(320, 427)
        Me.Controls.Add(Me.hist_butt)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.start_butt)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(336, 466)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Racing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents exit_butt As Button
    Friend WithEvents hist_butt As Button
    Friend WithEvents start_butt As Button
End Class
