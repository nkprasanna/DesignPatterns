using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    class Audi:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on Audi");

        }

        public void TurnOff()
        {
            Console.WriteLine("Turn Off Audi");
        }
    }
}
