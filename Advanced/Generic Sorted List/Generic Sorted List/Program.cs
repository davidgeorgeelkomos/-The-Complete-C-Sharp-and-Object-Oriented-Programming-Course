using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            SortedList list = new SortedList();//Non Generic list
            SortedList<string, string> phoneBook = new SortedList<string, string>(); //Generic list

            //Add
            phoneBook.Add("Jack", "123456789");
            phoneBook.Add("Emma", "987654321");
            phoneBook.Add("Eva", "987412365");
            phoneBook.Add("Mike", "987456321");

            //Display
            Console.WriteLine("Display with Foreach");
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " the mobile no is " + item.Value);
            }
            Console.WriteLine("----------");
            
            //Index
            Console.WriteLine("After Change...");
            phoneBook["Jack"] = "77777777";
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " the mobile no is " + item.Value);
            }
            Console.WriteLine("----------");

            //TryGetValue
            Console.WriteLine("Try Get Value");
            phoneBook.TryGetValue("Mike", out string Result);
            if (Result == null)
            {
                Console.WriteLine("Mike is in the list");
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Mike is not in the list");
            }
            Console.WriteLine("----------");

            //Contains
            Console.WriteLine("Is Mike there?...");
            Console.WriteLine(phoneBook.ContainsKey("Mike"));
            Console.WriteLine("------------");

            //Remove
            Console.WriteLine("After Removing");
            phoneBook.Remove("Mike");
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " the mobile no is " + item.Value);
            }
            Console.WriteLine("----------");

            //RemoveAll
            Console.WriteLine(phoneBook.Count());
            Console.WriteLine("After Removing all");
            phoneBook.Clear();
            Console.WriteLine(phoneBook.Count());
        }
    }
}
