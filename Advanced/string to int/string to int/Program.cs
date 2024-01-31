using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_to_int
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number:");
                string numberString = Console.ReadLine();

                bool success = int.TryParse(numberString, out int number);
                if (success)
                {
                    Console.WriteLine("Conversion succeeded. The number is: " + number);
                }
                else
                {
                    Console.WriteLine("Conversion failed. Invalid input.");
                }
            }
        }
}

