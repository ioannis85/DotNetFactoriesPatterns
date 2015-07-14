using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DotNetFactoriesPatterns
{
    public class SimpleAutoFactory
    {
        private Dictionary<string, Type> autoTypes;

        public SimpleAutoFactory()
        {
            this.autoTypes = GetAviableCars();
            
        }

        private Dictionary<string, Type> GetAviableCars()
        {
          Assembly currentAssembly = Assembly.GetExecutingAssembly();
          var autoInterfaces = currentAssembly.GetTypes().Where((t) => t.GetInterface("IAuto") != null);
          return  autoInterfaces.ToDictionary((type)=> type.Name);  
        }


        public IAuto Create(string type)
        {

            return this.CreateInstance(type);
        }

        private IAuto CreateInstance(string type)
        {
            if (this.autoTypes.ContainsKey(type))
            {
                return (IAuto)Activator.CreateInstance(this.autoTypes[type]);
            }
            else
            {
                return NullAutoObject.GetInstance();
            }
        }
    }
}


