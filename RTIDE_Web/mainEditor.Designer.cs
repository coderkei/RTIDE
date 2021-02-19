namespace RTIDE_Web
{
    partial class mainEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainEditor));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.previewInDefaultBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewInChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewInFirefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewInInternetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCompleteSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickStartGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ideTabs = new System.Windows.Forms.TabControl();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.lineNumberBoxHTML = new System.Windows.Forms.RichTextBox();
            this.codeSuggestBox = new System.Windows.Forms.ListBox();
            this.htmlBox = new System.Windows.Forms.RichTextBox();
            this.editorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cssTab = new System.Windows.Forms.TabPage();
            this.updateCSS = new System.Windows.Forms.Button();
            this.lineNumberBoxCSS = new System.Windows.Forms.RichTextBox();
            this.cssBox = new System.Windows.Forms.RichTextBox();
            this.linksTabs = new System.Windows.Forms.TabPage();
            this.linkList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.ideTabs.SuspendLayout();
            this.htmlTab.SuspendLayout();
            this.editorMenu.SuspendLayout();
            this.cssTab.SuspendLayout();
            this.linksTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem,
            this.cSSToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.fileToolStripMenuItem1.Text = "File...";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.newFile);
            // 
            // cSSToolStripMenuItem
            // 
            this.cSSToolStripMenuItem.Name = "cSSToolStripMenuItem";
            this.cSSToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cSSToolStripMenuItem.Text = "CSS";
            this.cSSToolStripMenuItem.Click += new System.EventHandler(this.newCSS);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.uRLToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.fileToolStripMenuItem2.Text = "File...";
            this.fileToolStripMenuItem2.Click += new System.EventHandler(this.openFile);
            // 
            // uRLToolStripMenuItem
            // 
            this.uRLToolStripMenuItem.Name = "uRLToolStripMenuItem";
            this.uRLToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.uRLToolStripMenuItem.Text = "URL...";
            this.uRLToolStripMenuItem.Click += new System.EventHandler(this.loadURL);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem1,
            this.cSSToolStripMenuItem1});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveFileToolStripMenuItem.Text = "Save File...";
            // 
            // hTMLToolStripMenuItem1
            // 
            this.hTMLToolStripMenuItem1.Name = "hTMLToolStripMenuItem1";
            this.hTMLToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.hTMLToolStripMenuItem1.Text = "HTML";
            this.hTMLToolStripMenuItem1.Click += new System.EventHandler(this.saveFile);
            // 
            // cSSToolStripMenuItem1
            // 
            this.cSSToolStripMenuItem1.Name = "cSSToolStripMenuItem1";
            this.cSSToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.cSSToolStripMenuItem1.Text = "CSS";
            this.cSSToolStripMenuItem1.Click += new System.EventHandler(this.saveCSS);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitApplication);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undo);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delete);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAll);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToggle});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullscreenToggle
            // 
            this.fullscreenToggle.Name = "fullscreenToggle";
            this.fullscreenToggle.Size = new System.Drawing.Size(131, 22);
            this.fullscreenToggle.Text = "Full Screen";
            this.fullscreenToggle.Click += new System.EventHandler(this.fullscreen);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePreviewToolStripMenuItem,
            this.refreshPreviewToolStripMenuItem,
            this.toolStripSeparator8,
            this.previewInDefaultBrowserToolStripMenuItem,
            this.previewInChromeToolStripMenuItem,
            this.previewInFirefoxToolStripMenuItem,
            this.previewInInternetExplorerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // updatePreviewToolStripMenuItem
            // 
            this.updatePreviewToolStripMenuItem.Name = "updatePreviewToolStripMenuItem";
            this.updatePreviewToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.updatePreviewToolStripMenuItem.Text = "Update Preview";
            this.updatePreviewToolStripMenuItem.Click += new System.EventHandler(this.manualUpdate);
            // 
            // refreshPreviewToolStripMenuItem
            // 
            this.refreshPreviewToolStripMenuItem.Name = "refreshPreviewToolStripMenuItem";
            this.refreshPreviewToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.refreshPreviewToolStripMenuItem.Text = "Refresh Preview";
            this.refreshPreviewToolStripMenuItem.Click += new System.EventHandler(this.refreshPreview);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(214, 6);
            // 
            // previewInDefaultBrowserToolStripMenuItem
            // 
            this.previewInDefaultBrowserToolStripMenuItem.Name = "previewInDefaultBrowserToolStripMenuItem";
            this.previewInDefaultBrowserToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.previewInDefaultBrowserToolStripMenuItem.Text = "Preview in Default Browser";
            this.previewInDefaultBrowserToolStripMenuItem.Click += new System.EventHandler(this.prevDefault);
            // 
            // previewInChromeToolStripMenuItem
            // 
            this.previewInChromeToolStripMenuItem.Name = "previewInChromeToolStripMenuItem";
            this.previewInChromeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.previewInChromeToolStripMenuItem.Text = "Preview in Chrome";
            this.previewInChromeToolStripMenuItem.Click += new System.EventHandler(this.prevChrome);
            // 
            // previewInFirefoxToolStripMenuItem
            // 
            this.previewInFirefoxToolStripMenuItem.Name = "previewInFirefoxToolStripMenuItem";
            this.previewInFirefoxToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.previewInFirefoxToolStripMenuItem.Text = "Preview in Firefox";
            this.previewInFirefoxToolStripMenuItem.Click += new System.EventHandler(this.prevFirefox);
            // 
            // previewInInternetExplorerToolStripMenuItem
            // 
            this.previewInInternetExplorerToolStripMenuItem.Name = "previewInInternetExplorerToolStripMenuItem";
            this.previewInInternetExplorerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.previewInInternetExplorerToolStripMenuItem.Text = "Preview in Internet Explorer";
            this.previewInInternetExplorerToolStripMenuItem.Click += new System.EventHandler(this.prevIE);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realTimeSelector,
            this.autoCompleteSelector,
            this.syntaxSelector});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // realTimeSelector
            // 
            this.realTimeSelector.Checked = true;
            this.realTimeSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.realTimeSelector.Name = "realTimeSelector";
            this.realTimeSelector.Size = new System.Drawing.Size(217, 22);
            this.realTimeSelector.Text = "Real-Time Preview";
            this.realTimeSelector.Click += new System.EventHandler(this.rtCheck);
            // 
            // autoCompleteSelector
            // 
            this.autoCompleteSelector.Checked = true;
            this.autoCompleteSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCompleteSelector.Name = "autoCompleteSelector";
            this.autoCompleteSelector.Size = new System.Drawing.Size(217, 22);
            this.autoCompleteSelector.Text = "Autocomplete Suggestions";
            this.autoCompleteSelector.Click += new System.EventHandler(this.asCheck);
            // 
            // syntaxSelector
            // 
            this.syntaxSelector.Checked = true;
            this.syntaxSelector.CheckState = System.Windows.Forms.CheckState.Checked;
            this.syntaxSelector.Name = "syntaxSelector";
            this.syntaxSelector.Size = new System.Drawing.Size(217, 22);
            this.syntaxSelector.Text = "HTML Syntax Highlighting";
            this.syntaxSelector.Click += new System.EventHandler(this.shCheck);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.quickStartGuideToolStripMenuItem,
            this.toolStripSeparator9,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.openMainHelp);
            // 
            // quickStartGuideToolStripMenuItem
            // 
            this.quickStartGuideToolStripMenuItem.Name = "quickStartGuideToolStripMenuItem";
            this.quickStartGuideToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.quickStartGuideToolStripMenuItem.Text = "Quick Start";
            this.quickStartGuideToolStripMenuItem.Click += new System.EventHandler(this.quickStart);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(129, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.showAbout);
            // 
            // ideTabs
            // 
            this.ideTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ideTabs.Controls.Add(this.htmlTab);
            this.ideTabs.Controls.Add(this.cssTab);
            this.ideTabs.Controls.Add(this.linksTabs);
            this.ideTabs.Location = new System.Drawing.Point(12, 27);
            this.ideTabs.Name = "ideTabs";
            this.ideTabs.SelectedIndex = 0;
            this.ideTabs.Size = new System.Drawing.Size(504, 691);
            this.ideTabs.TabIndex = 1;
            this.ideTabs.SelectedIndexChanged += new System.EventHandler(this.switchTabs);
            // 
            // htmlTab
            // 
            this.htmlTab.Controls.Add(this.lineNumberBoxHTML);
            this.htmlTab.Controls.Add(this.codeSuggestBox);
            this.htmlTab.Controls.Add(this.htmlBox);
            this.htmlTab.Location = new System.Drawing.Point(4, 22);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(3);
            this.htmlTab.Size = new System.Drawing.Size(496, 665);
            this.htmlTab.TabIndex = 0;
            this.htmlTab.Text = "HTML";
            this.htmlTab.UseVisualStyleBackColor = true;
            // 
            // lineNumberBoxHTML
            // 
            this.lineNumberBoxHTML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lineNumberBoxHTML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberBoxHTML.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNumberBoxHTML.ForeColor = System.Drawing.Color.Gray;
            this.lineNumberBoxHTML.Location = new System.Drawing.Point(7, 9);
            this.lineNumberBoxHTML.Name = "lineNumberBoxHTML";
            this.lineNumberBoxHTML.ReadOnly = true;
            this.lineNumberBoxHTML.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberBoxHTML.Size = new System.Drawing.Size(33, 653);
            this.lineNumberBoxHTML.TabIndex = 1;
            this.lineNumberBoxHTML.Text = "";
            this.lineNumberBoxHTML.WordWrap = false;
            // 
            // codeSuggestBox
            // 
            this.codeSuggestBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeSuggestBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.codeSuggestBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeSuggestBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeSuggestBox.FormattingEnabled = true;
            this.codeSuggestBox.ItemHeight = 18;
            this.codeSuggestBox.Location = new System.Drawing.Point(314, 0);
            this.codeSuggestBox.Name = "codeSuggestBox";
            this.codeSuggestBox.Size = new System.Drawing.Size(179, 92);
            this.codeSuggestBox.TabIndex = 2;
            this.codeSuggestBox.Visible = false;
            this.codeSuggestBox.SelectedIndexChanged += new System.EventHandler(this.changeIndex);
            // 
            // htmlBox
            // 
            this.htmlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlBox.ContextMenuStrip = this.editorMenu;
            this.htmlBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlBox.Location = new System.Drawing.Point(46, 6);
            this.htmlBox.Name = "htmlBox";
            this.htmlBox.Size = new System.Drawing.Size(444, 653);
            this.htmlBox.TabIndex = 0;
            this.htmlBox.Text = "";
            this.htmlBox.WordWrap = false;
            this.htmlBox.SelectionChanged += new System.EventHandler(this.htmlSelChange);
            this.htmlBox.VScroll += new System.EventHandler(this.htmlScroll);
            this.htmlBox.TextChanged += new System.EventHandler(this.htmlUpdate);
            // 
            // editorMenu
            // 
            this.editorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.toolStripSeparator10,
            this.selectAllToolStripMenuItem1});
            this.editorMenu.Name = "editorMenu";
            this.editorMenu.Size = new System.Drawing.Size(123, 120);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cut);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copy);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.paste);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.delete);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem1.Text = "Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAll);
            // 
            // cssTab
            // 
            this.cssTab.Controls.Add(this.updateCSS);
            this.cssTab.Controls.Add(this.lineNumberBoxCSS);
            this.cssTab.Controls.Add(this.cssBox);
            this.cssTab.Location = new System.Drawing.Point(4, 22);
            this.cssTab.Name = "cssTab";
            this.cssTab.Padding = new System.Windows.Forms.Padding(3);
            this.cssTab.Size = new System.Drawing.Size(496, 665);
            this.cssTab.TabIndex = 1;
            this.cssTab.Text = "CSS";
            this.cssTab.UseVisualStyleBackColor = true;
            // 
            // updateCSS
            // 
            this.updateCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateCSS.Location = new System.Drawing.Point(46, 636);
            this.updateCSS.Name = "updateCSS";
            this.updateCSS.Size = new System.Drawing.Size(75, 23);
            this.updateCSS.TabIndex = 4;
            this.updateCSS.Text = "Update";
            this.updateCSS.UseVisualStyleBackColor = true;
            this.updateCSS.Click += new System.EventHandler(this.writeCSS);
            // 
            // lineNumberBoxCSS
            // 
            this.lineNumberBoxCSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lineNumberBoxCSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberBoxCSS.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNumberBoxCSS.ForeColor = System.Drawing.Color.Gray;
            this.lineNumberBoxCSS.Location = new System.Drawing.Point(7, 9);
            this.lineNumberBoxCSS.Name = "lineNumberBoxCSS";
            this.lineNumberBoxCSS.ReadOnly = true;
            this.lineNumberBoxCSS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lineNumberBoxCSS.Size = new System.Drawing.Size(33, 624);
            this.lineNumberBoxCSS.TabIndex = 3;
            this.lineNumberBoxCSS.Text = "";
            this.lineNumberBoxCSS.WordWrap = false;
            // 
            // cssBox
            // 
            this.cssBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cssBox.ContextMenuStrip = this.editorMenu;
            this.cssBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cssBox.Location = new System.Drawing.Point(46, 6);
            this.cssBox.Name = "cssBox";
            this.cssBox.Size = new System.Drawing.Size(444, 624);
            this.cssBox.TabIndex = 2;
            this.cssBox.Text = "";
            this.cssBox.WordWrap = false;
            this.cssBox.VScroll += new System.EventHandler(this.cssScroll);
            this.cssBox.TextChanged += new System.EventHandler(this.cssUpdate);
            // 
            // linksTabs
            // 
            this.linksTabs.Controls.Add(this.linkList);
            this.linksTabs.Location = new System.Drawing.Point(4, 22);
            this.linksTabs.Name = "linksTabs";
            this.linksTabs.Size = new System.Drawing.Size(496, 665);
            this.linksTabs.TabIndex = 2;
            this.linksTabs.Text = "Links";
            this.linksTabs.UseVisualStyleBackColor = true;
            // 
            // linkList
            // 
            this.linkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkList.FormattingEnabled = true;
            this.linkList.ItemHeight = 19;
            this.linkList.Items.AddRange(new object[] {
            "Links"});
            this.linkList.Location = new System.Drawing.Point(0, 0);
            this.linkList.Name = "linkList";
            this.linkList.Size = new System.Drawing.Size(496, 665);
            this.linkList.TabIndex = 0;
            // 
            // mainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ideTabs);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainEditor";
            this.Text = "RT-IDE for Web";
            this.Load += new System.EventHandler(this.init);
            this.Resize += new System.EventHandler(this.resizeForm);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ideTabs.ResumeLayout(false);
            this.htmlTab.ResumeLayout(false);
            this.editorMenu.ResumeLayout(false);
            this.cssTab.ResumeLayout(false);
            this.linksTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl ideTabs;
        private System.Windows.Forms.TabPage htmlTab;
        private System.Windows.Forms.RichTextBox lineNumberBoxHTML;
        private System.Windows.Forms.RichTextBox htmlBox;
        private System.Windows.Forms.TabPage cssTab;
        private System.Windows.Forms.RichTextBox lineNumberBoxCSS;
        private System.Windows.Forms.RichTextBox cssBox;
        private System.Windows.Forms.TabPage linksTabs;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToggle;
        private System.Windows.Forms.ToolStripMenuItem updatePreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem previewInDefaultBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewInChromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewInFirefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewInInternetExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realTimeSelector;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickStartGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip editorMenu;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ListBox linkList;
        private System.Windows.Forms.ToolStripMenuItem refreshPreviewToolStripMenuItem;
        private System.Windows.Forms.Button updateCSS;
        private System.Windows.Forms.ListBox codeSuggestBox;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoCompleteSelector;
        private System.Windows.Forms.ToolStripMenuItem syntaxSelector;
        private System.Windows.Forms.Timer timer1;
    }
}

