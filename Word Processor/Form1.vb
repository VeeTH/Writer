'The Ribbon Control at the top isn't mine. It is part of this: https://github.com/ComponentFactory/Krypton. I would not be able to program anything like it myself.

Imports System.ComponentModel
Imports System.Drawing.Text
Imports Word_Processor.GlobalVariables
Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.SaveMySettingsOnExit = True

        'Set font style
        RichTextBox.SelectionFont = New Font("Arial", 11, FontStyle.Regular)

        'Tool Strip initalization
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
        ToolStripStatusLabel_WordCount.Text = " " & WordCount & " Words"
        ToolStripStatusLabel_CharCount.Text = " " & CharacterCount & " Characters"

        'Font selection combo box initalization
        Dim SystemFonts = New InstalledFontCollection
        Dim fontFamilies() As FontFamily = SystemFonts.Families

        For Each Font As FontFamily In fontFamilies
            RibbonGroupComboBox_FontSelect.Items.Add(Font.Name)
        Next
        RibbonGroupComboBox_FontSelect.DropDownStyle = ComboBoxStyle.DropDownList
        RibbonGroupComboBox_FontSelect.Text = "Arial"
    End Sub
    'Start of Zoom Level Dropdown code
    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_170.Click
        RTBZoomLevel = 170
        RichTextBox.ZoomFactor = 1.7
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_20.Click
        RTBZoomLevel = 20
        RichTextBox.ZoomFactor = 0.2
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_40.Click
        RTBZoomLevel = 40
        RichTextBox.ZoomFactor = 0.4
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_60.Click
        RTBZoomLevel = 60
        RichTextBox.ZoomFactor = 0.6
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_80.Click
        RTBZoomLevel = 80
        RichTextBox.ZoomFactor = 0.8
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_100.Click
        RTBZoomLevel = 100
        RichTextBox.ZoomFactor = 1
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_110.Click
        RTBZoomLevel = 110
        RichTextBox.ZoomFactor = 1.1
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_120.Click
        RTBZoomLevel = 120
        RichTextBox.ZoomFactor = 1.2
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_130.Click
        RTBZoomLevel = 130
        RichTextBox.ZoomFactor = 1.3
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_140.Click
        RTBZoomLevel = 140
        RichTextBox.ZoomFactor = 1.4
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_150.Click
        RTBZoomLevel = 150
        RichTextBox.ZoomFactor = 1.5
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_160.Click
        RTBZoomLevel = 160
        RichTextBox.ZoomFactor = 1.6
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_180.Click
        RTBZoomLevel = 180
        RichTextBox.ZoomFactor = 1.8
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_190.Click
        RTBZoomLevel = 190
        RichTextBox.ZoomFactor = 1.9
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ZoomLevelDropdown_200.Click
        RTBZoomLevel = 200
        RichTextBox.ZoomFactor = 2
        ToolStripStatusLabel_ZoomPercent.Text = " " & RTBZoomLevel & "% Zoom"
    End Sub
    'End of Zoom Level Dropdown code
    Private Sub StatusBarHandler(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        'Word count
        WordCount = RichTextBox.Text.Length - RichTextBox.Text.Replace(" ", String.Empty).Length
        ToolStripStatusLabel_WordCount.Text = " " & WordCount & " Words"

        'Character count
        CharacterCount = RichTextBox.Text.Length
        ToolStripStatusLabel_CharCount.Text = " " & CharacterCount & " Characters"

        'Save text
        isSaved = False
        If isSaved = True Then
            ToolStripStatusLabel_SaveStatus.Text = "Saved"
        ElseIf isSaved = False Then
            ToolStripStatusLabel_SaveStatus.Text = "Not Saved"
        End If
    End Sub

    Private Sub SaveOnCloseDialog(sender As Object, e As EventArgs) Handles RibbonGroupButton_Exit.Click, MyBase.FormClosing
        'SAVE ON CLOSE

        SaveFileDialog1.Filter = "Writer File (*.wrt)|*.wrt|Rich Text File (*.rtf)|*.rtf"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.RestoreDirectory = True

        If isSaved = False And exitedThroughTaskDialog = False Then
            Dim result As DialogResult = MessageBox.Show("There are unsaved changes to this document. Do you want to save them?", "Writer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            If result = DialogResult.Yes Then
                GoTo SaveDocument
            ElseIf result = DialogResult.No Then
                Process.GetCurrentProcess.Kill()
                'ElseIf result = DialogResult.Cancel Then
                'GoTo ResultCancel
                'e.Cancel = True
            End If
        ElseIf isSaved = True And exitedThroughTaskDialog = False Then
            Process.GetCurrentProcess.Kill()
        ElseIf isSaved = False And exitedThroughTaskDialog = True Then
            Process.GetCurrentProcess.Kill()
        End If

SaveDocument:
        If noSaveDialogPopup = True Then
            RichTextBox.SaveFile(fileName)
            isSaved = True
            'Console.WriteLine("Saved to " & fileName & " ")
            Process.GetCurrentProcess.Kill()
        End If

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox.SaveFile(SaveFileDialog1.FileName)
            isSaved = True
            'Console.WriteLine("Saved to " & fileName & " ")
            Process.GetCurrentProcess.Kill()
        End If

ResultCancel:
    End Sub

    Private Sub SaveDocument(sender As Object, e As EventArgs) Handles RibbonQATButton_Save.Click, RibbonGroupButton_Save.Click
        'SAVE BUTTON

        SaveFileDialog1.Filter = "Writer File (*.wrt)|*.wrt|Rich Text File (*.rtf)|*.rtf"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.RestoreDirectory = True

        If noSaveDialogPopup = True Then
            RichTextBox.SaveFile(fileName)
            isSaved = True
            If isSaved = True Then
                ToolStripStatusLabel_SaveStatus.Text = "Saved"
            ElseIf isSaved = False Then
                ToolStripStatusLabel_SaveStatus.Text = "Not Saved"
            End If
            Console.WriteLine("Saved to " & fileName & " ")
            GoTo AlreadySaved
        End If

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox.SaveFile(SaveFileDialog1.FileName)
            fileName = SaveFileDialog1.FileName
            Me.Text = "Writer (" & fileName & ")"
            noSaveDialogPopup = True
            isSaved = True
            If isSaved = True Then
                ToolStripStatusLabel_SaveStatus.Text = "Saved"
            ElseIf isSaved = False Then
                ToolStripStatusLabel_SaveStatus.Text = "Not Saved"
            End If
            Console.WriteLine("Saved to " & fileName & " ")
        End If

AlreadySaved:
    End Sub

    Private Sub OpenDocument(sender As Object, e As EventArgs) Handles TaskDialog_OpenDocument.Execute, RibbonGroupButton_Open.Click
        'OPEN BUTTON

        OpenFileDialog1.Filter = "Writer File (*.wrt)|*.wrt|Rich Text File (*rtf)|*.rtf"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox.LoadFile(OpenFileDialog1.FileName)
            fileName = OpenFileDialog1.FileName
            Me.Text = "Writer (" & fileName & ")"
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If My.Settings.ShowTaskDialagOnStartup = True Then
            TaskDialog.ShowDialog()
        ElseIf My.Settings.ShowTaskDialagOnStartup = False Then
            GoTo FalseResult
        End If

FalseResult:
    End Sub

    Private Sub SaveDocumentAs(sender As Object, e As EventArgs) Handles RibbonGroupButton_SaveAs.Click
        'SAVE AS BUTTON

        SaveFileDialog1.Filter = "Writer File (*.wrt)|*.wrt|Rich Text File (*.rtf)|*.rtf"
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox.SaveFile(SaveFileDialog1.FileName)
            fileName = SaveFileDialog1.FileName
            Me.Text = "Writer (" & fileName & ")"
            noSaveDialogPopup = True
            isSaved = True
            If isSaved = True Then
                ToolStripStatusLabel_SaveStatus.Text = "Saved"
            ElseIf isSaved = False Then
                ToolStripStatusLabel_SaveStatus.Text = "Not Saved"
            End If
            Console.WriteLine("Saved to " & fileName & " ")
        End If
    End Sub

    Private Sub QAT_Undo(sender As Object, e As EventArgs) Handles RibbonQATButton_Undo.Click
        RichTextBox.Undo()
    End Sub

    Private Sub QAT_Redo(sender As Object, e As EventArgs) Handles RibbonQATButton_Redo.Click
        RichTextBox.Redo()
    End Sub

    Private Sub TaskDialog_Exit(sender As Object, e As EventArgs) Handles TaskDialog_ExitWriter.Execute
        isSaved = False
        exitedThroughTaskDialog = True
        Call SaveOnCloseDialog(TaskDialog_ExitWriter, MouseEventArgs.Empty)
    End Sub

    Private Sub AboutDialog_Show(sender As Object, e As EventArgs) Handles RibbonGroupButton_AboutWriter.Click
        About.Show()
    End Sub

    Private Sub RichTextBox_Cut(sender As Object, e As EventArgs) Handles RibbonGroupButton_Cut.Click
        RichTextBox.Cut()
    End Sub

    Private Sub RichTextBox_Copy(sender As Object, e As EventArgs) Handles RibbonGroupButton_Copy.Click
        RichTextBox.Copy()
    End Sub

    Private Sub RichTextBox_Paste(sender As Object, e As EventArgs) Handles RibbonGroupButton_Paste.Click
        RichTextBox.Paste()
    End Sub

    Private Sub KryptonRibbonGroupClusterButton1_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Bold.Click
        ' Local variables
        Dim selectedFont As String
        Dim selectedSize As Integer
        Dim selectedStyle As FontStyle

        ' Bolds or unbolds
        If selectionIsBolded = False Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            selectedStyle = RichTextBox.SelectionFont.Style
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, FontStyle.Bold)
        ElseIf selectionIsBolded = True Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, selectedStyle)
        End If
    End Sub

    Private Sub RichTextBox_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox.SelectionChanged

        'Checks if selected text is Bold. If so, checks the Bold button in Ribbon
        If RichTextBox.SelectionFont.Style = FontStyle.Bold Then
            RibbonGroupButton_Bold.Checked = True
        ElseIf RichTextBox.SelectionFont.Style <> FontStyle.Bold Then
            RibbonGroupButton_Bold.Checked = False
        End If

        'Checks if selected text is italicized. If so, checks the Italics button in Ribbon
        If RichTextBox.SelectionFont.Style = FontStyle.Italic Then
            RibbonGroupButton_Italicize.Checked = True
        ElseIf RichTextBox.SelectionFont.Style <> FontStyle.Italic Then
            RibbonGroupButton_Italicize.Checked = False
        End If

        'Checks if selected text is underlined. If so, checks the Underline button in Ribbon
        If RichTextBox.SelectionFont.Style = FontStyle.Underline Then
            RibbonGroupButton_Underline.Checked = True
        ElseIf RichTextBox.SelectionFont.Style <> FontStyle.Underline Then
            RibbonGroupButton_Underline.Checked = False
        End If

        'Checks if selected text is strokethrough. If so, checks the Strikethrough button in Ribbon
        If RichTextBox.SelectionFont.Style = FontStyle.Strikeout Then
            RibbonGroupButton_Strikethrough.Checked = True
        ElseIf RichTextBox.SelectionFont.Style <> FontStyle.Strikeout Then
            RibbonGroupButton_Strikethrough.Checked = False
        End If

        'Checks selected text's font size and sets it as Font Size box value
        RibbonGroupNumericUpDown_FontSize.Value = RichTextBox.SelectionFont.Size

        'Checks selected text's font and sets it as Font dropdown value
        RibbonGroupComboBox_FontSelect.Text = RichTextBox.SelectionFont.Name
    End Sub

    Private Sub KryptonRibbonGroupClusterButton2_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Italicize.Click
        ' Local variables
        Dim selectedFont As String
        Dim selectedSize As Integer
        Dim selectedStyle As FontStyle

        ' Italicizes or unitalicizes
        If selectionIsItalicized = False Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            selectedStyle = RichTextBox.SelectionFont.Style
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, FontStyle.Italic)
        ElseIf selectionIsItalicized = True Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, selectedStyle)
        End If
    End Sub

    Private Sub KryptonRibbonGroupClusterButton3_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Underline.Click
        ' Local variables
        Dim selectedFont As String
        Dim selectedSize As Integer
        Dim selectedStyle As FontStyle

        ' Underlines or ununderlines
        If selectionIsUnderlined = False Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            selectedStyle = RichTextBox.SelectionFont.Style
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, FontStyle.Underline)
        ElseIf selectionIsUnderlined = True Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, selectedStyle)
        End If
    End Sub

    Private Sub KryptonRibbonGroupClusterColorButton1_SelectedColorChanged(sender As Object, e As ComponentFactory.Krypton.Toolkit.ColorEventArgs) Handles RibbonGroupClusterColorButton_TextColor.SelectedColorChanged
        RichTextBox.SelectionColor = RibbonGroupClusterColorButton_TextColor.SelectedColor
    End Sub

    Private Sub KryptonRibbonGroupClusterColorButton2_SelectedColorChanged(sender As Object, e As ComponentFactory.Krypton.Toolkit.ColorEventArgs) Handles RibbonGroupClusterColorButton_HighlightColor.SelectedColorChanged
        RichTextBox.SelectionBackColor = RibbonGroupClusterColorButton_HighlightColor.SelectedColor
    End Sub

    Private Sub KryptonRibbonGroupClusterColorButton1_Click(sender As Object, e As EventArgs) Handles RibbonGroupClusterColorButton_TextColor.Click
        RichTextBox.SelectionColor = RibbonGroupClusterColorButton_TextColor.SelectedColor
    End Sub

    Private Sub KryptonRibbonGroupClusterColorButton2_Click(sender As Object, e As EventArgs) Handles RibbonGroupClusterColorButton_HighlightColor.Click
        RichTextBox.SelectionBackColor = RibbonGroupClusterColorButton_HighlightColor.SelectedColor
    End Sub

    Private Sub KryptonRibbonGroupNumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles RibbonGroupNumericUpDown_FontSize.ValueChanged
        Dim selectedFont As FontFamily
        Dim selectedStyle As FontStyle

        selectedFont = RichTextBox.SelectionFont.FontFamily
        selectedStyle = RichTextBox.SelectionFont.Style
        fontSizeBoxValue = RibbonGroupNumericUpDown_FontSize.Value

        RichTextBox.SelectionFont = New Font(selectedFont, fontSizeBoxValue, selectedStyle)
    End Sub

    Private Sub KryptonRibbonGroupButton1_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_ClearFormatting.Click
        RichTextBox.SelectionFont = New Font("Arial", 11, FontStyle.Regular)
    End Sub

    Private Sub KryptonRibbonGroupButton5_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_AlignLeft.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub KryptonRibbonGroupButton6_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_AlignCenter.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub KryptonRibbonGroupButton7_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_AlignRight.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub KryptonRibbonGroupClusterButton10_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_DecreaseIndent.Click
        If lineIdent > 0 Then
            lineIdent = lineIdent - 20
        ElseIf lineIdent <= 0 Then
            lineIdent = 0
        End If

        RichTextBox.SelectionIndent = lineIdent
    End Sub

    Private Sub KryptonRibbonGroupClusterButton11_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_IncreaseIndent.Click
        If lineIdent < 100 Then
            lineIdent = lineIdent + 20
        ElseIf lineIdent >= 100 Then
            lineIdent = 100
        End If

        RichTextBox.SelectionIndent = lineIdent
    End Sub

    Private Sub KryptonRibbonGroupClusterButton8_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_BulletedList.Click
        If RichTextBox.SelectionBullet = False Then
            RichTextBox.SelectionBullet = True
        ElseIf RichTextBox.SelectionBullet = True Then
            RichTextBox.SelectionBullet = False
        End If
    End Sub

    Private Sub KryptonRibbonGroupGallery1_TrackingImage(sender As Object, e As ComponentFactory.Krypton.Toolkit.ImageSelectEventArgs) Handles KryptonRibbonGroupGallery1.TrackingImage

    End Sub

    Private Sub KryptonRibbonGroupGallery1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupGallery1.SelectedIndexChanged
        'Font Style: Regular
        If KryptonRibbonGroupGallery1.SelectedIndex = 0 Then
            RichTextBox.SelectionFont = New Font("Arial", 11, FontStyle.Regular)
        End If

        'Font Style: Professional
        If KryptonRibbonGroupGallery1.SelectedIndex = 1 Then
            RichTextBox.SelectionFont = New Font("Times New Roman", 11, FontStyle.Regular)
        End If

        'Font Style: Title
        If KryptonRibbonGroupGallery1.SelectedIndex = 2 Then
            RichTextBox.SelectionFont = New Font("Arial", 22, FontStyle.Bold)
        End If

        'Font Style: Heading 1
        If KryptonRibbonGroupGallery1.SelectedIndex = 3 Then
            RichTextBox.SelectionFont = New Font("Arial", 18, FontStyle.Bold)
        End If

        'Font Style: Professional Heading 1
        If KryptonRibbonGroupGallery1.SelectedIndex = 4 Then
            RichTextBox.SelectionFont = New Font("Times New Roman", 18, FontStyle.Bold)
        End If

        'Font Style: Heading 2
        If KryptonRibbonGroupGallery1.SelectedIndex = 5 Then
            RichTextBox.SelectionFont = New Font("Arial", 14, FontStyle.Bold)
        End If

        'Font Style: Professional Heading 2
        If KryptonRibbonGroupGallery1.SelectedIndex = 6 Then
            RichTextBox.SelectionFont = New Font("Times New Roman", 14, FontStyle.Bold)
        End If
    End Sub

    Private Sub KryptonRibbonGroupColorButton1_SelectedColorChanged(sender As Object, e As ComponentFactory.Krypton.Toolkit.ColorEventArgs) Handles RibbonGroupClusterColorButton_PageColor.SelectedColorChanged
        RichTextBox.BackColor = RibbonGroupClusterColorButton_PageColor.SelectedColor
    End Sub

    Private Sub KryptonRibbonGroupClusterButton5_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Subscript.Click
        RichTextBox.SelectionCharOffset = -10
    End Sub

    Private Sub KryptonRibbonGroupClusterButton6_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Superscript.Click
        RichTextBox.SelectionCharOffset = 10
    End Sub

    Private Sub KryptonRibbonGroupClusterButton4_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Strikethrough.Click
        ' Local variables
        Dim selectedFont As String
        Dim selectedSize As Integer
        Dim selectedStyle As FontStyle

        ' Underlines or ununderlines
        If selectionIsStrikethroughed = False Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            selectedStyle = RichTextBox.SelectionFont.Style
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, FontStyle.Strikeout)
        ElseIf selectionIsStrikethroughed = True Then
            selectedFont = RichTextBox.SelectionFont.Name
            selectedSize = RichTextBox.SelectionFont.Size
            RichTextBox.SelectionFont = New Font(selectedFont, selectedSize, selectedStyle)
        End If
    End Sub

    Private Sub RibbonGroupButton_Find_Click(sender As Object, e As EventArgs) Handles RibbonGroupButton_Find.Click
        Find.Show()
    End Sub

    Private Sub RibbonGroupButton_FindAndReplace_Click(sender As Object, e As EventArgs)
        FindAndReplace.Show()
    End Sub

    Private Sub RibbonGroupComboBox_FontSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles RibbonGroupComboBox_FontSelect.SelectedValueChanged
        'Dim selectedSize As Integer
        'Dim selectedStyle As FontStyle

        'selectedSize = RichTextBox.SelectionFont.Size
        'selectedStyle = RichTextBox.SelectionFont.Style

        'RichTextBox.SelectionFont = New Font(fontDropdownSelection, selectedSize, selectedStyle)
    End Sub

    Private Sub TaskDialog_OpenPreferences_Execute(sender As Object, e As EventArgs) Handles TaskDialog_OpenPreferences.Execute, RibbonGroupButton_Preferences.Click
        Preferences.Show()
    End Sub
End Class
