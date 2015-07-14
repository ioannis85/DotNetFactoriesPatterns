using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetFactoriesPatterns
{
   public class NullAutoObject : IAuto
    {
       private static NullAutoObject _instance;

       private NullAutoObject()
       {
          
       }

       public static NullAutoObject GetInstance(){

           if (_instance == null)
           {
               _instance = new NullAutoObject();
           }
                
           return _instance;
       }

        public void Prender()
        {
           
        }

        public void Apagar()
        {
            
        }
    }
}
