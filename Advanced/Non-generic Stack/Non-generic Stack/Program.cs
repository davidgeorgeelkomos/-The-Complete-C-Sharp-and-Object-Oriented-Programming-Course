using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating 
            Stack stack = new Stack();

            //Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Ahmad");
            stack.Push("Emma");

            //Removing

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
