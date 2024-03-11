using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerformMathOperations(1,2,3,4);
            PerformMathOperations(1,2,3,4,5,6,7);
        }
        public static void PerformMathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddingNumbers());
            int AddingNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number;
                }
                return result;
            }
            Console.WriteLine("Multi = " + MultiNumbers());
            int MultiNumbers()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
            Console.WriteLine("------------");

        }
    }
}
