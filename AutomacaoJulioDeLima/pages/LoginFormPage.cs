using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class LoginFormPage:BasePage
    {
        
        public LoginFormPage(IWebDriver navegador)
        {
            this.navegador = navegador;
        }

        public LoginFormPage DigitarLogin(string login)
        {
            navegador.FindElement(By.Id("signinbox")).FindElement(By.Name("login")).SendKeys(login);            
            return this;             
        }

        public LoginFormPage DigitarSenha(string passopassword)
        {
            navegador.FindElement(By.Id("signinbox")).FindElement(By.Name("password")).SendKeys(passopassword);
            return this;
        }

        public SecretaPage ClicarSign()
        {
            navegador.FindElement(By.LinkText("SIGN IN")).Click();
            return new SecretaPage(navegador);
        }

        public SecretaPage FazerLogin(string login, string senha)
        {
            DigitarLogin(login);
            DigitarSenha(senha);
            ClicarSign();
            return new SecretaPage(navegador);

        }
        

    }
}