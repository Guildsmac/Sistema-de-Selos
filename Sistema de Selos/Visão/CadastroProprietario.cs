﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Selos.Modelo;
using Sistema_de_Selos.Controle;

namespace Sistema_de_Selos
{
    public partial class CadastroProprietario : Form
    {
        public CadastroProprietario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            this.txtBoxNomeProp.Text = "";
            this.txtBoxMatProp.Text = "";
            this.txtBoxTelProp.Text = "";
            this.txtBoxEmailPropi.Text = "";
        }

        private bool checkEmpty()
        {
            if(this.txtBoxEmailPropi.Text == "" || this.txtBoxMatProp.Text == "" || this.txtBoxNomeProp.Text == "" ||
               this.txtBoxTelProp.Text == "" || this.cBoxCargoProp.SelectedItem == null ||
               this.cBoxDptProp.SelectedItem == null)
                return true;
            return false;
        }

        private void cadastrarProprietario(object sender, EventArgs e)
        {
            if (checkEmpty())
                MessageBox.Show("Preencha todos os dados.");
            else
            {
                UnidadeDeControle udc = new UnidadeDeControle();
                if (udc.cadastrarProprietario(
                    this.txtBoxNomeProp.Text,
                    this.txtBoxMatProp.Text,
                    this.txtBoxTelProp.Text,
                    this.txtBoxEmailPropi.Text,
                    this.cBoxCargoProp.SelectedItem.ToString(),
                    this.cBoxDptProp.SelectedItem.ToString()
                    ))
                {
                    MessageBox.Show("Proprietário cadastrado com sucesso");
                    this.clearAll();
                }
                else
                    MessageBox.Show("Erro ao salvar dados");
            }

            

            /*Proprietario p = new Proprietario(
                this.txtBoxNomeProp.Text,
                this.txtBoxMatProp.Text,
                this.txtBoxTelProp.Text,
                this.txtBoxEmailPropi.Text,
                this.cBoxCargoProp.SelectedItem.ToString(),
                this.cBoxDptProp.SelectedItem.ToString()
                );
            DAOProprietario dp = new DAOProprietario();
            if (dp.insert(p) > 0)
            {
                MessageBox.Show("Proprietário cadastrado com sucesso");
                this.clearAll();
            }
            else
                MessageBox.Show("Erro ao salvar dados");*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CadastroProprietario_Load(object sender, EventArgs e)
        {

        }
    }
}
