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
    public partial class CadastroSelo : Form
    {
        public CadastroSelo()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            this.txtBoxPlaca.Text = "";
            this.txtBoxModelo.Text = "";
            this.txtBoxCor.Text = "";
            this.txtBoxIdProp.Text = "";

        }

        private void CadastroSelo_Load(object sender, EventArgs e)
        {
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.select();
            foreach(Proprietario temp in listProp)
            {
                string[] data =
                {
                    temp.Nome,
                    temp.IdProprietario.ToString(),
                    temp.Matricula,
                    temp.Telefone,
                    temp.Email,
                    temp.Cargo,
                    temp.Area
                };
                dgvProp.Rows.Add(data);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBoxIdProp.Text = dgvProp.CurrentRow.Cells[1].Value.ToString();

        }

        private void cadastrarVeiculo(object sender, EventArgs e)
        {
            if (txtBoxIdProp.Text != "") {
                
                Selo s = new Selo(
                    Convert.ToInt32(this.txtBoxIdProp.Text),
                    this.txtBoxPlaca.Text,
                    this.txtBoxModelo.Text,
                    this.txtBoxCor.Text

                );
                DAOSelo ds = new DAOSelo();
                if (ds.insert(s) > 0)
                {
                    MessageBox.Show("Selo salvo com sucesso. O selo gerado é " + ds.getLastInsertedID() + "!");
                    this.clearAll();
                }
                else
                    MessageBox.Show("Erro ao salvar os dados");
            }
            else
                MessageBox.Show("Por favor, clique duas vezes em um proprietário para o referido selo.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscarProprietario(object sender, EventArgs e)
        {

            string searchSubject = txtBoxBuscar.Text;
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.select();
            foreach (Proprietario temp in listProp)
            {
                if (temp.Matricula.Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.Nome,
                    temp.IdProprietario.ToString(),
                    temp.Matricula,
                    temp.Telefone,
                    temp.Email,
                    temp.Cargo,
                    temp.Area
                };
                    dgvProp.Rows.Add(data);
                }
            }
        }
    }
}
