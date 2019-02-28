using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Selos.Modelo
{
    class Veiculo
    {
        private String placa;
        private String modelo;
        private String cor;
        private int idProprietario;
        private int numSelo;

        public Veiculo(int idProprietario, String placa, String modelo, String cor)
        {
            this.idProprietario = idProprietario;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
        }

        public Veiculo(int numSelo, int idProprietario, String placa, String modelo, String cor)
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
    }
}
