using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empInfo = new List<Tuple<int, string, string, DateTime>>();
            empInfo.Add(new Tuple<int, string, string, DateTime> (2, "David", "George", new DateTime(2025, 4, 25)));
            empInfo.Add(Tuple.Create (4, "David", "George", new DateTime(2025, 4, 25)));
            empInfo.Add(Tuple.Create (3, "David", "George", new DateTime(2025, 4, 25)));
            empInfo.Add(Tuple.Create (1, "David", "George", new DateTime(2025, 4, 25)));

            foreach (var item in empInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            empInfo.Sort();

            foreach (var item in empInfo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            empInfo.Reverse();
            foreach (var item in empInfo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
