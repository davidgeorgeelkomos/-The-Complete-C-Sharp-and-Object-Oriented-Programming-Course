
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Creating_Threads
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHi));
            t1.Name = "Thread number 1 in English";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHola));
            t2.Name = "Thread number 2 in Spanish";
            t2.Start();
        }
        public static void SayHi()
        {
            Console.WriteLine("Starting execute thread number " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                t2.Join();
                //Thread.Sleep(1000);
                //if (i == 31)
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " is about to abort");
                //    t1.Abort();
                //}

                Console.WriteLine(i + "-Hi...");
            }
        }
        public static void SayHola()
        {
            Console.WriteLine("Starting execute thread number " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(new TimeSpan(0, 0, 1));
                Console.WriteLine(i + "-Hola...");
            }
        }
    }
}
