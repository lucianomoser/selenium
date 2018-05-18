using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutomacaoJulioDeLima
{
    [TestFixture]
    public class TesteUsuarioPageObject
    {
        public IWebDriver navegador { get; set; }


        [SetUp]
        public void inicializaAmbiente()
        {
            navegador = Web.chrome();           
        }



        

        [Test]
        public void informacoesUsuarioTeste()
        {
            new LoginPage(navegador)

            .clicarLinkSignIn()
            //.DigitarLogin("julio0001")
            //.DigitaSenha("123456")
            .FazerLogin("julio0001", "123456")
            //.ClicarSign()
            .ClicarPaginaMe()
            .ClicarMoreDataAbout()
            .ClicarAddBotaoMoreDateAbout();    
                 
            
        }


        [TearDown]
        public void finalizaAmbiente()
        {
            navegador.Quit();
        }
    }
}
