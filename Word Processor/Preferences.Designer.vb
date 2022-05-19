<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preferences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preferences))
        Me.CheckBox_ShowWelcomeOnStart = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CheckBox_ShowWelcomeOnStart
        '
        Me.CheckBox_ShowWelcomeOnStart.AutoSize = True
        Me.CheckBox_ShowWelcomeOnStart.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox_ShowWelcomeOnStart.Name = "CheckBox_ShowWelcomeOnStart"
        Me.CheckBox_ShowWelcomeOnStart.Size = New System.Drawing.Size(171, 17)
        Me.CheckBox_ShowWelcomeOnStart.TabIndex = 0
        Me.CheckBox_ShowWelcomeOnStart.Text = "Show Welcome Menu on Start"
        Me.CheckBox_ShowWelcomeOnStart.UseVisualStyleBackColor = True
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 181)
        Me.Controls.Add(Me.CheckBox_ShowWelcomeOnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Preferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox_ShowWelcomeOnStart As CheckBox
End Class
