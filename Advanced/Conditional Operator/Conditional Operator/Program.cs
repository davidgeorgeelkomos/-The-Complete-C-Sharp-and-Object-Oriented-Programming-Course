using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsAdmin())
            {
                Console.WriteLine("Yes,he is an admin");
            }
            else
            {
                Console.WriteLine("No,he is not an admin");
            }
            Console.WriteLine("--------------");

            Console.WriteLine(IsAdmin() ? "Is an Admin" : "Not admin" );
        }
        public static bool IsAdmin()
        {
            return true;
        }
    }
}
