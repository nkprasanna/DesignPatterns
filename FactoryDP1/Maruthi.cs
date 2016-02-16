using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    public class Maruthi:IAuto
    {

        public void TurnOn()
        {
            Console.WriteLine("Maruthi car is Turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Maruthi car is Turned off");
        }
    }
}
