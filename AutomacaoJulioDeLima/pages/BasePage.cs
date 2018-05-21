using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomacaoJulioDeLima
{
    public class BasePage
    {
        protected IWebDriver navegador { get; set; }


        WebDriverWait aguardar { get; set; }

        public BasePage()
        {
            this.navegador = navegador; 
        }


        public string VerificaMsgToastcontainer()
        {
               
            return navegador.FindElement(By.Id("toast-container")).Text;
        }
    }
}
