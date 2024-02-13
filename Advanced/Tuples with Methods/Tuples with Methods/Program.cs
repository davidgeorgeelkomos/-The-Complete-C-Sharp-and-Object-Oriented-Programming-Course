using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples_with_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lolo = Tuple.Create(3, "Lolo", "lol", "Winterfell");
            DisplayInformation(lolo);
            Console.WriteLine("------------");
            var soso = Tuple.Create(7, "Soso", "sos", "Winterfell");
            DisplayInformation(soso);
            Console.WriteLine("------------");
            Console.WriteLine(GetInformation().Item1);
            Console.WriteLine(GetInformation().Item2);
            Console.WriteLine(GetInformation().Item3);
            Console.WriteLine(GetInformation().Item4);

        }

        public static void DisplayInformation(Tuple<int, string, string, string> personInfo)
        {
            Console.WriteLine(personInfo.Item1);
            Console.WriteLine(personInfo.Item2);
            Console.WriteLine(personInfo.Item3);
            Console.WriteLine(personInfo.Item4);
        }

        public static Tuple<int, string, string, string> GetInformation()
        {
            var info = Tuple.Create(5, "Goto", "Got", "Winterfell");

            return info;
        }
    }
}
