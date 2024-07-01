using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreaded_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart (delegate ()
            {
                Console.WriteLine("Process 1 Start");
                Console.WriteLine("Process 1 running");
                for (long i = 0; i < 2_500_000_000; i++)
                {}
                Console.WriteLine("Process is done");
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 2 Start");
                Console.WriteLine("Process 2 runnint");
                for (long i = 0; i < 5_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 is done");
            }));
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(delegate ()
            {
                Thread.Sleep(1);
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name + " welcome back");
            }));
            t3.Start();

        }
    }
}
