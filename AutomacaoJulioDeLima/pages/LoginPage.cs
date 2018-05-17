using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{

    public class LoginPage
    {
        private IWebDriver navegador { get; set; }


        public LoginPage(IWebDriver navegador)
        {
            this.navegador = navegador;
        }

        public LoginFormPage clicarLinkSignIn()
        {
            navegador.FindElement(By.LinkText("Sign in")).Click();            
            return new LoginFormPage(navegador);

        }
    }
}
