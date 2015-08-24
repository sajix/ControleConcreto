using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMoldagem.GUI;

namespace ControleMoldagem
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
            if (Properties.Settings.Default.FirstAcess == true)
            {
                Application.Run(new PrimeiroAcesso());
            }
            else
            {
                Application.Run(new Principal());
            }
        }
    }
}
