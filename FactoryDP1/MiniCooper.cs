using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    class MiniCooper:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("Mincooper is Running");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off Mini Cooper");

        }
    }
}
