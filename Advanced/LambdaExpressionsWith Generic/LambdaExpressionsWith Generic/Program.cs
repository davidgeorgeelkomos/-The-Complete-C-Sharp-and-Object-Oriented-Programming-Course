using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsWith_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(8); list.Add(3); list.Add(6); list.Add(2); 
            list.Add(1); list.Add(4); list.Add(7); list.Add(5);

            var oddNumber = list.Where(n => n % 2 != 0);
            var evenNumber = list.Where(n => n % 2 == 0);

            Console.WriteLine("The Odd numbers");
            foreach (var item in oddNumber)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            Console.WriteLine("The Even numbers");
            foreach (var item in evenNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}
