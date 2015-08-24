namespace ControleMoldagem.GUI
{
    partial class RelatorioAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioAgenda));
            this.dtpkAgenda = new System.Windows.Forms.DateTimePicker();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dtpkAgenda
            // 
            this.dtpkAgenda.Location = new System.Drawing.Point(12, 12);
            this.dtpkAgenda.Name = "dtpkAgenda";
            this.dtpkAgenda.Size = new System.Drawing.Size(215, 20);
            this.dtpkAgenda.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(233, 10);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(76, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 38);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(297, 23);
            this.pBar.TabIndex = 2;
            this.pBar.Visible = false;
            // 
            // RelatorioAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 72);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.dtpkAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkAgenda;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ProgressBar pBar;
    }
}