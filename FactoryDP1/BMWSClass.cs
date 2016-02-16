using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP1
{
    class BMWSClass:IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("BMS is Turned On");

        }

        public void TurnOff()
        {
            Console.WriteLine("Bmw is Turned Off");
        }
    }
}
