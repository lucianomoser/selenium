using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    class BasePage
    {
        protected IWebDriver navegador { get; set; }

        public BasePage()
        {
            this.navegador = navegador; 
        }

    }
}
