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
            string mensagem = new LoginPage(navegador)

            .clicarLinkSignIn()
            //.DigitarLogin("julio0001")
            //.DigitaSenha("123456")
            .FazerLogin("julio0001", "123456")
            //.ClicarSign()
            .ClicarPaginaMe()
            .ClicarMoreDataAbout()
            .ClicarAddBotaoMoreDateAbout()
            .AdicionarContato("Phone","+55119999999112")
            .VerificaMsgToastcontainer();

            Assert.AreEqual(mensagem, "Your contact has been added!");

                 
            
        }


        [TearDown]
        public void finalizaAmbiente()
        {
            navegador.Quit();
        }
    }
}
