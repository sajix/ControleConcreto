using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ControleMoldagem.Regras;
using ControleMoldagem.Entidades;

namespace ControleMoldagem.GUI
{
    public partial class formTracoCadastro : Form
    {
        CadastroTraco cTraco = new CadastroTraco();
        Traco[] traco;
        public formTracoCadastro()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (txtCodTraco.Text == "" || txtAc.Text == "" || txtConsitencia.Text == "" || txtConsumo.Text == "" || txtFck.Text == "" || txtIdade.Text == "" || txtTolerancia.Text == "" || txtUsina.Text == "")
            {
                MessageBox.Show("Prencha todos os campos",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                cTraco.InserirTraco(txtCodTraco.Text, txtUsina.Text, txtFck.Text, txtAc.Text, txtIdade.Text, txtConsumo.Text, txtConsitencia.Text, txtTolerancia.Text);
                lstTraco.Items.Clear();
                txtCodTraco.Clear();
                txtUsina.Clear();
                txtFck.Clear();
                txtAc.Clear();
                txtIdade.Text = "28";
                txtConsumo.Clear();
                txtConsitencia.Clear();
                txtTolerancia.Clear();
                traco = cTraco.BuscarTodos();
                for (int i = 0; i < traco.Length; i++)
                {
                    lstTraco.Items.Add(new ListViewItem(new string[] { traco[i].CodigoTraco, traco[i].Usina, Convert.ToString(traco[i].Fck), Convert.ToString(traco[i].FatorAC), Convert.ToString(traco[i].IdadeControle), Convert.ToString(traco[i].ConsumoCimento), Convert.ToString(traco[i].Consistencia), Convert.ToString(traco[i].Tolerancia) }));
                }
            }
        }

        private void formTracoCadastro_Load(object sender, EventArgs e)
        {
            traco = cTraco.BuscarTodos();
            for (int i = 0; i < traco.Length; i++)
            {
                lstTraco.Items.Add(new ListViewItem(new string[] { traco[i].CodigoTraco, traco[i].Usina, Convert.ToString(traco[i].Fck), Convert.ToString(traco[i].FatorAC), Convert.ToString(traco[i].IdadeControle), Convert.ToString(traco[i].ConsumoCimento), Convert.ToString(traco[i].Consistencia), Convert.ToString(traco[i].Tolerancia) }));
            }
        }

        private void lstTraco_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection  selecao = lstTraco.SelectedItems;
            //string item = "";
            foreach (ListViewItem item in selecao)
            {
                txtCodTraco.Text = item.SubItems[0].Text;
                txtUsina.Text = item.SubItems[1].Text;
                txtFck.Text = item.SubItems[2].Text;
                txtAc.Text = item.SubItems[3].Text;
                txtIdade.Text = item.SubItems[4].Text;
                txtConsumo.Text = item.SubItems[5].Text;
                txtConsitencia.Text = item.SubItems[6].Text;
                txtTolerancia.Text = item.SubItems[7].Text;
            }
            //txtCodTraco.Text
        }

        private void btEdita_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection  selecao = lstTraco.SelectedItems;
            if (txtCodTraco.Text == "" || txtAc.Text == "" || txtConsitencia.Text == "" || txtConsumo.Text == "" || txtFck.Text == "" || txtIdade.Text == "" || txtTolerancia.Text == "" || txtUsina.Text == "")
            {
                MessageBox.Show("Prencha todos os campos",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                foreach (ListViewItem item in selecao)
                {
                    cTraco.EditarTraco(txtCodTraco.Text, item.SubItems[0].Text, txtUsina.Text, txtFck.Text, txtAc.Text, txtIdade.Text, txtConsumo.Text, txtConsitencia.Text, txtTolerancia.Text);
                }
                lstTraco.Items.Clear();
                traco = cTraco.BuscarTodos();
                for (int i = 0; i < traco.Length; i++)
                {
                    lstTraco.Items.Add(new ListViewItem(new string[] { traco[i].CodigoTraco, traco[i].Usina, Convert.ToString(traco[i].Fck), Convert.ToString(traco[i].FatorAC), Convert.ToString(traco[i].IdadeControle), Convert.ToString(traco[i].ConsumoCimento), Convert.ToString(traco[i].Consistencia), Convert.ToString(traco[i].Tolerancia) }));
                }
                txtCodTraco.Clear();
                txtUsina.Clear();
                txtFck.Clear();
                txtAc.Clear();
                txtIdade.Text = "28";
                txtConsumo.Clear();
                txtConsitencia.Clear();
                txtTolerancia.Clear();
            }
        }

        private void btApaga_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selecao = lstTraco.SelectedItems;
            foreach (ListViewItem item in selecao)
            {
                cTraco.RemoverTraco(item.SubItems[0].Text);
                item.Remove();
            }
            txtCodTraco.Clear();
            txtUsina.Clear();
            txtFck.Clear();
            txtAc.Clear();
            txtIdade.Text = "28";
            txtConsumo.Clear();
            txtConsitencia.Clear();
            txtTolerancia.Clear();
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            txtCodTraco.Clear();
            txtUsina.Clear();
            txtFck.Clear();
            txtAc.Clear();
            txtIdade.Text = "28";
            txtConsumo.Clear();
            txtConsitencia.Clear();
            txtTolerancia.Clear();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
