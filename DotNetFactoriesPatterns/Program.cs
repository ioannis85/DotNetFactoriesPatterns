using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFactoriesPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = new SimpleAutoFactory();
            var maserati = carFactory.Create("Maserati");
            maserati.Prender();
            maserati.Apagar();

            var honda = carFactory.Create("Honda");
            honda.Prender();
            honda.Apagar();
            var noAsignado = carFactory.Create("");
            if (noAsignado.Equals(NullAutoObject.GetInstance()))
            {
                Console.WriteLine("Auto no encontrado");
            }
            Console.ReadLine();
        }
    }
            
}
