namespace ControleMoldagem.GUI
{
    partial class Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConectString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboPrinter = new System.Windows.Forms.ComboBox();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoSimples = new System.Windows.Forms.RadioButton();
            this.rdoCompleto = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtASenha = new System.Windows.Forms.TextBox();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.txtNSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(382, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConectString);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco de Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // txtConectString
            // 
            this.txtConectString.Location = new System.Drawing.Point(103, 19);
            this.txtConectString.Name = "txtConectString";
            this.txtConectString.Size = new System.Drawing.Size(151, 20);
            this.txtConectString.TabIndex = 0;
            this.txtConectString.TextChanged += new System.EventHandler(this.txtConectString_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboPrinter);
            this.groupBox2.Controls.Add(this.cbPreview);
            this.groupBox2.Controls.Add(this.txtCopies);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impressão";
            // 
            // comboPrinter
            // 
            this.comboPrinter.FormattingEnabled = true;
            this.comboPrinter.Location = new System.Drawing.Point(154, 14);
            this.comboPrinter.Name = "comboPrinter";
            this.comboPrinter.Size = new System.Drawing.Size(100, 21);
            this.comboPrinter.TabIndex = 7;
            this.comboPrinter.SelectedIndexChanged += new System.EventHandler(this.comboPrinter_SelectedIndexChanged);
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Location = new System.Drawing.Point(155, 71);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(15, 14);
            this.cbPreview.TabIndex = 5;
            this.cbPreview.UseVisualStyleBackColor = true;
            this.cbPreview.CheckedChanged += new System.EventHandler(this.cbPreview_CheckedChanged);
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(154, 45);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(35, 20);
            this.txtCopies.TabIndex = 4;
            this.txtCopies.TextChanged += new System.EventHandler(this.txtCopies_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preview da Impressão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de Copias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Impressora";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoAdmin);
            this.groupBox3.Controls.Add(this.rdoSimples);
            this.groupBox3.Controls.Add(this.rdoCompleto);
            this.groupBox3.Location = new System.Drawing.Point(278, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 262);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modo";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.Location = new System.Drawing.Point(6, 181);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(248, 75);
            this.rdoAdmin.TabIndex = 1;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Modo Administrativo - Apresenta ferramentas para gerar relatorios.";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.CheckedChanged += new System.EventHandler(this.rdoAdmin_CheckedChanged);
            // 
            // rdoSimples
            // 
            this.rdoSimples.Location = new System.Drawing.Point(6, 100);
            this.rdoSimples.Name = "rdoSimples";
            this.rdoSimples.Size = new System.Drawing.Size(248, 75);
            this.rdoSimples.TabIndex = 0;
            this.rdoSimples.TabStop = true;
            this.rdoSimples.Text = "Modo Simples - Apresenta apenas o Modulo de Ruptura.";
            this.rdoSimples.UseVisualStyleBackColor = true;
            this.rdoSimples.CheckedChanged += new System.EventHandler(this.rdoSimples_CheckedChanged);
            // 
            // rdoCompleto
            // 
            this.rdoCompleto.Location = new System.Drawing.Point(6, 19);
            this.rdoCompleto.Name = "rdoCompleto";
            this.rdoCompleto.Size = new System.Drawing.Size(248, 75);
            this.rdoCompleto.TabIndex = 0;
            this.rdoCompleto.TabStop = true;
            this.rdoCompleto.Text = "Modo Completo - Apresenta todos os Modulos";
            this.rdoCompleto.UseVisualStyleBackColor = true;
            this.rdoCompleto.CheckedChanged += new System.EventHandler(this.rdoCompleto_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtASenha);
            this.groupBox4.Controls.Add(this.txtRepetir);
            this.groupBox4.Controls.Add(this.txtNSenha);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 99);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Senha Antiga";
            // 
            // txtASenha
            // 
            this.txtASenha.Location = new System.Drawing.Point(155, 21);
            this.txtASenha.Name = "txtASenha";
            this.txtASenha.PasswordChar = '•';
            this.txtASenha.Size = new System.Drawing.Size(100, 20);
            this.txtASenha.TabIndex = 4;
            this.txtASenha.TextChanged += new System.EventHandler(this.txtASenha_TextChanged);
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(154, 73);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '•';
            this.txtRepetir.Size = new System.Drawing.Size(100, 20);
            this.txtRepetir.TabIndex = 3;
            this.txtRepetir.TextChanged += new System.EventHandler(this.txtRepetir_TextChanged);
            // 
            // txtNSenha
            // 
            this.txtNSenha.Location = new System.Drawing.Point(154, 47);
            this.txtNSenha.Name = "txtNSenha";
            this.txtNSenha.PasswordChar = '•';
            this.txtNSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNSenha.TabIndex = 2;
            this.txtNSenha.TextChanged += new System.EventHandler(this.txtNSenha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Repetir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nova Senha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(463, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 317);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConectString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPreview;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPrinter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoSimples;
        private System.Windows.Forms.RadioButton rdoCompleto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.TextBox txtASenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
    }
}