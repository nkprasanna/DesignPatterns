using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    class NullCar:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Unknown car Running");
        }

        public void TurnOff()
        {
            Console.WriteLine("Unknown car Shutdown");
        }
    }
}
