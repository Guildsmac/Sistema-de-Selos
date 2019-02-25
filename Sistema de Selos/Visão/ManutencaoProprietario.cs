using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Selos.Controle;
using Sistema_de_Selos.Modelo;

namespace Sistema_de_Selos
{
    public partial class ManutencaoProprietario : Form
    {
        public ManutencaoProprietario()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public bool checkEmpty()
        {
            if (this.txtBoxNome.Text == "" || this.txtBoxMat.Text == "" ||
               this.txtBoxTelefone.Text == "" || this.txtBoxEmail.Text == "" ||
               this.txtBoxIdProp.Text == "" || this.cBoxCargo == null ||
               this.cBoxDpt == null)
                return true;
            return false;
        }

        private void clearAll()
        {
            this.txtBoxNome.Text = "";
            this.txtBoxMat.Text = "";
            this.txtBoxTelefone.Text = "";
            this.txtBoxEmail.Text = "";
            this.txtBoxIdProp.Text = "";
            dgvProp.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> proprietarios = udc.verProprietario();
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);
        }

        private void ManutencaoProprietario_Load(object sender, EventArgs e)
        {
            dgvProp.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> proprietarios = udc.verProprietario();
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);

        }

        private string getColumnByPosition(int position)
        {
            return dgvProp.CurrentRow.Cells[position].Value.ToString();
        }

        private void dgvProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtBoxIdProp.Text = this.getColumnByPosition(1);
            this.txtBoxMat.Text = this.getColumnByPosition(0);
            this.txtBoxNome.Text = this.getColumnByPosition(2);
            this.cBoxDpt.SelectedItem = this.getColumnByPosition(3);
            this.cBoxCargo.SelectedItem = this.getColumnByPosition(4);
            this.txtBoxEmail.Text = this.getColumnByPosition(5);
            this.txtBoxTelefone.Text = this.getColumnByPosition(6);


        }

        private void txtBoxIdProp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProprietario(object sender, EventArgs e)
        {
            string searchSubject = txtBoxMat.Text;
            dgvProp.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> proprietarios = udc.buscarProprietario(searchSubject);
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);

        }

        private void btnAlterarProprietario(object sender, EventArgs e)
        {
            if (this.txtBoxIdProp.Text != "")
            {
                if (!this.checkEmpty())
                {
                    UnidadeDeControle udc = new UnidadeDeControle();
                    if (udc.alterarProprietario(
                        Convert.ToInt32(this.txtBoxIdProp.Text),
                        this.txtBoxNome.Text,
                        this.txtBoxMat.Text,
                        this.txtBoxTelefone.Text,
                        this.txtBoxEmail.Text,
                        this.cBoxCargo.SelectedItem.ToString(),
                        this.cBoxDpt.SelectedItem.ToString()
                        ))
                    {
                        MessageBox.Show("Proprietário atualizado com sucesso!");
                        this.clearAll();
                    }
                    else
                        MessageBox.Show("Erro ao salvar Dados");


                }
                else
                    MessageBox.Show("Por favor, preencha todos os dados.");
            }
            else
                MessageBox.Show("Por favor, clique duas vezes em um dos funcionários da tabela!");
        }

        private void txtBoxEmail_Click(object sender, EventArgs e)
        {

        }

        private void deletarProprietario(object sender, EventArgs e)
        {
            if(this.txtBoxIdProp.Text != "")
            {
                UnidadeDeControle udc = new UnidadeDeControle();
                if (udc.deletarProprietario(this.txtBoxIdProp.Text))
                {
                    MessageBox.Show("Proprietário deletado com sucesso!");
                    this.clearAll();
                }
                else
                    MessageBox.Show("Erro ao deletar");
            }
            else
            {
                MessageBox.Show("Por favor, selecione um proprietário para deletar!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
