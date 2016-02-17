using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
   public class LazySingleton
   {
       private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
       
       private  LazySingleton()
       {
           Console.WriteLine("Lazy Instance created\n");
       }
       public static LazySingleton Instance
       {
           get
           {
               return _instance.Value;
           }
       }
       public void LazyMethod()
       {
           Console.WriteLine("Super Lazy\n");
       }
   }    
}
