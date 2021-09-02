using qa_regressao.Config;
using qa_regressao.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class DaoPeriodo
    {
        public string SelectPeriodo(string Campo, SqlConnection Conexao)
        {
            string Select_Periodo = "select " + Campo + " from periodo";
            SqlCommand Sqlcmd = new SqlCommand(Select_Periodo, Conexao);

            SqlDataReader lerBanco = Sqlcmd.ExecuteReader();
            if (lerBanco.HasRows)
            {
                while (lerBanco.Read())
                {

                    string linha = lerBanco["PerioData"].ToString();
                    lerBanco.Close();
                    return linha;


                }

            }
            lerBanco.Close();
            return "";


        }

        public void UpdatePeriodo(SqlConnection Conexao)
        {
            PreparacaoBanco preparacaobanco = new PreparacaoBanco();
            string DataAtualMaquina = DataHorario.HoraHost("yyyy-MM-dd 00:00:00");

            string Update_Periodo = "UPDATE PERIODO SET PerioData = '" + DataAtualMaquina + "'";
            SqlCommand Sqlcmd = new SqlCommand(Update_Periodo, Conexao);

            Sqlcmd.ExecuteNonQuery();
        }
    }
}
