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

namespace AutomacaoJulioDeLima
{
    [TestFixture]
    public class TestesSitejulioDeLima
    {
        [Test]
        public void TesteAdicionarUmaInformacaoAdicionalDoUsuario()
        {
            IWebDriver navegador = new ChromeDriver();
            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");
          



            //Clicar no link que possui o texto "SignBox"
            navegador.FindElement(By.LinkText("Sign in")).Click();                       

            
            IWebElement formularioSignBox = navegador.FindElement(By.Id("signinbox"));

            //Clicar no campo com name "Login" que está dentro do formulario "SignBox" informar o texto julio0001
            formularioSignBox.FindElement(By.Name("login")).SendKeys("julio0001");

            //Clicar no campo com name "password" que está dentro do formulario "SignBox" informar o texto 123456
            formularioSignBox.FindElement(By.Name("password")).SendKeys("123456");
            
            //Clicar no link SIGN IN
            navegador.FindElement(By.LinkText("SIGN IN")).Click();
            
            //Validar que dentro do elemento com class  "me" esta o texto "Hi Julio"
            IWebElement me =  navegador.FindElement(By.ClassName("me"));

            string textoNoElementoMe;

            textoNoElementoMe = me.Text;              
            
            //Validação            
            Assert.AreEqual("Hi, Julio1", textoNoElementoMe);

            //Fechar navegador

            
        }
    }
}
