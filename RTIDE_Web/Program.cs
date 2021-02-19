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
    static class Program
    {
        static string pdfPath = Application.StartupPath + @"\manual.pdf";
        static string libPath = Application.StartupPath + @"\WinFormsSyntaxHighlighter.dll";
        static string codePath = Application.StartupPath + @"\codeList.ini";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(libPath) == false || File.Exists(pdfPath) == false || File.Exists(codePath) == false)
            {
                FileStream libStream = new FileStream(libPath, FileMode.Create, FileAccess.Write);
                FileStream pdfStream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write);
                FileStream codeStream = new FileStream(codePath, FileMode.Create, FileAccess.Write);
                BinaryWriter libWriter = new BinaryWriter(libStream);
                BinaryWriter pdfWriter = new BinaryWriter(pdfStream);
                BinaryWriter codeWriter = new BinaryWriter(codeStream);
                libWriter.Write(generalResources.WinFormsSyntaxHighlighter);
                pdfWriter.Write(htmlResource.manual);
                codeWriter.Write(generalResources.codeList);
                Application.Restart();
            }
            else
            {
                Application.Run(new startForm());
            }
        }
    }
}
