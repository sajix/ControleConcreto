namespace ControleMoldagem.GUI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraEixoPeçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moldagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rupturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPsDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieCodigoDeBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.buscaToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(656, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obraEixoPeçaToolStripMenuItem,
            this.traçoToolStripMenuItem,
            this.moldagemToolStripMenuItem,
            this.rupturaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // obraEixoPeçaToolStripMenuItem
            // 
            this.obraEixoPeçaToolStripMenuItem.Name = "obraEixoPeçaToolStripMenuItem";
            this.obraEixoPeçaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.obraEixoPeçaToolStripMenuItem.Text = "Obra / Eixo / Peça";
            this.obraEixoPeçaToolStripMenuItem.Click += new System.EventHandler(this.obraEixoPeçaToolStripMenuItem_Click);
            // 
            // traçoToolStripMenuItem
            // 
            this.traçoToolStripMenuItem.Name = "traçoToolStripMenuItem";
            this.traçoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.traçoToolStripMenuItem.Text = "Traço";
            this.traçoToolStripMenuItem.Click += new System.EventHandler(this.traçoToolStripMenuItem_Click);
            // 
            // moldagemToolStripMenuItem
            // 
            this.moldagemToolStripMenuItem.Name = "moldagemToolStripMenuItem";
            this.moldagemToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.moldagemToolStripMenuItem.Text = "Moldagem";
            this.moldagemToolStripMenuItem.Click += new System.EventHandler(this.moldagemToolStripMenuItem_Click);
            // 
            // rupturaToolStripMenuItem
            // 
            this.rupturaToolStripMenuItem.Name = "rupturaToolStripMenuItem";
            this.rupturaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rupturaToolStripMenuItem.Text = "Ruptura";
            this.rupturaToolStripMenuItem.Click += new System.EventHandler(this.rupturaToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loteToolStripMenuItem,
            this.resistenciasToolStripMenuItem,
            this.codigoDeBarraToolStripMenuItem,
            this.cPsDoDiaToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // loteToolStripMenuItem
            // 
            this.loteToolStripMenuItem.Name = "loteToolStripMenuItem";
            this.loteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.loteToolStripMenuItem.Text = "FCK Estimado";
            this.loteToolStripMenuItem.Click += new System.EventHandler(this.loteToolStripMenuItem_Click);
            // 
            // resistenciasToolStripMenuItem
            // 
            this.resistenciasToolStripMenuItem.Name = "resistenciasToolStripMenuItem";
            this.resistenciasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.resistenciasToolStripMenuItem.Text = "Resistencia Diaria";
            this.resistenciasToolStripMenuItem.Click += new System.EventHandler(this.resistenciasToolStripMenuItem_Click);
            // 
            // codigoDeBarraToolStripMenuItem
            // 
            this.codigoDeBarraToolStripMenuItem.Name = "codigoDeBarraToolStripMenuItem";
            this.codigoDeBarraToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.codigoDeBarraToolStripMenuItem.Text = "Codigo de Barra";
            this.codigoDeBarraToolStripMenuItem.Click += new System.EventHandler(this.codigoDeBarraToolStripMenuItem_Click);
            // 
            // cPsDoDiaToolStripMenuItem
            // 
            this.cPsDoDiaToolStripMenuItem.Name = "cPsDoDiaToolStripMenuItem";
            this.cPsDoDiaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cPsDoDiaToolStripMenuItem.Text = "Agenda";
            this.cPsDoDiaToolStripMenuItem.Click += new System.EventHandler(this.cPsDoDiaToolStripMenuItem_Click);
            // 
            // buscaToolStripMenuItem
            // 
            this.buscaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serieCodigoDeBarrasToolStripMenuItem});
            this.buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            this.buscaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.buscaToolStripMenuItem.Text = "Busca";
            // 
            // serieCodigoDeBarrasToolStripMenuItem
            // 
            this.serieCodigoDeBarrasToolStripMenuItem.Name = "serieCodigoDeBarrasToolStripMenuItem";
            this.serieCodigoDeBarrasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.serieCodigoDeBarrasToolStripMenuItem.Text = "Serie / Codigo de Barras";
            this.serieCodigoDeBarrasToolStripMenuItem.Click += new System.EventHandler(this.serieCodigoDeBarrasToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDBToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.toolStripSeparator1,
            this.sobreToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // exportarDBToolStripMenuItem
            // 
            this.exportarDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem});
            this.exportarDBToolStripMenuItem.Name = "exportarDBToolStripMenuItem";
            this.exportarDBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarDBToolStripMenuItem.Text = "Exportar DB...";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 448);
            this.Controls.Add(this.menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Moldagem";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraEixoPeçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moldagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rupturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeBarraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPsDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieCodigoDeBarrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}