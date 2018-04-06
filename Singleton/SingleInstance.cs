using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleInstance
    {
        private static SingleInstance _instance;
        private static readonly object _lock = new object();

        /// <summary>
        /// 
        /// </summary>
        private SingleInstance()
        {

        }
        public static SingleInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    //Double checking lock ch
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingleInstance();
                            Console.WriteLine("One and only Instance created\n");
                        }
                    }
                }
                return _instance;
            }
        }
        public static void MyMethod()
        {
            Console.WriteLine("Static Method Call\n");
        }
        public void MyNormalMethod()
        {
            Console.WriteLine("Normal Method\n");
        }
    }

}
