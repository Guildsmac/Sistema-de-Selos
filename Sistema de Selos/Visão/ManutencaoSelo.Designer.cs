namespace Sistema_de_Selos
{
    partial class ManutencaoSelo
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
            this.dgvSelo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSelo = new System.Windows.Forms.TextBox();
            this.btnBuscarSelo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBoxCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelmodelo = new System.Windows.Forms.Label();
            this.selo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelo
            // 
            this.dgvSelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selo,
            this.placa,
            this.modelo,
            this.cor,
            this.matriculaProp,
            this.nomeProp});
            this.dgvSelo.Location = new System.Drawing.Point(276, 36);
            this.dgvSelo.Name = "dgvSelo";
            this.dgvSelo.RowTemplate.Height = 24;
            this.dgvSelo.Size = new System.Drawing.Size(1028, 333);
            this.dgvSelo.TabIndex = 1;
            this.dgvSelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvSelo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelo_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selo";
            // 
            // txtBoxSelo
            // 
            this.txtBoxSelo.Enabled = false;
            this.txtBoxSelo.Location = new System.Drawing.Point(15, 56);
            this.txtBoxSelo.Name = "txtBoxSelo";
            this.txtBoxSelo.Size = new System.Drawing.Size(255, 22);
            this.txtBoxSelo.TabIndex = 3;
            // 
            // btnBuscarSelo
            // 
            this.btnBuscarSelo.Location = new System.Drawing.Point(800, 375);
            this.btnBuscarSelo.Name = "btnBuscarSelo";
            this.btnBuscarSelo.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarSelo.TabIndex = 4;
            this.btnBuscarSelo.Text = "Buscar";
            this.btnBuscarSelo.UseVisualStyleBackColor = true;
            this.btnBuscarSelo.Click += new System.EventHandler(this.btnBuscarSelo_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(165, 272);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(105, 32);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(15, 272);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 32);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBoxCor
            // 
            this.txtBoxCor.Location = new System.Drawing.Point(15, 224);
            this.txtBoxCor.Name = "txtBoxCor";
            this.txtBoxCor.Size = new System.Drawing.Size(255, 22);
            this.txtBoxCor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cor";
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(15, 165);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(255, 22);
            this.txtBoxModelo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBoxPlaca
            // 
            this.txtBoxPlaca.Location = new System.Drawing.Point(15, 111);
            this.txtBoxPlaca.Name = "txtBoxPlaca";
            this.txtBoxPlaca.Size = new System.Drawing.Size(255, 22);
            this.txtBoxPlaca.TabIndex = 17;
            // 
            // labelmodelo
            // 
            this.labelmodelo.AutoSize = true;
            this.labelmodelo.Location = new System.Drawing.Point(12, 91);
            this.labelmodelo.Name = "labelmodelo";
            this.labelmodelo.Size = new System.Drawing.Size(43, 17);
            this.labelmodelo.TabIndex = 16;
            this.labelmodelo.Text = "Placa";
            // 
            // selo
            // 
            this.selo.HeaderText = "Selo";
            this.selo.Name = "selo";
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // cor
            // 
            this.cor.HeaderText = "Cor";
            this.cor.Name = "cor";
            // 
            // matriculaProp
            // 
            this.matriculaProp.HeaderText = "Matrícula do Proprietário";
            this.matriculaProp.Name = "matriculaProp";
            this.matriculaProp.Width = 200;
            // 
            // nomeProp
            // 
            this.nomeProp.HeaderText = "Nome do Proprietário";
            this.nomeProp.Name = "nomeProp";
            this.nomeProp.Width = 200;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(454, 375);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(340, 22);
            this.txtBoxBuscar.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar por número de Selo";
            // 
            // ManutencaoSelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.txtBoxPlaca);
            this.Controls.Add(this.labelmodelo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtBoxCor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarSelo);
            this.Controls.Add(this.txtBoxSelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelo);
            this.Name = "ManutencaoSelo";
            this.Text = "ManutencaoSelo";
            this.Load += new System.EventHandler(this.ManutencaoSelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSelo;
        private System.Windows.Forms.Button btnBuscarSelo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtBoxCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBoxPlaca;
        private System.Windows.Forms.Label labelmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn selo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Label label4;
    }
}