using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(26, 65, 65);
            Console.WriteLine(ts.TotalHours);

            ts = ts.Add(new TimeSpan(0, 0, 10));
            Console.WriteLine(ts);

            DateTime dateTimeOne = new DateTime(2004, 5, 31);
            DateTime dateTimeTwo = new DateTime(2024, 6, 15);

            TimeSpan sub = dateTimeOne - dateTimeTwo;
            sub = dateTimeTwo.Subtract(dateTimeOne);
            Console.WriteLine(sub.TotalDays/365.25);
        }
    }
}
