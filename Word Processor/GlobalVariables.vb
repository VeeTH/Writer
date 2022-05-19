Public Class GlobalVariables
    'Main Form Variables
    Public Shared RTBZoomLevel As Integer = 100
    Public Shared WordCount As Integer = 0
    Public Shared CharacterCount As Integer = 0
    Public Shared isSaved As Boolean = False
    Public Shared noSaveDialogPopup As Boolean = False
    Public Shared fileName As String
    Public Shared exitedThroughTaskDialog As Boolean = False
    Public Shared currentFontStyle As String
    Public Shared selectionIsBolded As Boolean = False
    Public Shared selectionIsItalicized As Boolean = False
    Public Shared selectionIsUnderlined As Boolean = False
    Public Shared selectionIsStrikethroughed As Boolean = False
    Public Shared fontSizeBoxValue As Integer = 11
    Public Shared lineIdent As Integer = 0
    'Public Shared fontDropdownSelection = Form1.RibbonGroupComboBox_FontSelect.Text

    'Preferences Variables
    Public Shared preferencesIsDeactivated As Boolean = False

    'Text finding variables
    Public Shared findInputTB = Find.TextBox1.Text
    Public Shared findTypeDD
End Class
