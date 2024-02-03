using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameValueCoollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            NameValueCollection cities = new NameValueCollection();

            //Adding
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "Frankfrut");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");

            //Displaying
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("-------------");

            //Set
            Console.WriteLine("After Chenging");
            cities.Set("Italy", "Venice");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("-------------");

            //Remove
            cities.Remove("Germany");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            Console.WriteLine("-------------");

            //Contains
            Console.WriteLine(cities.HasKeys());
            Console.WriteLine("-------------");

            //Remove all
            cities.Clear();
            Console.WriteLine(cities.HasKeys());
            Console.WriteLine("-------------");
        }
    }
}
