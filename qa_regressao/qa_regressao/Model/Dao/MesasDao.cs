using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class MesasDao
    {
        public void Update_DboMesas(string Campo1, string Valor, string Codigo, string ValorCodigo, SqlConnection Conexao)
        {

            string Update_Acesso = "update mesas set " + Campo1 + " = " + Valor + " where " + Codigo + " >= " + ValorCodigo + "";
            SqlCommand Sqlcmd = new SqlCommand(Update_Acesso, Conexao);
            Sqlcmd.ExecuteNonQuery();
        }
    }
}
