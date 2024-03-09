using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo("John");
            DisplayInfo(2);
            DisplayInfo(2.5);

            var PlayerInfo = (7, "Ronaldo", 60);
            Console.WriteLine(PlayerInfo);
        }
        public static void DisplayInfo<T>(T info)
        {
            Console.WriteLine(info);
        }
    }
}
