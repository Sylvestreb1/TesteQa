using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class PedidoMesasDao
    {
        public void Delete_Dbo_Pedido_Mesa(SqlConnection Conexao)
        {
            string Delete_Pedido_Mesa = "DELETE PEDIDOMESA";
            SqlCommand Sqlcmd = new SqlCommand(Delete_Pedido_Mesa, Conexao);
            Sqlcmd.ExecuteNonQuery();
        }
    }
}
