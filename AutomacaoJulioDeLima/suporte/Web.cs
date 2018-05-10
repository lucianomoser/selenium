using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoJulioDeLima{
    public class Web {
        public static IWebDriver chrome() {

            IWebDriver navegador = new ChromeDriver();
       
            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");

            return navegador;
        }

    }
}
