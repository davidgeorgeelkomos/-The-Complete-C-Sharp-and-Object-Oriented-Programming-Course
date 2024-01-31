using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_generic_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Queue queue = new Queue();

            //Adding
            queue.Enqueue("Cavin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            //Display
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Removing
            Console.WriteLine("------------");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

        }
    }
}
