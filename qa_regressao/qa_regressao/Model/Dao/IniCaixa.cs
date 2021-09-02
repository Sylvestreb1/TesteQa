using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dao
{
    class IniCaixa
    {
        /*public void EditarArqIni()
        {
            IniFile Arq = new IniFile(PathArqIniCaixa.PathArqIniCaixa);

            string[] ValorBanco = {PathArqIniCaixa.Servidor, PathArqIniCaixa.Porta, PathArqIniCaixa.BancoDeDados};
            string[] ChaveBanco = { "SERVER=", "PORT=", "DB_NAME=" };

            for (int i = 0; i < ValorBanco.Length; i++)
            {
                Arq.IniWriteValue("DATABASE", ChaveBanco[i], ValorBanco[i]);
            }


            int SAT_Ativo = 1;
            int ValorImp = 0;

            if (SAT_Ativo == 1 )
            {
                

                switch (PathArqIniCaixa.Modelo_Imp)
                {

                    case "1":
                        ValorImp = 1;
                        break;
                    case "2":
                        ValorImp = 2;
                        break;
                    case "3":
                        ValorImp = 3;
                        break;
                    case "4":
                        ValorImp = 4;
                        break;
                    case "5":
                        ValorImp = 5;
                        break;
                    case "6":
                        ValorImp = 6;
                        break;
                    case "7":
                        ValorImp = 7;
                        break;
                    case "8":
                        ValorImp = 8;
                        break;
                    case "9":
                        ValorImp = 9;
                        break;
                    case "10":
                        ValorImp = 10;
                        break;
                    case "11":
                        ValorImp = 11;
                        break;
                    case "12":
                        ValorImp = 12;
                        break;
                    case "13":
                        ValorImp = 13;
                        break;
                    default:
                        Assert.Fail();
                        break;

                }

                string[] ValorSAT = { PathArqIniCaixa.Use_Sat, PathArqIniCaixa.Signac, PathArqIniCaixa.Cod_Ativacao, PathArqIniCaixa.Pasta_Arquivo, PathArqIniCaixa.Serie_Equipamento, PathArqIniCaixa.PortaImpSat, PathArqIniCaixa.Velocidade_Sat, ValorImp.ToString(), PathArqIniCaixa.PortaImpSat, PathArqIniCaixa.Versao_Layout };
                string[] ChaveSAT = { "USE_SAT=", "SIGNAC_SAT=", "ID_ATIVACAO_EQUIP_SAT=", "ARQUIVOS_SAT=", "SERIE_EQUIP_SAT=", "PORTA_SAT=", "VELOCIDADE_SAT=", "PRINTER_MODEL=", "ACBRSAT_BRAND=", "VERSAO_SAT=" };

                for (int i = 0; i < ValorSAT.Length; i++)
                {
                    Arq.IniWriteValue("DATABASE", ChaveSAT[i], ValorSAT[i]);
                }
            }*/
    }
}
