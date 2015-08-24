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
//using System.Math;

namespace ControleMoldagem.GUI
{
    public partial class formRuptura : Form
    {
        CadastroMoldagem cMoldagem = new CadastroMoldagem();
        CadastroCodigoBarras cBarras = new CadastroCodigoBarras();
        CadastroRuptura cRuptura = new CadastroRuptura();
        CadastrarResistencia cResistencia = new CadastrarResistencia();
        CodigoBarras[] cb;
        Moldagem molde;
        Resistencia resist;
        public formRuptura()
        {
            InitializeComponent();
        }

        private void formRuptura_Load(object sender, EventArgs e)
        {

        }

        private void txtCodBarra_LostFocus(object sender, System.EventArgs e)
        {
            ImportBarCode();
        }

        private void btRegistra_Click(object sender, EventArgs e)
        {
            Romper();
        }
        private void ImportBarCode()
        {
            Inicio();
            lbRecado.Visible = false;
            CodigoBarras codigo = new CodigoBarras();
            codigo = cBarras.BuscarCodigoBarras(txtCodBarra.Text);
            molde = cMoldagem.BuscarMoldagem(Convert.ToString(codigo.IdSerie));
            cb = cBarras.BuscarSerie(Convert.ToString(codigo.IdSerie));
            txtSerie.Text = Convert.ToString(molde.IdSerie);
            resist = cResistencia.BuscarResistencia(txtSerie.Text);
            lbHoje.Text = Convert.ToString((DateTime.Now - molde.DataMoldagem).Days);
            if (molde.QuantidadeCP == 2)
            {
                if (molde.IdadeA != Convert.ToInt32(lbHoje.Text));
                {
                    lbRecado.Visible = true;
                }
                lbA.Text = "";
                lbB.Text = "";
                lbC.Text = "";
                lbA.Text = Convert.ToString(molde.IdadeA);
                rdoIdadeA.Enabled = true;
                rdoIdadeB.Enabled = false;
                rdoIdadeC.Enabled = false;
                ImagemA();
            }
            else if (molde.QuantidadeCP == 4)
            {
                if (molde.IdadeA != Convert.ToInt32(lbHoje.Text) || molde.IdadeB != Convert.ToInt32(lbHoje.Text));
                {
                    lbRecado.Visible = true;
                }
                lbA.Text = "";
                lbB.Text = "";
                lbC.Text = "";
                lbA.Text = Convert.ToString(molde.IdadeA);
                lbB.Text = Convert.ToString(molde.IdadeB);
                rdoIdadeA.Enabled = true;
                rdoIdadeB.Enabled = true;
                rdoIdadeC.Enabled = false;
                ImagemA();
                ImagemB();
            }
            else if (molde.QuantidadeCP == 6)
            {
                if (molde.IdadeA != Convert.ToInt32(lbHoje.Text) || molde.IdadeB != Convert.ToInt32(lbHoje.Text) || molde.IdadeC != Convert.ToInt32(lbHoje.Text)) ;
                {
                    lbRecado.Visible = true;
                }
                lbA.Text = "";
                lbB.Text = "";
                lbC.Text = "";
                lbA.Text = Convert.ToString(molde.IdadeA);
                lbB.Text = Convert.ToString(molde.IdadeB);
                lbC.Text = Convert.ToString(molde.IdadeC);
                rdoIdadeA.Enabled = true;
                rdoIdadeB.Enabled = true;
                rdoIdadeC.Enabled = true;
                ImagemA();
                ImagemB();
                ImagemC();
            }
            
            
        }
        private void Romper()
        {
            decimal alturaDiamentro = Convert.ToDecimal(txtAltura.Text) / Convert.ToDecimal(txtDiametro.Text);
            decimal correcao = cRuptura.BuscaCorrecao(Convert.ToString(alturaDiamentro));
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            string hora = DateTime.Now.ToString("HH:mm");
            double carga = Convert.ToDouble(txtCarga.Text);
            double area = ((Math.Pow(Convert.ToDouble(txtDiametro.Text),2)*Math.PI)/4);
            string corpo = "cRupturaA1";
            if (rbKN.Checked == true)
            {
                carga = carga / 10;
            }
            double resistencia = (carga/area)*100;
            if (rdoIdadeA.Checked == true)
            {
                if (pctRupt1.Visible == true)
                {
                    corpo = "cRupturaA2";
                }
                else
                {
                    corpo = "cRupturaA1";
                }
                cMoldagem.AtualizarData("cidadeA", txtSerie.Text, lbHoje.Text);
            }
            else if (rdoIdadeB.Checked == true)
            {
                if (pctRupt3.Visible == true)
                {
                    corpo = "cRupturaB2";
                }
                else
                {
                    corpo = "cRupturaB1";
                }
                cMoldagem.AtualizarData("cIdadeB", txtSerie.Text, lbHoje.Text);
            }
            else if (rdoIdadeC.Checked == true)
            {
                if (pctRupt5.Visible == true)
                {
                    corpo = "cRupturaC2";
                }
                else
                {
                    corpo = "cRupturaC1";
                }
                cMoldagem.AtualizarData("cIdadeB", txtSerie.Text, lbHoje.Text);
            }
            cRuptura.InserirRuptura(txtCodBarra.Text, data, hora, txtSerie.Text, txtDiametro.Text, txtAltura.Text, Convert.ToString(correcao), Convert.ToString(carga));
            cBarras.EditarCodigoBarras(txtCodBarra.Text, txtCodBarra.Text, txtSerie.Text, "1");
            cResistencia.EditarResistencia(txtSerie.Text, Convert.ToString(resistencia), corpo);
            MessageBox.Show("CP Rompido.", "Rompimento de CP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            Limpar();
        }
        private void Limpar()
        {
            txtCodBarra.Clear();
            txtAltura.Clear();
            txtCarga.Clear();
            txtDiametro.Clear();
            txtSerie.Clear();
            lbA.Text = "";
            lbB.Text = "";
            lbC.Text = "";
            lbHoje.Text = "";
            lbRecado.Visible = false;
            pctConc1.Visible = false;
            pctConc2.Visible = false;
            pctConc3.Visible = false;
            pctConc4.Visible = false;
            pctConc5.Visible = false;
            pctConc6.Visible = false;
            pctRupt1.Visible = false;
            pctRupt2.Visible = false;
            pctRupt3.Visible = false;
            pctRupt4.Visible = false;
            pctRupt5.Visible = false;
            pctRupt6.Visible = false;
        }
        private void Inicio()
        {
            lbA.Text = "";
            lbB.Text = "";
            lbC.Text = "";
            lbHoje.Text = "";
            lbRecado.Visible = false;
            pctConc1.Visible = false;
            pctConc2.Visible = false;
            pctConc3.Visible = false;
            pctConc4.Visible = false;
            pctConc5.Visible = false;
            pctConc6.Visible = false;
            pctRupt1.Visible = false;
            pctRupt2.Visible = false;
            pctRupt3.Visible = false;
            pctRupt4.Visible = false;
            pctRupt5.Visible = false;
            pctRupt6.Visible = false;
        }
        private void ImagemA()
        {
            if (resist.RA1 != 0)
            {
                pctRupt1.Visible = true;
            }
            else if (resist.RA1 == 0)
            {
                pctConc1.Visible = true;
            }

            if (resist.RA2 != 0)
            {
                pctRupt2.Visible = true;
            }
            else if (resist.RA2 == 0)
            {
                pctConc2.Visible = true;
            }
        }
        private void ImagemB()
        {
            if (resist.RB1 != 0)
            {
                pctRupt3.Visible = true;
            }
            else if (resist.RB1 == 0)
            {
                pctConc3.Visible = true;
            }

            if (resist.RB2 != 0)
            {
                pctRupt4.Visible = true;
            }
            else if (resist.RB2 == 0)
            {
                pctConc4.Visible = true;
            }
        }
        private void ImagemC()
        {
            if (resist.RC1 != 0)
            {
                pctRupt5.Visible = true;
            }
            else if (resist.RC1 == 0)
            {
                pctConc5.Visible = true;
            }

            if (resist.RC2 != 0)
            {
                pctRupt6.Visible = true;
            }
            else if (resist.RC2 == 0)
            {
                pctConc6.Visible = true;
            }
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
            
        }
    }
}
