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
        Dim lblEnter As System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        lblEnter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        lblEnter.AutoSize = True
        lblEnter.Location = New System.Drawing.Point(25, 39)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New System.Drawing.Size(100, 15)
        lblEnter.TabIndex = 0
        lblEnter.Text = "Enter your name :"
        AddHandler lblEnter.Click, AddressOf Me.lblEnter_Click
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(148, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(181, 23)
        Me.txtName.TabIndex = 1
        '
        'cmdClick
        '
        Me.cmdClick.Location = New System.Drawing.Point(148, 81)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(181, 23)
        Me.cmdClick.TabIndex = 2
        Me.cmdClick.Text = "CLICK HERE"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOutput.Location = New System.Drawing.Point(25, 127)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(45, 15)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Result :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 302)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cmdClick)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(lblEnter)
        Me.Name = "Form1"
        Me.Text = "Input Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdClick As Button
    Friend WithEvents lblOutput As Label
End Class
