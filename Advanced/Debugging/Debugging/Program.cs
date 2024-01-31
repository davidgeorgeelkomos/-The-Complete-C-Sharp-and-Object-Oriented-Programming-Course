using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            //F11 step into: get inside the void the chick in it
            //F12 step over: execute the void without getting into it
            x = 2;
            y = 2;
            Console.WriteLine("inside main");
            ChangeValues();
            x = 9;
            y= 9;
            Console.WriteLine("inside main again");
        }
        public static void ChangeValues()
        {
            x = 4;
            y = 4;
            Console.WriteLine("inside ChangeValue");
        }

    }
}
