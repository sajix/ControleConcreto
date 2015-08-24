using ControleMoldagem.Regras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMoldagem.GUI
{
    public partial class RelatorioFCK : Form
    {
        public RelatorioFCK()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            btnGerar.Enabled = false;
            Relatorio rel = new Relatorio();
            rel.RelatorioLote(pBar, Convert.ToInt32(txtLote.Text));
            pBar.Visible = true;
            MessageBox.Show("Relatorio", "Relatório Concluido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            btnGerar.Enabled = true;
        }
    }
}
