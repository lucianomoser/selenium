using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoJulioDeLima {
    public class Foto {

        public static void tirar(IWebDriver navegador, string arquivo) {

            ITakesScreenshot camera = navegador as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();


                
                foto.SaveAsFile(arquivo, ScreenshotImageFormat.Png);

        

        }
    }
}
