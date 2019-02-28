using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Selos.Modelo;
using MySql.Data.MySqlClient;


namespace Sistema_de_Selos.Controle
{
    class DAOVeiculo : Connection
    {

        public int delete(int id)
        {
            try
            {
                this.prepareConnection("delete from veiculo where idSelo = " + id);
                return this.finalize();
            }catch(Exception e)
            {
                return -1;
            }
        }

        public int update(Veiculo s)
        {
                this.prepareConnection("update veiculo " +
                    "set modelo = @mod, cor = @cor, placa = @placa WHERE idSelo = @id");
                this.changeValue("@mod", s.Modelo);
                this.changeValue("@cor", s.Cor);
                this.changeValue("@placa", s.Placa);
                this.changeValue("@id", s.NumSelo.ToString());
                return this.finalize();
            
        }

        public int insert(Veiculo s)
        {
            try
            {
                this.prepareConnection("insert into veiculo(modelo, cor, placa, Proprietario_idProprietario)" +
                    "values (@mod, @cor, @placa, @idProp)");
                this.changeValue("@mod", s.Modelo);
                this.changeValue("@cor", s.Cor);
                this.changeValue("@placa", s.Placa);
                this.changeValue("@idProp", s.IdProprietario.ToString());
                return this.finalize();
            }
            catch(Exception e)
            {
                return -1;
            }

        }

        public List<Veiculo> select()
        {
            List<Veiculo> seloList = new List<Veiculo>();
            this.prepareConnection("select * from veiculo ");
            this.setReader();
            while (this.Reader.Read())
            {
                Veiculo p = new Veiculo(
                    this.Reader.GetInt32("idSelo"),
                    this.Reader.GetInt32("Proprietario_idProprietario"),
                    this.Reader.GetString("placa"),
                    this.Reader.GetString("modelo"),
                    this.Reader.GetString("cor")
                    );
                seloList.Add(p);

            }
            return seloList;
        }

        public List<Veiculo> select(string conditions)
        {
            List<Veiculo> seloList = new List<Veiculo>();
            this.prepareConnection("select * from veiculo " + conditions);
            this.setReader();
            while (this.Reader.Read())
            {
                Veiculo p = new Veiculo(
                    this.Reader.GetInt32("idSelo"),
                    this.Reader.GetInt32("Proprietario_idProprietario"),
                    this.Reader.GetString("placa"),
                    this.Reader.GetString("modelo"),
                    this.Reader.GetString("cor")
                    );
                seloList.Add(p);

            }
            return seloList;
        }

        public int getLastInsertedID()
        {
            this.prepareConnection("select MAX(idSelo) from veiculo WHERE 1");
            this.setReader();
            int r = 0;
            while (this.Reader.Read())
            {
                r = this.Reader.GetInt32("MAX(idSelo)");
            }
            return r;

        }
    }
}
