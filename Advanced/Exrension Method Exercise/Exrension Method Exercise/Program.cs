using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrension_Method_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Time = new DateTime(2000, 11, 1);
            Console.WriteLine(Time);
            Console.WriteLine("-----------");
            Console.WriteLine(Time.TheDateTime());
        }
    }
    static class NewDate
    {
        public static string TheDateTime(this DateTime date)
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}",date);
        }
    }
}
