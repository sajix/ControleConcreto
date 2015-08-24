using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMoldagem.Regras;

namespace ControleMoldagem.GUI
{
    public partial class RelatorioCodigoBarras : Form
    {
        Relatorio rel;
        public RelatorioCodigoBarras()
        {
            InitializeComponent();
            rel = new Relatorio();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            btnGerar.Enabled = false;
            rel.RelatorioCodigoBarras(pBar);
            btnGerar.Enabled = true;
        }
    }
}
