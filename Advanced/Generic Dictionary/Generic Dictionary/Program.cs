using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Dictionary<string,string> capital = new Dictionary<string,string>();

            //Creating with initialization
            Dictionary<int, string> name = new Dictionary<int, string>()
            {
                {1,"James" },
                {2,"Emma" },
                {3,"Eva" },
            };
            foreach (var item in name)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("----------");


            //Adding
            capital.Add("Japan", "Tokyo");
            capital.Add("Italy", "Rome");
            capital.Add("Russia", "Moscow");
            capital.Add("Spain", "Madrid");
            capital.Add("England", "London");
            capital.Add("Germany", "Berlin");

            //Displaying
            Console.WriteLine("Display with Foreach");
            foreach (var item in capital)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Display with for");
            for (int i = 0; i < capital.Count; i++)
            {
                Console.WriteLine(capital.Values.ElementAt(i));
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Another for Display");
            for (int i = 0; i < capital.Count; i++)
            {
                Console.WriteLine(capital[capital.Keys.ElementAt(i)]);
            }
            Console.WriteLine("-----------");

            //Index
            Console.WriteLine("After chenging...");
            capital["England"] = "Cairo";
            Console.WriteLine(capital["England"]);
            Console.WriteLine("-----------");
            for (int i = 0; i < capital.Count; i++)
            {
                Console.WriteLine(capital[capital.Keys.ElementAt(i)]);
            }
            Console.WriteLine("-----------");


            //Capacity
            Console.WriteLine("count is " + capital.Count());
            Console.WriteLine("-----------");

            //Try to value
            Console.WriteLine("Try To Get Value");
            capital.TryGetValue("Germany", out string result);
            if (result == null)
            {
                Console.WriteLine("The Result is " + result);
            }
            Console.WriteLine("-----------");

            //Contains
            Console.WriteLine("Asking if it countains England or not..");
            Console.WriteLine(capital.ContainsKey("England"));
            Console.WriteLine("-----------");

            //Remove
            Console.WriteLine("After Removing England...");
            capital.Remove("England");
            for (int i = 0; i < capital.Count; i++)
            {
                Console.WriteLine(capital[capital.Keys.ElementAt(i)]);
            }
            Console.WriteLine("-----------");

            //Remove all
            capital.Clear();

        }
    }
}
