using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Selos.Modelo
{
    class Selo
    {
        private String placa;
        private String modelo;
        private String cor;
        private string matriculaProprietario;
        private string nomeProprietario;
        private int idProprietario;
        private int numSelo;

        public Selo(int idProprietario, String placa, String modelo, String cor)
        {
            this.idProprietario = idProprietario;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
        }

        public Selo(int idProprietario, int numSelo, String placa, String modelo, String cor, string matriculaProprietario, string nomeProprietario)
        {
            this.numSelo = numSelo;
            this.idProprietario = idProprietario;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.matriculaProprietario = matriculaProprietario;
            this.nomeProprietario = nomeProprietario;
        }

        public Selo(int numSelo, int idProprietario, String placa, String modelo, String cor)
        {
            this.idProprietario = idProprietario;
            this.numSelo = numSelo;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
        }

        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int NumSelo { get => numSelo; set => numSelo = value; }
        public int IdProprietario { get => idProprietario; set => idProprietario = value; }
        public string MatriculaProprietario { get => matriculaProprietario; set => matriculaProprietario = value; }
        public string NomeProprietario { get => nomeProprietario; set => nomeProprietario = value; }
    }
}
