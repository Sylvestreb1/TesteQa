using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class DaoAcesso
    {
        public void Update_DboAcesso(string PrimeiroCampo, string PrimeiroValor, string SegundoCampo, string SegundoValor, SqlConnection Conexao)
        {
            string Update_Acesso = "UPDATE ACESSO SET " + PrimeiroCampo + " = '" + PrimeiroValor + "' WHERE " + SegundoCampo + " = '" + SegundoValor + "'";
            SqlCommand Sqlcmd = new SqlCommand(Update_Acesso, Conexao);
            Sqlcmd.ExecuteNonQuery();
        }
    }
}
