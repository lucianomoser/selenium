using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class BasePage
    {
        protected IWebDriver navegador { get; set; }

        public BasePage()
        {
            this.navegador = navegador; 
        }

    }
}
