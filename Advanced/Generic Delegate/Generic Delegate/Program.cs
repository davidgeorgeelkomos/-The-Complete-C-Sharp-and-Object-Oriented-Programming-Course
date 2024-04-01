using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    public delegate T DisplayInfo<T>(T value);
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(myNumber(100));
            Console.WriteLine("------------");

            DisplayInfo<double> myDoubleNumber = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(1.23855));
            Console.WriteLine("------------");


            DisplayInfo<DateTime> myDateNumber = new DisplayInfo<DateTime>(DisplayValue);
            Console.WriteLine(myDateNumber(DateTime.Now));
            Console.WriteLine("------------");



        }
        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name);
            return value;
        }
    }
}
