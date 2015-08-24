namespace ControleMoldagem.GUI
{
    partial class formModagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTraco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConsistencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTempAr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTempConcreto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEixo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPeca = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdadeA = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdadeB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIdadeC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBarCod1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBarCod2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBarCod3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBarCod4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBarCod5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtBarCod6 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lstGeral = new System.Windows.Forms.ListView();
            this.cIndice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCodigoTraco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUsina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFatorAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdadeControle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cConsumoCimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cConsistencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTolerancia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtVolumeLote = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.lstGeral2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSerie
            // 
            this.txtSerie.AcceptsTab = true;
            this.txtSerie.Location = new System.Drawing.Point(55, 51);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(97, 22);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            this.txtSerie.LostFocus += new System.EventHandler(this.txtSerie_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÉRIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "HORA";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(400, 51);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(97, 22);
            this.txtLote.TabIndex = 4;
            this.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLote_KeyPress);
            this.txtLote.LostFocus += new System.EventHandler(this.txtLote_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "LOTE ESTATÍSTICA";
            // 
            // txtTraco
            // 
            this.txtTraco.Location = new System.Drawing.Point(515, 51);
            this.txtTraco.Name = "txtTraco";
            this.txtTraco.Size = new System.Drawing.Size(97, 22);
            this.txtTraco.TabIndex = 5;
            this.txtTraco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTraco.GotFocus += new System.EventHandler(this.txtTraco_GotFocus);
            this.txtTraco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTraco_KeyPress);
            this.txtTraco.LostFocus += new System.EventHandler(this.txtTraco_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "CÓDIGO TRAÇO";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(630, 51);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(97, 22);
            this.txtFornecedor.TabIndex = 6;
            this.txtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(636, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "FORNECEDOR";
            // 
            // txtFck
            // 
            this.txtFck.Enabled = false;
            this.txtFck.Location = new System.Drawing.Point(745, 51);
            this.txtFck.Name = "txtFck";
            this.txtFck.Size = new System.Drawing.Size(97, 22);
            this.txtFck.TabIndex = 7;
            this.txtFck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(778, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "FCK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(674, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "DADOS DO CONCRETO MOLDADO";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(860, 51);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(97, 22);
            this.txtNota.TabIndex = 8;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(890, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "NOTA";
            // 
            // txtConsistencia
            // 
            this.txtConsistencia.Location = new System.Drawing.Point(170, 116);
            this.txtConsistencia.Name = "txtConsistencia";
            this.txtConsistencia.Size = new System.Drawing.Size(97, 22);
            this.txtConsistencia.TabIndex = 10;
            this.txtConsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConsistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsistencia_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "CONSISTÊNCIA (mm)";
            // 
            // txtTempAr
            // 
            this.txtTempAr.Location = new System.Drawing.Point(285, 116);
            this.txtTempAr.Name = "txtTempAr";
            this.txtTempAr.Size = new System.Drawing.Size(97, 22);
            this.txtTempAr.TabIndex = 11;
            this.txtTempAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempAr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempAr_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "TEMP. AR";
            // 
            // txtTempConcreto
            // 
            this.txtTempConcreto.Location = new System.Drawing.Point(400, 116);
            this.txtTempConcreto.Name = "txtTempConcreto";
            this.txtTempConcreto.Size = new System.Drawing.Size(97, 22);
            this.txtTempConcreto.TabIndex = 12;
            this.txtTempConcreto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempConcreto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempConcreto_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(400, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "TEMP. CONRETO";
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(515, 116);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(212, 22);
            this.txtObra.TabIndex = 13;
            this.txtObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtObra.GotFocus += new System.EventHandler(this.txtObra_GotFocus);
            this.txtObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObra_KeyPress);
            this.txtObra.LostFocus += new System.EventHandler(this.txtObra_LostFocus);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(602, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "OBRA";
            // 
            // txtEixo
            // 
            this.txtEixo.Location = new System.Drawing.Point(745, 116);
            this.txtEixo.Name = "txtEixo";
            this.txtEixo.Size = new System.Drawing.Size(212, 22);
            this.txtEixo.TabIndex = 14;
            this.txtEixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEixo.GotFocus += new System.EventHandler(this.txtEixo_GotFocus);
            this.txtEixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEixo_KeyPress);
            this.txtEixo.LostFocus += new System.EventHandler(this.txtEixo_LostFocus);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(828, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "EIXO";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(55, 116);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(97, 22);
            this.txtVolume.TabIndex = 9;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "VOLUME BT";
            // 
            // txtPeca
            // 
            this.txtPeca.Location = new System.Drawing.Point(55, 180);
            this.txtPeca.Name = "txtPeca";
            this.txtPeca.Size = new System.Drawing.Size(441, 22);
            this.txtPeca.TabIndex = 15;
            this.txtPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeca.GotFocus += new System.EventHandler(this.txtPeca_GotFocus);
            this.txtPeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeca_KeyPress);
            this.txtPeca.LostFocus += new System.EventHandler(this.txtPeca_LostFocus);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(257, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "PEÇA";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(515, 180);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(97, 22);
            this.txtQuant.TabIndex = 16;
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuant_KeyPress);
            this.txtQuant.LostFocus += new System.EventHandler(this.txtQuant_LostFocus);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(538, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Qtd CPs";
            // 
            // txtIdadeA
            // 
            this.txtIdadeA.Location = new System.Drawing.Point(630, 180);
            this.txtIdadeA.Name = "txtIdadeA";
            this.txtIdadeA.Size = new System.Drawing.Size(97, 22);
            this.txtIdadeA.TabIndex = 17;
            this.txtIdadeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdadeA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeA_KeyPress);
            this.txtIdadeA.LostFocus += new System.EventHandler(this.txtIdadeA_LostFocus);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(653, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "IDADE A";
            // 
            // txtIdadeB
            // 
            this.txtIdadeB.Enabled = false;
            this.txtIdadeB.Location = new System.Drawing.Point(745, 180);
            this.txtIdadeB.Name = "txtIdadeB";
            this.txtIdadeB.Size = new System.Drawing.Size(97, 22);
            this.txtIdadeB.TabIndex = 18;
            this.txtIdadeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdadeB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeB_KeyPress);
            this.txtIdadeB.LostFocus += new System.EventHandler(this.txtIdadeB_LostFocus);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(768, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "IDADE B";
            // 
            // txtIdadeC
            // 
            this.txtIdadeC.Enabled = false;
            this.txtIdadeC.Location = new System.Drawing.Point(860, 180);
            this.txtIdadeC.Name = "txtIdadeC";
            this.txtIdadeC.Size = new System.Drawing.Size(97, 22);
            this.txtIdadeC.TabIndex = 19;
            this.txtIdadeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdadeC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeC_KeyPress);
            this.txtIdadeC.LostFocus += new System.EventHandler(this.txtIdadeC_LostFocus);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(883, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "IDADE C";
            // 
            // txtBarCod1
            // 
            this.txtBarCod1.Location = new System.Drawing.Point(630, 257);
            this.txtBarCod1.Name = "txtBarCod1";
            this.txtBarCod1.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod1.TabIndex = 20;
            this.txtBarCod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod1_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(637, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "COD BARRA 1";
            // 
            // txtBarCod2
            // 
            this.txtBarCod2.Location = new System.Drawing.Point(630, 328);
            this.txtBarCod2.Name = "txtBarCod2";
            this.txtBarCod2.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod2.TabIndex = 21;
            this.txtBarCod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod2_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(637, 309);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "COD BARRA 2";
            // 
            // txtBarCod3
            // 
            this.txtBarCod3.Enabled = false;
            this.txtBarCod3.Location = new System.Drawing.Point(745, 257);
            this.txtBarCod3.Name = "txtBarCod3";
            this.txtBarCod3.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod3.TabIndex = 22;
            this.txtBarCod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod3_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(752, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "COD BARRA 3";
            // 
            // txtBarCod4
            // 
            this.txtBarCod4.Enabled = false;
            this.txtBarCod4.Location = new System.Drawing.Point(745, 328);
            this.txtBarCod4.Name = "txtBarCod4";
            this.txtBarCod4.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod4.TabIndex = 23;
            this.txtBarCod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod4_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(752, 309);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "COD BARRA 4";
            // 
            // txtBarCod5
            // 
            this.txtBarCod5.Enabled = false;
            this.txtBarCod5.Location = new System.Drawing.Point(860, 257);
            this.txtBarCod5.Name = "txtBarCod5";
            this.txtBarCod5.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod5.TabIndex = 24;
            this.txtBarCod5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod5_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(867, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "COD BARRA 5";
            // 
            // txtBarCod6
            // 
            this.txtBarCod6.Enabled = false;
            this.txtBarCod6.Location = new System.Drawing.Point(860, 328);
            this.txtBarCod6.Name = "txtBarCod6";
            this.txtBarCod6.Size = new System.Drawing.Size(97, 22);
            this.txtBarCod6.TabIndex = 25;
            this.txtBarCod6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCod6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCod6_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(867, 309);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 16);
            this.label26.TabIndex = 1;
            this.label26.Text = "COD BARRA 6";
            // 
            // lstGeral
            // 
            this.lstGeral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cIndice,
            this.cCodigoTraco,
            this.cUsina,
            this.cFck,
            this.cFatorAC,
            this.cIdadeControle,
            this.cConsumoCimento,
            this.cConsistencia,
            this.cTolerancia});
            this.lstGeral.Location = new System.Drawing.Point(55, 257);
            this.lstGeral.Name = "lstGeral";
            this.lstGeral.Size = new System.Drawing.Size(557, 499);
            this.lstGeral.TabIndex = 2;
            this.lstGeral.UseCompatibleStateImageBehavior = false;
            this.lstGeral.View = System.Windows.Forms.View.Details;
            // 
            // cIndice
            // 
            this.cIndice.Text = "Indice";
            // 
            // cCodigoTraco
            // 
            this.cCodigoTraco.Text = "Codigo Traço";
            // 
            // cUsina
            // 
            this.cUsina.Text = "Usina";
            // 
            // cFck
            // 
            this.cFck.Text = "FCK";
            // 
            // cFatorAC
            // 
            this.cFatorAC.Text = "Fator A/C";
            // 
            // cIdadeControle
            // 
            this.cIdadeControle.Text = "Idade Controle";
            // 
            // cConsumoCimento
            // 
            this.cConsumoCimento.Text = "Consumo Cimento";
            // 
            // cConsistencia
            // 
            this.cConsistencia.Text = "Consistencia (mm)";
            // 
            // cTolerancia
            // 
            this.cTolerancia.Text = "Tolerancia";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(745, 394);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(137, 50);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegistrar_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(745, 472);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 50);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseCompatibleTextRendering = true;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(745, 550);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(137, 50);
            this.btnApagar.TabIndex = 28;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseCompatibleTextRendering = true;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(745, 628);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 50);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseCompatibleTextRendering = true;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(745, 706);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 50);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "SAIR";
            this.btnVoltar.UseCompatibleTextRendering = true;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(52, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 16);
            this.label27.TabIndex = 4;
            this.label27.Text = "VOLUME LOTE";
            // 
            // txtVolumeLote
            // 
            this.txtVolumeLote.Enabled = false;
            this.txtVolumeLote.Location = new System.Drawing.Point(141, 221);
            this.txtVolumeLote.Name = "txtVolumeLote";
            this.txtVolumeLote.Size = new System.Drawing.Size(35, 22);
            this.txtVolumeLote.TabIndex = 26;
            this.txtVolumeLote.Text = "0";
            this.txtVolumeLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(170, 51);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(97, 22);
            this.txtData.TabIndex = 2;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.UseWaitCursor = true;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(285, 51);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(97, 22);
            this.txtHora.TabIndex = 3;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // lstGeral2
            // 
            this.lstGeral2.FormattingEnabled = true;
            this.lstGeral2.ItemHeight = 16;
            this.lstGeral2.Location = new System.Drawing.Point(55, 256);
            this.lstGeral2.Name = "lstGeral2";
            this.lstGeral2.Size = new System.Drawing.Size(557, 500);
            this.lstGeral2.TabIndex = 8;
            // 
            // formModagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1014, 783);
            this.ControlBox = false;
            this.Controls.Add(this.lstGeral2);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtVolumeLote);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lstGeral);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtFck);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtTraco);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtPeca);
            this.Controls.Add(this.txtEixo);
            this.Controls.Add(this.txtObra);
            this.Controls.Add(this.txtBarCod6);
            this.Controls.Add(this.txtBarCod5);
            this.Controls.Add(this.txtBarCod4);
            this.Controls.Add(this.txtBarCod3);
            this.Controls.Add(this.txtBarCod2);
            this.Controls.Add(this.txtBarCod1);
            this.Controls.Add(this.txtIdadeC);
            this.Controls.Add(this.txtIdadeB);
            this.Controls.Add(this.txtIdadeA);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtTempConcreto);
            this.Controls.Add(this.txtTempAr);
            this.Controls.Add(this.txtConsistencia);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtSerie);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formModagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO MOLDAGEM";
            this.Load += new System.EventHandler(this.formModagem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formModagem_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTraco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConsistencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTempAr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTempConcreto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEixo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPeca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIdadeA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdadeB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIdadeC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBarCod1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBarCod2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBarCod3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBarCod4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBarCod5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtBarCod6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListView lstGeral;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtVolumeLote;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.ListBox lstGeral2;
        private System.Windows.Forms.ColumnHeader cCodigoTraco;
        private System.Windows.Forms.ColumnHeader cUsina;
        private System.Windows.Forms.ColumnHeader cFck;
        private System.Windows.Forms.ColumnHeader cFatorAC;
        private System.Windows.Forms.ColumnHeader cIdadeControle;
        private System.Windows.Forms.ColumnHeader cConsumoCimento;
        private System.Windows.Forms.ColumnHeader cConsistencia;
        private System.Windows.Forms.ColumnHeader cTolerancia;
        private System.Windows.Forms.ColumnHeader cIndice;
    }
}