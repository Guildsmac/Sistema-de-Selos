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

        public int insert(Selo s)
        {

            this.prepareConnection("insert into selo(modelo, cor, placa, Proprietario_idProprietario)" +
                "values (@mod, @cor, @placa, @idProp)");
            this.changeValue("@mod", s.Modelo);
            this.changeValue("@cor", s.Cor);
            this.changeValue("@placa", s.Placa);
            this.changeValue("@idProp", s.IdProprietario.ToString());
            return this.finalize();

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
