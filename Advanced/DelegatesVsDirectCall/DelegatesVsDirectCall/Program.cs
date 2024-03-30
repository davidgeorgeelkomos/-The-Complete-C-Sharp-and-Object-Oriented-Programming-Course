using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesVsDirectCall
{
    public delegate void DoSomethingsDel();

    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWachOne = Stopwatch.StartNew();
            Stopwatch stopWachTwo = Stopwatch.StartNew();
            DoSomethingsDel taskOne = new DoSomethingsDel(DoSomething);

            //using Delegates 
            Console.WriteLine("Delegates Method ..... \n ----------");
            stopWachOne.Start();
            taskOne();
            stopWachOne.Stop();
            var elapsedOne = stopWachOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedOne.TotalSeconds,2));

            //using Direct Method
            Console.WriteLine("Direct Method....... \n ----------");
            stopWachTwo.Start();
            DoSomething();
            stopWachTwo.Stop();
            var elapsedTwo = stopWachTwo.Elapsed;
            Console.WriteLine(Math.Round(elapsedTwo.TotalSeconds,2));

            Console.WriteLine("\nDelegates saved you " + Math.Round((elapsedTwo.TotalMilliseconds - elapsedOne.TotalMilliseconds),4) + " Millisecond");
            Console.WriteLine("Delegates saved you " + Math.Round((elapsedTwo.TotalSeconds - elapsedOne.TotalSeconds),4) + " Second");


        }
        public static void DoSomething()
        {
            double number = 8.543231;
            List<double> list = new List<double>();
            for (double i = 0; i < 60_000_000; i++)
            {
                number += i+DateTime.Now.Second;
                list.Add(number);
            }
            list.Reverse();
        }
    }
}
