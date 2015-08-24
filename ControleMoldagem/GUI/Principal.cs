using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMoldagem.Dados;
using ControleMoldagem.Regras;

namespace ControleMoldagem.GUI
{
    public partial class Principal : Form
    {
        Relatorio rel;
        public Principal()
        {
            InitializeComponent();
             rel = new Relatorio();
        }

        private void obraEixoPeçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formObraCadastro obraCadastro = new formObraCadastro();
            this.AddOwnedForm(obraCadastro);
            obraCadastro.Show();
            this.Hide();
        }

        private void traçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTracoCadastro tracoCadastro = new formTracoCadastro();
            this.AddOwnedForm(tracoCadastro);
            tracoCadastro.Show();
            this.Hide();
        }

        private void moldagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formModagem moldagemCadastro = new formModagem();
            this.AddOwnedForm(moldagemCadastro);
            moldagemCadastro.Show();
            this.Hide();
        }

        private void rupturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRuptura ruptura = new formRuptura();
            this.AddOwnedForm(ruptura);
            ruptura.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Module == 1)
            {
                relatorioToolStripMenuItem.Enabled = false;
                buscaToolStripMenuItem.Enabled = false;
                exportarDBToolStripMenuItem.Enabled = false;
                obraEixoPeçaToolStripMenuItem.Enabled = false;
                traçoToolStripMenuItem.Enabled = false;
                moldagemToolStripMenuItem.Enabled = false;
            }
            else if (Properties.Settings.Default.Module == 2)
            {
                cadastroToolStripMenuItem.Enabled = false;

            }
            else
            {

            }
        }

        private void loteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFCK fckRel = new RelatorioFCK();
            fckRel.Show();
        }

        private void cPsDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioAgenda agendaRel = new RelatorioAgenda();
            agendaRel.Show();
        }

        private void serieCodigoDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaSerie serieBusca = new BuscaSerie();
            this.AddOwnedForm(serieBusca);
            serieBusca.Show();
            this.Hide();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBtoExl export = new DBtoExl();
            export.ExportarCodigoBarras();
        }

        private void codigoDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCodigoBarras cbRelatorio = new RelatorioCodigoBarras();
            cbRelatorio.Show();
        }

        private void resistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioResistencia resistenciaRelatorio = new RelatorioResistencia();
            resistenciaRelatorio.Show();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senha senha = new Senha();
            Configuracoes configuracao = new Configuracoes();
            this.AddOwnedForm(configuracao);
            this.AddOwnedForm(senha);
            senha.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
    }
}
