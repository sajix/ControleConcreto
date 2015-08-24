using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMoldagem.Entidades;
using ControleMoldagem.Regras;

namespace ControleMoldagem.GUI
{
    public partial class formObraCadastro : Form
    {
        CadastroObra cObra = new CadastroObra();
        CadastroEixo cEixo = new CadastroEixo();
        CadastroPeca cPeca = new CadastroPeca();
        Obra[] obra;
        Eixo[] eixo;
        Peca[] peca;
        
        public formObraCadastro()
        {
            InitializeComponent();
        }

        private void formObraCadastro_Load(object sender, EventArgs e)
        {

            obra = cObra.BuscarTodos();
            for (int i = 0; i < obra.Length; i++)
            {
                lstObra.Items.Add(obra[i].NomeObra);
            }
            lstObra.MouseDoubleClick += new MouseEventHandler(lstObra_MouseDoubleClick);
        }
        private void btObraNovo_Click(object sender, EventArgs e)
        {
            if (txtObra.Text == "")
            {
                MessageBox.Show("Prencha o Campo Obra",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                cObra.InserirObra(txtObra.Text, "cNomeObra");
                lstObra.Items.Clear();
                obra = cObra.BuscarTodos();
                for (int i = 0; i < obra.Length; i++)
                {
                    lstObra.Items.Add(obra[i].NomeObra);
                }
                txtObra.Clear();
            }
        }

        private void btObraEdita_Click(object sender, EventArgs e)
        {
            if (txtObra.Text == "")
            {
                MessageBox.Show("Prencha o Campo Obra",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                cObra.EditarObra(lstObra.SelectedItem.ToString(), txtObra.Text, "cNomeObra");
                lstObra.Items.Clear();
                obra = cObra.BuscarTodos();
                for (int i = 0; i < obra.Length; i++)
                {
                    lstObra.Items.Add(obra[i].NomeObra);
                }
                txtObra.Clear();
            }
        }

        private void lstObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEixo.Items.Clear();
            eixo = cEixo.BuscarTodos(buscaIdObra(lstObra.SelectedItem.ToString()));
            for (int i = 0; i < eixo.Length; i++)
            {
                lstEixo.Items.Add(eixo[i].NomeEixo);
            }
            txtObra.Text = lstObra.SelectedItem.ToString();
        }

        private void lstObra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtObra.Text = lstObra.SelectedItem.ToString();
        }

        private void btEixoNovo_Click(object sender, EventArgs e)
        {
            if (txtEixo.Text == "")
            {
                MessageBox.Show("Prencha o Campo Eixo",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {

                cEixo.InserirEixo(txtEixo.Text, Convert.ToString(buscaIdObra(txtObra.Text)), "cNomeEixo");
                lstEixo.Items.Clear();
                eixo = cEixo.BuscarTodos(buscaIdObra(lstObra.SelectedItem.ToString()));
                for (int i = 0; i < eixo.Length; i++)
                {
                    lstEixo.Items.Add(eixo[i].NomeEixo);
                }
                txtEixo.Clear();
            }
        }

        private void btEixoEdita_Click(object sender, EventArgs e)
        {
            if (txtEixo.Text == "")
            {
                MessageBox.Show("Prencha o Campo Eixo",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                cEixo.EditarEixo(lstEixo.SelectedItem.ToString(), txtEixo.Text, Convert.ToString(buscaIdObra(lstObra.SelectedItem.ToString())));
                lstEixo.Items.Clear();
                eixo = cEixo.BuscarTodos(buscaIdObra(lstObra.SelectedItem.ToString()));
                for (int i = 0; i < eixo.Length; i++)
                {
                    lstEixo.Items.Add(eixo[i].NomeEixo);
                }
                txtEixo.Clear();
            }
        }

        private void lstEixo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEixo.Text = lstEixo.SelectedItem.ToString();
            lstPeca.Items.Clear();
            int idObra = buscaIdObra(lstObra.SelectedItem.ToString());
            int idEixo = buscaIdEixo(lstEixo.SelectedItem.ToString(), idObra);
            peca = cPeca.BuscarTodos(idObra, idEixo);
            for (int i = 0; i < peca.Length; i++)
            {
                lstPeca.Items.Add(peca[i].NomePeca);
            }
        }

        
        private void btPecaNovo_Click(object sender, EventArgs e)
        {
            if (txtPeca.Text == "")
            {
                MessageBox.Show("Prencha o Campo Peça",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                int idObra = buscaIdObra(lstObra.SelectedItem.ToString());
                int idEixo = buscaIdEixo(lstEixo.SelectedItem.ToString(), idObra);
                cPeca.InserirPeca(Convert.ToString(idObra), Convert.ToString(idEixo), txtPeca.Text);
                lstPeca.Items.Clear();
                peca = cPeca.BuscarTodos(idObra, idEixo);
                for (int i = 0; i < peca.Length; i++)
                {
                    lstPeca.Items.Add(peca[i].NomePeca);
                }
                txtPeca.Clear();
            }
        }

        private int buscaIdObra(String nomeObra)
        {
            obra = cObra.BuscarTodos();
            bool enc = false;
            int aux = 0;
            while (enc == false)
            {
                if (obra[aux].NomeObra == nomeObra)
                {
                    enc = true;
                }
                else
                {
                    aux++;
                }
            }
            int idObra = obra[aux].IdObra;

            return idObra;
        }

        private int buscaIdEixo(String nomeEixo, int idObra)
        {
            eixo = cEixo.BuscarTodos(idObra);
            bool enc = false;
            int aux = 0;
            while (enc == false)
            {
                if (eixo[aux].NomeEixo == nomeEixo)
                {
                    enc = true;
                }
                else
                {
                    aux++;
                }
            }
            int idEixo = eixo[aux].IdEixo;

            return idEixo;
        }

        private void lstPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPeca.Text = lstPeca.SelectedItem.ToString();
        }

        private void btPecaEdita_Click(object sender, EventArgs e)
        {
            if (txtPeca.Text == "")
            {
                MessageBox.Show("Prencha o Campo Peça",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                int idObra = buscaIdObra(lstObra.SelectedItem.ToString());
                int idEixo = buscaIdEixo(lstEixo.SelectedItem.ToString(), idObra);
                cPeca.EditarPeca(Convert.ToString(idObra), Convert.ToString(idEixo), lstPeca.SelectedItem.ToString(), txtPeca.Text);
                lstPeca.Items.Clear();
                peca = cPeca.BuscarTodos(idObra, idEixo);
                for (int i = 0; i < peca.Length; i++)
                {
                    lstPeca.Items.Add(peca[i].NomePeca);
                }
                txtPeca.Clear();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        
    }
}
