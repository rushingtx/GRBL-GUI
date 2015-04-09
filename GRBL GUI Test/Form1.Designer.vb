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
        Me.btnXMinus = New System.Windows.Forms.Button()
        Me.BtnXplus = New System.Windows.Forms.Button()
        Me.btnYPLus = New System.Windows.Forms.Button()
        Me.btnYminus = New System.Windows.Forms.Button()
        Me.btnZPLus = New System.Windows.Forms.Button()
        Me.btnZMinus = New System.Windows.Forms.Button()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXMinus
        '
        Me.btnXMinus.Location = New System.Drawing.Point(21, 48)
        Me.btnXMinus.Name = "btnXMinus"
        Me.btnXMinus.Size = New System.Drawing.Size(75, 23)
        Me.btnXMinus.TabIndex = 0
        Me.btnXMinus.Text = "X -"
        Me.btnXMinus.UseVisualStyleBackColor = True
        '
        'BtnXplus
        '
        Me.BtnXplus.Location = New System.Drawing.Point(168, 48)
        Me.BtnXplus.Name = "BtnXplus"
        Me.BtnXplus.Size = New System.Drawing.Size(75, 23)
        Me.BtnXplus.TabIndex = 1
        Me.BtnXplus.Text = "X +"
        Me.BtnXplus.UseVisualStyleBackColor = True
        '
        'btnYPLus
        '
        Me.btnYPLus.Location = New System.Drawing.Point(96, 19)
        Me.btnYPLus.Name = "btnYPLus"
        Me.btnYPLus.Size = New System.Drawing.Size(75, 23)
        Me.btnYPLus.TabIndex = 2
        Me.btnYPLus.Text = "Y +"
        Me.btnYPLus.UseVisualStyleBackColor = True
        '
        'btnYminus
        '
        Me.btnYminus.Location = New System.Drawing.Point(96, 77)
        Me.btnYminus.Name = "btnYminus"
        Me.btnYminus.Size = New System.Drawing.Size(75, 23)
        Me.btnYminus.TabIndex = 3
        Me.btnYminus.Text = "Y -"
        Me.btnYminus.UseVisualStyleBackColor = True
        '
        'btnZPLus
        '
        Me.btnZPLus.Location = New System.Drawing.Point(21, 132)
        Me.btnZPLus.Name = "btnZPLus"
        Me.btnZPLus.Size = New System.Drawing.Size(75, 23)
        Me.btnZPLus.TabIndex = 4
        Me.btnZPLus.Text = "Z+"
        Me.btnZPLus.UseVisualStyleBackColor = True
        '
        'btnZMinus
        '
        Me.btnZMinus.Location = New System.Drawing.Point(21, 161)
        Me.btnZMinus.Name = "btnZMinus"
        Me.btnZMinus.Size = New System.Drawing.Size(75, 23)
        Me.btnZMinus.TabIndex = 5
        Me.btnZMinus.Text = "Z-"
        Me.btnZMinus.UseVisualStyleBackColor = True
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Location = New System.Drawing.Point(141, 163)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(81, 21)
        Me.cbSize.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Step Size"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnXMinus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnYPLus)
        Me.GroupBox1.Controls.Add(Me.cbSize)
        Me.GroupBox1.Controls.Add(Me.BtnXplus)
        Me.GroupBox1.Controls.Add(Me.btnZMinus)
        Me.GroupBox1.Controls.Add(Me.btnYminus)
        Me.GroupBox1.Controls.Add(Me.btnZPLus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 220)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jog Control"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 253)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "GRBL GUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnXMinus As System.Windows.Forms.Button
    Friend WithEvents BtnXplus As System.Windows.Forms.Button
    Friend WithEvents btnYPLus As System.Windows.Forms.Button
    Friend WithEvents btnYminus As System.Windows.Forms.Button
    Friend WithEvents btnZPLus As System.Windows.Forms.Button
    Friend WithEvents btnZMinus As System.Windows.Forms.Button
    Friend WithEvents cbSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
