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
    public partial class BuscaSerie : Form
    {
        CadastroMoldagem cMoldagem = new CadastroMoldagem();
        CadastroLote cLote = new CadastroLote();
        CadastroTraco cTraco = new CadastroTraco();
        CadastroObra cObra = new CadastroObra();
        CadastroPeca cPeca = new CadastroPeca();
        CadastroEixo cEixo = new CadastroEixo();
        CadastroRuptura cRuptura = new CadastroRuptura();
        CadastrarResistencia cResistencia = new CadastrarResistencia();
        CadastroCodigoBarras cBarras = new CadastroCodigoBarras();
        Resistencia resist;
        CodigoBarras cb;
        CodigoBarras[] carregarCB;
        Obra[] obra;
        Eixo[] eixo;
        Peca[] peca;
        Traco[] traco;
        Ruptura[] ruptura;
        //Moldagem molde;
        Moldagem carregarMoldagem;
        Lote lote;
        public BuscaSerie()
        {
            InitializeComponent();
        }

        private void btnSerieBusca_Click(object sender, EventArgs e)
        {
            BuscaSerieText(txtSerieBusca.Text);
        }
        public void BuscaSerieText(string serie)
        {
            carregarMoldagem = cMoldagem.BuscarMoldagem(serie);
            traco = cTraco.BuscarTraco(Convert.ToString(carregarMoldagem.IdTraco), "cIDTraco");
            obra = cObra.BuscarObra(Convert.ToString(carregarMoldagem.IdObra), "cIDObra");
            eixo = cEixo.BuscarEixo(Convert.ToString(carregarMoldagem.IdEixo), Convert.ToString(carregarMoldagem.IdObra), "cIDEixo");
            peca = cPeca.BuscarPeca(Convert.ToString(carregarMoldagem.IdPeca), Convert.ToString(carregarMoldagem.IdEixo), Convert.ToString(carregarMoldagem.IdObra), "cIDPeca");
            carregarCB = cBarras.BuscarSerie(serie);
            resist = cResistencia.BuscarResistencia(serie);
            ruptura = cRuptura.BuscarRupturaSerie(serie);
            if (carregarMoldagem.IdSerie != 0)
            {
                txtSerie.Text = Convert.ToString(carregarMoldagem.IdSerie);
                txtLote.Text = Convert.ToString(carregarMoldagem.Lote);
                txtData.Text = Convert.ToString(carregarMoldagem.DataMoldagem);
                txtHora.Text = carregarMoldagem.HoraMoldagem.ToShortTimeString();
                txtVolume.Text = Convert.ToString(carregarMoldagem.VolumeBetonada);
                txtQuant.Text = Convert.ToString(carregarMoldagem.QuantidadeCP);
                txtIdadeA.Text = Convert.ToString(carregarMoldagem.IdadeA);
                txtIdadeB.Text = Convert.ToString(carregarMoldagem.IdadeB);
                txtIdadeC.Text = Convert.ToString(carregarMoldagem.IdadeC);
                txtNota.Text = Convert.ToString(carregarMoldagem.Nota);
                txtTempAr.Text = Convert.ToString(carregarMoldagem.TemperaturaAr);
                txtTempConcreto.Text = Convert.ToString(carregarMoldagem.TemperaturaCimento);
                txtTraco.Text = Convert.ToString(traco[0].CodigoTraco);
                txtFornecedor.Text = traco[0].Usina;
                txtFck.Text = Convert.ToString(traco[0].Fck);
                txtConsistencia.Text = Convert.ToString(traco[0].Consistencia);
                txtObra.Text = obra[0].NomeObra;
                txtEixo.Text = eixo[0].NomeEixo;
                txtPeca.Text = peca[0].NomePeca;
                lote = cLote.BuscarLote(txtLote.Text);
                txtVolumeLote.Text = Convert.ToString(lote.Volume);
                int qtd = carregarMoldagem.QuantidadeCP;
                if (qtd == 2)
                {
                    txtBarCod1.Text = carregarCB[0].IdCodigoBarras;
                    txtBarCod2.Text = carregarCB[1].IdCodigoBarras;
                    txtCP1A.Text = Convert.ToString(resist.RA1);
                    txtCP2A.Text = Convert.ToString(resist.RA2);
                    txtBarCod3.Enabled = false;
                    txtBarCod3.Clear();
                    txtBarCod4.Enabled = false;
                    txtBarCod4.Clear();
                    txtBarCod5.Enabled = false;
                    txtBarCod5.Clear();
                    txtBarCod6.Enabled = false;
                    txtBarCod6.Clear();
                    txtIdadeB.Enabled = false;
                    txtIdadeC.Enabled = false;
                }
                else if (qtd == 4)
                {
                    txtBarCod1.Text = carregarCB[0].IdCodigoBarras;
                    txtBarCod2.Text = carregarCB[1].IdCodigoBarras;
                    txtBarCod3.Text = carregarCB[2].IdCodigoBarras;
                    txtBarCod4.Text = carregarCB[3].IdCodigoBarras;
                    txtCP1A.Text = Convert.ToString(resist.RA1);
                    txtCP2A.Text = Convert.ToString(resist.RA2);
                    txtCP1B.Text = Convert.ToString(resist.RB1);
                    txtCP2B.Text = Convert.ToString(resist.RB2);
                    txtBarCod3.Enabled = true;
                    txtBarCod4.Enabled = true;
                    txtIdadeB.Enabled = true;
                    txtBarCod5.Enabled = false;
                    txtBarCod5.Clear();
                    txtBarCod6.Enabled = false;
                    txtBarCod6.Clear();
                    txtIdadeC.Enabled = false;

                }
                else if (qtd == 6)
                {
                    txtBarCod1.Text = carregarCB[0].IdCodigoBarras;
                    txtBarCod2.Text = carregarCB[1].IdCodigoBarras;
                    txtBarCod3.Text = carregarCB[2].IdCodigoBarras;
                    txtBarCod4.Text = carregarCB[3].IdCodigoBarras;
                    txtBarCod5.Text = carregarCB[4].IdCodigoBarras;
                    txtBarCod6.Text = carregarCB[5].IdCodigoBarras;
                    txtCP1A.Text = Convert.ToString(resist.RA1);
                    txtCP2A.Text = Convert.ToString(resist.RA2);
                    txtCP1B.Text = Convert.ToString(resist.RB1);
                    txtCP2B.Text = Convert.ToString(resist.RB2);
                    txtCP1C.Text = Convert.ToString(resist.RC1);
                    txtCP2C.Text = Convert.ToString(resist.RC2);
                    txtBarCod3.Enabled = true;
                    txtBarCod4.Enabled = true;
                    txtBarCod5.Enabled = true;
                    txtBarCod6.Enabled = true;
                    txtIdadeB.Enabled = true;
                    txtIdadeC.Enabled = true;
                }
                if (carregarCB[0].Situacao == 1)
                {
                    //txtBarCod1.Enabled = false;
                    txtBarCod1.BackColor = Color.LightGreen;

                }
                if (carregarCB[1].Situacao == 1)
                {
                    //txtBarCod2.Enabled = false;
                    txtBarCod2.BackColor = Color.LightGreen;

                }
                if (carregarCB[2].Situacao == 1)
                {
                    //txtBarCod3.Enabled = false;
                    txtBarCod3.BackColor = Color.LightGreen;

                }
                if (carregarCB[3].Situacao == 1)
                {
                    //txtBarCod4.Enabled = false;
                    txtBarCod4.BackColor = Color.LightGreen;

                }
                if (carregarCB[4].Situacao == 1)
                {
                    //txtBarCod5.Enabled = false;
                    txtBarCod5.BackColor = Color.LightGreen;

                }
                if (carregarCB[5].Situacao == 1)
                {
                    //txtBarCod6.Enabled = false;
                    txtBarCod6.BackColor = Color.LightGreen;

                }
                for (int i = 0; i < ruptura.Length; i++)
                {
                    if (Convert.ToInt32((ruptura[i].DataRuptura - carregarMoldagem.DataMoldagem).Days) == carregarMoldagem.IdadeA)
                    {
                        txtDataA.Text = ruptura[i].DataRuptura.ToString("dd/MM/yyyy");
                    }
                    if (Convert.ToInt32((ruptura[i].DataRuptura - carregarMoldagem.DataMoldagem).Days) == carregarMoldagem.IdadeB)
                    {
                        txtDataB.Text = ruptura[i].DataRuptura.ToString("dd/MM/yyyy");
                    }
                    if (Convert.ToInt32((ruptura[i].DataRuptura - carregarMoldagem.DataMoldagem).Days) == carregarMoldagem.IdadeC)
                    {
                        txtDataC.Text = ruptura[i].DataRuptura.ToString("dd/MM/yyyy");
                    }
                }
            }
            else
            {
                /*Reset();
                btnRegistrar.Enabled = true;
                txtBarCod1.Enabled = true;
                txtBarCod2.Enabled = true;
                txtBarCod3.Enabled = false;
                txtBarCod4.Enabled = false;
                txtBarCod5.Enabled = false;
                txtBarCod6.Enabled = false;*/
            }
        }

        private void btnCBBusca_Click(object sender, EventArgs e)
        {
            cb = cBarras.BuscarCodigoBarras(txtCBBusca.Text);
            BuscaSerieText(Convert.ToString(cb.IdSerie));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
