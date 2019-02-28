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
    public partial class ManutencaoSelo : Form
    {
        public ManutencaoSelo()
        {
            InitializeComponent();
        }

        private string getColumnByPosition(int position)
        {
            return dgvSelo.CurrentRow.Cells[position].Value.ToString();
        }

        private void clearAll()
        {
            this.txtBoxSelo.Text = "";
            this.txtBoxPlaca.Text = "";
            this.txtBoxModelo.Text = "";
            this.txtBoxCor.Text = "";
            dgvSelo.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> selos = udc.verVeiculo();
            foreach (string[] temp in selos)
                dgvSelo.Rows.Add(temp);
        }

        private bool checkEmpty()
        {
            if (this.txtBoxCor.Text == "" || this.txtBoxPlaca.Text == "" || this.txtBoxModelo.Text == "")
                return true;
            return false;
        }

        private void ManutencaoSelo_Load(object sender, EventArgs e)
        {
            dgvSelo.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> selos = udc.verVeiculo();
            foreach(string[] temp in selos)
                dgvSelo.Rows.Add(temp);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarSelo_Click(object sender, EventArgs e)
        {
            string searchSubject = txtBoxBuscar.Text;
            dgvSelo.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> selos = udc.buscarVeiculo(searchSubject);
            foreach (string[] temp in selos)
                dgvSelo.Rows.Add(temp);
            
        }

        private void alterarVeiculo(object sender, EventArgs e)
        {
            if (this.txtBoxSelo.Text != "")
            {
                if (!this.checkEmpty())
                {
                    UnidadeDeControle udc = new UnidadeDeControle();
                    if (udc.alterarVeiculo(
                        Convert.ToInt32(this.txtBoxSelo.Text),
                        this.txtBoxPlaca.Text,
                        this.txtBoxModelo.Text,
                        this.txtBoxCor.Text))
                    {
                        MessageBox.Show("Selo atualizado com sucesso!");
                        this.clearAll();
                    }
                    else
                        MessageBox.Show("Não foi possível atualizar selo");
                }
                else
                    MessageBox.Show("Por favor, digite todos os campos.");
            }
            else
            {
                MessageBox.Show("Por favor, clique duas vezes no selo desejado!");
            }
            
        }

        private void deletarVeiculo(object sender, EventArgs e)
        {
            if (this.txtBoxSelo.Text != "")
            {
                UnidadeDeControle udc = new UnidadeDeControle();
                if (udc.deletarVeiculo(Convert.ToInt32(this.txtBoxSelo.Text))){
                    MessageBox.Show("Selo deletado com sucesso.");
                    this.clearAll();

                } else
                    MessageBox.Show("Erro ao deletar o selo.");
           
                
            }
            else
            {
                MessageBox.Show("Por favor, clique duas vezes no selo desejado!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarProprietario(object sender, EventArgs e)
        {
            /* string searchSubject = txtBoxMatriculaProp.Text;
            DAOSelo ds = new DAOSelo();
            dgvSelo.Rows.Clear();
            List<Selo> listProp = ds.select();
            foreach (Selo temp in listProp)
            {
                if (true)//(temp.MatriculaProprietario.ToString().Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.Modelo,
                    temp.Cor,
                    temp.IdProprietario.ToString()
                };
                    dgvSelo.Rows.Add(data);
                }
            }*/
        }

        private void dgvSelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBoxSelo.Text = this.getColumnByPosition(0);
            this.txtBoxPlaca.Text = this.getColumnByPosition(1);
            this.txtBoxModelo.Text = this.getColumnByPosition(2);
            this.txtBoxCor.Text = this.getColumnByPosition(3);
        }
    }
}
