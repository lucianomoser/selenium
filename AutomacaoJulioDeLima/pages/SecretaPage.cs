using System;
using OpenQA.Selenium;

namespace AutomacaoJulioDeLima
{
    public class SecretaPage:BasePage
    {        

        public SecretaPage(IWebDriver navegador)
        {
            this.navegador = navegador;
        }

        public PaginaMe ClicarPaginaMe()
        {
            navegador.FindElement(By.ClassName("me")).Click();
            return new PaginaMe(navegador);
        }



    }
}