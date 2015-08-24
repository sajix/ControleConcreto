namespace ControleMoldagem.GUI
{
    partial class PrimeiroAcesso
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
            this.rdoSimples = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoCompleto = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSimples
            // 
            this.rdoSimples.Checked = true;
            this.rdoSimples.Location = new System.Drawing.Point(6, 100);
            this.rdoSimples.Name = "rdoSimples";
            this.rdoSimples.Size = new System.Drawing.Size(248, 75);
            this.rdoSimples.TabIndex = 0;
            this.rdoSimples.TabStop = true;
            this.rdoSimples.Text = "Modo Simples - Apresenta apenas o Modulo de Ruptura.";
            this.rdoSimples.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAdmin);
            this.groupBox2.Controls.Add(this.rdoSimples);
            this.groupBox2.Controls.Add(this.rdoCompleto);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.Location = new System.Drawing.Point(6, 181);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(248, 75);
            this.rdoAdmin.TabIndex = 1;
            this.rdoAdmin.Text = "Modo Administrativo - Apresenta ferramentas para gerar relatorios.";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoCompleto
            // 
            this.rdoCompleto.Location = new System.Drawing.Point(6, 19);
            this.rdoCompleto.Name = "rdoCompleto";
            this.rdoCompleto.Size = new System.Drawing.Size(248, 75);
            this.rdoCompleto.TabIndex = 0;
            this.rdoCompleto.Text = "Modo Completo - Apresenta todos os Modulos";
            this.rdoCompleto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 45);
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(103, 19);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(151, 20);
            this.txtConnection.TabIndex = 4;
            // 
            // PrimeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrimeiroAcesso";
            this.Text = "Primeiro Acesso";
            this.Load += new System.EventHandler(this.PrimeiroAcesso_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSimples;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoCompleto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnection;
    }
}