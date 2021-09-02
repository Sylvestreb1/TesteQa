using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Config
{
    class DataHorario
    {
        public static string HoraHost(string FormatarHorario)
        {

            string data_host = DateTime.Now.ToString(FormatarHorario); ;

            return data_host;


        }
    }
}
