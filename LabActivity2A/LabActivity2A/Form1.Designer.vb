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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(61, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(387, 46)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tambah Dua Intiger"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(57, 174)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(109, 22)
        Me.txtFirst.TabIndex = 1
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(240, 173)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(117, 22)
        Me.txtSecond.TabIndex = 2
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(449, 173)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(46, 22)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "="
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(550, 175)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(128, 22)
        Me.txtSum.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtSum As TextBox
End Class
