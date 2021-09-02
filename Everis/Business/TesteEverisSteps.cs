using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;
using System.Configuration;
using NUnit.Framework;

namespace Everis.Business
{
    [Binding]
    [Scope(Feature = "TesteEveris Validar os valores no carrinho")]
    public class TesteEverisValidarOsValoresNoCarrinhoSteps
    {
        private IWebDriver driver;
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(@"C:\ProjetoTesteQa\TesteEveris\Everis\chromedriver\");
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"que escolhi um produto")]
        public void DadoQueEscolhiUmProduto()
        {
            var produto = driver.FindElement(By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[1]/img"));
            produto.Click();
            Thread.Sleep(6000);
            
        }
        
        [When(@"cliquei no botão adicionar no carrinho")]
        public void QuandoCliqueiNoBotaoAdicionarNoCarrinho()
        {
            
            var AddCarrinho = driver.FindElement(By.Id("//*[@id=\"add_to_cart\"]/button/span"));
            AddCarrinho.Click();

            var Voltar = driver.FindElement(By.ClassName("exclusive-medium"));
            Voltar.Click();
            Thread.Sleep(6000);
            
        }
        
        [When(@"cliquei no botão do carrinho")]
        public void QuandoCliqueiNoBotaoDoCarrinho()
        {
            var Carrinho = driver.FindElement(By.ClassName("ajax_cart_no_product"));
            Carrinho.Click();
        }
        
        [Then(@"validei o valor Shipping e valor Total")]
        public void EntaoValideiOValorShippingEValorTotal()
        {
            var Valor_Carrinho = driver.FindElement(By.Id("total_price"));

            Assert.AreEqual(Valor_Carrinho, "$29.00");
        }

        [Then(@"validei o total da compra")]
        public void EntaoValideiOTotalDaCompra()
        {
            var Validar_Total = driver.FindElement(By.XPath("//*[@id=\"total_price\"]"));

            Assert.AreEqual(Validar_Total, "$29.00");
        }

    }
}
