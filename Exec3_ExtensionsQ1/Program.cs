using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_ExtensionsQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isOdd = Predicate(55, n => n % 2 == 1); 
            Console.WriteLine(isOdd);
           
            bool isEven = Predicate(40 , x => x % 2 == 0);
            Console.WriteLine(isEven);

                   
        }

        static bool Predicate(int num, Func<int, bool> func)
        {
            return func(num);
        }

    }
}
