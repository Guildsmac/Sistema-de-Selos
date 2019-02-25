using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Selos.Modelo;

namespace Sistema_de_Selos.Controle
{
    class UnidadeDeControle
    {

        // PROPRIETÁRIOS
        public bool cadastrarProprietario(
            string nome,
            string matricula,
            string telefone,
            string email,
            string cargo,
            string departamento
            ) {
            Proprietario p = new Proprietario(
                nome,
                matricula,
                telefone,
                email,
                cargo,
                departamento
                );
            DAOProprietario dp = new DAOProprietario();
            if (dp.insert(p) > 0)
                return true;
            return false;
        }

        public List<string[]> buscarProprietario(
            string searchSubject
            ) {
            List<string[]> r = new List<string[]>();
            DAOProprietario dp = new DAOProprietario();
            List<Proprietario> listProp = dp.select();
            foreach (Proprietario temp in listProp)
            {
                if (temp.Matricula.Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.Matricula,
                    temp.IdProprietario.ToString(),
                    temp.Nome,
                    temp.Area,
                    temp.Cargo,
                    temp.Email,
                    temp.Telefone
                };
                    r.Add(data);
                }
            }
            return r;
        }

        public bool alterarProprietario(
            int id,
            string nome,
            string matricula,
            string telefone,
            string email,
            string cargo,
            string departamento

            )
        {
            Proprietario p = new Proprietario(
                id,
                nome,
                matricula,
                telefone,
                email,
                cargo,
                departamento
                );
            DAOProprietario dp = new DAOProprietario();
            if (dp.update(p) > 0)
                return true;
            return false;
        }

        public List<string[]> verProprietario() {
            List<string[]> r = new List<string[]>();
            DAOProprietario dp = new DAOProprietario();
            List<Proprietario> listProp = dp.select();
            foreach (Proprietario temp in listProp)
            {
                string[] data =
                {
                    temp.Matricula,
                    temp.IdProprietario.ToString(),
                    temp.Nome,
                    temp.Area,
                    temp.Cargo,
                    temp.Email,
                    temp.Telefone
                };
                r.Add(data);
            }
            return r;
        }

        public bool deletarProprietario(string id) {
            DAOProprietario dp = new DAOProprietario();
            if (dp.delete(id) > 0)
                return true;
            return false;
        }



        //VEÍCULOS
        public bool cadastrarVeiculo(
            int idProprietario,
            string placa,
            string modelo,
            string cor

            ) {
            DAOSelo ds = new DAOSelo();
            List<Selo> selosComProprietario = ds.select("where Proprietario_idProprietario = " + idProprietario);

            if (selosComProprietario.Count >= 2)
                return false;
            
            else
            {
                Selo s = new Selo(
                    idProprietario,
                    placa,
                    modelo,
                    cor

                );
                ds = new DAOSelo();
                if (ds.insert(s) > 0)
                    return true;
                return false;
            }
        }

        public int pegarUltimoVeiculo()
        {
            DAOSelo ds = new DAOSelo();
            return ds.getLastInsertedID();
        }

        public List<string[]> buscarVeiculo(string searchSubject) {
            List<string[]> r = new List<string[]>();
            DAOSelo ds = new DAOSelo();
            List<Selo> listSelo = ds.select();
            foreach (Selo temp in listSelo)
            {
                DAOProprietario dp = new DAOProprietario();
                List<Proprietario> listProp = dp.select("where idProprietario = " + temp.IdProprietario);
                Proprietario p = listProp.First();
                if (p.Matricula.ToString().Contains(searchSubject) || temp.NumSelo.ToString().Contains(searchSubject) || temp.Placa.ToString().Contains(searchSubject))
                {
                    string[] data =
                    {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.Modelo,
                    temp.Cor,
                    p.Matricula,
                    p.Nome
                };
                    r.Add(data);
                }
            }
            return r;
        }

        public bool alterarVeiculo(
            int idSelo,
            string placa,
            string modelo,
            string cor

            )
        {
            DAOSelo ds = new DAOSelo();
            Selo s = new Selo(
                idSelo,
                0,
                placa,
                modelo,
                cor);

            if (ds.update(s) > 0)
                return true;
            else
                return false;
        }

        public List<string[]> verVeiculo() {
            List<string[]> r = new List<string[]>();
            DAOSelo ds = new DAOSelo();
            List<Selo> listSelo = ds.select();
            foreach (Selo temp in listSelo)
            {
                DAOProprietario dp = new DAOProprietario();
                List<Proprietario> listProp = dp.select("where idProprietario = " + temp.IdProprietario.ToString());
                
                Proprietario p = listProp.First();
                string[] data =
                {
                    temp.NumSelo.ToString(),
                    temp.Placa,
                    temp.Modelo,
                    temp.Cor,
                    p.Matricula,
                    p.Nome
                };
                r.Add(data);
            }
            return r;

        }

        public bool deletarVeiculo(int id) {
            DAOSelo ds = new DAOSelo();
            if (ds.delete(Convert.ToInt32(id)) > 0)
                return true;
            return false;
        }


        

        

        




    }
}
