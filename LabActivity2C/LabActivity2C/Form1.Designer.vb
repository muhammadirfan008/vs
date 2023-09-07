<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtln = New System.Windows.Forms.TextBox()
        Me.cmdCoins = New System.Windows.Forms.Button()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sum Of Money $"
        '
        'txtln
        '
        Me.txtln.Location = New System.Drawing.Point(266, 66)
        Me.txtln.Name = "txtln"
        Me.txtln.Size = New System.Drawing.Size(147, 22)
        Me.txtln.TabIndex = 1
        '
        'cmdCoins
        '
        Me.cmdCoins.Location = New System.Drawing.Point(116, 125)
        Me.cmdCoins.Name = "cmdCoins"
        Me.cmdCoins.Size = New System.Drawing.Size(98, 28)
        Me.cmdCoins.TabIndex = 2
        Me.cmdCoins.Text = "To Coins"
        Me.cmdCoins.UseVisualStyleBackColor = True
        '
        'lbl100
        '
        Me.lbl100.AutoSize = True
        Me.lbl100.Location = New System.Drawing.Point(305, 179)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(103, 16)
        Me.lbl100.TabIndex = 3
        Me.lbl100.Text = " pound coins = 3"
        '
        'lbl50
        '
        Me.lbl50.AutoSize = True
        Me.lbl50.Location = New System.Drawing.Point(305, 208)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(84, 16)
        Me.lbl50.TabIndex = 4
        Me.lbl50.Text = "50p coins = 0"
        '
        'lbl20
        '
        Me.lbl20.AutoSize = True
        Me.lbl20.Location = New System.Drawing.Point(305, 239)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(76, 16)
        Me.lbl20.TabIndex = 5
        Me.lbl20.Text = "20 coins = 2"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(305, 270)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(84, 16)
        Me.lbl10.TabIndex = 6
        Me.lbl10.Text = "10p coins = 0"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(305, 304)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(77, 16)
        Me.lbl5.TabIndex = 7
        Me.lbl5.Text = "5p coins = 1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(305, 336)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(77, 16)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "2p coins = 0"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(305, 365)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(77, 16)
        Me.lbl1.TabIndex = 9
        Me.lbl1.Text = "1p coins = 1"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "The sum of Money that is to be return as coins"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.cmdCoins)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtln As TextBox
    Friend WithEvents cmdCoins As Button
    Friend WithEvents lbl100 As Label
    Friend WithEvents lbl50 As Label
    Friend WithEvents lbl20 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
