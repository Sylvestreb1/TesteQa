using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dto
{
    class PathRetaguarda
    {
        public static class PathLoginRetaguarda
        {
            public static string RETAGUARDA_LOGIN_USUARIO = "/form[@name='FrmSenha']/text[@name='dbUsuario']";//NativeWindow
            public static string RETAGUARDA_LOGIN_BTN_USUARIO = "/form[@name='FrmSenha']/text[@name='dbUsuario']/?/?/element";//DelphiElement
            public static string RETAGUARDA_LOGIN_SENHA = "/form[@name='FrmSenha']/text[@name='edSenha']";//NativeWindow
            public static string RETAGUARDA_LOGIN_LOJA = "/form[@name='FrmSenha']/text[@name='dbLoja']";//NativeWindow
            public static string RETAGUARDA_LOGIN_BTN_OK = "/form[@name='FrmSenha']/button[@name='btnOK']";//NativeWindow
            public static string RETAGUARDA_LOGIN_BTN_SAIR = "/form[@name='FrmSenha']/button[@name='btnFechar']";//NativeWindow
            public static string RETAGUARDA_LOGIN_BTN_CONFIG = "/form[@name='FrmSenha']/picture[@name='Image2']";//DelphiElement
        }

        public static class PathMenu
        {
            public static string RETAGUARDA_HOME_MENU_CADASTRO = "/form[@name='FrmMenu']/?/?/menuitem[@name='Cadastros1']";//DelephiElement
            public static string RETAGUARDA_HOME_MENU_FINANCEIRO = "/form[@name='FrmMenu']/?/?/menuitem[@name='mnuFinanceiro']";//DelephiElement
            public static string RETAGUARDA_HOME_MENU_COMPRAS = "/form[@name='FrmMenu']/?/?/menuitem[@name='ComPras1']";//DelphiElement
            public static string RETAGUARDA_HOME_MENU_ESTOQUE = "/form[@name='FrmMenu']/?/?/menuitem[@name='mnuEstoque']";//DelphiElement
            public static string RETAGUARDA_HOME_MENU_MANUTENCAO = "/form[@name='FrmMenu']/?/?/menuitem[@name='Manuteno1']";//DelphiElement
            public static string RETAGUARDA_HOME_MENU_RELATORIOS = "/form[@name='FrmMenu']/?/?/menuitem[@name='mnuRelatorios']";//DelphiElement
            public static string RETAGUARDA_HOME_MENU_SOBRE = "/form[@name='FrmMenu']/?/?/menuitem[@name='Sobre1']";//DelphiElement

        }
        public class FinanceiroApagar
        {
            public static string RETAGUARDA_FINANCEIRO_APAGAR = "/form[@name='FrmMenu']/?/?/menuitem[@name='mnuFinanceiro']/menuitem[@name='ContPag']";//DelphiElement
            public static string RETAGUARDA_FINANCEIRO_LANCAMENTO = "/form[@name='FrmPagamentos']/?/?/container[@name='tsConsulta']/button[@name='btnLancamento']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_DATA_EMISSAO = "/form[@name='FrmMaPag']/container[@name='pnlPagamentoDireto']/?/?/text[@name='edCompetencia']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_DATA_VENCIMENTO = "/form[@name='FrmMaPag']/container[@name='pnlPagamentoDireto']/?/?/text[@name='EdData']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_DATA_PAGAMENTO = "/form[@name='FrmMaPag']/container[@name='pnlPagamentoDireto']/?/?/text[@name='EdDataPag']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_LANCAMENTO_TITULOS = "/form[@name='FrmMaPag']/?/?/container[@name='Panel18']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_MENSAGEM_PADRAO = "/form[@title='Retaguarda']/text[@controlid='65535']";//NativeWindow
        }

        public class FinanceiroAreceber
        {
            public static string RETAGUARDA_FINANCEIRO_ARECEBER_BTN_LANCAMENTO = "/form[@name='frmRecebimento']/tabpagelist[@name='pcCadastros']/?/?/button[@name='btnLancamento']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_ARECEBER_FORM_LANCAMENTO_TITULOS = "/form[@name='frmRecebimento']/container[@name='pnlPagamentoDireto']";//NativeWindow
            public static string RETAGUARAD_FINANCEIRO_ARECEBER_CAMPO_DATA_EMISSAO = "/form[@name='frmRecebimento']/container[@name='pnlPagamentoDireto']/?/?/text[@name='edCompetencia']";//NativeWindow
            public static string RETAGUARDA_FINANCEIRO_ARECEBER_CAMPO_DATA_VENCIMENTO = "/form[@name='frmRecebimento']/container[@name='pnlPagamentoDireto']/?/?/text[@name='EdData']";//NativeWindow
        }
    }
}
