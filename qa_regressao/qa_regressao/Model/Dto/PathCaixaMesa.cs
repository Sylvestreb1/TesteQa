using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qa_regressao.Model.Dto
{
    class PathCaixaMesa
    {
        public static class CaixaLogin
        {

            public static string CAIXA_LOGIN_PAINEL_INICIAL = "/form[@name='frmSenhaEntrada']/?/?/picture[@name='Imagem']"; //DelphiElement
            public static string CAIXA_LOGIN_CAMPO_USUARIO = "/form[@name='frmSenhaEntrada']/?/?/combobox[@name='cmbUsuario']"; //NativeWindows
            public static string CAIXA_LOGIN_USUARIO_ADM = "/form[@name='frmSenhaEntrada']/?/?/combobox[@name='cmbUsuario']/listitem[@name='ADM']"; //DelphiElement                        
            public static string CAIXA_LOGIN_BUTTON_USUARIO = "/form[@name='frmSenhaEntrada']/?/?/combobox[@name='cmbUsuario']/button[@text='>']"; //Button
            public static string CAIXA_LOGIN_CAMPO_SENHA = "/form[@name='frmSenhaEntrada']/?/?/text[@name='txtSenhaEntrada']"; //NativeWindows
            public static string CAIXA_LOGIN_BUTTON_OK = "/form[@name='frmSenhaEntrada']/?/?/button[@name='btnOK']"; //Button
            public static string CAIXA_LOGIN_LISTA_USUARIO = "/form[@name='frmSenhaEntrada']/?/?/combobox[@name='cmbUsuario']/list[@controlid='1000']";//NativeWindows

        }

        public static class CaixaHome
        {
            public static string CAIXA_TELA_HOME_CAMPO_MESA = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='cmbMesas']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_PESSOAS = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='txtPessoas']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_VENDEDOR = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='txtVendedor']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_LISTA_VENDEDOR = "/form[@name='FrmPesquisarVendedor']/?/?/text[@name='edtNomeVendedor']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_LUGAR = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='edLugar']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_QUANTIDADE_PRODUTO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='edQuantidade']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_PRODUTO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='txtLancaProd']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_PESQUISA_PRODUTO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='txtLancaProd']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_COMPLEMENTO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//button[@name='btnComp']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_OBSERVACAO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//text[@name='edtObservacao']";//NativeWindow
            public static string CAIXA_TELA_HOME_BOTAO_PESQUISA_PRODUTOS_F5 = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//button[@name='btPesquisaProduto']";//NativeWindow
            public static string CAIXA_TELA_HOME_BOTAO_PRODUCAO = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']//button[@name='btnProducao']";//NativeWindow
            public static string CAIXA_TELA_HOME_STATUS_PRODUCAO_GRID = "/form[@name='frmMesa']/container[@name='Panel8']/container[@name='Panel9']//rawtext[@column='0']";//RawText
            public static string CAIXA_TELA_HOME_BOTAO_SAIR_F12 = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']/?/?/button[@name='btnFechar']";//NativeWindow
            public static string CAIXA_TELA_HOME_BOTAO_OK_CONFIRMAR_FECHAR = "/form[@name='none']/button[@name='Yes']";//NativeWindow
            public static string CAIXA_TELA_HOME_BOTAO_CONTA_F7 = "/form[@name='frmMesa']/container[@name='pnlMenuDigitacao']/?/?/button[@name='btnImprimeConta']";//NativeWindow
            public static string CAIXA_TELA_HOME_BOTAO_SERVICO_ACRECIMO = "/form[@name='frmMesa']/container[@name='Panel8']/container[@name='Panel15']//button[@name='btnServico']";//NativeWindow
            public static string CAIXA_TELA_HOME_CAMPO_VALOR_SERVICO = "/form[@name='frmMesa']/container[@name='Panel8']/container[@name='Panel15']//text[@name='txtServico']";//NativeWindow
        }

        public static class CaixaConta
        {
            public static string CAIXA_TELA_CONTA_NAO_DIVIDIR = "/form[@name='frmDivConta']/button[@name='btnNDiv']"; //NativeWindow
        }

        public static class CaixaServico
        {
            public static string CAIXA_TELA_SERVICO = "/form[@name='frmMesa']/container[@name='Panel3']/?/?/text[@name='txtPagar']";//NativeWindow
            public static string CAIXA_TELA_SERVICO_BOTAO_OK = "/form[@name='frmMesa']/container[@name='Panel3']/?/?/button[@name='btnTiraServico']";//NativeWindow
            public static string CAIXA_TELA_SERVICO_PERMISSAO_USUARIO = "/form[@name='frmSenhaAutorizacao']/element[@name='cmbUsuario']";//NativeWindow
            public static string CAIXA_TELA_SERVICO_PERMISSAO_SENHA = "/form[@name='frmSenhaAutorizacao']/text[@name='edtSenha']";//NativeWindow
            public static string CAIXA_TELA_SERVICO_BTN_PERMISSAO_OK = "/form[@name='frmSenhaAutorizacao']/button[@name='btnOK']";//NativeWindow
        }

        public static class CaixaTransferencia
        {

        }

        public static class CaixaExclusao
        {

        }

        public static class MensageriaCaixa
        {
            public static string CAIXA_MENSAGEM_SERVICO_PERMISSAO_NEGADA = "/form[@title='Caixa®']/text[@controlid='65535']";//NativeWindow
        }







        public static class PathCaixaCartao
        {

        }
        public static class PathCaixaBalcao
        {

        }

        public static class PathCaixaDelivery
        {

        }
    }
}

