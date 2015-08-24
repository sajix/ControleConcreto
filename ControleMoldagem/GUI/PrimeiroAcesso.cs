using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ControleMoldagem.GUI
{
    public partial class PrimeiroAcesso : Form
    {
        public PrimeiroAcesso()
        {
            InitializeComponent();
        }

        private void PrimeiroAcesso_Load(object sender, EventArgs e)
        {
            /*
             * Propriedade Module
             * 0 = Modo Completo
             * 1 = Modo Ruptura
             * 2 = Modo Administrador
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoCompleto.Checked == true)
            {
                Properties.Settings.Default.Module = 0;
            }
            if (rdoSimples.Checked == true)
            {
                Properties.Settings.Default.Module = 1;
            }
            if (rdoAdmin.Checked == true)
            {
                Properties.Settings.Default.Module = 2;
            }
            if (txtConnection.Text != "")
            {
                Properties.Settings.Default.ConnectionString = txtConnection.Text;
            }
            Properties.Settings.Default.FirstAcess = false;
            Properties.Settings.Default.Printer = GetDefaultPrinter();
            Properties.Settings.Default.ConnectionString = txtConnection.Text;
            Properties.Settings.Default.Save();
            Principal princial = new Principal();
            princial.Show();
            this.Hide();
        }
        private string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
    }
}
