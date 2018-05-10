using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace AutomacaoJulioDeLima {
    [TestFixture]
    public class TestesSitejulioDeLima {
        private IWebDriver driver { get; set; }
        private IWebDriver navegador { get; set; }
        private WebDriverWait aguardar { get; set; }

        [SetUp]
        public void inicializaAmbiente() {


            navegador = Web.chrome();

            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Clicar no link que possui o texto "SignBox"
            navegador.FindElement(By.LinkText("Sign in")).Click();

            IWebElement formularioSignBox = navegador.FindElement(By.Id("signinbox"));

            //Clicar no campo com name "Login" que está dentro do formulario "SignBox" informar o texto julio0001
            formularioSignBox.FindElement(By.Name("login")).SendKeys("julio0001");

            //Clicar no campo com name "password" que está dentro do formulario "SignBox" informar o texto 123456
            formularioSignBox.FindElement(By.Name("password")).SendKeys("123456");

            //Clicar no link SIGN IN
            navegador.FindElement(By.LinkText("SIGN IN")).Click();

            //aguardar = new WebDriverWait(navegador, TimeSpan.FromSeconds(3));           


            IWebElement me = navegador.FindElement(By.ClassName("me"));

            string textoNoElementoMe;

            textoNoElementoMe = me.Text;

            //Clicar no link Hi, Julio1
            navegador.FindElement(By.LinkText(textoNoElementoMe)).Click();

            //Clicar no link MORE DATA ABOUT YOU
            navegador.FindElement(By.LinkText("MORE DATA ABOUT YOU")).Click();


        }



        [Test]
        public void informacoesUsuarioTeste() {

            
            aguardar = new WebDriverWait(navegador, TimeSpan.FromSeconds(3));


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

            IWebElement mensagem = aguardar.Until(driver => navegador.FindElement(By.Id("toast-container")));

            string textoMsg = mensagem.Text;

            Assert.AreEqual(textoMsg, "Your contact has been added!");



            //Validação            
            //Assert.AreEqual("Hi, Julio1", textoNoElementoMe);                        
        }

        [Test]
        public void RemoverUmContatoDeUmUsuario() {

            //Clicar pelo elemento XPath //span[text()="+554788881122"]/following-sibling::a
            navegador.FindElement(By.XPath("//span[text()='554788881122']/following-sibling::a")).Click();

            //Confirmar a janela java script o botão Ok
            navegador.SwitchTo().Alert().Accept();

            //Validar que a mensagem apresentanda Rest in peace, dear email! id = "toast-container"
            IWebElement mensagemPop = navegador.FindElement(By.Id("toast-container"));
            string mensagem = mensagemPop.Text;
            Assert.AreEqual("Rest in peace, dear phone!", mensagem);

            string nomeDoArquivo = @"C:\temp\" + Generator.dataHoraParaArquivo() + "RemoverUmcontatoParaUsusario.png";
            Foto.tirar(navegador, nomeDoArquivo );



            //Depois da janela ser apresentada aguardar 10 segundos a janela desaparecer.3
            aguardar = new WebDriverWait(navegador, TimeSpan.FromSeconds(10));

            //aguardar.Until(driver => navegador.FindElement(By.Id("toast-container")));                     
            aguardar.Until(ExpectedConditions.StalenessOf(mensagemPop));

            //Fazer logaunt clicar no link Logout     
            navegador.FindElement(By.LinkText("Logout")).Click();
        }


        [TearDown]
        public void finalizaambiente() {
            //Fecha navegador
            navegador.Quit();
        }

    }
}



