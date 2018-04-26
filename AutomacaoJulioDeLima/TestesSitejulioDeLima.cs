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


        private IWebDriver driver { get; set; }
        private IWebDriver navegador { get; set; }



        [SetUp]
        public void inicializaAmbiente()
        {
            navegador = new ChromeDriver();
            navegador.Manage().Window.Maximize();
            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");
        }



        [Test]
        public void informacoesUsuarioTeste()
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
            IWebElement me = wait.Until(driver => navegador.FindElement(By.ClassName("me")));

            string textoNoElementoMe;

            textoNoElementoMe = me.Text;

            //Clicar no link Hi, Julio1
            navegador.FindElement(By.LinkText(textoNoElementoMe)).Click();

            //Clicar no link MORE DATA ABOUT YOU
            navegador.FindElement(By.LinkText("MORE DATA ABOUT YOU")).Click();

            //Clicar no Botão  + ADD MORE DATA atraves do XPath ////div[@id="moredata"]//button[@data-target="addmoredata"]
            navegador.FindElement(By.XPath("//div[@id='moredata']//button[@data-target='addmoredata']")).Click();


            //Identificar a poupap onde está o formulario de id="addmoredata"
            IWebElement formularioPop = navegador.FindElement(By.Id("addmoredata"));


            //No combo de name Type escolher a opção pelo texto "Phone"
            IWebElement campoType = formularioPop.FindElement(By.Name("type"));

            new SelectElement(campoType).SelectByText("Phone", false);


            //No campo de name="contact" digitar "+551199999999999"
            formularioPop.FindElement(By.Name("contact")).SendKeys("+551188888888");

            //Clicar no Link no Link Save
            formularioPop.FindElement(By.LinkText("SAVE")).Click();

            //Na mensagem de id="toast-container" validar o texto 'Your contact has been added!'

            IWebElement mensagem = wait.Until(driver => navegador.FindElement(By.Id("toast-container")));

            string textoMsg = mensagem.Text;

            Assert.AreEqual(textoMsg, "Your contact has been added!"); 



            //Validação            
            //Assert.AreEqual("Hi, Julio1", textoNoElementoMe);                        
        }


        [TearDown]
        public void finalizaambiente()
        {
            //Finaliza navegador
            navegador.Quit();
        }

    }
}
