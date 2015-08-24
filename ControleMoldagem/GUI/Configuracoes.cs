using ControleMoldagem.Dados;
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
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }
        bool novaSenha;
        string senhaDigitada;
        private void Configuracoes_Load(object sender, EventArgs e)
        {
            txtConectString.Text = Properties.Settings.Default.ConnectionString;
            comboPrinter.Text = Properties.Settings.Default.Printer;
            txtCopies.Text = Convert.ToString(Properties.Settings.Default.NumberCopies);
            cbPreview.Checked = Properties.Settings.Default.PreviewPrint;
            btnSalvar.Enabled = false;
            novaSenha = false;
            if (Properties.Settings.Default.Module == 0)
            {
                rdoCompleto.Checked = true;
            }
            else if (Properties.Settings.Default.Module == 1)
            {
                rdoSimples.Checked = true;
            }
            else if (Properties.Settings.Default.Module == 2)
            {
                rdoAdmin.Checked = true;
            }
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboPrinter.Items.Add(printer);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Owner.Refresh();
            this.Owner.Show();
            this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novaSenha == false)
            {
                Properties.Settings.Default.ConnectionString = txtConectString.Text;
                Properties.Settings.Default.Printer = comboPrinter.Text;
                Properties.Settings.Default.NumberCopies = Convert.ToInt32(txtCopies.Text);
                Properties.Settings.Default.PreviewPrint = Convert.ToBoolean(cbPreview.Checked.ToString());
                if (rdoCompleto.Checked == true)
                {
                    Properties.Settings.Default.Module = 0;
                }
                else if (rdoSimples.Checked == true)
                {
                    Properties.Settings.Default.Module = 1;
                }
                else if (rdoAdmin.Checked == true)
                {
                    Properties.Settings.Default.Module = 2;
                }
                Properties.Settings.Default.Save();
                btnSalvar.Enabled = false;
            }
            else
            {
                if (txtASenha.Text == "" || txtNSenha.Text == "" || txtRepetir.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos da senha.", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (txtNSenha.Text.Length < 5 || txtRepetir.Text.Length < 5)
                {
                    MessageBox.Show("Senha precisa ser maior que 5 caracteres.", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (txtNSenha.Text != txtRepetir.Text)
                {
                    MessageBox.Show("Campo Repetir precisa ser igual ao campo Nova Senha.", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    
                }
                else
                {
                    senhaDigitada = Criptografia.HashValue(txtASenha.Text);
                    if (senhaDigitada != Properties.Settings.Default.Password)
                    {
                        MessageBox.Show("Senha Antiga Incorreta", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        Properties.Settings.Default.ConnectionString = txtConectString.Text;
                        Properties.Settings.Default.Printer = comboPrinter.Text;
                        Properties.Settings.Default.NumberCopies = Convert.ToInt32(txtCopies.Text);
                        Properties.Settings.Default.PreviewPrint = Convert.ToBoolean(cbPreview.Checked.ToString());
                        if (rdoCompleto.Checked == true)
                        {
                            Properties.Settings.Default.Module = 0;
                        }
                        else if (rdoSimples.Checked == true)
                        {
                            Properties.Settings.Default.Module = 1;
                        }
                        else if (rdoAdmin.Checked == true)
                        {
                            Properties.Settings.Default.Module = 2;
                        }
                        Properties.Settings.Default.Password = Criptografia.HashValue(txtNSenha.Text);
                        Properties.Settings.Default.Save();
                        btnSalvar.Enabled = false;
                    }
                }
            }
        }

        private void txtConectString_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtPrinter_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void txtCopies_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void cbPreview_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void comboPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtASenha_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            novaSenha = true;
        }

        private void txtNSenha_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            novaSenha = true;
        }

        private void txtRepetir_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            novaSenha = true;
        }

        private void rdoCompleto_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void rdoSimples_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Owner.Update();
            this.Owner.Show();
            this.Close();
        }

    }
}
