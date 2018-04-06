using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleInstance.Instance.MyNormalMethod();

            SingleInstance.Instance.MyNormalMethod();
            SingleInstance.MyMethod();
            LazySingleton.Instance.LazyMethod();

            
        }
    }
}
