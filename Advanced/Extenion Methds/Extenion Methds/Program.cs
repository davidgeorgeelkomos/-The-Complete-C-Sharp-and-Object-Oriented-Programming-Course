using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenion_Methds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x.IsGreater(20));

            string text =  "aa";
            Console.WriteLine(text.IsNumber());
        }
    }
    static class MyCustomExtension
    {
        public static bool IsGreater(this int value,int number)
        {
            return value > number;
        }
        public static bool IsNumber(this string text)
        {
            return int.TryParse (text, out int result);
        }
    }
}
