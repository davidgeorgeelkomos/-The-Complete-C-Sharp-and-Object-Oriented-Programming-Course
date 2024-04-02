using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiply MultiplyNumber = delegate (int n) { { return n * 3; } };
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(25));

            //DisplayMessage Messge = delegate { Console.WriteLine("Hi from Anonymous Method"); };
            DisplayMessage Message = () => Console.WriteLine("Hi from Lambda expression");
            Message();

        }
    }
}
