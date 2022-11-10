using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_ExtensionsQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "steelismybody";
            string result = MyMath.Left(value, 5);

            value = null;
            string empty = value.Left(2);

            value = "1";
            string result2 = value.Left(-1);


            value = "steelismybody";
            string result3 = value.Left(99);

            Console.WriteLine(result);
            Console.WriteLine(empty);
          
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }

       

      
    }
    public static class MyMath
    {
        public static string Left(this string source, int length)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            if (length <= 0) return string.Empty;
            if (source.Length <= length) return source;
            return source.Substring(0, length);
        }
    }
}

