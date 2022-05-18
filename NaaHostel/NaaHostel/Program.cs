using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaaHostel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DaxilOL f = new DaxilOL();
            Application.Run(new AnaForm());
            if(f.ac ==true)
            {
                Application.Run(new AnaForm());
            }
        }
    }
}
