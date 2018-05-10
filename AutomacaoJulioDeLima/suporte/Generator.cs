using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoJulioDeLima {
    public class Generator {

        public static string dataHoraParaArquivo() {

  
            string horaMinutoSegundo = DateTime.Now.ToString("yyyymmddhhmmss");
            return horaMinutoSegundo;
        }
    }
}
