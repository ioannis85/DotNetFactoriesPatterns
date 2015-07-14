using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFactoriesPatterns
{
   public class Maserati : IAuto
    {
       private const string nombreAuto = "Maserati";
       public void Prender()
       {
           Console.WriteLine("El auto {0} listo para acelerar y disfrutar de su potencia !!", nombreAuto);
       }

       public void Apagar()
       {
           Console.WriteLine("El auto {0} se ha apagado, fue un buen viaje!!", nombreAuto);
       }
    }
}
