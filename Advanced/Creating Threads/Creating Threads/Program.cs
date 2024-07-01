
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Creating_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SayHi));
            t1.Name = "Thread number 1 in English";
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(SayHola));
            t2.Name = "Thread number 1 in Spanish";
            t2.Start();
        }
        public static void SayHi()
        {
            Console.WriteLine("Starting execute thread number " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine( i + "-Hi...");
            }
        }
        public static void SayHola()
        {
            Console.WriteLine("Starting execute thread number " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + "-Hola...");
            }
        }
    }
}
