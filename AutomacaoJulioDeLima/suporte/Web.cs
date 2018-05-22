using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoJulioDeLima{
    public class Web {
        public static IWebDriver chrome() {

            IWebDriver navegador = new ChromeDriver();

            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");           

            return navegador;
        }


        public static IWebDriver CreateBrowserstack()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browserName", "iPhone");
            capability.SetCapability("device", "iPhone 7");
            capability.SetCapability("realMobile", "true");
            capability.SetCapability("os_version", "10.3");
            capability.SetCapability("browserstack.user", "lucianojosemarch1");
            capability.SetCapability("browserstack.key", "FJuiyoJwbEohXnJHz7Xp");

            IWebDriver navegador = null;          

            navegador = new RemoteWebDriver(
              new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability);

            navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            navegador.Navigate().GoToUrl("http://www.juliodelima.com.br/taskit/");

            return navegador;
        }

    }
}
