using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "David", "George", new DateTime(2020, 10, 27), true);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString());
            Console.WriteLine(empInfo.Item5);
            Console.WriteLine("------------");

            var studentInfo = Tuple.Create(5, "Ahmad", "Abas", new DateTime(2006, 2, 3));
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(((DateTime)(studentInfo.Item4)).ToShortDateString());

        }
    }
}
