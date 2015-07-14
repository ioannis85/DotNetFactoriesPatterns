using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFactoriesPatterns
{
    public class Honda : IAuto
    {
        private const string nombreAuto = "Honda";

        public void Prender()
        {
            Console.WriteLine("El auto {0} listo para acelerar!!",nombreAuto);
        }

        public void Apagar()
        {
            Console.WriteLine("El auto {0} se ha apagado!!", nombreAuto);
        }
    }
}
