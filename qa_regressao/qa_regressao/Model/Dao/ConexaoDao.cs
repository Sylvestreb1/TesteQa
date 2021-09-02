using qa_regressao.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class ConexaoDao
    {
        public SqlConnection ConnBanco = new SqlConnection();
        public SqlConnection ConexaoBancoPdv(ConexaoBancoDTO conexaoBanco)
        {
            if (ConnBanco.State != System.Data.ConnectionState.Open)
            {
                ConnBanco.ConnectionString = ("Server=" + conexaoBanco.server + "," + conexaoBanco.port + ";database=" + conexaoBanco.dataBase + ";Uid=" + conexaoBanco.user + ";PWD=" + conexaoBanco.password + ";");


                ConnBanco.Open();
            }

            return ConnBanco;
        }

        public SqlConnection ConexaoBancoRetaguarda(ConexaoBancoDTO conexaoBanco)
        {
            if (ConnBanco.State != System.Data.ConnectionState.Open)
            {
                ConnBanco.ConnectionString = ("Server=" + conexaoBanco.server + "," + conexaoBanco.port + ";database=" + conexaoBanco.dataBaseRetaguarda + ";Uid=" + conexaoBanco.user + ";PWD=" + conexaoBanco.password + ";");


                ConnBanco.Open();
            }

            return ConnBanco;

        }

        public void CloseDataBase()
        {
            ConnBanco.Close();
        }
    }
}
