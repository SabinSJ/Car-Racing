<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Back_butt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataView = New System.Windows.Forms.DataGridView()
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_butt
        '
        Me.Back_butt.BackColor = System.Drawing.Color.Transparent
        Me.Back_butt.FlatAppearance.BorderSize = 0
        Me.Back_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_butt.ForeColor = System.Drawing.Color.DarkGray
        Me.Back_butt.Location = New System.Drawing.Point(12, 405)
        Me.Back_butt.Name = "Back_butt"
        Me.Back_butt.Size = New System.Drawing.Size(99, 33)
        Me.Back_butt.TabIndex = 0
        Me.Back_butt.Text = "Back"
        Me.Back_butt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Location = New System.Drawing.Point(326, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "High Score"
        '
        'dataView
        '
        Me.dataView.BackgroundColor = System.Drawing.Color.White
        Me.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataView.Location = New System.Drawing.Point(160, 84)
        Me.dataView.Name = "dataView"
        Me.dataView.Size = New System.Drawing.Size(478, 301)
        Me.dataView.TabIndex = 2
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dataView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Back_butt)
        Me.Name = "Form5"
        Me.Text = "High score"
        CType(Me.dataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_butt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dataView As DataGridView
End Class
