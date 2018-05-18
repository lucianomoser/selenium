using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class PaginaAdicionarContato:BasePage
    {      
        public PaginaAdicionarContato(IWebDriver navegador)
        {
            this.navegador = navegador;
        }
    }
}