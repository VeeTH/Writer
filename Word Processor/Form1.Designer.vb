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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_SaveStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spacer1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_WordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spacer2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_CharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spacer3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_ZoomPercent = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Spacer4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ZoomLevelDropdown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ZoomLevelDropdown_200 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_190 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_180 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_170 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_160 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_150 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_140 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_130 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_120 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_110 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_80 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_60 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomLevelDropdown_20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ribbon = New ComponentFactory.Krypton.Ribbon.KryptonRibbon()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.RibbonQATButton_Save = New ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton()
        Me.RibbonQATButton_Undo = New ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton()
        Me.RibbonQATButton_Redo = New ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton()
        Me.RibbonTab_Document = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab()
        Me.RibbonGroup_Document_File = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.RibbonGroupTriple1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.RibbonGroupButton_Open = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_Save = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_SaveAs = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroup_Document_Other = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.RibbonGroupTriple2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.RibbonGroupButton_Preferences = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_AboutWriter = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_Exit = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonTab_Text = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab()
        Me.KryptonRibbonGroup1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupTriple2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.KryptonRibbonGroupTriple1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.RibbonGroupButton_Cut = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_Copy = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonGroupButton_Paste = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.KryptonRibbonGroup2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupLines1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.RibbonGroupComboBox_FontSelect = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox()
        Me.RibbonGroupNumericUpDown_FontSize = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupNumericUpDown()
        Me.RibbonGroupButton_ClearFormatting = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.KryptonRibbonGroupCluster1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.RibbonGroupButton_Bold = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_Italicize = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_Underline = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_Strikethrough = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_Subscript = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_Superscript = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.KryptonRibbonGroupCluster2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.RibbonGroupClusterColorButton_TextColor = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterColorButton()
        Me.RibbonGroupClusterColorButton_HighlightColor = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterColorButton()
        Me.KryptonRibbonGroup3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupLines2 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.KryptonRibbonGroupCluster3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.RibbonGroupButton_BulletedList = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_NumberedList = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.KryptonRibbonGroupCluster6 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.RibbonGroupButton_DecreaseIndent = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_IncreaseIndent = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.KryptonRibbonGroupCluster4 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.RibbonGroupButton_AlignLeft = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_AlignCenter = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_AlignRight = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.RibbonGroupButton_AlignJustify = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.KryptonRibbonGroup4 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupGallery1 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupGallery()
        Me.ImageList_Styles = New System.Windows.Forms.ImageList(Me.components)
        Me.KryptonRibbonGroup5 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupTriple3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.RibbonGroupButton_Find = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.RibbonTab_Advanced = New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab()
        Me.KryptonRibbonGroup6 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup()
        Me.KryptonRibbonGroupLines3 = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.RibbonGroupClusterColorButton_PageColor = New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupColorButton()
        Me.RichTextBox = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TaskDialog = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialog()
        Me.TaskDialog_OpenNewDocument = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.TaskDialog_OpenDocument = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.TaskDialog_OpenPreferences = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.TaskDialog_ExitWriter = New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand()
        Me.StatusStrip.SuspendLayout()
        CType(Me.Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.HotTrack
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_SaveStatus, Me.ToolStripStatusLabel_Spacer1, Me.ToolStripStatusLabel_WordCount, Me.ToolStripStatusLabel_Spacer2, Me.ToolStripStatusLabel_CharCount, Me.ToolStripStatusLabel_Spacer3, Me.ToolStripStatusLabel_ZoomPercent, Me.ToolStripStatusLabel_Spacer4, Me.ZoomLevelDropdown})
        Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip.Location = New System.Drawing.Point(0, 583)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1250, 21)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_SaveStatus
        '
        Me.ToolStripStatusLabel_SaveStatus.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel_SaveStatus.Name = "ToolStripStatusLabel_SaveStatus"
        Me.ToolStripStatusLabel_SaveStatus.Size = New System.Drawing.Size(61, 15)
        Me.ToolStripStatusLabel_SaveStatus.Text = "Not Saved"
        '
        'ToolStripStatusLabel_Spacer1
        '
        Me.ToolStripStatusLabel_Spacer1.Name = "ToolStripStatusLabel_Spacer1"
        Me.ToolStripStatusLabel_Spacer1.Size = New System.Drawing.Size(157, 15)
        Me.ToolStripStatusLabel_Spacer1.Text = "                                                  "
        '
        'ToolStripStatusLabel_WordCount
        '
        Me.ToolStripStatusLabel_WordCount.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel_WordCount.Name = "ToolStripStatusLabel_WordCount"
        Me.ToolStripStatusLabel_WordCount.Size = New System.Drawing.Size(58, 15)
        Me.ToolStripStatusLabel_WordCount.Text = "## Words"
        '
        'ToolStripStatusLabel_Spacer2
        '
        Me.ToolStripStatusLabel_Spacer2.Name = "ToolStripStatusLabel_Spacer2"
        Me.ToolStripStatusLabel_Spacer2.Size = New System.Drawing.Size(37, 15)
        Me.ToolStripStatusLabel_Spacer2.Text = "          "
        '
        'ToolStripStatusLabel_CharCount
        '
        Me.ToolStripStatusLabel_CharCount.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel_CharCount.Name = "ToolStripStatusLabel_CharCount"
        Me.ToolStripStatusLabel_CharCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel_CharCount.Size = New System.Drawing.Size(80, 15)
        Me.ToolStripStatusLabel_CharCount.Text = "## Characters"
        Me.ToolStripStatusLabel_CharCount.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripStatusLabel_Spacer3
        '
        Me.ToolStripStatusLabel_Spacer3.Name = "ToolStripStatusLabel_Spacer3"
        Me.ToolStripStatusLabel_Spacer3.Size = New System.Drawing.Size(157, 15)
        Me.ToolStripStatusLabel_Spacer3.Text = "                                                  "
        '
        'ToolStripStatusLabel_ZoomPercent
        '
        Me.ToolStripStatusLabel_ZoomPercent.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel_ZoomPercent.Name = "ToolStripStatusLabel_ZoomPercent"
        Me.ToolStripStatusLabel_ZoomPercent.Size = New System.Drawing.Size(66, 15)
        Me.ToolStripStatusLabel_ZoomPercent.Text = "##% Zoom"
        '
        'ToolStripStatusLabel_Spacer4
        '
        Me.ToolStripStatusLabel_Spacer4.Name = "ToolStripStatusLabel_Spacer4"
        Me.ToolStripStatusLabel_Spacer4.Size = New System.Drawing.Size(37, 15)
        Me.ToolStripStatusLabel_Spacer4.Text = "          "
        '
        'ZoomLevelDropdown
        '
        Me.ZoomLevelDropdown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ZoomLevelDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ZoomLevelDropdown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomLevelDropdown_200, Me.ZoomLevelDropdown_190, Me.ZoomLevelDropdown_180, Me.ZoomLevelDropdown_170, Me.ZoomLevelDropdown_160, Me.ZoomLevelDropdown_150, Me.ZoomLevelDropdown_140, Me.ZoomLevelDropdown_130, Me.ZoomLevelDropdown_120, Me.ZoomLevelDropdown_110, Me.ZoomLevelDropdown_100, Me.ZoomLevelDropdown_80, Me.ZoomLevelDropdown_60, Me.ZoomLevelDropdown_40, Me.ZoomLevelDropdown_20})
        Me.ZoomLevelDropdown.ForeColor = System.Drawing.Color.White
        Me.ZoomLevelDropdown.Image = CType(resources.GetObject("ZoomLevelDropdown.Image"), System.Drawing.Image)
        Me.ZoomLevelDropdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomLevelDropdown.Name = "ZoomLevelDropdown"
        Me.ZoomLevelDropdown.Size = New System.Drawing.Size(82, 19)
        Me.ZoomLevelDropdown.Text = "Zoom Level"
        '
        'ZoomLevelDropdown_200
        '
        Me.ZoomLevelDropdown_200.Name = "ZoomLevelDropdown_200"
        Me.ZoomLevelDropdown_200.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_200.Text = "200%"
        '
        'ZoomLevelDropdown_190
        '
        Me.ZoomLevelDropdown_190.Name = "ZoomLevelDropdown_190"
        Me.ZoomLevelDropdown_190.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_190.Text = "190%"
        '
        'ZoomLevelDropdown_180
        '
        Me.ZoomLevelDropdown_180.Name = "ZoomLevelDropdown_180"
        Me.ZoomLevelDropdown_180.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_180.Text = "180%"
        '
        'ZoomLevelDropdown_170
        '
        Me.ZoomLevelDropdown_170.Name = "ZoomLevelDropdown_170"
        Me.ZoomLevelDropdown_170.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_170.Text = "170%"
        '
        'ZoomLevelDropdown_160
        '
        Me.ZoomLevelDropdown_160.Name = "ZoomLevelDropdown_160"
        Me.ZoomLevelDropdown_160.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_160.Text = "160%"
        '
        'ZoomLevelDropdown_150
        '
        Me.ZoomLevelDropdown_150.Name = "ZoomLevelDropdown_150"
        Me.ZoomLevelDropdown_150.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_150.Text = "150%"
        '
        'ZoomLevelDropdown_140
        '
        Me.ZoomLevelDropdown_140.Name = "ZoomLevelDropdown_140"
        Me.ZoomLevelDropdown_140.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_140.Text = "140%"
        '
        'ZoomLevelDropdown_130
        '
        Me.ZoomLevelDropdown_130.Name = "ZoomLevelDropdown_130"
        Me.ZoomLevelDropdown_130.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_130.Text = "130%"
        '
        'ZoomLevelDropdown_120
        '
        Me.ZoomLevelDropdown_120.Name = "ZoomLevelDropdown_120"
        Me.ZoomLevelDropdown_120.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_120.Text = "120%"
        '
        'ZoomLevelDropdown_110
        '
        Me.ZoomLevelDropdown_110.Name = "ZoomLevelDropdown_110"
        Me.ZoomLevelDropdown_110.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_110.Text = "110%"
        '
        'ZoomLevelDropdown_100
        '
        Me.ZoomLevelDropdown_100.Name = "ZoomLevelDropdown_100"
        Me.ZoomLevelDropdown_100.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_100.Text = "Default (100%)"
        '
        'ZoomLevelDropdown_80
        '
        Me.ZoomLevelDropdown_80.Name = "ZoomLevelDropdown_80"
        Me.ZoomLevelDropdown_80.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_80.Text = "80%"
        '
        'ZoomLevelDropdown_60
        '
        Me.ZoomLevelDropdown_60.Name = "ZoomLevelDropdown_60"
        Me.ZoomLevelDropdown_60.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_60.Text = "60%"
        '
        'ZoomLevelDropdown_40
        '
        Me.ZoomLevelDropdown_40.Name = "ZoomLevelDropdown_40"
        Me.ZoomLevelDropdown_40.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_40.Text = "40%"
        '
        'ZoomLevelDropdown_20
        '
        Me.ZoomLevelDropdown_20.Name = "ZoomLevelDropdown_20"
        Me.ZoomLevelDropdown_20.Size = New System.Drawing.Size(151, 22)
        Me.ZoomLevelDropdown_20.Text = "20%"
        '
        'Ribbon
        '
        Me.Ribbon.AllowButtonSpecToolTips = True
        Me.Ribbon.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.Ribbon.InDesignHelperMode = False
        Me.Ribbon.Name = "Ribbon"
        Me.Ribbon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Ribbon.QATButtons.AddRange(New System.ComponentModel.Component() {Me.RibbonQATButton_Save, Me.RibbonQATButton_Undo, Me.RibbonQATButton_Redo})
        Me.Ribbon.RibbonAppButton.AppButtonText = "Document"
        Me.Ribbon.RibbonAppButton.AppButtonVisible = False
        Me.Ribbon.RibbonTabs.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonTab() {Me.RibbonTab_Document, Me.RibbonTab_Text, Me.RibbonTab_Advanced})
        Me.Ribbon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ribbon.SelectedTab = Me.RibbonTab_Text
        Me.Ribbon.Size = New System.Drawing.Size(1250, 152)
        Me.Ribbon.StateCommon.RibbonGeneral.ContextTextFont = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ribbon.StateCommon.RibbonGeneral.RibbonShape = ComponentFactory.Krypton.Toolkit.PaletteRibbonShape.Office2010
        Me.Ribbon.StateCommon.RibbonGeneral.TextFont = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ribbon.StateCommon.RibbonGroupArea.BackColor1 = System.Drawing.SystemColors.HotTrack
        Me.Ribbon.TabIndex = 1
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.Text = "30 days left in trial"
        Me.ButtonSpecAny1.UniqueName = "17ECA389468D498C398477331280C717"
        '
        'RibbonQATButton_Save
        '
        Me.RibbonQATButton_Save.Image = Global.Word_Processor.My.Resources.Resources.save_ico_small
        Me.RibbonQATButton_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.RibbonQATButton_Save.Text = "Save"
        Me.RibbonQATButton_Save.ToolTipBody = "Saves the current document." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RibbonQATButton_Save.ToolTipImage = Global.Word_Processor.My.Resources.Resources.save_ico
        Me.RibbonQATButton_Save.ToolTipTitle = "Save"
        '
        'RibbonQATButton_Undo
        '
        Me.RibbonQATButton_Undo.Image = Global.Word_Processor.My.Resources.Resources.undo_ico_small
        Me.RibbonQATButton_Undo.Text = "Undo"
        Me.RibbonQATButton_Undo.ToolTipBody = "Undoes the previous edit."
        Me.RibbonQATButton_Undo.ToolTipImage = Global.Word_Processor.My.Resources.Resources.undo_ico
        Me.RibbonQATButton_Undo.ToolTipTitle = "Undo"
        '
        'RibbonQATButton_Redo
        '
        Me.RibbonQATButton_Redo.Image = Global.Word_Processor.My.Resources.Resources.redo_ico_small
        Me.RibbonQATButton_Redo.Text = "Redo"
        Me.RibbonQATButton_Redo.ToolTipBody = "Redoes the proceeding edit."
        Me.RibbonQATButton_Redo.ToolTipImage = Global.Word_Processor.My.Resources.Resources.redo_ico
        Me.RibbonQATButton_Redo.ToolTipTitle = "Redo"
        '
        'RibbonTab_Document
        '
        Me.RibbonTab_Document.Groups.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup() {Me.RibbonGroup_Document_File, Me.RibbonGroup_Document_Other})
        Me.RibbonTab_Document.KeyTip = "Q"
        Me.RibbonTab_Document.Text = "Document"
        '
        'RibbonGroup_Document_File
        '
        Me.RibbonGroup_Document_File.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.RibbonGroupTriple1})
        Me.RibbonGroup_Document_File.TextLine1 = "File"
        '
        'RibbonGroupTriple1
        '
        Me.RibbonGroupTriple1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_Open, Me.RibbonGroupButton_Save, Me.RibbonGroupButton_SaveAs})
        '
        'RibbonGroupButton_Open
        '
        Me.RibbonGroupButton_Open.ImageLarge = Global.Word_Processor.My.Resources.Resources.open_ico
        Me.RibbonGroupButton_Open.KeyTip = "A"
        Me.RibbonGroupButton_Open.TextLine1 = "Open"
        Me.RibbonGroupButton_Open.ToolTipBody = "Opens a document."
        Me.RibbonGroupButton_Open.ToolTipImage = Global.Word_Processor.My.Resources.Resources.open_ico
        Me.RibbonGroupButton_Open.ToolTipTitle = "Open"
        '
        'RibbonGroupButton_Save
        '
        Me.RibbonGroupButton_Save.ImageLarge = Global.Word_Processor.My.Resources.Resources.save_ico
        Me.RibbonGroupButton_Save.ImageSmall = Global.Word_Processor.My.Resources.Resources.save_ico_small
        Me.RibbonGroupButton_Save.KeyTip = "S"
        Me.RibbonGroupButton_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Save.TextLine1 = "Save"
        Me.RibbonGroupButton_Save.ToolTipBody = "Saves the current document."
        Me.RibbonGroupButton_Save.ToolTipImage = Global.Word_Processor.My.Resources.Resources.save_ico
        Me.RibbonGroupButton_Save.ToolTipTitle = "Save"
        '
        'RibbonGroupButton_SaveAs
        '
        Me.RibbonGroupButton_SaveAs.ImageLarge = Global.Word_Processor.My.Resources.Resources.save_ico
        Me.RibbonGroupButton_SaveAs.ImageSmall = Global.Word_Processor.My.Resources.Resources.save_ico_small
        Me.RibbonGroupButton_SaveAs.KeyTip = "D"
        Me.RibbonGroupButton_SaveAs.TextLine1 = "Save"
        Me.RibbonGroupButton_SaveAs.TextLine2 = "As..."
        Me.RibbonGroupButton_SaveAs.ToolTipBody = "Saves the document in a different format or extension."
        Me.RibbonGroupButton_SaveAs.ToolTipImage = Global.Word_Processor.My.Resources.Resources.save_ico
        Me.RibbonGroupButton_SaveAs.ToolTipTitle = "Save As..."
        '
        'RibbonGroup_Document_Other
        '
        Me.RibbonGroup_Document_Other.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.RibbonGroupTriple2})
        Me.RibbonGroup_Document_Other.TextLine1 = "Other"
        '
        'RibbonGroupTriple2
        '
        Me.RibbonGroupTriple2.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_Preferences, Me.RibbonGroupButton_AboutWriter, Me.RibbonGroupButton_Exit})
        '
        'RibbonGroupButton_Preferences
        '
        Me.RibbonGroupButton_Preferences.ImageLarge = Global.Word_Processor.My.Resources.Resources.settings_ico
        Me.RibbonGroupButton_Preferences.KeyTip = "F"
        Me.RibbonGroupButton_Preferences.TextLine1 = "Preferences"
        Me.RibbonGroupButton_Preferences.ToolTipBody = "Change settings."
        Me.RibbonGroupButton_Preferences.ToolTipImage = Global.Word_Processor.My.Resources.Resources.settings_ico
        Me.RibbonGroupButton_Preferences.ToolTipTitle = "Preferences"
        '
        'RibbonGroupButton_AboutWriter
        '
        Me.RibbonGroupButton_AboutWriter.ImageLarge = Global.Word_Processor.My.Resources.Resources.about_ico
        Me.RibbonGroupButton_AboutWriter.ImageSmall = Global.Word_Processor.My.Resources.Resources.about_ico_small
        Me.RibbonGroupButton_AboutWriter.KeyTip = "G"
        Me.RibbonGroupButton_AboutWriter.TextLine1 = "About Writer"
        '
        'RibbonGroupButton_Exit
        '
        Me.RibbonGroupButton_Exit.ImageLarge = Global.Word_Processor.My.Resources.Resources.close_ico
        Me.RibbonGroupButton_Exit.ImageSmall = Global.Word_Processor.My.Resources.Resources.close_ico_small
        Me.RibbonGroupButton_Exit.KeyTip = "H"
        Me.RibbonGroupButton_Exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Exit.TextLine1 = "Exit"
        '
        'RibbonTab_Text
        '
        Me.RibbonTab_Text.Groups.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup() {Me.KryptonRibbonGroup1, Me.KryptonRibbonGroup2, Me.KryptonRibbonGroup3, Me.KryptonRibbonGroup4, Me.KryptonRibbonGroup5})
        Me.RibbonTab_Text.KeyTip = "W"
        Me.RibbonTab_Text.Text = "Text"
        '
        'KryptonRibbonGroup1
        '
        Me.KryptonRibbonGroup1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupTriple2, Me.KryptonRibbonGroupTriple1})
        Me.KryptonRibbonGroup1.TextLine1 = " "
        '
        'KryptonRibbonGroupTriple1
        '
        Me.KryptonRibbonGroupTriple1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_Cut, Me.RibbonGroupButton_Copy, Me.RibbonGroupButton_Paste})
        Me.KryptonRibbonGroupTriple1.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium
        '
        'RibbonGroupButton_Cut
        '
        Me.RibbonGroupButton_Cut.ImageSmall = Global.Word_Processor.My.Resources.Resources.cut_ico_small
        Me.RibbonGroupButton_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Cut.TextLine1 = "Cut"
        Me.RibbonGroupButton_Cut.ToolTipBody = "Cuts the current selection."
        '
        'RibbonGroupButton_Copy
        '
        Me.RibbonGroupButton_Copy.ImageSmall = Global.Word_Processor.My.Resources.Resources.copy_ico_small
        Me.RibbonGroupButton_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Copy.TextLine1 = "Copy"
        Me.RibbonGroupButton_Copy.ToolTipBody = "Copies the current selection."
        '
        'RibbonGroupButton_Paste
        '
        Me.RibbonGroupButton_Paste.ImageSmall = Global.Word_Processor.My.Resources.Resources.paste_ico_small
        Me.RibbonGroupButton_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Paste.TextLine1 = "Paste"
        Me.RibbonGroupButton_Paste.ToolTipBody = "Pastes the most recent item in the clipboard."
        '
        'KryptonRibbonGroup2
        '
        Me.KryptonRibbonGroup2.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupLines1})
        Me.KryptonRibbonGroup2.TextLine1 = "Appearance"
        '
        'KryptonRibbonGroupLines1
        '
        Me.KryptonRibbonGroupLines1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupComboBox_FontSelect, Me.RibbonGroupNumericUpDown_FontSize, Me.RibbonGroupButton_ClearFormatting, Me.KryptonRibbonGroupCluster1, Me.KryptonRibbonGroupCluster2})
        '
        'RibbonGroupComboBox_FontSelect
        '
        Me.RibbonGroupComboBox_FontSelect.DropDownWidth = 121
        Me.RibbonGroupComboBox_FontSelect.FormattingEnabled = False
        Me.RibbonGroupComboBox_FontSelect.ItemHeight = 15
        Me.RibbonGroupComboBox_FontSelect.Text = ""
        '
        'RibbonGroupNumericUpDown_FontSize
        '
        Me.RibbonGroupNumericUpDown_FontSize.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'RibbonGroupButton_ClearFormatting
        '
        Me.RibbonGroupButton_ClearFormatting.ImageSmall = Global.Word_Processor.My.Resources.Resources.clearformatting_ico_small
        Me.RibbonGroupButton_ClearFormatting.TextLine1 = " "
        Me.RibbonGroupButton_ClearFormatting.ToolTipBody = "Clears all formatting from the selected text, leaving the original unformatted te" &
    "xt."
        Me.RibbonGroupButton_ClearFormatting.ToolTipTitle = "Clear All Formatting"
        '
        'KryptonRibbonGroupCluster1
        '
        Me.KryptonRibbonGroupCluster1.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_Bold, Me.RibbonGroupButton_Italicize, Me.RibbonGroupButton_Underline, Me.RibbonGroupButton_Strikethrough, Me.RibbonGroupButton_Subscript, Me.RibbonGroupButton_Superscript})
        '
        'RibbonGroupButton_Bold
        '
        Me.RibbonGroupButton_Bold.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check
        Me.RibbonGroupButton_Bold.ImageSmall = Global.Word_Processor.My.Resources.Resources.bold_ico
        Me.RibbonGroupButton_Bold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Bold.ToolTipBody = "Bolds selected text."
        Me.RibbonGroupButton_Bold.ToolTipTitle = "Bold"
        '
        'RibbonGroupButton_Italicize
        '
        Me.RibbonGroupButton_Italicize.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check
        Me.RibbonGroupButton_Italicize.ImageSmall = Global.Word_Processor.My.Resources.Resources.italic_ico
        Me.RibbonGroupButton_Italicize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Italicize.ToolTipBody = "Italicizes selected text."
        Me.RibbonGroupButton_Italicize.ToolTipTitle = "Italics"
        '
        'RibbonGroupButton_Underline
        '
        Me.RibbonGroupButton_Underline.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Check
        Me.RibbonGroupButton_Underline.ImageSmall = Global.Word_Processor.My.Resources.Resources.underline_ico
        Me.RibbonGroupButton_Underline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.RibbonGroupButton_Underline.ToolTipBody = "Underlines selected text."
        Me.RibbonGroupButton_Underline.ToolTipTitle = "Underline"
        '
        'RibbonGroupButton_Strikethrough
        '
        Me.RibbonGroupButton_Strikethrough.ImageSmall = Global.Word_Processor.My.Resources.Resources.strikethrough_ico_small
        Me.RibbonGroupButton_Strikethrough.ToolTipBody = "Strikethroughs selected text."
        Me.RibbonGroupButton_Strikethrough.ToolTipTitle = "Strikethrough"
        '
        'RibbonGroupButton_Subscript
        '
        Me.RibbonGroupButton_Subscript.ImageSmall = Global.Word_Processor.My.Resources.Resources.subscript_ico_small
        Me.RibbonGroupButton_Subscript.ToolTipBody = "Subscripts selected text."
        Me.RibbonGroupButton_Subscript.ToolTipTitle = "Subscript"
        '
        'RibbonGroupButton_Superscript
        '
        Me.RibbonGroupButton_Superscript.ImageSmall = Global.Word_Processor.My.Resources.Resources.superscript_ico_small
        Me.RibbonGroupButton_Superscript.ToolTipBody = "Superscripts selected text."
        Me.RibbonGroupButton_Superscript.ToolTipTitle = "Superscript"
        '
        'KryptonRibbonGroupCluster2
        '
        Me.KryptonRibbonGroupCluster2.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupClusterColorButton_TextColor, Me.RibbonGroupClusterColorButton_HighlightColor})
        '
        'RibbonGroupClusterColorButton_TextColor
        '
        Me.RibbonGroupClusterColorButton_TextColor.RecentColors = New System.Drawing.Color(-1) {}
        Me.RibbonGroupClusterColorButton_TextColor.SelectedColor = System.Drawing.Color.Yellow
        Me.RibbonGroupClusterColorButton_TextColor.ToolTipBody = "Changes the color of selected text."
        Me.RibbonGroupClusterColorButton_TextColor.ToolTipTitle = "Text Color"
        '
        'RibbonGroupClusterColorButton_HighlightColor
        '
        Me.RibbonGroupClusterColorButton_HighlightColor.RecentColors = New System.Drawing.Color(-1) {}
        Me.RibbonGroupClusterColorButton_HighlightColor.ToolTipBody = "Changes the highlight color of selected text."
        Me.RibbonGroupClusterColorButton_HighlightColor.ToolTipTitle = "Highlight Color"
        Me.RibbonGroupClusterColorButton_HighlightColor.VisibleMoreColors = False
        '
        'KryptonRibbonGroup3
        '
        Me.KryptonRibbonGroup3.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupLines2})
        Me.KryptonRibbonGroup3.TextLine1 = "Layout"
        '
        'KryptonRibbonGroupLines2
        '
        Me.KryptonRibbonGroupLines2.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.KryptonRibbonGroupCluster3, Me.KryptonRibbonGroupCluster6, Me.KryptonRibbonGroupCluster4})
        Me.KryptonRibbonGroupLines2.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium
        '
        'KryptonRibbonGroupCluster3
        '
        Me.KryptonRibbonGroupCluster3.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_BulletedList, Me.RibbonGroupButton_NumberedList})
        '
        'RibbonGroupButton_BulletedList
        '
        Me.RibbonGroupButton_BulletedList.ImageSmall = Global.Word_Processor.My.Resources.Resources.bulletedlist_ico_small
        Me.RibbonGroupButton_BulletedList.ToolTipBody = "Creates a bulleted list."
        Me.RibbonGroupButton_BulletedList.ToolTipTitle = "Bullet"
        '
        'RibbonGroupButton_NumberedList
        '
        Me.RibbonGroupButton_NumberedList.ImageSmall = Global.Word_Processor.My.Resources.Resources.numberedlist_ico_small
        Me.RibbonGroupButton_NumberedList.ToolTipBody = "Creates a numbered list."
        Me.RibbonGroupButton_NumberedList.ToolTipTitle = "Numbering"
        '
        'KryptonRibbonGroupCluster6
        '
        Me.KryptonRibbonGroupCluster6.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_DecreaseIndent, Me.RibbonGroupButton_IncreaseIndent})
        '
        'RibbonGroupButton_DecreaseIndent
        '
        Me.RibbonGroupButton_DecreaseIndent.ImageSmall = Global.Word_Processor.My.Resources.Resources.decreaseident_ico_small
        Me.RibbonGroupButton_DecreaseIndent.ToolTipBody = "Decreases the selected text's indent."
        Me.RibbonGroupButton_DecreaseIndent.ToolTipTitle = "Decrease Indent"
        '
        'RibbonGroupButton_IncreaseIndent
        '
        Me.RibbonGroupButton_IncreaseIndent.ImageSmall = Global.Word_Processor.My.Resources.Resources.increaseident_ico_small
        Me.RibbonGroupButton_IncreaseIndent.ToolTipBody = "Increases the selected text's indent."
        Me.RibbonGroupButton_IncreaseIndent.ToolTipTitle = "Increase Indent"
        '
        'KryptonRibbonGroupCluster4
        '
        Me.KryptonRibbonGroupCluster4.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_AlignLeft, Me.RibbonGroupButton_AlignCenter, Me.RibbonGroupButton_AlignRight, Me.RibbonGroupButton_AlignJustify})
        '
        'RibbonGroupButton_AlignLeft
        '
        Me.RibbonGroupButton_AlignLeft.ImageSmall = Global.Word_Processor.My.Resources.Resources.alignleft_small_ico
        Me.RibbonGroupButton_AlignLeft.ToolTipBody = "Aligns selected text to the left."
        Me.RibbonGroupButton_AlignLeft.ToolTipTitle = "Align Left"
        '
        'RibbonGroupButton_AlignCenter
        '
        Me.RibbonGroupButton_AlignCenter.ImageSmall = Global.Word_Processor.My.Resources.Resources.center_small_ico
        Me.RibbonGroupButton_AlignCenter.ToolTipBody = "Centers selected text."
        Me.RibbonGroupButton_AlignCenter.ToolTipTitle = "Center"
        '
        'RibbonGroupButton_AlignRight
        '
        Me.RibbonGroupButton_AlignRight.ImageSmall = Global.Word_Processor.My.Resources.Resources.alignright_small_ico
        Me.RibbonGroupButton_AlignRight.ToolTipBody = "Aligns selected text to the right."
        Me.RibbonGroupButton_AlignRight.ToolTipTitle = "Align Right"
        '
        'RibbonGroupButton_AlignJustify
        '
        Me.RibbonGroupButton_AlignJustify.ImageSmall = Global.Word_Processor.My.Resources.Resources.justify_small_ico
        Me.RibbonGroupButton_AlignJustify.ToolTipBody = "Makes selected text fit the page width."
        Me.RibbonGroupButton_AlignJustify.ToolTipTitle = "Justify"
        '
        'KryptonRibbonGroup4
        '
        Me.KryptonRibbonGroup4.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupGallery1})
        Me.KryptonRibbonGroup4.TextLine1 = "Font Styles"
        '
        'KryptonRibbonGroupGallery1
        '
        Me.KryptonRibbonGroupGallery1.ImageList = Me.ImageList_Styles
        '
        'ImageList_Styles
        '
        Me.ImageList_Styles.ImageStream = CType(resources.GetObject("ImageList_Styles.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Styles.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Styles.Images.SetKeyName(0, "Regular.png")
        Me.ImageList_Styles.Images.SetKeyName(1, "Professional.png")
        Me.ImageList_Styles.Images.SetKeyName(2, "Title.png")
        Me.ImageList_Styles.Images.SetKeyName(3, "Heading 1.png")
        Me.ImageList_Styles.Images.SetKeyName(4, "Professional Heading 1.png")
        Me.ImageList_Styles.Images.SetKeyName(5, "Heading 2.png")
        Me.ImageList_Styles.Images.SetKeyName(6, "Professional Heading 2.png")
        '
        'KryptonRibbonGroup5
        '
        Me.KryptonRibbonGroup5.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupTriple3})
        Me.KryptonRibbonGroup5.TextLine1 = "Edit"
        '
        'KryptonRibbonGroupTriple3
        '
        Me.KryptonRibbonGroupTriple3.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupButton_Find})
        Me.KryptonRibbonGroupTriple3.MaximumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Medium
        '
        'RibbonGroupButton_Find
        '
        Me.RibbonGroupButton_Find.ImageSmall = Global.Word_Processor.My.Resources.Resources.find_ico_small
        Me.RibbonGroupButton_Find.TextLine1 = "Find"
        Me.RibbonGroupButton_Find.ToolTipBody = "Finds instances of the specified string in your document."
        Me.RibbonGroupButton_Find.ToolTipTitle = "Find"
        '
        'RibbonTab_Advanced
        '
        Me.RibbonTab_Advanced.Groups.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup() {Me.KryptonRibbonGroup6})
        Me.RibbonTab_Advanced.KeyTip = "E"
        Me.RibbonTab_Advanced.Text = "Advanced"
        '
        'KryptonRibbonGroup6
        '
        Me.KryptonRibbonGroup6.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer() {Me.KryptonRibbonGroupLines3})
        Me.KryptonRibbonGroup6.TextLine1 = "Appearance"
        '
        'KryptonRibbonGroupLines3
        '
        Me.KryptonRibbonGroupLines3.Items.AddRange(New ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem() {Me.RibbonGroupClusterColorButton_PageColor})
        '
        'RibbonGroupClusterColorButton_PageColor
        '
        Me.RibbonGroupClusterColorButton_PageColor.RecentColors = New System.Drawing.Color(-1) {}
        Me.RibbonGroupClusterColorButton_PageColor.TextLine1 = "Page Color"
        '
        'RichTextBox
        '
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.EnableAutoDragDrop = True
        Me.RichTextBox.HideSelection = False
        Me.RichTextBox.Location = New System.Drawing.Point(0, 152)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox.Size = New System.Drawing.Size(1250, 431)
        Me.RichTextBox.TabIndex = 2
        Me.RichTextBox.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TaskDialog
        '
        Me.TaskDialog.CheckboxText = Nothing
        Me.TaskDialog.CommandButtons.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand() {Me.TaskDialog_OpenNewDocument, Me.TaskDialog_OpenDocument, Me.TaskDialog_OpenPreferences, Me.TaskDialog_ExitWriter})
        Me.TaskDialog.CommonButtons = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.None
        Me.TaskDialog.Content = "What do you want to do?"
        Me.TaskDialog.DefaultRadioButton = Nothing
        Me.TaskDialog.FooterHyperlink = Nothing
        Me.TaskDialog.FooterText = "Vicrosoft © 2022"
        Me.TaskDialog.Icon = System.Windows.Forms.MessageBoxIcon.Question
        Me.TaskDialog.MainInstruction = "Welcome to Writer!"
        Me.TaskDialog.WindowTitle = "Start Screen"
        '
        'TaskDialog_OpenNewDocument
        '
        Me.TaskDialog_OpenNewDocument.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.TaskDialog_OpenNewDocument.Text = "Open a new document"
        '
        'TaskDialog_OpenDocument
        '
        Me.TaskDialog_OpenDocument.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.TaskDialog_OpenDocument.Text = "Open a document"
        '
        'TaskDialog_OpenPreferences
        '
        Me.TaskDialog_OpenPreferences.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.TaskDialog_OpenPreferences.Text = "Change some settings"
        '
        'TaskDialog_ExitWriter
        '
        Me.TaskDialog_ExitWriter.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.TaskDialog_ExitWriter.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 604)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.Ribbon)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Writer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents Ribbon As ComponentFactory.Krypton.Ribbon.KryptonRibbon
    Friend WithEvents RibbonQATButton_Save As ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents RibbonQATButton_Undo As ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents RibbonQATButton_Redo As ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents RibbonTab_Text As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents RibbonTab_Advanced As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents RichTextBox As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents ToolStripStatusLabel_ZoomPercent As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Spacer3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_WordCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Spacer4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_CharCount As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_SaveStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Spacer1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Spacer2 As ToolStripStatusLabel
    Friend WithEvents ZoomLevelDropdown As ToolStripDropDownButton
    Friend WithEvents ZoomLevelDropdown_170 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_160 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_150 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_140 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_130 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_120 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_110 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_100 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_80 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_60 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_40 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_20 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_200 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_190 As ToolStripMenuItem
    Friend WithEvents ZoomLevelDropdown_180 As ToolStripMenuItem
    Friend WithEvents RibbonTab_Document As ComponentFactory.Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents RibbonGroup_Document_File As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents RibbonGroupTriple1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents RibbonGroupButton_Open As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroupButton_Save As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroupButton_SaveAs As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroup_Document_Other As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents RibbonGroupTriple2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents RibbonGroupButton_Preferences As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroupButton_Exit As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TaskDialog As ComponentFactory.Krypton.Toolkit.KryptonTaskDialog
    Friend WithEvents TaskDialog_OpenNewDocument As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents TaskDialog_OpenDocument As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents TaskDialog_OpenPreferences As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents TaskDialog_ExitWriter As ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand
    Friend WithEvents RibbonGroupButton_AboutWriter As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroup1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupTriple2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents KryptonRibbonGroupTriple1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents RibbonGroupButton_Cut As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroupButton_Copy As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents RibbonGroupButton_Paste As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroup2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupLines1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents RibbonGroupComboBox_FontSelect As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox
    Friend WithEvents RibbonGroupNumericUpDown_FontSize As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupNumericUpDown
    Friend WithEvents KryptonRibbonGroupCluster1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents RibbonGroupButton_Bold As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_Italicize As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_Underline As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_Strikethrough As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_Subscript As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_Superscript As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents KryptonRibbonGroupCluster2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents RibbonGroupClusterColorButton_TextColor As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterColorButton
    Friend WithEvents RibbonGroupClusterColorButton_HighlightColor As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterColorButton
    Friend WithEvents RibbonGroupButton_ClearFormatting As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroup3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupLines2 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents KryptonRibbonGroup4 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupGallery1 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupGallery
    Friend WithEvents KryptonRibbonGroup5 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupTriple3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents RibbonGroupButton_Find As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents KryptonRibbonGroupCluster3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents RibbonGroupButton_NumberedList As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_BulletedList As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents KryptonRibbonGroupCluster6 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents RibbonGroupButton_DecreaseIndent As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_IncreaseIndent As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents KryptonRibbonGroupCluster4 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents RibbonGroupButton_AlignLeft As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_AlignCenter As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_AlignRight As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents RibbonGroupButton_AlignJustify As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents ImageList_Styles As ImageList
    Friend WithEvents KryptonRibbonGroup6 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents KryptonRibbonGroupLines3 As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents RibbonGroupClusterColorButton_PageColor As ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupColorButton
End Class
