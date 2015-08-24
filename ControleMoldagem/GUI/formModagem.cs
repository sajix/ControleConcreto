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
    public partial class formModagem : Form
    {
        CadastroMoldagem cMoldagem = new CadastroMoldagem();
        CadastroLote cLote = new CadastroLote();
        CadastroTraco cTraco = new CadastroTraco();
        CadastroObra cObra = new CadastroObra();
        CadastroPeca cPeca = new CadastroPeca();
        CadastroEixo cEixo = new CadastroEixo();
        CadastrarResistencia cResistencia = new CadastrarResistencia();
        CadastroCodigoBarras cBarras = new CadastroCodigoBarras();
        CodigoBarras[] cb;
        CodigoBarras[] carregarCB;
        Obra[] obra;
        Eixo[] eixo;
        Peca[] peca;
        Traco[] traco;
        Moldagem molde;
        Moldagem carregarMoldagem;
        Lote lote;
        int controle;
        string serie;
        string nLote;
        bool idadeBflag;
        bool idadeCflag;
        public formModagem()
        {
            InitializeComponent();
        }

        private void formModagem_Load(object sender, EventArgs e)
        {
            serie = Convert.ToString(cMoldagem.UltimaSeria());
            nLote = Convert.ToString(cLote.UltimaNLote());
            txtSerie.Text = serie;
            txtLote.Text = nLote;
            txtData.Text = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            lstGeral2.Visible = true;
            lstGeral.Visible = false;
            idadeBflag = false;
            idadeCflag = false;
            txtSerie.Focus();
        }

        private void txtSerie_LostFocus(object sender, System.EventArgs e)
        {
            Novo();
            if (txtSerie.Text != serie)
            {
                carregarMoldagem = cMoldagem.BuscarMoldagem(txtSerie.Text);
                traco = cTraco.BuscarTraco(Convert.ToString(carregarMoldagem.IdTraco), "cIDTraco");
                obra = cObra.BuscarObra(Convert.ToString(carregarMoldagem.IdObra), "cIDObra");
                eixo = cEixo.BuscarEixo(Convert.ToString(carregarMoldagem.IdEixo), Convert.ToString(carregarMoldagem.IdObra), "cIDEixo");
                peca = cPeca.BuscarPeca(Convert.ToString(carregarMoldagem.IdPeca), Convert.ToString(carregarMoldagem.IdEixo), Convert.ToString(carregarMoldagem.IdObra), "cIDPeca");
                carregarCB = cBarras.BuscarSerie(txtSerie.Text);
                if (carregarMoldagem.IdSerie != 0)
                {
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
                        txtBarCod3.Enabled = true;
                        txtBarCod4.Enabled = true;
                        txtBarCod5.Enabled = true;
                        txtBarCod6.Enabled = true;
                        txtIdadeB.Enabled = true;
                        txtIdadeC.Enabled = true;
                    }
                    if (carregarCB[0].Situacao == 1)
                    {
                        txtBarCod1.Enabled = false;
                        Rompido();
                    }
                    if (carregarCB[1].Situacao == 1)
                    {
                        txtBarCod2.Enabled = false;
                        Rompido();
                    }
                    if (carregarCB[2].Situacao == 1)
                    {
                        txtBarCod3.Enabled = false;
                        Rompido();
                    }
                    if (carregarCB[3].Situacao == 1)
                    {
                        txtBarCod4.Enabled = false;
                        Rompido();
                    }
                    if (carregarCB[4].Situacao == 1)
                    {
                        txtBarCod5.Enabled = false;
                        Rompido();
                    }
                    if (carregarCB[5].Situacao == 1)
                    {
                        txtBarCod6.Enabled = false;
                        Rompido();
                    }
                    btnRegistrar.Enabled = false;
                }
                else
                {
                    Reset();
                    btnRegistrar.Enabled = true;
                    txtBarCod1.Enabled = true;
                    txtBarCod2.Enabled = true;
                    txtBarCod3.Enabled = false;
                    txtBarCod4.Enabled = false;
                    txtBarCod5.Enabled = false;
                    txtBarCod6.Enabled = false;
                }
            }
            else
            {
                Limpar();
                btnRegistrar.Enabled = true;
                txtBarCod1.Enabled = true;
                txtBarCod2.Enabled = true;
                txtBarCod3.Enabled = false;
                txtBarCod4.Enabled = false;
                txtBarCod5.Enabled = false;
                txtBarCod6.Enabled = false;
            }
        }

        private void txtLote_LostFocus(object sender, EventArgs e)
        {
            if (txtLote.Text != nLote)
            {

                lote = cLote.BuscarLote(txtLote.Text);
                txtVolumeLote.Text = Convert.ToString(lote.Volume);
            }
            else
            {
                txtVolumeLote.Text = "0";
            }
        }

        private void txtObra_GotFocus(object sender, EventArgs e)
        {
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
            obra = cObra.BuscarTodos();
            for (int i = 0; i < obra.Length; i++)
            {
                lstGeral2.Items.Add(Convert.ToString(i+1) + " - " + obra[i].NomeObra);
            }
        }
        private void txtObra_LostFocus(object sender, EventArgs e)
        {
            int indice = 0;
            indice = Convert.ToInt32(txtObra.Text);
            indice--;
            txtObra.Text = obra[indice].NomeObra;
            lstGeral2.Items.Clear();
        }

        private void txtTraco_GotFocus(object sender, EventArgs e)
        {
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = true;
            lstGeral2.Visible = false;
            traco = cTraco.BuscarTodos();
            for (int i = 0; i < traco.Length; i++)
            {
                lstGeral.Items.Add(new ListViewItem(new string[] {Convert.ToString(i+1), traco[i].CodigoTraco, traco[i].Usina, Convert.ToString(traco[i].Fck), Convert.ToString(traco[i].FatorAC), Convert.ToString(traco[i].IdadeControle), Convert.ToString(traco[i].ConsumoCimento), Convert.ToString(traco[i].Consistencia), Convert.ToString(traco[i].Tolerancia) }));
            }
        }
        private void txtTraco_LostFocus(object sender, EventArgs e)
        {
            int indice = 0;
            indice = Convert.ToInt32(txtTraco.Text);
            indice--;
            txtTraco.Text = traco[indice].CodigoTraco;
            txtFck.Text = Convert.ToString(traco[indice].Fck);
            txtFornecedor.Text = traco[indice].Usina;
            txtConsistencia.Text = Convert.ToString(traco[indice].Consistencia);
            controle = traco[indice].IdadeControle;
            lstGeral.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
        }

        private void txtEixo_GotFocus(object sender, EventArgs e)
        {
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
            eixo = cEixo.BuscarTodos(buscaIdObra(txtObra.Text));
            for (int i = 0; i < eixo.Length; i++)
            {
                lstGeral2.Items.Add(Convert.ToString(i + 1) + " - " + eixo[i].NomeEixo);
            }
        }
        private void txtEixo_LostFocus(object sender, EventArgs e)
        {
            int indice = 0;
            indice = Convert.ToInt32(txtEixo.Text);
            indice--;
            txtEixo.Text = eixo[indice].NomeEixo;
            lstGeral2.Items.Clear();
        }

        private void txtPeca_GotFocus(object sender, EventArgs e)
        {
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
            peca = cPeca.BuscarTodos(buscaIdObra(txtObra.Text), buscaIdEixo(txtEixo.Text, buscaIdObra(txtObra.Text)));
            for (int i = 0; i < peca.Length; i++)
            {
                lstGeral2.Items.Add(Convert.ToString(i + 1) + " - " + peca[i].NomePeca);
            }
        }
        private void txtPeca_LostFocus(object sender, EventArgs e)
        {
            int indice = 0;
            indice = Convert.ToInt32(txtPeca.Text);
            indice--;
            txtPeca.Text = peca[indice].NomePeca;
            lstGeral2.Items.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool cbFlag = true;
            int qtd = Convert.ToInt32(txtQuant.Text);
            string[] codigo = new string[qtd];
            if (qtd == 2)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                if (codigo[0] == codigo[1])
                {
                    MessageBox.Show("Codigo de Barra Repetido.",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    cbFlag = false;
                }
            }
            else if (qtd == 4)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                codigo[2] = txtBarCod3.Text;
                codigo[3] = txtBarCod4.Text;
                for (int i = 0; i < qtd-1; i++)
                {
                    for (int j = i+1; j < qtd; j++)
                    {
                        if (codigo[i] == codigo[j])
                        {
                            MessageBox.Show("Codigo de Barra Repetido.",
                            "Erro ao Cadastrar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbFlag = false;
                            //break;
                        }
                    }
                }
            }
            else if (qtd == 6)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                codigo[2] = txtBarCod3.Text;
                codigo[3] = txtBarCod4.Text;
                codigo[4] = txtBarCod5.Text;
                codigo[5] = txtBarCod6.Text;
                for (int i = 0; i < qtd - 1; i++)
                {
                    for (int j = i + 1; j < qtd; j++)
                    {
                        if (codigo[i] == codigo[j])
                        {
                            MessageBox.Show("Codigo de Barra Repetido.",
                            "Erro ao Cadastrar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbFlag = false;
                            //break;
                        }
                    }
                }
            }
            cb = cBarras.BuscarTodos();
            for (int i = 0; i < qtd; i++)
            {
                for (int j = 0; j < cb.Length; j++)
                {
                    if (codigo[i] == cb[j].IdCodigoBarras)
                    {
                        MessageBox.Show("Codigo de Barra Repetido.",
                        "Erro ao Cadastrar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                        cbFlag = false;
                    }
                }
            }
            if (cbFlag == true)
            {
                double volumeTotal = Convert.ToDouble(txtVolumeLote.Text) + Convert.ToDouble(txtVolume.Text);
                int idObra = buscaIdObra(txtObra.Text);
                int idEixo = buscaIdEixo(txtEixo.Text, idObra);
                int idPeca = buscaIdPeca(txtPeca.Text, idObra, idEixo);
                int idTraco = buscaIdTraco(txtTraco.Text);
                DateTime dataControle = Convert.ToDateTime(txtData.Text);
                dataControle = dataControle.AddDays(controle);
                if (txtLote.Text == nLote)
                {
                    cLote.CadastrarLote(txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "0", txtVolume.Text);
                    cMoldagem.InserirMoldagem(txtSerie.Text, txtData.Text, txtHora.Text, txtLote.Text, Convert.ToString(idTraco), txtFck.Text, Convert.ToString(idObra), Convert.ToString(idEixo), Convert.ToString(idPeca), txtQuant.Text, "28", txtIdadeA.Text, txtIdadeB.Text, txtIdadeC.Text, txtVolume.Text, txtTempAr.Text, txtTempConcreto.Text, txtNota.Text);
                    cResistencia.InserirResistencia(txtSerie.Text);
                    for (int i = 0; i < qtd; i++)
                    {
                        cBarras.InserirCodigoBarras(Convert.ToString(codigo[i]), txtSerie.Text, "0");
                    }
                    MessageBox.Show("Serie Cadastrada.",
                    "Cadastro Serie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    Registrado();
                }
                else if (txtLote.Text != nLote && volumeTotal <= 50)
                {
                    cLote.EditarLote("0", txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "", Convert.ToString(volumeTotal));
                    cMoldagem.InserirMoldagem(txtSerie.Text, txtData.Text, txtHora.Text, txtLote.Text, Convert.ToString(idTraco), txtFck.Text, Convert.ToString(idObra), Convert.ToString(idEixo), Convert.ToString(idPeca), txtQuant.Text, "28", txtIdadeA.Text, txtIdadeB.Text, txtIdadeC.Text, txtVolume.Text, txtTempAr.Text, txtTempConcreto.Text, txtNota.Text);
                    cResistencia.InserirResistencia(txtSerie.Text);
                    for (int i = 0; i < qtd; i++)
                    {
                        cBarras.InserirCodigoBarras(Convert.ToString(codigo[i]), txtSerie.Text, "0");
                    }
                    MessageBox.Show("Serie Cadastrada.",
                    "Cadastro Serie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    Registrado();
                }
                else
                {
                    MessageBox.Show("Lote muito Grande. Inicie outro lote.",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private int buscaIdTraco(string codigoTraco)
        {
            Traco[] traco = cTraco.BuscarTraco(txtTraco.Text, "cCodigoTraco");
            int idTraco = traco[0].IdTraco;
            return idTraco;
        }
        private int buscaIdObra(string nomeObra)
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

        private int buscaIdEixo(string nomeEixo, int idObra)
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

        private int buscaIdPeca(string nomePeca, int idObra, int idEixo)
        {
            peca = cPeca.BuscarTodos(idObra, idEixo);
            eixo = cEixo.BuscarTodos(idObra);
            bool enc = false;
            int aux = 0;
            while (enc == false)
            {
                if (peca[aux].NomePeca == nomePeca)
                {
                    enc = true;
                }
                else
                {
                    aux++;
                }
            }
            int idPeca = peca[aux].IdPeca;

            return idPeca;
        }

        private void txtQuant_LostFocus(object sender, EventArgs e)
        {
            int quant = Convert.ToInt32(txtQuant.Text);
            if (quant % 2 == 0 && quant <=6)
            {
                if (quant == 2)
                {
                    txtIdadeA.Enabled = true;
                    txtIdadeB.Enabled = false;
                    txtIdadeC.Enabled = false;

                    txtBarCod1.Enabled = true;
                    txtBarCod2.Enabled = true;
                    txtBarCod3.Enabled = false;
                    txtBarCod4.Enabled = false;
                    txtBarCod5.Enabled = false;
                    txtBarCod6.Enabled = false;

                    idadeBflag = false;
                    idadeCflag = false;
                }
                else if (quant == 4)
                {
                    txtIdadeA.Enabled = true;
                    txtIdadeB.Enabled = true;
                    txtIdadeC.Enabled = false;

                    txtBarCod1.Enabled = true;
                    txtBarCod2.Enabled = true;
                    txtBarCod3.Enabled = true;
                    txtBarCod4.Enabled = true;
                    txtBarCod5.Enabled = false;
                    txtBarCod6.Enabled = false;

                    idadeBflag = true;
                    idadeCflag = false;
                }
                else if (quant == 6)
                {
                    txtIdadeA.Enabled = true;
                    txtIdadeB.Enabled = true;
                    txtIdadeC.Enabled = true;

                    txtBarCod1.Enabled = true;
                    txtBarCod2.Enabled = true;
                    txtBarCod3.Enabled = true;
                    txtBarCod4.Enabled = true;
                    txtBarCod5.Enabled = true;
                    txtBarCod6.Enabled = true;
                    idadeCflag = true;
                    idadeBflag = true;
                }
            }
            else if (txtQuant.Text == "")
            {
                MessageBox.Show("Preencha o campo Qtd CPs.",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                txtQuant.Clear();
                txtQuant.Focus();
            }
            else
            {
                MessageBox.Show("Qunatidade de Copor de Prova deve ser par e menor que 6.",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                txtQuant.Clear();
                txtQuant.Focus();
            }
        }

        private void txtIdadeA_LostFocus(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtQuant.Text);
            if (txtQuant.Text == "" || qtd%2 != 0)
            {

            }
            else
            {
                if (txtIdadeA.Text == "")
                {

                    MessageBox.Show("Preencha a Idade de Rompimento A.",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    txtIdadeA.Focus();
                }
            }
        }

        private void txtIdadeB_LostFocus(object sender, EventArgs e)
        {
            if (txtIdadeA.Text == "")
            {

            }
            else
            {
                if (idadeBflag == true)
                {
                    if (txtIdadeB.Text == "")
                    {
                        MessageBox.Show("Preencha a Idade de Rompimento B.",
                        "Erro ao Cadastrar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                        txtIdadeB.Focus();
                    }
                }
            }
        }

        private void txtIdadeC_LostFocus(object sender, EventArgs e)
        {
            if (txtIdadeB.Text == "")
            {

            }
            else
            {
                if (idadeCflag == true)
                {
                    if (txtIdadeC.Text == "")
                    {
                        MessageBox.Show("Preencha a Idade de Rompimento C.",
                        "Erro ao Cadastrar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                        txtIdadeC.Focus();
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTraco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtTempAr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void txtTempConcreto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void txtPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIdadeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIdadeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIdadeC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBarCod6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtConsistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Limpar()
        {
            serie = Convert.ToString(cMoldagem.UltimaSeria());
            nLote = Convert.ToString(cLote.UltimaNLote());
            txtLote.Clear();
            txtData.Clear();
            txtHora.Clear();
            txtVolume.Clear();
            txtQuant.Clear();
            txtIdadeA.Clear();
            txtIdadeB.Clear();
            txtIdadeC.Clear();
            txtNota.Clear();
            txtTempAr.Clear();
            txtTempConcreto.Clear();
            txtTraco.Clear();
            txtFornecedor.Clear();
            txtFck.Clear();
            txtConsistencia.Clear();
            txtObra.Clear();
            txtEixo.Clear();
            txtPeca.Clear();
            txtVolumeLote.Clear();
            txtBarCod1.Clear();
            txtBarCod2.Clear();
            txtBarCod3.Clear();
            txtBarCod4.Clear();
            txtBarCod5.Clear();
            txtBarCod6.Clear();
            txtSerie.Text = serie;
            txtLote.Text = nLote;
            txtData.Text = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            btnRegistrar.Enabled = true;
            txtBarCod1.Enabled = true;
            txtBarCod2.Enabled = true;
            txtConsistencia.Enabled = true;
            txtData.Enabled = true;
            txtEixo.Enabled = true;
            txtFck.Enabled = true;
            txtFornecedor.Enabled = true;
            txtHora.Enabled = true;
            txtIdadeA.Enabled = true;
            txtLote.Enabled = true;
            txtNota.Enabled = true;
            txtObra.Enabled = true;
            txtPeca.Enabled = true;
            txtQuant.Enabled = true;
            txtTempAr.Enabled = true;
            txtTempConcreto.Enabled = true;
            txtTraco.Enabled = true;
            txtVolume.Enabled = true;
            btnEditar.Enabled = true;
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;

        }
        private void Reset()
        {
            nLote = Convert.ToString(cLote.UltimaNLote());
            txtLote.Clear();
            txtData.Clear();
            txtHora.Clear();
            txtVolume.Clear();
            txtQuant.Clear();
            txtIdadeA.Clear();
            txtIdadeB.Clear();
            txtIdadeC.Clear();
            txtNota.Clear();
            txtTempAr.Clear();
            txtTempConcreto.Clear();
            txtTraco.Clear();
            txtFornecedor.Clear();
            txtFck.Clear();
            txtConsistencia.Clear();
            txtObra.Clear();
            txtEixo.Clear();
            txtPeca.Clear();
            txtVolumeLote.Clear();
            txtBarCod1.Clear();
            txtBarCod2.Clear();
            txtBarCod3.Clear();
            txtBarCod4.Clear();
            txtBarCod5.Clear();
            txtBarCod6.Clear();
            txtLote.Text = nLote;
            txtData.Text = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            btnRegistrar.Enabled = true;
            txtBarCod1.Enabled = true;
            txtBarCod2.Enabled = true;
            txtConsistencia.Enabled = true;
            txtData.Enabled = true;
            txtEixo.Enabled = true;
            txtFck.Enabled = true;
            txtFornecedor.Enabled = true;
            txtHora.Enabled = true;
            txtIdadeA.Enabled = true;
            txtLote.Enabled = true;
            txtNota.Enabled = true;
            txtObra.Enabled = true;
            txtPeca.Enabled = true;
            txtQuant.Enabled = true;
            txtTempAr.Enabled = true;
            txtTempConcreto.Enabled = true;
            txtTraco.Enabled = true;
            txtVolume.Enabled = true;
            btnEditar.Enabled = true;
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
        }
        private void Registrado()
        {
            double volumeTotal = Convert.ToDouble(txtVolumeLote.Text) + Convert.ToDouble(txtVolume.Text);
            txtHora.Clear();
            txtVolume.Clear();
            txtQuant.Clear();
            txtIdadeA.Clear();
            txtIdadeB.Clear();
            txtIdadeC.Clear();
            txtNota.Clear();
            txtTempAr.Clear();
            txtTempConcreto.Clear();
            txtFck.Clear();
            txtConsistencia.Clear();
            txtVolumeLote.Text = Convert.ToString(volumeTotal);
            txtBarCod1.Clear();
            txtBarCod2.Clear();
            txtBarCod3.Clear();
            txtBarCod4.Clear();
            txtBarCod5.Clear();
            txtBarCod6.Clear();
            txtSerie.Focus();
        }

        private void formModagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnRegistrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{ENTER}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool cbFlag = true;
            bool novoCB = false;
            int qtd = Convert.ToInt32(txtQuant.Text);
            string[] codigo = new string[qtd];
            if (qtd == 2)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                if (codigo[0] == codigo[1])
                {
                    MessageBox.Show("Codigo de Barra Repetido.",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    cbFlag = false;
                }
            }
            else if (qtd == 4)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                codigo[2] = txtBarCod3.Text;
                codigo[3] = txtBarCod4.Text;
                for (int i = 0; i < qtd - 1; i++)
                {
                    for (int j = i + 1; j < qtd; j++)
                    {
                        if (codigo[i] == codigo[j])
                        {
                            MessageBox.Show("Codigo de Barra Repetido.",
                            "Erro ao Cadastrar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbFlag = false;
                            //break;
                        }
                    }
                }
            }
            else if (qtd == 6)
            {
                codigo[0] = txtBarCod1.Text;
                codigo[1] = txtBarCod2.Text;
                codigo[2] = txtBarCod3.Text;
                codigo[3] = txtBarCod4.Text;
                codigo[4] = txtBarCod5.Text;
                codigo[5] = txtBarCod6.Text;
                for (int i = 0; i < qtd - 1; i++)
                {
                    for (int j = i + 1; j < qtd; j++)
                    {
                        if (codigo[i] == codigo[j])
                        {
                            MessageBox.Show("Codigo de Barra Repetido.",
                            "Erro ao Cadastrar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbFlag = false;
                            //break;
                        }
                    }
                }
            }

            for (int i = 0; i < qtd; i++)
            {
                if (codigo[i] != carregarCB[i].IdCodigoBarras)
                {
                    novoCB = true;
                }
            }

            if (novoCB == true)
            {
                cb = cBarras.BuscarTodos();
                for (int i = 0; i < qtd; i++)
                {
                    for (int j = 0; j < cb.Length; j++)
                    {
                        if (codigo[i] == cb[j].IdCodigoBarras && codigo[i] != carregarCB[i].IdCodigoBarras)
                        {
                            MessageBox.Show("Codigo de Barra Repetido.",
                            "Erro ao Cadastrar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                            cbFlag = false;
                        }
                    }
                }
            }
            
            //for (int i = 0; i>

            if (cbFlag == true)
            {
                
                double volumeNovo = Convert.ToDouble(txtVolumeLote.Text) - carregarMoldagem.VolumeBetonada;
                double volumeTotal = volumeNovo + Convert.ToDouble(txtVolume.Text);
                int idObra = buscaIdObra(txtObra.Text);
                int idEixo = buscaIdEixo(txtEixo.Text, idObra);
                int idPeca = buscaIdPeca(txtPeca.Text, idObra, idEixo);
                int idTraco = buscaIdTraco(txtTraco.Text);
                DateTime dataControle = Convert.ToDateTime(txtData.Text);
                dataControle = dataControle.AddDays(controle);
                lote = cLote.BuscarLote(txtLote.Text);
                cLote.EditarLote("0", txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "", Convert.ToString(volumeNovo));
                if (lote.IdSerie == 0)
                {
                    cLote.CadastrarLote(txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "0", txtVolume.Text);
                    cMoldagem.EditarMoldagem("", txtSerie.Text, txtData.Text, txtHora.Text, txtLote.Text, Convert.ToString(idTraco), txtFck.Text, Convert.ToString(idObra), Convert.ToString(idEixo), Convert.ToString(idPeca), txtQuant.Text, "28", txtIdadeA.Text, txtIdadeB.Text, txtIdadeC.Text, txtVolume.Text, txtTempAr.Text, txtTempConcreto.Text, txtNota.Text);
                    for (int i = 0; i < qtd; i++)
                    {
                        //MessageBox.Show(codigo[i], "Formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        cBarras.EditarCodigoBarras(codigo[i], carregarCB[i].IdCodigoBarras, Convert.ToString(carregarCB[i].IdSerie), Convert.ToString(carregarCB[i].Situacao));
                    }
                    MessageBox.Show("Serie Editada.",
                    "Cadastro Serie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    //Registrado();
                }
                else if (volumeTotal <= 50)
                {
                    cLote.EditarLote("0", txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "", Convert.ToString(volumeTotal));
                    cMoldagem.EditarMoldagem("", txtSerie.Text, txtData.Text, txtHora.Text, txtLote.Text, Convert.ToString(idTraco), txtFck.Text, Convert.ToString(idObra), Convert.ToString(idEixo), Convert.ToString(idPeca), txtQuant.Text, "28", txtIdadeA.Text, txtIdadeB.Text, txtIdadeC.Text, txtVolume.Text, txtTempAr.Text, txtTempConcreto.Text, txtNota.Text);
                    for (int i = 0; i < qtd; i++)
                    {
                        //MessageBox.Show(codigo[i], "Formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        cBarras.EditarCodigoBarras(codigo[i], carregarCB[i].IdCodigoBarras, Convert.ToString(carregarCB[i].IdSerie), Convert.ToString(carregarCB[i].Situacao));
                    }
                    MessageBox.Show("Serie Editada.",
                    "Cadastro Serie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    //Registrado();
                }
                else
                {
                    MessageBox.Show("Lote muito Grande. Inicie outro lote.",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }    
        }

        private void Rompido()
        {
            txtBarCod1.Enabled = false;
            txtBarCod2.Enabled = false;
            txtBarCod3.Enabled = false;
            txtBarCod4.Enabled = false;
            txtBarCod5.Enabled = false;
            txtBarCod6.Enabled = false;
            txtConsistencia.Enabled = false;
            txtData.Enabled = false;
            txtEixo.Enabled = false;
            txtFck.Enabled = false;
            txtFornecedor.Enabled = false;
            txtHora.Enabled = false;
            txtIdadeA.Enabled = false;
            txtIdadeB.Enabled = false;
            txtIdadeC.Enabled = false;
            txtLote.Enabled = false;
            txtNota.Enabled = false;
            txtObra.Enabled = false;
            txtPeca.Enabled = false;
            txtQuant.Enabled = false;
            txtTempAr.Enabled = false;
            txtTempConcreto.Enabled = false;
            txtTraco.Enabled = false;
            txtVolume.Enabled = false;
            btnEditar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnApagar.Enabled = false;
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
        }
        private void Novo()
        {
            btnRegistrar.Enabled = true;
            txtBarCod1.Enabled = true;
            txtBarCod2.Enabled = true;
            txtConsistencia.Enabled = true;
            txtData.Enabled = true;
            txtEixo.Enabled = true;
            txtFck.Enabled = true;
            txtFornecedor.Enabled = true;
            txtHora.Enabled = true;
            txtIdadeA.Enabled = true;
            txtLote.Enabled = true;
            txtNota.Enabled = true;
            txtObra.Enabled = true;
            txtPeca.Enabled = true;
            txtQuant.Enabled = true;
            txtTempAr.Enabled = true;
            txtTempConcreto.Enabled = true;
            txtTraco.Enabled = true;
            txtVolume.Enabled = true;
            btnEditar.Enabled = true;
            lstGeral.Items.Clear();
            lstGeral2.Items.Clear();
            lstGeral.Visible = false;
            lstGeral2.Visible = true;
            btnApagar.Enabled = true;
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Você tem certeza que deseja deletar essa serie?",
                        "Excluir Serie!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                double volumeNovo = Convert.ToDouble(txtVolumeLote.Text) - carregarMoldagem.VolumeBetonada;
                DateTime dataControle = Convert.ToDateTime(txtData.Text);
                cLote.EditarLote("0", txtLote.Text, Convert.ToString(dataControle), txtFck.Text, "", Convert.ToString(volumeNovo));
                cMoldagem.RemoverMoldagem(txtSerie.Text);
                cBarras.RemoverCodigoBarras(Convert.ToString(carregarMoldagem.IdSerie));
            }
            else
            {
                // if 'No' do something here 
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
