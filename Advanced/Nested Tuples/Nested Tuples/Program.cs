using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105 ,"Ali","","","","","",Tuple.Create(2000m,3000m,4000m,5000m,6000m));

            Console.WriteLine("Employe name is " + employeeInfo.Item2);
            Console.WriteLine("Employe last five salaries is ");
            Console.WriteLine(employeeInfo.Rest.Item1);
            Console.WriteLine(employeeInfo.Rest.Item2);
            Console.WriteLine(employeeInfo.Rest.Item3);
            Console.WriteLine(employeeInfo.Rest.Item4);
            Console.WriteLine(employeeInfo.Rest.Item5);
        }
    }
}
