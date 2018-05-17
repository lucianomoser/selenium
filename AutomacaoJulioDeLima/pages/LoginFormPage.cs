using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class LoginFormPage
    {
        private IWebDriver navegador;

        public LoginFormPage(IWebDriver navegador)
        {
            this.navegador = navegador;
        }

        public LoginFormPage DigitarLogin(string login)
        {
            navegador.FindElement(By.Id("signinbox")).FindElement(By.Name("login")).SendKeys(login);            
            return this;             
        }

        public LoginFormPage DigitaSenha(string passopassword)
        {
            navegador.FindElement(By.Id("signinbox")).FindElement(By.Name("password")).SendKeys(passopassword);
            return this;
        }

        public SecretaPage ClicarSign()
        {
            navegador.FindElement(By.LinkText("SIGN IN")).Click();
            return new SecretaPage(navegador);
        }
    }
}