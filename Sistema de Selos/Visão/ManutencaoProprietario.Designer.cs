namespace Sistema_de_Selos
{
    partial class ManutencaoProprietario
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
            this.txtBoxMat = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProp = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cBoxDpt = new System.Windows.Forms.ComboBox();
            this.txtBoxIdProp = new System.Windows.Forms.TextBox();
            this.cBoxCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // txtBoxMat
            // 
            this.txtBoxMat.Location = new System.Drawing.Point(15, 47);
            this.txtBoxMat.Name = "txtBoxMat";
            this.txtBoxMat.Size = new System.Drawing.Size(255, 22);
            this.txtBoxMat.TabIndex = 1;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(15, 115);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(255, 22);
            this.txtBoxNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departamento/Curso";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 410);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 32);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(162, 410);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(105, 32);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvProp
            // 
            this.dgvProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nome,
            this.depCurso,
            this.cargo,
            this.email,
            this.telefone,
            this.idProp});
            this.dgvProp.Location = new System.Drawing.Point(276, 27);
            this.dgvProp.Name = "dgvProp";
            this.dgvProp.RowTemplate.Height = 24;
            this.dgvProp.Size = new System.Drawing.Size(1066, 486);
            this.dgvProp.TabIndex = 10;
            this.dgvProp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProp_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 478);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(144, 35);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cBoxDpt
            // 
            this.cBoxDpt.FormattingEnabled = true;
            this.cBoxDpt.Items.AddRange(new object[] {
            "DCOMP",
            "DAL",
            "Departamento de Química",
            "DEMAT",
            "Departamento de Física"});
            this.cBoxDpt.Location = new System.Drawing.Point(12, 302);
            this.cBoxDpt.Name = "cBoxDpt";
            this.cBoxDpt.Size = new System.Drawing.Size(255, 24);
            this.cBoxDpt.TabIndex = 12;
            // 
            // txtBoxIdProp
            // 
            this.txtBoxIdProp.Location = new System.Drawing.Point(793, 568);
            this.txtBoxIdProp.Name = "txtBoxIdProp";
            this.txtBoxIdProp.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIdProp.TabIndex = 13;
            this.txtBoxIdProp.Visible = false;
            this.txtBoxIdProp.TextChanged += new System.EventHandler(this.txtBoxIdProp_TextChanged);
            // 
            // cBoxCargo
            // 
            this.cBoxCargo.FormattingEnabled = true;
            this.cBoxCargo.Items.AddRange(new object[] {
            "Professor",
            "Coordenador",
            "Zelador",
            "Diretor",
            "Supervisor"});
            this.cBoxCargo.Location = new System.Drawing.Point(12, 366);
            this.cBoxCargo.Name = "cBoxCargo";
            this.cBoxCargo.Size = new System.Drawing.Size(255, 24);
            this.cBoxCargo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cargo";
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matrícula";
            this.matricula.Name = "matricula";
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
            this.depCurso.Width = 200;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // idProp
            // 
            this.idProp.HeaderText = "Id Proprietário";
            this.idProp.Name = "idProp";
            this.idProp.Visible = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 180);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(255, 22);
            this.txtBoxEmail.TabIndex = 17;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(9, 160);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(42, 17);
            this.labela.TabIndex = 16;
            this.labela.Text = "Email";
            this.labela.Click += new System.EventHandler(this.txtBoxEmail_Click);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(12, 245);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(255, 22);
            this.txtBoxTelefone.TabIndex = 19;
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(9, 225);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(64, 17);
            this.labelb.TabIndex = 18;
            this.labelb.Text = "Telefone";
            // 
            // ManutencaoProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 641);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.cBoxCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxIdProp);
            this.Controls.Add(this.cBoxDpt);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvProp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMat);
            this.Controls.Add(this.label1);
            this.Name = "ManutencaoProprietario";
            this.Text = "Manutencao de Proprietario";
            this.Load += new System.EventHandler(this.ManutencaoProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMat;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProp;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cBoxDpt;
        private System.Windows.Forms.TextBox txtBoxIdProp;
        private System.Windows.Forms.ComboBox cBoxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn depCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProp;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.Label labelb;
    }
}