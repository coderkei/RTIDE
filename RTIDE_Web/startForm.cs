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
using System.Windows.Forms;
using System.IO;

namespace RTIDE_Web
{
    /// <summary>
    /// The start page form that shows before the editor
    /// </summary>
    public partial class startForm : Form
    {
        /// <summary>
        /// Initializes the start form
        /// </summary>
        public startForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fileToMain
        /// </summary>
        public string fileToMain;
        /// <summary>
        /// urlToMain
        /// </summary>
        public string urlToMain;
        /// <summary>
        /// Recent file configuration file
        /// </summary>
        public string iniPath = Application.StartupPath + @"\lastloc.ini";
        /// <summary>
        /// Default directory path
        /// </summary>
        public string initialDirectory = @"%PUBLIC%\Documents";

        SaveFileDialog saveDialog;
        OpenFileDialog openDialog;

        private void newFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainEditor newEditor = new mainEditor(null, true, false);
            newEditor.ShowDialog();
            this.Close();
        }

        private void loadFile(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startLoad(0);
            this.Hide();
            mainEditor newEditor = new mainEditor(fileToMain, true, false);
            newEditor.ShowDialog();
            this.Close();

        }

        private void init(object sender, EventArgs e)
        {
            generateObjects();
            if(File.Exists(iniPath))
            {
                openRecent.Enabled = true;
                recentLabel.Text = Path.GetFileName(File.ReadAllText(iniPath));
            }
        }

        private void generateObjects()
        {
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        private void startLoad(int mode)
        {
            switch (mode)
            {
                case 0://load file
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileToMain = openDialog.FileName;
                    }
                    break;
                case 1://load project
                    break;
                case 2://load url
                    urlToMain = Microsoft.VisualBasic.Interaction.InputBox("URL", "Please input URL", "", 0, 0);
                    break;
                case 3://load recent
                    fileToMain = File.ReadAllText(iniPath);
                    break;
                default:
                    break;
            }
        }

        private void loadURL(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startLoad(2);
            this.Hide();
            mainEditor newEditor = new mainEditor(urlToMain, true, true);
            newEditor.ShowDialog();
            this.Close();
        }

        private void openRecentBtn(object sender, EventArgs e)
        {
            startLoad(3);
            this.Hide();
            mainEditor newEditor = new mainEditor(fileToMain, true, false);
            newEditor.ShowDialog();
            this.Close();
        }

        private void openQuickStart(object sender, EventArgs e)
        {
            htmlHelp openHelp = new htmlHelp(0);
            openHelp.Show();
        }

        private void openHelp(object sender, EventArgs e)
        {
            htmlHelp openHelp = new htmlHelp(1);        
        }

        
    }
}
