using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();

            arrivals.Enqueue(new DateTime(2017 , 01 , 09));
            arrivals.Enqueue(new DateTime(2020 , 08 , 30));
            arrivals.Enqueue(new DateTime(2004 , 05 , 31));

            Console.WriteLine("Before Dequeue");
            Console.WriteLine("At the top " + arrivals.Peek());
            Console.WriteLine("--------------");
            Console.WriteLine("At the bottom " + arrivals.Last());
            Console.WriteLine("--------------");

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            arrivals.Dequeue();
            Console.WriteLine("After Dequeue");
            Console.WriteLine("At the top " + arrivals.Peek());
            Console.WriteLine("--------------");
            Console.WriteLine("At the bottom " + arrivals.Last());
            Console.WriteLine("--------------");

            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }


        }
    }
}
