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

        private void ManutencaoProprietario_Load(object sender, EventArgs e)
        {
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.getPropList();
            foreach(Proprietario temp in listProp)
            {
                string[] data =
                {
                    temp.Matricula,
                    temp.Nome,
                    temp.Area,
                    temp.Cargo,
                    temp.Email,
                    temp.Telefone,
                    temp.IdProprietario.ToString()
                };
                dgvProp.Rows.Add(data);
            }
        }

        private string getColumnByPosition(int position)
        {
            return dgvProp.CurrentRow.Cells[position].Value.ToString();
        }

        private void dgvProp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtBoxIdProp.Text = this.getColumnByPosition(6);
            this.txtBoxMat.Text = this.getColumnByPosition(0);
            this.txtBoxNome.Text = this.getColumnByPosition(1);
            this.cBoxDpt.SelectedItem = this.getColumnByPosition(2);
            this.cBoxCargo.SelectedItem = this.getColumnByPosition(3);
            this.txtBoxEmail.Text = this.getColumnByPosition(4);
            this.txtBoxTelefone.Text = this.getColumnByPosition(5);


        }

        private void txtBoxIdProp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchSubject = txtBoxMat.Text;
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.getPropList();
            foreach (Proprietario temp in listProp)
            {
                if (temp.Matricula.Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.Matricula,
                    temp.Nome,
                    temp.Area,
                    temp.Cargo,
                    temp.Email,
                    temp.Telefone,
                    temp.IdProprietario.ToString()
                };
                    dgvProp.Rows.Add(data);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (this.txtBoxIdProp.Text != "")
            {
                Proprietario p = new Proprietario(
                    Convert.ToInt32(this.txtBoxIdProp.Text),
                    this.txtBoxNome.Text,
                    this.txtBoxMat.Text,
                    this.txtBoxTelefone.Text,
                    this.txtBoxEmail.Text,
                    this.cBoxCargo.SelectedItem.ToString(),
                    this.cBoxDpt.SelectedItem.ToString()
                    );
                DAOProprietario dp = new DAOProprietario();
                if (dp.update(p) > 0)
                    MessageBox.Show("Proprietário atualizado com sucesso!");
                else
                    MessageBox.Show("Erro ao salvar Dados");
            }
            else
                MessageBox.Show("Por favor, clique duas vezes em um dos funcionários da tabela!");
        }

        private void txtBoxEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(this.txtBoxIdProp.Text != "")
            {
                DAOProprietario dp = new DAOProprietario();
                if (dp.delete(this.txtBoxIdProp.Text) > 0)
                    MessageBox.Show("Proprietário deletado com sucesso!");
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
