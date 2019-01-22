using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_de_Selos.Controle
{
    class Connection
    {
        const string CONNECTION_STRING = "server=localhost;userid=root;password=;database=consultaselosdb";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string sql;

        protected int finalize()
        {
            this.prepare();
            int r = this.executeCommand();
            this.closeConnection();
            return r;

        }

        protected void prepareConnection(String sql)
        {
            this.getConnection().Open();
            this.Sql = sql;
            this.Command = new MySqlCommand();
            this.Command.Connection = this.getConnection();
            this.Command.CommandText = this.Sql;

        }

        protected void closeConnection()
        {
            this.getConnection().Close();

        }

        private int executeCommand()
        {
            return this.Command.ExecuteNonQuery();
        }

        private void prepare()
        {
            this.Command.Prepare();

        }

        protected void setReader()
        {
            this.Reader = this.Command.ExecuteReader();
        }

        protected void changeValue(String from, String to)
        {
            this.Command.Parameters.AddWithValue(from, to);
        }

        public void setConnection(MySqlConnection connection)
        {
            this.connection = connection;

        }

        public MySqlConnection getConnection()
        {
            return this.connection;
        }
        public MySqlCommand Command { get => command; set => command = value; }
        public MySqlDataReader Reader { get => reader; set => reader = value; }
        public string Sql { get => sql; set => sql = value; }

        public Connection()
        {
            this.connection = new MySqlConnection(CONNECTION_STRING);

        }
    }
}
