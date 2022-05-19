Imports Word_Processor.GlobalVariables
Public Class Find
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_FindAll.Click
        Dim findType As Integer
        findType = ComboBox1.SelectedIndex

        If TextBox1.TextLength > 0 And findType = 0 Then
            Form1.RichTextBox.Find(TextBox1.Text, 0, RichTextBoxFinds.None)
        ElseIf TextBox1.TextLength > 0 And findType = 1 Then
            Form1.RichTextBox.Find(TextBox1.Text, 0, RichTextBoxFinds.MatchCase)
        ElseIf TextBox1.TextLength > 0 And findType = 2 Then
            Form1.RichTextBox.Find(TextBox1.Text, 0, RichTextBoxFinds.WholeWord)
        End If

        Form1.RichTextBox.Focus()
    End Sub

    Private Sub Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class