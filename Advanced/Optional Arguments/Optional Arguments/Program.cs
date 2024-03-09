using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformaion(7, "Ronaldo", 60, "Portugal", "Alnassr");
            Console.WriteLine("-----------");
            DisplayPlayerInformaion(10, "Messi", 70);
        }

        //If i want to set a defult value i have to start from the last one
        public static void DisplayPlayerInformaion(int no,string name,int goals,string country="Unknow",string club = "Unknow")
        {
            Console.WriteLine("From the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
            Console.WriteLine(club);
        }
        public static void DisplayPlayerInformaion(int no, string name, int goals)
        {
            Console.WriteLine("From the second method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
        }
    }
}
