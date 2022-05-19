Imports Word_Processor.GlobalVariables
Public Class Preferences
    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checkbox initalization
        If My.Settings.ShowTaskDialagOnStartup = True Then
            CheckBox_ShowWelcomeOnStart.Checked = True
        End If
    End Sub

    Private Sub Preferences_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowWelcomeOnStart.CheckStateChanged
        If CheckBox_ShowWelcomeOnStart.CheckState = CheckState.Unchecked Then
            My.Settings.ShowTaskDialagOnStartup = False
        ElseIf CheckBox_ShowWelcomeOnStart.CheckState = CheckState.Checked Then
            My.Settings.ShowTaskDialagOnStartup = True
        End If
    End Sub
End Class