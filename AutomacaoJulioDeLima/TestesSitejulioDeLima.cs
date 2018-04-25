using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System.Threading;

namespace AutomacaoJulioDeLima
{
    [TestFixture]
    public class TestesSitejulioDeLima
    {


        public IWebDriver driver { get; set; }
        public IWebDriver navegador { get; set; }

        

        [SetUp]
        public void inicializaAmbiente()
        {
            navegador = new ChromeDriver();
            navegador.Manage().Window.Maximize();
            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");
        }

        [TearDown]
        public void finalizaambiente()
        {
            //Finaliza navegador
            navegador.Quit();
        }


        [Test]
        public void TesteAdicionarUmaInformacaoAdicionalDoUsuario()
        {           

            //Clicar no link que possui o texto "SignBox"
            navegador.FindElement(By.LinkText("Sign in")).Click();                    
            
            IWebElement formularioSignBox = navegador.FindElement(By.Id("signinbox"));

            //Clicar no campo com name "Login" que está dentro do formulario "SignBox" informar o texto julio0001
            formularioSignBox.FindElement(By.Name("login")).SendKeys("julio0001");

            //Clicar no campo com name "password" que está dentro do formulario "SignBox" informar o texto 123456
            formularioSignBox.FindElement(By.Name("password")).SendKeys("123456");
            
            //Clicar no link SIGN IN
            navegador.FindElement(By.LinkText("SIGN IN")).Click();

            WebDriverWait wait = new WebDriverWait(navegador, TimeSpan.FromSeconds(3));
            
            //Validar que dentro do elemento com class  "me" esta o texto "Hi Julio"
            IWebElement me =  wait.Until(driver => navegador.FindElement(By.ClassName("me")));            

            string textoNoElementoMe;

            textoNoElementoMe = me.Text;              
                        
            //Validação            
            Assert.AreEqual("Hi, Julio1", textoNoElementoMe);            
            
        }
    }
}
