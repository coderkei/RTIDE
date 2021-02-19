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
using System.Diagnostics;

namespace RTIDE_Web
{
    /// <summary>
    /// Start of htmlHelp
    /// </summary>
    public partial class htmlHelp : Form
    {
        /// <summary>
        /// html based help class
        /// </summary>
        /// <param name="modeSel"></param>
        public htmlHelp(int modeSel)
        {
            InitializeComponent();
            switch (modeSel)
            {
                case 0://quick start
                    htmlView.DocumentText = htmlResource.quickStart;
                    break;
                case 1://open help
                    try
                    {
                        Process.Start("chrome.exe", Application.StartupPath + @"\manual.pdf");
                    }
                    catch
                    {
                        Process.Start(Application.StartupPath + @"\manual.pdf");
                    }
                    break;
                default:
                    throw new Exception("Invalid mode");
            }
        }
    }
}
