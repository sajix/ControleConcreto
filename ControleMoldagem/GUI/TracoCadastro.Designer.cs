namespace ControleMoldagem.GUI
{
    partial class formTracoCadastro
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
            this.components = new System.ComponentModel.Container();
            this.btOut = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.btApaga = new System.Windows.Forms.Button();
            this.btEdita = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsitencia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAc = new System.Windows.Forms.TextBox();
            this.txtFck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsina = new System.Windows.Forms.TextBox();
            this.txtCodTraco = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tblTracoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.tblTracoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstTraco = new System.Windows.Forms.ListView();
            this.codigoTraco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idadeControle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consumoCimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consistencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tolerancia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            
            this.SuspendLayout();
            // 
            // btOut
            // 
            this.btOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.Location = new System.Drawing.Point(841, 30);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(93, 44);
            this.btOut.TabIndex = 47;
            this.btOut.Text = "SAIR";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpa.Location = new System.Drawing.Point(489, 30);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(93, 44);
            this.btLimpa.TabIndex = 48;
            this.btLimpa.Text = "LIMPAR";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // btApaga
            // 
            this.btApaga.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApaga.Location = new System.Drawing.Point(354, 30);
            this.btApaga.Name = "btApaga";
            this.btApaga.Size = new System.Drawing.Size(93, 44);
            this.btApaga.TabIndex = 49;
            this.btApaga.Text = "APAGA";
            this.btApaga.UseVisualStyleBackColor = true;
            this.btApaga.Click += new System.EventHandler(this.btApaga_Click);
            // 
            // btEdita
            // 
            this.btEdita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdita.Location = new System.Drawing.Point(228, 30);
            this.btEdita.Name = "btEdita";
            this.btEdita.Size = new System.Drawing.Size(93, 44);
            this.btEdita.TabIndex = 46;
            this.btEdita.Text = "EDITA";
            this.btEdita.UseVisualStyleBackColor = true;
            this.btEdita.Click += new System.EventHandler(this.btEdita_Click);
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(102, 30);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(93, 44);
            this.btNovo.TabIndex = 45;
            this.btNovo.Text = "NOVO";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // label7
            // 
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(756, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "CONSISTÊNCIA (mm)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "CONSUMO CIMENTO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 37;
            this.label4.Text = "IDADE CONTROLE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "A/C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "FCK";
            // 
            // txtConsitencia
            // 
            this.txtConsitencia.Location = new System.Drawing.Point(756, 125);
            this.txtConsitencia.Name = "txtConsitencia";
            this.txtConsitencia.Size = new System.Drawing.Size(100, 20);
            this.txtConsitencia.TabIndex = 7;
            this.txtConsitencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(653, 125);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(70, 20);
            this.txtConsumo.TabIndex = 6;
            this.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(545, 125);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(75, 20);
            this.txtIdade.TabIndex = 5;
            this.txtIdade.Text = "28";
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAc
            // 
            this.txtAc.Location = new System.Drawing.Point(456, 125);
            this.txtAc.Name = "txtAc";
            this.txtAc.Size = new System.Drawing.Size(56, 20);
            this.txtAc.TabIndex = 4;
            this.txtAc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFck
            // 
            this.txtFck.Location = new System.Drawing.Point(367, 125);
            this.txtFck.Name = "txtFck";
            this.txtFck.Size = new System.Drawing.Size(56, 20);
            this.txtFck.TabIndex = 3;
            this.txtFck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "USINA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "CÓDIGO TRAÇO";
            // 
            // txtUsina
            // 
            this.txtUsina.Location = new System.Drawing.Point(214, 125);
            this.txtUsina.Name = "txtUsina";
            this.txtUsina.Size = new System.Drawing.Size(120, 20);
            this.txtUsina.TabIndex = 2;
            this.txtUsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodTraco
            // 
            this.txtCodTraco.Location = new System.Drawing.Point(82, 125);
            this.txtCodTraco.Name = "txtCodTraco";
            this.txtCodTraco.Size = new System.Drawing.Size(99, 20);
            this.txtCodTraco.TabIndex = 1;
            this.txtCodTraco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(889, 125);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(85, 20);
            this.txtTolerancia.TabIndex = 8;
            this.txtTolerancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(889, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "TOLERANCIA (mm)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblTracoBindingSource
            // 
            
            // 
            // controleMoldagemDataSet
            // 
            
            // 
            // tblTracoTableAdapter
            // 
            
            // 
            // tblTracoBindingSource1
            // 
            
            
            // 
            // lstTraco
            // 
            this.lstTraco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoTraco,
            this.usina,
            this.fck,
            this.ac,
            this.idadeControle,
            this.consumoCimento,
            this.consistencia,
            this.tolerancia});
            this.lstTraco.FullRowSelect = true;
            this.lstTraco.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstTraco.Location = new System.Drawing.Point(82, 151);
            this.lstTraco.MultiSelect = false;
            this.lstTraco.Name = "lstTraco";
            this.lstTraco.Size = new System.Drawing.Size(892, 443);
            this.lstTraco.TabIndex = 50;
            this.lstTraco.UseCompatibleStateImageBehavior = false;
            this.lstTraco.View = System.Windows.Forms.View.Details;
            this.lstTraco.SelectedIndexChanged += new System.EventHandler(this.lstTraco_SelectedIndexChanged);
            // 
            // codigoTraco
            // 
            this.codigoTraco.Text = "Código Traco";
            this.codigoTraco.Width = 130;
            // 
            // usina
            // 
            this.usina.Text = "Usina";
            this.usina.Width = 150;
            // 
            // fck
            // 
            this.fck.Text = "FCK";
            this.fck.Width = 90;
            // 
            // ac
            // 
            this.ac.Text = "A/C";
            this.ac.Width = 90;
            // 
            // idadeControle
            // 
            this.idadeControle.Text = "Idade Controle";
            this.idadeControle.Width = 105;
            // 
            // consumoCimento
            // 
            this.consumoCimento.Text = "Consumo Cimento";
            this.consumoCimento.Width = 100;
            // 
            // consistencia
            // 
            this.consistencia.Text = "Consistência (mm)";
            this.consistencia.Width = 124;
            // 
            // tolerancia
            // 
            this.tolerancia.Text = "Tolerancia (mm)";
            this.tolerancia.Width = 87;
            // 
            // formTracoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1052, 660);
            this.ControlBox = false;
            this.Controls.Add(this.lstTraco);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btApaga);
            this.Controls.Add(this.btEdita);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsitencia);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtAc);
            this.Controls.Add(this.txtFck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsina);
            this.Controls.Add(this.txtCodTraco);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTracoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO TRAÇO";
            this.Load += new System.EventHandler(this.formTracoCadastro_Load);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Button btApaga;
        private System.Windows.Forms.Button btEdita;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsitencia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtAc;
        private System.Windows.Forms.TextBox txtFck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsina;
        private System.Windows.Forms.TextBox txtCodTraco;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tblTracoBindingSource;
        private System.Windows.Forms.BindingSource tblTracoBindingSource1;
        private System.Windows.Forms.ListView lstTraco;
        private System.Windows.Forms.ColumnHeader codigoTraco;
        private System.Windows.Forms.ColumnHeader usina;
        private System.Windows.Forms.ColumnHeader fck;
        private System.Windows.Forms.ColumnHeader ac;
        private System.Windows.Forms.ColumnHeader idadeControle;
        private System.Windows.Forms.ColumnHeader consumoCimento;
        private System.Windows.Forms.ColumnHeader consistencia;
        private System.Windows.Forms.ColumnHeader tolerancia;
    }
}