namespace Sistema_de_Selos
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProprietárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seloToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seloToolStripMenuItem,
            this.porProprietárioToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seloToolStripMenuItem1,
            this.proprietárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seloToolStripMenuItem2,
            this.proprietárioToolStripMenuItem1});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // seloToolStripMenuItem
            // 
            this.seloToolStripMenuItem.Name = "seloToolStripMenuItem";
            this.seloToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.seloToolStripMenuItem.Text = "Por selo";
            this.seloToolStripMenuItem.Click += new System.EventHandler(this.seloToolStripMenuItem_Click);
            // 
            // porProprietárioToolStripMenuItem
            // 
            this.porProprietárioToolStripMenuItem.Name = "porProprietárioToolStripMenuItem";
            this.porProprietárioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.porProprietárioToolStripMenuItem.Text = "Por proprietário";
            this.porProprietárioToolStripMenuItem.Click += new System.EventHandler(this.porProprietárioToolStripMenuItem_Click);
            // 
            // seloToolStripMenuItem1
            // 
            this.seloToolStripMenuItem1.Name = "seloToolStripMenuItem1";
            this.seloToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.seloToolStripMenuItem1.Text = "Selo";
            this.seloToolStripMenuItem1.Click += new System.EventHandler(this.seloToolStripMenuItem1_Click);
            // 
            // proprietárioToolStripMenuItem
            // 
            this.proprietárioToolStripMenuItem.Name = "proprietárioToolStripMenuItem";
            this.proprietárioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.proprietárioToolStripMenuItem.Text = "Proprietário";
            this.proprietárioToolStripMenuItem.Click += new System.EventHandler(this.proprietárioToolStripMenuItem_Click);
            // 
            // seloToolStripMenuItem2
            // 
            this.seloToolStripMenuItem2.Name = "seloToolStripMenuItem2";
            this.seloToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.seloToolStripMenuItem2.Text = "Selo";
            this.seloToolStripMenuItem2.Click += new System.EventHandler(this.seloToolStripMenuItem2_Click);
            // 
            // proprietárioToolStripMenuItem1
            // 
            this.proprietárioToolStripMenuItem1.Name = "proprietárioToolStripMenuItem1";
            this.proprietárioToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.proprietárioToolStripMenuItem1.Text = "Proprietário";
            this.proprietárioToolStripMenuItem1.Click += new System.EventHandler(this.proprietárioToolStripMenuItem1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sistema de Selos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProprietárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proprietárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seloToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem proprietárioToolStripMenuItem1;
    }
}

