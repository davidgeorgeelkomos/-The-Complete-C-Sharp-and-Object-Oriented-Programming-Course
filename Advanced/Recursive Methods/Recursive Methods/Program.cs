using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            Console.WriteLine("Non recursive way");
            Console.WriteLine(FactorialNonRecurive(number));

            Console.WriteLine("Recursive way");
            Console.WriteLine(Factorial(number));

        }

        //Non recurive way
        public static int FactorialNonRecurive (int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }
        //Recurive Way
        public static int Factorial(int n)
        {
            if(n==0) 
                return 1;
            return n * Factorial(n - 1);

        }
    }
}
