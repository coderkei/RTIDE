/*Uses WinFormsSyntaxHighlighter licensed under the MIT License. Copyright 2014 - 2016 Sina Iravanian, sinairv*/

/*
 * Copyright (C) 2020  coderkei
 * This file is part of RT-IDE.

    RT-IDE is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    RT-IDE is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with RT-IDE.  If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using WinFormsSyntaxHighlighter;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RTIDE_Web
{
    /// <summary>
    /// Main code editor form
    /// </summary>
    public partial class mainEditor : Form
    {
        //Generate objects from classes
        webControl browser;
        /// <summary>
        /// fromStart
        /// </summary>
        public bool fromStart;
        bool fileInUse = false;
        bool cssFileInUse = false;

        string loadedFileName;
        string loadedURL;
        string cssName;

        SaveFileDialog saveDialog;
        OpenFileDialog openDialog;

        FontDialog fontChooser;

        MemoryStream pageMemCopy = new MemoryStream();

        SyntaxHighlighter syntaxHighlighter;

        string codePath = Application.StartupPath + @"\codeList.ini";
        string initialDirectory = @"%PUBLIC%\Documents";
        string iniPath = Application.StartupPath + @"\lastloc.ini";
        string tempPath = Application.StartupPath + @"\temp.html";

        private List<string> autoCompleteList = new List<string>();

        int currentLine = 0;

        /// <summary>
        /// Initializes the main editor form
        /// </summary>
        public mainEditor(string data, bool start, bool isURL)
        {
            InitializeComponent();
            if (isURL == true)
            {
                loadedURL = data;
            } 
            else 
            {
                loadedFileName = data;
            }
            fromStart = start;

            var lines = File.ReadAllLines(codePath);
            foreach (var codeLine in lines)
            {
                autoCompleteList.Add(codeLine);
            }
        }

        private void manualUpdate(object sender, EventArgs e)
        {
            browser.previewControl(0, htmlBox.Text, null);
        }

        private void htmlUpdate(object sender, EventArgs e)
        {
            htmlBox.Focus();
            if (realTimeSelector.Checked)
            {
                if (fileInUse == false)
                {
                    browser.previewControl(0, htmlBox.Text, null);
                    extractLink(browser.Document);
                }
            }
            if (htmlBox.Text == "")
            {
                LineNumbers();
            }

            codeSuggestBox.Items.Clear();
            if (htmlBox.Text.Length == 0)
            {
                hideAutoCompleteMenu();
                return;
            }

            currentLine = htmlBox.GetLineFromCharIndex(htmlBox.SelectionStart);
            string buffer = htmlBox.Lines[currentLine];
            if (autoCompleteSelector.Checked == true)
            {
                codeSuggestBox.Show();
                foreach (String s in autoCompleteList)
                {
                    if (s.StartsWith(buffer))
                    {
                        codeSuggestBox.Items.Add(s);
                        codeSuggestBox.Visible = true;
                    }

                }
            }
            else
            {
                codeSuggestBox.Hide();
            }
        }

        private void hideAutoCompleteMenu()
        {
            codeSuggestBox.Visible = false;
            htmlBox.Focus();
        }

        private void changeIndex(object sender, EventArgs e)
        {
            try
            {
                htmlBox.AppendText(codeSuggestBox.Items[codeSuggestBox.SelectedIndex].ToString());
            }
            catch
            {
                MessageBox.Show("Please select a valid option");
            }
            finally
            {
                hideAutoCompleteMenu();
            }
        }

        private void newFile(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Create a new file? Unsaved changed will be lost", "New file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ideTabs.SelectedIndex = 0;
                htmlBox.Clear();
                LineNumbers();
                browser.previewControl(1, null, null);
            }
            
        }

        private void refreshPreview(object sender, EventArgs e)
        {
            browser.previewControl(2, null, null);
        }

        private void rtCheck(object sender, EventArgs e)
        {
            if (realTimeSelector.Checked)
            {
                realTimeSelector.Checked = false;
            }
            else
            {
                realTimeSelector.Checked = true;
            }
        }

        private void shCheck(object sender, EventArgs e)
        {
            if (syntaxSelector.Checked)
            {
                syntaxSelector.Checked = false;
                syntaxHighlighter.DisableHighlighting = true;
            }
            else
            {
                syntaxSelector.Checked = true;
                syntaxHighlighter.DisableHighlighting = false;
            }
        }

        private void asCheck(object sender, EventArgs e)
        {
            if (autoCompleteSelector.Checked)
            {
                autoCompleteSelector.Checked = false;
            }
            else
            {
                autoCompleteSelector.Checked = true;
            }
        }

        private void init(object sender, EventArgs e)
        {
            startForm start = new startForm();
            generateObjects();
            if (fromStart == true)
            {
                if (loadedFileName != null)
                {
                    try
                    {
                        htmlBox.Lines = File.ReadAllLines(loadedFileName);
                        browser.previewControl(3, null, loadedFileName);
                        LineNumbers();
                        fileInUse = true;
                    }
                    catch
                    {
                        MessageBox.Show("The file could not be found or is corrupted.", "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (loadedURL != null)
                {
                    browser.previewControl(3, null, loadedURL);
                    LineNumbers();
                    fileInUse = true;
                }
            }
            
        }

        private void generateObjects()
        {
           
            //generate syntax highlighter
            syntaxHighlighter = new SyntaxHighlighter(htmlBox);
            syntaxHighlighter.AddPattern(new PatternDefinition("<html>", "<html", "<link", "<head>", "<body>", "<a href", "<title>", "<meta", "<div", "<header", "<li>", "<ul", "<ul>", "<nav", "<section", "<article>", "<img", "<h1>", "<h2>", "<h3>", "<b>", "<u>", "<p>", "<i>", "<button", "<button>", "</html>", "</head>", "</body>", "</title>", "</div>", "</header>", "</li>", "</ul>", "</nav>", "</section>", "</article>", "</h1>", "</h2>", "</h3>", "</b>", "</u>", "</i>", "</p>", "/>", "</a>", "</button>", ">"),
                new SyntaxStyle(Color.Blue));//Objects

            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"<!--(.|[\r\n])*?\-->?", RegexOptions.Multiline | RegexOptions.Compiled)),
                new SyntaxStyle(Color.Green));//Comments

            syntaxHighlighter.AddPattern(new PatternDefinition("href", "onclick", "id", "class", "src", "rel", "charset", "lang", "href"),
                new SyntaxStyle(Color.Red));//atributes

            //Generate Preview
            browser = new webControl();
            browser.Location = new Point(527, 49);
            browser.Size = new Size(474, 669);
            browser.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.Controls.Add(browser);
            browser.Navigate("about:blank");

            //Generate File Save Dialog
            saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".html";
            saveDialog.Filter = "HTML Files|*.html;*.htm|CSS Files|*.css|PHP Files|*.php|JavaScript Files|*.js|All Files|*.*";
            saveDialog.InitialDirectory = initialDirectory;
            saveDialog.FileName = "";

            //Generate File Open Dialog
            openDialog = new OpenFileDialog();
            openDialog.DefaultExt = ".html";
            openDialog.Filter = "HTML Files|*.html;*.htm|CSS Files|*.css|PHP Files|*.php|JavaScript Files|*.js|All Files|*.*";
            openDialog.InitialDirectory = initialDirectory;
            openDialog.FileName = "";

            LineNumbers();
            lineNumberBoxHTML.BackColor = Color.White;
            lineNumberBoxCSS.BackColor = Color.White;

            //generate font box
            fontChooser = new FontDialog();


        }

        private void extractLink(HtmlDocument source)
        {
            linkList.Items.Clear();
            HtmlElementCollection anchorList = source.GetElementsByTagName("a");
            foreach (var item in anchorList)
            {
                linkList.Items.Add(((HtmlElement)item).GetAttribute("href"));
            }
        }

        private void openFile(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Open a new file? Unsaved changed will be lost", "Open file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    htmlBox.Lines = File.ReadAllLines(openDialog.FileName);
                    browser.previewControl(3, null, openDialog.FileName);
                    loadedFileName = openDialog.FileName;
                    LineNumbers();
                }
            }
        }

        private void saveFile(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveDialog.FileName, htmlBox.Lines);
                MessageBox.Show("File saved successfully");
                File.WriteAllText(iniPath, saveDialog.FileName);
            }
        }

        /// <summary>
        /// Gets the width of the line number box by reading the code editor font size
        /// </summary>
        /// <param name="boxSel"></param>
        /// <returns></returns>
        public int getWidth(int boxSel)
        {
            int wHtml = 25;
            int wCSS = 25;

            int lineHtml = htmlBox.Lines.Length;
            int lineCSS = cssBox.Lines.Length;

            if (lineHtml <= 99)
            {
                wHtml = 20 + (int)htmlBox.Font.Size;
                
            }
            else if (lineHtml <= 999)
            {
                wHtml = 20 + (int)htmlBox.Font.Size;
            }
            else
            {
                wHtml = 20 + (int)htmlBox.Font.Size;
            }

            if (lineCSS <= 99)
            {
                wCSS = 20 + (int)htmlBox.Font.Size;
            }
            else if (lineCSS <= 999)
            {
                wCSS = 20 + (int)htmlBox.Font.Size;
            }
            else
            {
                wCSS = 20 + (int)htmlBox.Font.Size;
            }

            switch (boxSel)
            {
                case 0:
                    return wHtml;
                case 1:
                    return wCSS;
                default:
                    throw new Exception("Invalid Width Source.");
            }
        }    

        /// <summary>
        /// Handles the line numbers for the HTML and CSS text boxes
        /// </summary>
        public void LineNumbers()
        {
            Point ptHtml = new Point(0, 0);
            Point ptCSS = new Point(0, 0);
            int First_Index_HTML = htmlBox.GetCharIndexFromPosition(ptHtml);
            int First_Index_CSS = cssBox.GetCharIndexFromPosition(ptCSS);
            int First_Line_Html = htmlBox.GetLineFromCharIndex(First_Index_HTML);
            int First_Line_CSS = cssBox.GetLineFromCharIndex(First_Index_CSS);

            ptHtml.X = ClientRectangle.Width;
            ptHtml.Y = ClientRectangle.Height;
            ptCSS.X = ClientRectangle.Width;
            ptCSS.Y = ClientRectangle.Height;

            int Last_Index_Html = htmlBox.GetCharIndexFromPosition(ptHtml);
            int Last_Line_Html = htmlBox.GetLineFromCharIndex(Last_Index_Html);
            int Last_Index_CSS = cssBox.GetCharIndexFromPosition(ptCSS);
            int Last_Line_CSS = cssBox.GetLineFromCharIndex(Last_Index_CSS);

            lineNumberBoxHTML.SelectionAlignment = HorizontalAlignment.Right;
            lineNumberBoxCSS.SelectionAlignment = HorizontalAlignment.Right;

            lineNumberBoxHTML.Text = "";
            lineNumberBoxCSS.Text = "";

            lineNumberBoxHTML.Width = getWidth(0);
            lineNumberBoxCSS.Width = getWidth(1);

            for (int i = First_Line_Html; i <= Last_Line_Html + 2; i++)
            {
                lineNumberBoxHTML.Text += i + 1 + "\n";
            }
            for (int i = First_Line_CSS; i <= Last_Line_CSS + 2; i++)
            {
                lineNumberBoxCSS.Text += i + 1 + "\n";
            }   
        }

        private void htmlSelChange(object sender, EventArgs e)
        {
            Point pt = htmlBox.GetPositionFromCharIndex(htmlBox.SelectionStart);
            if (pt.X == 1)
            {
                LineNumbers();
            }  
        }

        private void htmlScroll(object sender, EventArgs e)
        {
            lineNumberBoxHTML.Text = "";
            LineNumbers();
            lineNumberBoxHTML.Invalidate();
        }

        private void cssScroll(object sender, EventArgs e)
        {
            lineNumberBoxCSS.Text = "";
            LineNumbers();
            lineNumberBoxCSS.Invalidate();
        }

        private void resizeForm(object sender, EventArgs e)
        {
            LineNumbers();
        }

        private void cssUpdate(object sender, EventArgs e)
        {
            if (cssBox.Text == "")
            {
                LineNumbers();
            }
        }

        private void exitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cut(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.Cut();
            }
            else
                cssBox.Cut();
        }

        private void copy(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.Copy();
            }
            else
                cssBox.Copy();
        }

        private void paste(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.Paste();
            }
            else
                cssBox.Paste();
        }

        private void delete(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.SelectedText = "";
            }
            else
                cssBox.SelectedText = "";
        }

        private void selectAll(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.SelectAll();
            }
            else
            {
                cssBox.SelectAll();
            }
        }

        private void undo(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.Undo();
            }
            else
            {
                cssBox.Undo();
            }
        }

        private void redo(object sender, EventArgs e)
        {
            if (ideTabs.SelectedIndex == 0)
            {
                htmlBox.Redo();
            }
            else
            {
                cssBox.Redo();
            }
        }

        private void switchTabs(object sender, EventArgs e)
        {
            openDialog.FilterIndex = 2;
            if(ideTabs.SelectedIndex == 1 && cssFileInUse == false)
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    cssBox.Lines = File.ReadAllLines(openDialog.FileName);
                    cssName = openDialog.FileName;
                    cssFileInUse = true;
                }
            }
        }

        private void writeCSS(object sender, EventArgs e)
        {
            File.WriteAllLines(cssName, cssBox.Lines);
            browser.previewControl(3, null, loadedFileName);
        }

        private void prevDefault(object sender, EventArgs e)
        {
            File.WriteAllLines(tempPath, htmlBox.Lines);
            Process.Start(tempPath);
        }

        private void prevChrome(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(tempPath, htmlBox.Lines);
                Process.Start("chrome.exe", tempPath);
            }
            catch
            {
                MessageBox.Show("Google chrome is not installed.");
            }

        }

        private void prevFirefox(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(tempPath, htmlBox.Lines);
                Process.Start("firefox.exe", tempPath);
            }
            catch
            {
                MessageBox.Show("Mozilla Firefox is not installed.");
            }

        }

        private void prevIE(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllLines(tempPath, htmlBox.Lines);
                Process.Start("iexplore.exe", tempPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to launch Internet Explorer. Please report the following error: " + ex.ToString());
            }
        }

        private void fullscreen(object sender, EventArgs e)
        {
            if(fullscreenToggle.Checked == false)
            {
                fullscreenToggle.Checked = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fullscreenToggle.Checked = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void loadURL(object sender, EventArgs e)
        {
            loadedFileName = Microsoft.VisualBasic.Interaction.InputBox("URL", "Please input URL", "", 0, 0);
            browser.previewControl(3, null, loadedFileName);
        }

        private void newCSS(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Create a new file? Unsaved changed will be lost", "New file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Please save the css file to enable CSS editing.");
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    saveDialog.DefaultExt = ".css";
                    File.CreateText(saveDialog.FileName);
                    MessageBox.Show("File saved successfully");
                    cssFileInUse = true;
                    cssName = saveDialog.FileName;
                    ideTabs.SelectedIndex = 1;
                }
            }
        }

        private void saveCSS(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                saveDialog.DefaultExt = ".css";
                File.WriteAllLines(cssName, cssBox.Lines);
                MessageBox.Show("File saved successfully");
            }
        }

        private void showAbout(object sender, EventArgs e)
        {
            about abt = new about();
            abt.ShowDialog();
        }

        private void quickStart(object sender, EventArgs e)
        {
            htmlHelp openHelp = new htmlHelp(0);
            openHelp.Show();
        }

        private void openMainHelp(object sender, EventArgs e)
        {
            htmlHelp openHelp = new htmlHelp(1);
        }

    }
}
