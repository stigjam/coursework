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
        Me.lblCoursework = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtBoxKey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCoursework
        '
        Me.lblCoursework.AutoSize = True
        Me.lblCoursework.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoursework.ForeColor = System.Drawing.Color.LightGray
        Me.lblCoursework.Location = New System.Drawing.Point(99, 9)
        Me.lblCoursework.Name = "lblCoursework"
        Me.lblCoursework.Size = New System.Drawing.Size(124, 23)
        Me.lblCoursework.TabIndex = 0
        Me.lblCoursework.Text = "Coursework"
        '
        'txtBox1
        '
        Me.txtBox1.ForeColor = System.Drawing.Color.DimGray
        Me.txtBox1.Location = New System.Drawing.Point(12, 106)
        Me.txtBox1.Multiline = True
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(298, 77)
        Me.txtBox1.TabIndex = 1
        '
        'txtBox2
        '
        Me.txtBox2.ForeColor = System.Drawing.Color.DimGray
        Me.txtBox2.Location = New System.Drawing.Point(12, 263)
        Me.txtBox2.Multiline = True
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(298, 77)
        Me.txtBox2.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.DimGray
        Me.btnClose.Location = New System.Drawing.Point(12, 354)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Application"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.ForeColor = System.Drawing.Color.DimGray
        Me.btnEncrypt.Location = New System.Drawing.Point(19, 205)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(104, 37)
        Me.btnEncrypt.TabIndex = 4
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.ForeColor = System.Drawing.Color.DimGray
        Me.btnDecrypt.Location = New System.Drawing.Point(199, 205)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(104, 37)
        Me.btnDecrypt.TabIndex = 5
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtBoxKey
        '
        Me.txtBoxKey.Location = New System.Drawing.Point(111, 64)
        Me.txtBoxKey.Name = "txtBoxKey"
        Me.txtBoxKey.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxKey.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(322, 393)
        Me.Controls.Add(Me.txtBoxKey)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.lblCoursework)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCoursework As System.Windows.Forms.Label
    Friend WithEvents txtBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtBoxKey As System.Windows.Forms.TextBox

End Class
