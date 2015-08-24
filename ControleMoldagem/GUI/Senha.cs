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

namespace ControleMoldagem.GUI
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string senhaDigitada = Criptografia.HashValue(txtSenha.Text);
            if (senhaDigitada == Properties.Settings.Default.Password)
            {
                //Configuracoes configuracao = new Configuracoes();
                this.Owner.OwnedForms[0].Show();
                //configuracao.Show();
                this.Owner.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta.", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Senha_Load(object sender, EventArgs e)
        {

        }
    }
}
