using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
//using System.Windows.Forms; this was imported for debugging of the debugger!  JB 19/4/18

namespace RTIDE_Web
{
    /// <summary>
    /// This manages the debug log window
    /// </summary>
    public class Debug
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// Handles the debug input
        /// </summary>
        /// <param name="line"></param>
        public void WriteLine(string line)
        {
            System.Console.WriteLine(line);
            
        }
    }
}
