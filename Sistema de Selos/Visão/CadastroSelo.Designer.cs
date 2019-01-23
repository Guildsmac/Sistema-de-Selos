namespace Sistema_de_Selos
{
    partial class CadastroSelo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlaca = new System.Windows.Forms.TextBox();
            this.txtBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarSelo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProp = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxIdProp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do carro";
            // 
            // txtBoxPlaca
            // 
            this.txtBoxPlaca.Location = new System.Drawing.Point(15, 67);
            this.txtBoxPlaca.Name = "txtBoxPlaca";
            this.txtBoxPlaca.Size = new System.Drawing.Size(298, 22);
            this.txtBoxPlaca.TabIndex = 1;
            // 
            // txtBoxModelo
            // 
            this.txtBoxModelo.Location = new System.Drawing.Point(15, 153);
            this.txtBoxModelo.Name = "txtBoxModelo";
            this.txtBoxModelo.Size = new System.Drawing.Size(298, 22);
            this.txtBoxModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo do carro";
            // 
            // txtBoxCor
            // 
            this.txtBoxCor.Location = new System.Drawing.Point(15, 243);
            this.txtBoxCor.Name = "txtBoxCor";
            this.txtBoxCor.Size = new System.Drawing.Size(298, 22);
            this.txtBoxCor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor do carro";
            // 
            // btnCadastrarSelo
            // 
            this.btnCadastrarSelo.Location = new System.Drawing.Point(430, 376);
            this.btnCadastrarSelo.Name = "btnCadastrarSelo";
            this.btnCadastrarSelo.Size = new System.Drawing.Size(100, 40);
            this.btnCadastrarSelo.TabIndex = 13;
            this.btnCadastrarSelo.Text = "Cadastrar";
            this.btnCadastrarSelo.UseVisualStyleBackColor = true;
            this.btnCadastrarSelo.Click += new System.EventHandler(this.btnCadastrarSelo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvProp
            // 
            this.dgvProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.idProp,
            this.nome,
            this.depCurso,
            this.cargo});
            this.dgvProp.Location = new System.Drawing.Point(342, 42);
            this.dgvProp.Name = "dgvProp";
            this.dgvProp.RowTemplate.Height = 24;
            this.dgvProp.Size = new System.Drawing.Size(632, 223);
            this.dgvProp.TabIndex = 14;
            this.dgvProp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvProp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProp_CellDoubleClick);
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
            // 
            // idProp
            // 
            this.idProp.HeaderText = "Id";
            this.idProp.Name = "idProp";
            this.idProp.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // depCurso
            // 
            this.depCurso.HeaderText = "Departamento/Curso";
            this.depCurso.Name = "depCurso";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Matrícula do Proprietário";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(508, 271);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(385, 22);
            this.txtBoxBuscar.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(899, 268);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBoxIdProp
            // 
            this.txtBoxIdProp.Location = new System.Drawing.Point(713, 300);
            this.txtBoxIdProp.Name = "txtBoxIdProp";
            this.txtBoxIdProp.Size = new System.Drawing.Size(75, 22);
            this.txtBoxIdProp.TabIndex = 18;
            this.txtBoxIdProp.Visible = false;
            // 
            // CadastroSelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.txtBoxIdProp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProp);
            this.Controls.Add(this.btnCadastrarSelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBoxCor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPlaca);
            this.Controls.Add(this.label1);
            this.Name = "CadastroSelo";
            this.Text = "Cadastro de Selo";
            this.Load += new System.EventHandler(this.CadastroSelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlaca;
        private System.Windows.Forms.TextBox txtBoxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarSelo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn depCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.TextBox txtBoxIdProp;
    }
}