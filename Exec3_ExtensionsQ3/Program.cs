using Exec3_ExtensionsQ3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_ExtensionsQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "78763";
            int number = value.ToInt(-1);
            Console.WriteLine(number);

            value = "12木頭人";
            number = value.ToInt(-10);
            Console.WriteLine(number);

        }
    }
    public static class StringExtensions
    {
        public static int ToInt(this string source, int defaultValue)
        {
            bool isInt = int.TryParse(source, out int number);

            return isInt ? number : defaultValue;
        }

    }
}

