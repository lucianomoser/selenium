using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class PaginaMe : BasePage
    {        
        
        public PaginaMe(IWebDriver navegador)
        {
            this.navegador = navegador;
        }

        public PaginaMe ClicarMoreDataAbout()
        {
            navegador.FindElement(By.LinkText("MORE DATA ABOUT YOU")).Click();
            return this;
        }

        public PaginaAdicionarContato ClicarAddBotaoMoreDateAbout()
        {
            navegador.FindElement(By.XPath("//div[@id='moredata']//button[@data-target='addmoredata']")).Click();
            return new PaginaAdicionarContato(navegador);
        }
            
    }
}