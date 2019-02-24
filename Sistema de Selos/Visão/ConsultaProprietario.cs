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
    public partial class ConsultaProprietario : Form
    {
        public ConsultaProprietario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verProprietario(object sender, EventArgs e)
        {

            string searchSubject = txtBoxSearch.Text;
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.select();
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
                };
                    dgvProp.Rows.Add(data);
                }
            }
        }

        private void ConsultaProprietario_Load(object sender, EventArgs e)
        {
            
            DAOProprietario dp = new DAOProprietario();
            dgvProp.Rows.Clear();
            List<Proprietario> listProp = dp.select();
            foreach (Proprietario temp in listProp)
            {
                string[] data =
                {
                    temp.Matricula,
                    temp.Nome,
                    temp.Area,
                    temp.Cargo,
                    temp.Email,
                    temp.Telefone,
                };
                dgvProp.Rows.Add(data);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
