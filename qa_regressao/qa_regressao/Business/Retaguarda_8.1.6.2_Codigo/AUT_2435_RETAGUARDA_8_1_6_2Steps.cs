using qa_regressao.Config;
using qa_regressao.Model.Dto;
using qa_regressao.ViewModel;
using Ranorex;
using System;
using TechTalk.SpecFlow;

namespace qa_regressao.Business.Retaguarda_8._1._6._2_Codigo
{
    [Binding]
    [Scope(Feature = "AUT_2435_RETAGUARDA_8.1.6.2")]
    public class AUT_2435_RETAGUARDA_8_1_6_2Steps
    {

        public int pid = 0;

        [BeforeScenario]
        public void BeforeScenario()
        {
            PdvPadrao.FecharExecutavel();

            this.pid = PathAplication.DeskTop(PathCaminhoExe.ExecutavelRetaguarda, PathCaminhoExe.PathRetaguarda);

            Ranorex.Validate.Exists(PathRetaguarda.PathLoginRetaguarda.RETAGUARDA_LOGIN_USUARIO, Duration.FromMilliseconds(30000));
        }

        [AfterScenario]
        public void AftherScenario()
        {
            Ranorex.Host.Local.KillApplication(this.pid);
        }

        [Given(@"que informei o usuario")]
        public void DadoQueInformeiOUsuario()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"informei a senha")]
        public void QuandoInformeiASenha()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"cliquei no botão OK")]
        public void QuandoCliqueiNoBotaoOK()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deve entrar na tela home")]
        public void EntaoDeveEntrarNaTelaHome()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"cliquei no financeiro/ apagar")]
        public void EntaoCliqueiNoFinanceiroApagar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"clico no botão lançamento")]
        public void EntaoClicoNoBotaoLancamento()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"deve mostrar a tela de lançamento")]
        public void EntaoDeveMostrarATelaDeLancamento()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"informei a data no campo Emissão")]
        public void EntaoInformeiADataNoCampoEmissao()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"validei a informação  no campo Emissão")]
        public void EntaoValideiAInformacaoNoCampoEmissao()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
