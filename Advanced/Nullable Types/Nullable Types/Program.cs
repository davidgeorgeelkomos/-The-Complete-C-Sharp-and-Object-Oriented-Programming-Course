using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? myDate = null;
            Console.WriteLine(myDate);

            int? number = null;
            Console.WriteLine(number);
            //number = 5;

            int numbertwo = 10;
            Console.WriteLine(number ?? numbertwo);

            string name = null;
            name = "Dodo";

            string nameTwo = "Ahmad";
            Console.WriteLine(name ?? nameTwo);
        }
    }
}
