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
            dgvProp.Rows.Clear();
            UnidadeDeControle uc = new UnidadeDeControle();
            List<string[]> proprietarios = uc.verProprietario();
            foreach (string[] temp in proprietarios)
                dgvProp.Rows.Add(temp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtBoxIdProp.Text = dgvProp.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvProp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private bool checkEmpty()
        {
            if (this.txtBoxPlaca.Text == "" || this.txtBoxModelo.Text == "" || this.txtBoxCor.Text == "")
                return true;
            return false;

        }

        private void cadastrarVeiculo(object sender, EventArgs e)
        {
            if (checkEmpty())
                MessageBox.Show("Preencha todos os campos.");
            else
            {
                if (txtBoxIdProp.Text != "")
                {
                    UnidadeDeControle uc = new UnidadeDeControle();
                    if (uc.cadastrarVeiculo(
                        Convert.ToInt32(this.txtBoxIdProp.Text),
                        this.txtBoxPlaca.Text,
                        this.txtBoxModelo.Text,
                        this.txtBoxCor.Text
                        ))
                    {
                        MessageBox.Show("Selo salvo com sucesso. O selo gerado é " + uc.pegarUltimoVeiculo() + "!");
                        this.clearAll();
                    }
                    else 
                        MessageBox.Show("Erro ao salvar os dados. Verifique o número de veículos aregados a este usuário.");
                    
                }
                else
                    MessageBox.Show("Por favor, clique duas vezes em um proprietário para o referido selo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscarProprietario(object sender, EventArgs e)
        {

            string searchSubject = txtBoxBuscar.Text;
            dgvProp.Rows.Clear();
            UnidadeDeControle uc = new UnidadeDeControle();
            List<string[]> proprietarios = uc.buscarProprietario(searchSubject);
            foreach(string[] temp in proprietarios)
            {
                dgvProp.Rows.Add(temp);
            }
        }
    }
}
