using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class SecretaPage
    {
        private IWebDriver navegador;

        public SecretaPage(IWebDriver navegador)
        {
            this.navegador = navegador;
        }
    }
}