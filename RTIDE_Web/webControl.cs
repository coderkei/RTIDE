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

namespace RTIDE_Web
{
    class webControl : WebBrowser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeSel"></param>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        public void previewControl(int modeSel, string data, string filename)
        {
            switch (modeSel)
            {
                case 0://Live update
                    this.Document.OpenNew(true);
                    this.Document.Write(data);
                    break;
                case 1://Clear page
                    this.Navigate("about:blank");
                    break;
                case 2://Refresh
                    this.Refresh();
                    break;
                case 3://Load from file
                    this.Navigate(filename);
                    break;
                default:
                    throw new Exception("Invalid Function");
            }
        }
    }
}
