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
            dgvSelo.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> selos = udc.verVeiculo();
            foreach(string[] temp in selos)
                dgvSelo.Rows.Add(temp);
            
        }

        private void btnClickBuscar(object sender, EventArgs e)
        {
            string searchSubject = txtBoxBuscar.Text;
            dgvSelo.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> selos = udc.buscarVeiculo(searchSubject);
            foreach (string[] temp in selos)
                dgvSelo.Rows.Add(temp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
