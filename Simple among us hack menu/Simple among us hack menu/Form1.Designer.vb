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
        Me.ImpoButton = New System.Windows.Forms.Button()
        Me.CrewButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ImpoButton
        '
        Me.ImpoButton.Location = New System.Drawing.Point(0, 12)
        Me.ImpoButton.Name = "ImpoButton"
        Me.ImpoButton.Size = New System.Drawing.Size(232, 43)
        Me.ImpoButton.TabIndex = 0
        Me.ImpoButton.Text = "Impo"
        Me.ImpoButton.UseVisualStyleBackColor = True
        '
        'CrewButton
        '
        Me.CrewButton.Location = New System.Drawing.Point(0, 66)
        Me.CrewButton.Name = "CrewButton"
        Me.CrewButton.Size = New System.Drawing.Size(232, 43)
        Me.CrewButton.TabIndex = 1
        Me.CrewButton.Text = "Crew"
        Me.CrewButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 132)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Version 2020.9.22 Only"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(232, 164)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CrewButton)
        Me.Controls.Add(Me.ImpoButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImpoButton As Button
    Friend WithEvents CrewButton As Button
    Friend WithEvents TextBox1 As TextBox
End Class
