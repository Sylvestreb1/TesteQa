using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dto
{
    class ConexaoBancoDTO
    {
        public string server { get; set; }
        public string port { get; set; }
        public string dataBase { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string schema { get; set; }
        public string dataBaseRetaguarda { get; set; }
    }
}
