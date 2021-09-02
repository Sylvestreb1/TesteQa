using qa_regressao.Config;
using qa_regressao.Model.Dao;
using qa_regressao.Model.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.ViewModel
{
    class PreparacaoBanco
    {
        ConexaoBancoDTO strConect = new ConexaoBancoDTO();
        ConexaoDao strConectDao = new ConexaoDao();
        DaoAcesso acesso = new DaoAcesso();
        MesasDao mesas = new MesasDao();
        PedidoMesasDao pedidomesa = new PedidoMesasDao();
        DaoPeriodo periodo = new DaoPeriodo();

        public SqlConnection ConectBanco()
        {
            strConect.server = DadosConexaoBanco.CaminhoBanco;
            strConect.port = DadosConexaoBanco.PortaBanco;
            strConect.dataBase = DadosConexaoBanco.DataBase;
            strConect.user = DadosConexaoBanco.UsuarioBanco;
            strConect.password = DadosConexaoBanco.SenhaBanco;
            strConect.schema = DadosConexaoBanco.Schema;

            return strConectDao.ConexaoBancoPdv(strConect);
        }

        public SqlConnection ConectBancoRetaguarda()
        {
            strConect.server = DadosConexaoBanco.CaminhoBanco;
            strConect.port = DadosConexaoBanco.PortaBanco;
            strConect.dataBase = DadosConexaoBanco.DataBase;
            strConect.user = DadosConexaoBanco.UsuarioBanco;
            strConect.password = DadosConexaoBanco.SenhaBanco;
            strConect.schema = DadosConexaoBanco.Schema;

            return strConectDao.ConexaoBancoRetaguarda(strConect);
        }

        public void Update_Acesso(string PrimeiroCampo, string PrimeiroValor, string SegundoCampo, string SegundoValor, SqlConnection Conexa)
        {
            acesso.Update_DboAcesso(PrimeiroCampo, PrimeiroValor, SegundoCampo, SegundoValor, Conexa);
            strConectDao.CloseDataBase();

        }

        public void Update_Mesas(string Campo1, string Valor, string Codigo, string ValorCodigo, SqlConnection Conexao)
        {
            mesas.Update_DboMesas(Campo1, Valor, Codigo, ValorCodigo, Conexao);
            strConectDao.CloseDataBase();
        }

        public void DeletePedidoMesa(SqlConnection Conexao)
        {
            pedidomesa.Delete_Dbo_Pedido_Mesa(Conexao);
        }

        public string SelectPeriodo(string Campo, SqlConnection Conexao)
        {
            return periodo.SelectPeriodo(Campo, Conexao);
        }

        public void Update_Periodo(SqlConnection Conexao)
        {
            periodo.UpdatePeriodo(Conexao);
        }
    }
}
