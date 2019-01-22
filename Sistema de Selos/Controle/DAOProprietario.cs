using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Selos.Modelo;

namespace Sistema_de_Selos.Controle
{
    class DAOProprietario : Connection
    {
        
        public int insert(Proprietario p)
        {

            this.prepareConnection("insert into proprietario(nome, matricula, telefone, email, cargo, area)" +
                "values(@nome, @mat, @tel, @email, @cargo, @area)");
            this.changeValue("@nome", p.Nome);
            this.changeValue("@mat", p.Matricula);
            this.changeValue("@tel", p.Telefone);
            this.changeValue("@email", p.Email);
            this.changeValue("@cargo", p.Cargo);
            this.changeValue("@area", p.Area);
            return this.finalize();

        }

        public List<Proprietario> getPropList()
        {
            List<Proprietario> propList = new List<Proprietario>();

            this.prepareConnection("select * from proprietario");
            this.setReader();
            while (this.Reader.Read())
            {
                Proprietario p = new Proprietario(
                    this.Reader.GetInt32("idProprietario"),
                    this.Reader.GetString("nome"),
                    this.Reader.GetString("matricula"),
                    this.Reader.GetString("telefone"),
                    this.Reader.GetString("email"),
                    this.Reader.GetString("cargo"),
                    this.Reader.GetString("area")

                    );
                propList.Add(p);
            }
            this.closeConnection();
            return propList;

        }
        

    }
}
