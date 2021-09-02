using qa_regressao.Config;
using qa_regressao.Model.Dao;
using qa_regressao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dto
{
    class PdvPadrao
    {
        //=================================================Metodo Para Matar o processo de um executavel=============================================
        public static void FecharExecutavel()
        {
            string[] mataApliction = { "gerpdv-s.exe", "simcomu-s.exe", "sitcielo4_1-s.exe", "sitredecardl0603-s.exe",
                                        PathCaminhoExe.ExecutavelCaixa, PathCaminhoExe.ExecutavelSAT, "javaw.exe",
                                        PathCaminhoExe.ExecutavelRetaguarda};

            for (int i = 0; i < mataApliction.Length; i++)
            {
                KiilAplication.matarprocesso(mataApliction[i]);
            }
        }

        public static void PadraoBanco()
        {

            PreparacaoBanco preparacaobanco = new PreparacaoBanco();
            preparacaobanco.DeletePedidoMesa(preparacaobanco.ConectBanco());

            string[] CamposMesa = { "Status", "Lugares", "Servico", "Impressora", "Pessoas", "StatusIMP", "Vendedor", "Controle", "ContaImpressa", "HorarioAbertura", "HorarioFechamento", "Cliente", "UltimoConsumo", "Caixinha", "Usuariodesconto", "estacionamento", "carros", "TabelaServico", "MOTIVODESC", "NUM_COUVERT", "CODPRACA", "PESSOAS_INICIAL", "COO", "SeqECF", "entrada", "consumacao", "couvert", "valservico", "usuarioCheckin", "CODPROMO", "JUNCAOMESA", "STATUS_WEB", "bMesaDividida", "IECF", "COD_PRE_CONTA", "CONFIRM_PRINTER_TABLE", "MESAS_FINAN_GUID" };

            string[] ValorMesa = { "'L'", "'1'", "'S'", @"'\\SERVER-QA\BAR'", "'1'", "'1'", "NULL", "NULL", "'0'", "NULL", "NULL", "'0'", "NULL", "'10'", "NULL", "'0'", "'0'", "'0'", "'0'", "'0'", "NULL", "'1'", "'0'", "'0'", "'0,00'", "'0,00'", "'0,00'", "'0,00'", "NULL", "NULL", "'0'", "'N'", "'0'", "NULL", "NULL", "'0'", "NULL" };

            for (int i = 0; i < CamposMesa.Length; i++)
            {
                preparacaobanco.Update_Mesas(CamposMesa[i], ValorMesa[i], "Codigo", "150001", preparacaobanco.ConectBanco());
            }

        }

        public static void CorrigirData()
        {
            PreparacaoBanco preparacaobanco = new PreparacaoBanco();
            string DataBanco = preparacaobanco.SelectPeriodo("PerioData", preparacaobanco.ConectBanco());
            string DataAtualMaquina = DataHorario.HoraHost("yyyy-MM-dd 00:00:00");

            if (DataBanco != DataAtualMaquina)
            {
                preparacaobanco.Update_Periodo(preparacaobanco.ConectBanco());
            }
        }
    }
}
