﻿using System;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManutencaoSelo_Load(object sender, EventArgs e)
        {
            DAOSelo ds = new DAOSelo();
            dgvSelo.Rows.Clear();
            List<Selo> listSelo = ds.getSeloList();
            foreach (Selo temp in listSelo)
            {
                string[] data =
                {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.Modelo,
                    temp.Cor,
                    temp.MatriculaProprietario,
                    temp.NomeProprietario,
                    temp.IdProprietario.ToString()
                };
                dgvSelo.Rows.Add(data);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarSelo_Click(object sender, EventArgs e)
        {
            string searchSubject = txtBoxBuscar.Text;
            DAOSelo ds = new DAOSelo();
            dgvSelo.Rows.Clear();
            List<Selo> listProp = ds.getSeloList();
            foreach (Selo temp in listProp)
            {
                if (temp.NumSelo.ToString().Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.Modelo,
                    temp.Cor,
                    temp.MatriculaProprietario,
                    temp.NomeProprietario,
                    temp.IdProprietario.ToString()
                };
                    dgvSelo.Rows.Add(data);
                }
            }
        }

        private void dgvSelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.txtBoxSelo.Text = this.getColumnByPosition(0);
            this.txtBoxPlaca.Text = this.getColumnByPosition(1);
            this.txtBoxModelo.Text = this.getColumnByPosition(2);
            this.txtBoxCor.Text = this.getColumnByPosition(3);

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSelo.Text != "")
            {
                DAOSelo ds = new DAOSelo();
                Selo s = new Selo(
                    Convert.ToInt32(this.txtBoxSelo.Text),
                    0,
                    this.txtBoxPlaca.Text,
                    this.txtBoxModelo.Text,
                    this.txtBoxCor.Text);
                
                if (ds.update(s) > 0)
                    MessageBox.Show("Selo atualizado com sucesso!");
                else
                    MessageBox.Show("Não foi possível atualizar selo");
            }
            else
            {
                MessageBox.Show("Por favor, clique duas vezes no selo desejado!");
            }
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (this.txtBoxSelo.Text != "")
            {
                DAOSelo ds = new DAOSelo();
                if(ds.delete(Convert.ToInt32(this.txtBoxSelo.Text))>0)
                    MessageBox.Show("Selo deletado com sucesso!");
                else
                    MessageBox.Show("Não foi possível deletar selo");
            }
            else
            {
                MessageBox.Show("Por favor, clique duas vezes no selo desejado!");
            }
        }
    }
}
