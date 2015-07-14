using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFactoriesPatterns
{
    public class Volvo: IAuto
    {
        private const string nombreAuto = "Volvo";
        public void Prender()
        {
            Console.WriteLine("El auto {0} listo para acelerar y disfrutar de su seguridad!!", nombreAuto);
        }

        public void Apagar()
        {
            Console.WriteLine("El auto {0} se ha apagado, increible viaje tuve en el!!", nombreAuto);
        }

    }
}
