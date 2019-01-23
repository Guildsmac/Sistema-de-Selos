namespace Sistema_de_Selos
{
    partial class CadastroProprietario
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
            this.txtBoxNomeProp = new System.Windows.Forms.TextBox();
            this.txtBoxTelProp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMatProp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxCargoProp = new System.Windows.Forms.ComboBox();
            this.cBoxDptProp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarProprietario = new System.Windows.Forms.Button();
            this.txtBoxEmailPropi = new System.Windows.Forms.TextBox();
            this.txtBoxEmailProp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtBoxNomeProp
            // 
            this.txtBoxNomeProp.Location = new System.Drawing.Point(24, 74);
            this.txtBoxNomeProp.Name = "txtBoxNomeProp";
            this.txtBoxNomeProp.Size = new System.Drawing.Size(343, 22);
            this.txtBoxNomeProp.TabIndex = 1;
            // 
            // txtBoxTelProp
            // 
            this.txtBoxTelProp.Location = new System.Drawing.Point(24, 134);
            this.txtBoxTelProp.Name = "txtBoxTelProp";
            this.txtBoxTelProp.Size = new System.Drawing.Size(343, 22);
            this.txtBoxTelProp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtBoxMatProp
            // 
            this.txtBoxMatProp.Location = new System.Drawing.Point(24, 195);
            this.txtBoxMatProp.Name = "txtBoxMatProp";
            this.txtBoxMatProp.Size = new System.Drawing.Size(343, 22);
            this.txtBoxMatProp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo";
            // 
            // cBoxCargoProp
            // 
            this.cBoxCargoProp.FormattingEnabled = true;
            this.cBoxCargoProp.Items.AddRange(new object[] {
            "Professor",
            "Coordenador",
            "Zelador",
            "Diretor",
            "Supervisor"});
            this.cBoxCargoProp.Location = new System.Drawing.Point(24, 315);
            this.cBoxCargoProp.Name = "cBoxCargoProp";
            this.cBoxCargoProp.Size = new System.Drawing.Size(343, 24);
            this.cBoxCargoProp.TabIndex = 7;
            // 
            // cBoxDptProp
            // 
            this.cBoxDptProp.FormattingEnabled = true;
            this.cBoxDptProp.Items.AddRange(new object[] {
            "DCOMP",
            "DAL",
            "Departamento de Química",
            "DEMAT",
            "Departamento de Física"});
            this.cBoxDptProp.Location = new System.Drawing.Point(24, 380);
            this.cBoxDptProp.Name = "cBoxDptProp";
            this.cBoxDptProp.Size = new System.Drawing.Size(343, 24);
            this.cBoxDptProp.TabIndex = 9;
            this.cBoxDptProp.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamento/Curso/Setor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(52, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarProprietario
            // 
            this.btnCadastrarProprietario.Location = new System.Drawing.Point(230, 440);
            this.btnCadastrarProprietario.Name = "btnCadastrarProprietario";
            this.btnCadastrarProprietario.Size = new System.Drawing.Size(100, 40);
            this.btnCadastrarProprietario.TabIndex = 11;
            this.btnCadastrarProprietario.Text = "Cadastrar";
            this.btnCadastrarProprietario.UseVisualStyleBackColor = true;
            this.btnCadastrarProprietario.Click += new System.EventHandler(this.btnCadastrarProprietario_Click);
            // 
            // txtBoxEmailPropi
            // 
            this.txtBoxEmailPropi.Location = new System.Drawing.Point(24, 255);
            this.txtBoxEmailPropi.Name = "txtBoxEmailPropi";
            this.txtBoxEmailPropi.Size = new System.Drawing.Size(343, 22);
            this.txtBoxEmailPropi.TabIndex = 13;
            // 
            // txtBoxEmailProp
            // 
            this.txtBoxEmailProp.AutoSize = true;
            this.txtBoxEmailProp.Location = new System.Drawing.Point(21, 235);
            this.txtBoxEmailProp.Name = "txtBoxEmailProp";
            this.txtBoxEmailProp.Size = new System.Drawing.Size(42, 17);
            this.txtBoxEmailProp.TabIndex = 12;
            this.txtBoxEmailProp.Text = "Email";
            // 
            // CadastroProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 540);
            this.Controls.Add(this.txtBoxEmailPropi);
            this.Controls.Add(this.txtBoxEmailProp);
            this.Controls.Add(this.btnCadastrarProprietario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cBoxDptProp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxCargoProp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMatProp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxTelProp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNomeProp);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProprietario";
            this.Text = "Cadastro de Proprietario";
            this.Load += new System.EventHandler(this.CadastroProprietario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNomeProp;
        private System.Windows.Forms.TextBox txtBoxTelProp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMatProp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxCargoProp;
        private System.Windows.Forms.ComboBox cBoxDptProp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarProprietario;
        private System.Windows.Forms.TextBox txtBoxEmailPropi;
        private System.Windows.Forms.Label txtBoxEmailProp;
    }
}