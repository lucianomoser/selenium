using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomacaoJulioDeLima
{
    public class PaginaAdicionarContato:BasePage
    {      
        public PaginaAdicionarContato(IWebDriver navegador)
        {
            this.navegador = navegador;
        }



        public PaginaAdicionarContato InformarTipoContato(string tipo)
        {
            IWebElement campoType = navegador.FindElement(By.Id("addmoredata")).FindElement(By.Name("type"));

            new SelectElement(campoType).SelectByText(tipo);

            return this;
        }

        public PaginaAdicionarContato DigitarContato(string contato)
        {
            navegador.FindElement(By.Id("addmoredata")).FindElement(By.Name("contact")).SendKeys(contato);
            return this; 
        }

        public PaginaMe ClicarSalvar()
        {
            navegador.FindElement(By.Id("addmoredata")).FindElement(By.LinkText("SAVE")).Click();
            return new PaginaMe(navegador);
        }

        public PaginaMe AdicionarContato(string tipo, string contato)
        {
            InformarTipoContato(tipo);
            DigitarContato(contato);
            ClicarSalvar();
            return new PaginaMe(navegador);
        }

        
    }
}