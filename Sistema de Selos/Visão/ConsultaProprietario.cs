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
            dgvProp.Rows.Clear();
            string searchSubject = txtBoxSearch.Text;
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> proprietarios = udc.buscarProprietario(searchSubject);
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);

        }

        private void ConsultaProprietario_Load(object sender, EventArgs e)
        {
            dgvProp.Rows.Clear();
            UnidadeDeControle udc = new UnidadeDeControle();
            List<string[]> proprietarios = udc.verProprietario();
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
