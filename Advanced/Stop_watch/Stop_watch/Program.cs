using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_watch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Loop(900_000_000);
            stopwatch.Stop();

            Console.WriteLine("MilliSecond: " + stopwatch.Elapsed.Milliseconds);
            Console.WriteLine("TotalMilli Second: " + stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("TotalSecond: " + stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine("Second:  " + stopwatch.Elapsed.Seconds);
        }
        public static void Loop(long number)
        {
            for (int i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done");
        }
    }
}
