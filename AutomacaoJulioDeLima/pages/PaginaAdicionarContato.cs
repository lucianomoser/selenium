using OpenQA.Selenium;

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
            
            return this;
        }

        public PaginaAdicionarContato digtarContato(string contato)
        {
            return this;
        }

        public PaginaMe ClicarSalvar()
        {
            return new PaginaMe(navegador);
        }

        public PaginaMe AdicionarContato(string tipo, string contato)
        {
            InformarTipoContato("phone");
            digtarContato("4755555555");
            return new PaginaMe(navegador);
        }
    }
}