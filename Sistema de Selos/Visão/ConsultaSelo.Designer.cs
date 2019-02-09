namespace Sistema_de_Selos
{
    partial class ConsultaSelo
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
            this.selo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelo
            // 
            this.dgvSelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selo,
            this.placa,
            this.matriculaProp,
            this.nomeProp});
            this.dgvSelo.Location = new System.Drawing.Point(12, 12);
            this.dgvSelo.Name = "dgvSelo";
            this.dgvSelo.RowTemplate.Height = 24;
            this.dgvSelo.Size = new System.Drawing.Size(776, 378);
            this.dgvSelo.TabIndex = 0;
            this.dgvSelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa/Selo";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(93, 413);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(407, 22);
            this.txtBoxBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 410);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(201, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.verVeiculo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultaSelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelo);
            this.Name = "ConsultaSelo";
            this.Text = "Consulta de Veículo";
            this.Load += new System.EventHandler(this.ConsultaSelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn selo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
    }
}