using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Selos.Modelo;
using MySql.Data.MySqlClient;


namespace Sistema_de_Selos.Controle
{
    class DAOSelo : Connection
    {

        public int delete(int id)
        {
            try
            {
                this.prepareConnection("delete from selo where idSelo = " + id);
                return this.finalize();
            }catch(Exception e)
            {
                return -1;
            }
        }

        public int update(Selo s)
        {
                this.prepareConnection("update selo " +
                    "set modelo = @mod, cor = @cor, placa = @placa WHERE idSelo = @id");
                this.changeValue("@mod", s.Modelo);
                this.changeValue("@cor", s.Cor);
                this.changeValue("@placa", s.Placa);
                this.changeValue("@id", s.NumSelo.ToString());
                return this.finalize();
            
        }

        public int insert(Selo s)
        {
            try
            {
                this.prepareConnection("insert into selo(modelo, cor, placa, Proprietario_idProprietario)" +
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

        public List<Selo> getSeloList()
        {
            List<Selo> seloList = new List<Selo>();
            this.prepareConnection("select * from selo");
            this.setReader();
            while (this.Reader.Read())
            {
                DAOProprietario dp = new DAOProprietario();
                string[] data = dp.getMatriculaAndNameById(this.Reader.GetInt32("Proprietario_idProprietario"));
                Selo p = new Selo(
                    this.Reader.GetInt32("Proprietario_idProprietario"),
                    this.Reader.GetInt32("idSelo"),
                    this.Reader.GetString("placa"),
                    this.Reader.GetString("modelo"),
                    this.Reader.GetString("cor"),
                    data[0],
                    data[1]
                    );
                seloList.Add(p);

            }
            return seloList;
        }

        public int getLastInsertedID()
        {
            this.prepareConnection("select MAX(idSelo) from selo WHERE 1");
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
