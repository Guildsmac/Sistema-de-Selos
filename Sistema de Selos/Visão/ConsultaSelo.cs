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
    public partial class ConsultaSelo : Form
    {
        public ConsultaSelo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaSelo_Load(object sender, EventArgs e)
        {
            DAOSelo ds = new DAOSelo();
            dgvSelo.Rows.Clear();
            List<Selo> listSelo = ds.select();
            foreach (Selo temp in listSelo)
            {
                string[] data =
                {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.MatriculaProprietario,
                    temp.NomeProprietario,
                };
                dgvSelo.Rows.Add(data);
            }
        }

        private void verVeiculo(object sender, EventArgs e)
        {
            string searchSubject = txtBoxBuscar.Text;
            DAOSelo ds = new DAOSelo();
            dgvSelo.Rows.Clear();
            List<Selo> listProp = ds.select();
            foreach (Selo temp in listProp)
            {
                if (temp.NumSelo.ToString().Contains(searchSubject) || temp.Placa.ToString().Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.MatriculaProprietario,
                    temp.NomeProprietario,
                };
                    dgvSelo.Rows.Add(data);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
