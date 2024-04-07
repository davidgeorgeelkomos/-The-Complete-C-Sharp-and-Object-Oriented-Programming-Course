using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddingTwoNumbers;
            Console.WriteLine(funcOne(7,8));
            
            Func<int> funcTwo = AddingTwoNumbers;
            Console.WriteLine(funcTwo());
        }
        public static int AddingTwoNumbers(int x,int y)
        {
            return x+ y;
        }
        public static int AddingTwoNumbers()
        {
            int x = 5;
            int y = 7;
            int z;
            z= x + y;
            return z;
        }
    }
}
