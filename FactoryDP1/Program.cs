using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string carName = args[0];
            string carName = Console.ReadLine();
            AutoFactory factory = new AutoFactory();
            IAuto car = factory.CreateInstance(carName);
            car.TurnOn();            
            car.TurnOff();            
        }

        //static IAuto GetCar(string carName)
        //{
        //    switch (carName)
        //    {
        //        case "BMW": 
        //            return new BMWSClass();
        //        case "MiniCooper": 
        //            return new MiniCooper();
        //        case "Audi": 
        //            return new Audi();
        //        default:
        //            return new NullCar ();                    
        //    }
        //}
    }
}
