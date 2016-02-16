using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FactoryDP1
{
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypeICanReturn();
        }

     
        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);
            if(t == null )
            {
                return new NullCar();
            }
            return Activator.CreateInstance(t) as IAuto;
        }

        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
              if(auto.Key.Contains(carName))
              {
                  return autos[auto.Key];
              }
            }
            return null;
        }
        
        void LoadTypeICanReturn()
        {
            autos =new  Dictionary<string, Type>();
            Type[] typesInThisAssembley = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesInThisAssembley)
            {
                if(type.GetInterface(typeof(IAuto).ToString()) != null )
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
