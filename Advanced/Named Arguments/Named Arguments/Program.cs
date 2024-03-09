using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformaion(country: "Portugal", name: "Ronaldo", no: 7, goals:60);
        }
        public static void DisplayPlayerInformaion(int no, string name, int goals, string country = "Unknow")
        {
            Console.WriteLine("From the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
        }
    }
}
