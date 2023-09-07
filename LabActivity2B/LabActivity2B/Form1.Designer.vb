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
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.cmdCal = New System.Windows.Forms.Button()
        Me.lblCircu = New System.Windows.Forms.Label()
        Me.txtCirc = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(42, 105)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(50, 16)
        Me.lblRadius.TabIndex = 0
        Me.lblRadius.Text = "Radius"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(134, 99)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(148, 22)
        Me.txtRadius.TabIndex = 1
        '
        'cmdCal
        '
        Me.cmdCal.Location = New System.Drawing.Point(166, 141)
        Me.cmdCal.Name = "cmdCal"
        Me.cmdCal.Size = New System.Drawing.Size(81, 46)
        Me.cmdCal.TabIndex = 2
        Me.cmdCal.Text = "calculate"
        Me.cmdCal.UseVisualStyleBackColor = True
        '
        'lblCircu
        '
        Me.lblCircu.AutoSize = True
        Me.lblCircu.Location = New System.Drawing.Point(23, 209)
        Me.lblCircu.Name = "lblCircu"
        Me.lblCircu.Size = New System.Drawing.Size(93, 16)
        Me.lblCircu.TabIndex = 3
        Me.lblCircu.Text = "Circumference"
        '
        'txtCirc
        '
        Me.txtCirc.Location = New System.Drawing.Point(134, 203)
        Me.txtCirc.Name = "txtCirc"
        Me.txtCirc.Size = New System.Drawing.Size(148, 22)
        Me.txtCirc.TabIndex = 4
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(54, 279)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(36, 16)
        Me.lblArea.TabIndex = 5
        Me.lblArea.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(134, 273)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(147, 22)
        Me.txtArea.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.txtCirc)
        Me.Controls.Add(Me.lblCircu)
        Me.Controls.Add(Me.cmdCal)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblRadius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRadius As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents cmdCal As Button
    Friend WithEvents lblCircu As Label
    Friend WithEvents txtCirc As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents txtArea As TextBox
End Class
