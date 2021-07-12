using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCrud
{
    public class EmpresaRep
    {
        private bd bd;
        private void Inserir(Empresas empresa)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Empresa(Nome, Site, QuantidadeFuncionarios)";
            strQuery += string.Format(" VALUES ('{0}', '{1}', '{2}')", empresa.Nome, empresa.Site, empresa.QtdFunc
                );
            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Empresas empresa)
        {
            var strQuery = "";
            strQuery += "UPDATE Empresa SET ";
            strQuery += string.Format("Nome = '{0}',", empresa.Nome);
            strQuery += string.Format("Site = '{0}',", empresa.Site);
            strQuery += string.Format("QuantidadeFuncionarios = '{0}' ", empresa.QtdFunc);
            strQuery += string.Format("WHERE Id = {0} ", empresa.Id);

            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Empresas empresa)
        {
            if (empresa.Id > 0)
            {
                Alterar(empresa);
            }
            else
            {
                Inserir(empresa);
            }
        }

        public void Excluir(Empresas empresa)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format(" DELETE FROM Empresa WHERE Id = {0}", empresa.Id);
                bd.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<Empresas> ListarTodos()
        {
            using (bd = new bd())
            {
                var strQuery = "SELECT * FROM Empresa";
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }

        public Empresas ListarPorId(string id)
        {
            using (bd = new bd())
            {
                var strQuery = string.Format("SELECT * FROM Empresa WHERE Id = {0}", id);
                var retorno = bd.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno).FirstOrDefault();
            }
        }

        private List<Empresas> ReaderEmLista(SqlDataReader reader)
        {
            var empresas = new List<Empresas>();
            while (reader.Read())
            {
                var tempoObjeto = new Empresas()
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Nome = reader["Nome"].ToString(),
                    Site = reader["Site"].ToString(),
                    QtdFunc = int.Parse(reader["QuantidadeFuncionarios"].ToString())
                };

                empresas.Add(tempoObjeto);
            }

            reader.Close();
            return empresas;
        }
    }
}

