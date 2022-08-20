using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_prog3
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

            login log = new login();
            if (log.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new menu()); 
            }
            
        
        }
    }
}
