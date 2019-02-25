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

        public int delete(string id)
        {
            this.prepareConnection("delete from proprietario where idProprietario = @idProp");
            this.changeValue("@idProp", id);
            return this.finalize();

        }

        public int update(Proprietario p)
        {
            try
            {
                this.prepareConnection("update proprietario " +
                    "SET nome = @nome, matricula = @mat, telefone = @tel, email = @email, cargo = @cargo, area = @area" +
                    " WHERE idProprietario = @idProp");
                this.changeValue("@nome", p.Nome);
                this.changeValue("@mat", p.Matricula);
                this.changeValue("@tel", p.Telefone);
                this.changeValue("@email", p.Email);
                this.changeValue("@cargo", p.Cargo);
                this.changeValue("@area", p.Area);
                this.changeValue("@idProp", p.IdProprietario.ToString());
                return this.finalize();
            }catch(Exception e)
            {
                return -1;
            }
            
            
        }

        public int insert(Proprietario p)
        {
            try
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
            }catch(Exception e)
            {
                return -1;
            }

        }
        

        public List<Proprietario> select(string where)
        {
            List<Proprietario> propList = new List<Proprietario>();

            this.prepareConnection("select * from proprietario " + where );
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

        public List<Proprietario> select()
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
