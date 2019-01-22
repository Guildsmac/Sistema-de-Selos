using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Selos.Modelo
{
    class Proprietario
    {

        private String nome;
        private String matricula;
        private String telefone;
        private String email;
        private String cargo;
        private String area;
        private int idProprietario;

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Area { get => area; set => area = value; }
        public int IdProprietario { get => idProprietario; set => idProprietario = value; }

        public Proprietario(int idProprietario, string nome, string matricula, string telefone, string email, string cargo, string area)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.area = area;
            this.idProprietario = idProprietario;
        }

        public Proprietario(string nome, string matricula, string telefone, string email, string cargo, string area)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
            this.area = area;
        }
    }
}
