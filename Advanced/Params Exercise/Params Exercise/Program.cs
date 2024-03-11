using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayingPlayerInfo("Ahmad","adam");
            DisplayingPlayerInfo(7);
            DisplayingPlayerInfo(DateTime.Now);
        }
        public static void DisplayingPlayerInfo<T>(params T[] Info)
        {
            foreach (var name in Info)
            {
                Console.WriteLine(name);
            }
        }
    }
}
