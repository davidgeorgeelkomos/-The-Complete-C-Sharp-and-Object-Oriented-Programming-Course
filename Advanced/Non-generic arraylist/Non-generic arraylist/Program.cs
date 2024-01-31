using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_generic_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating

            ArrayList array = new ArrayList();

            //Add
            array.Add("admonz");
            array.Add("Feskos");
            array.Add("1");
            array.Add("Mohy");

            Console.WriteLine("----");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            array.Insert(1, "A2A");
            Console.WriteLine("========");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Index
            Console.WriteLine("---------");
            Console.WriteLine(array[2].ToString());

            //Capasity
            Console.WriteLine("---------");
            Console.WriteLine(array.Count);

            //Contains
            Console.WriteLine("---------");
            Console.WriteLine("After Asking if contains");
            Console.WriteLine(array.Contains("A2A"));

            //Get Range
            Console.WriteLine("---------");
            ArrayList name= new ArrayList();
            name = array.GetRange(0, 2);
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            //Sorting
            Console.WriteLine("---------");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Revers
            Console.WriteLine("---------");
            array.Reverse();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Removing
            Console.WriteLine("---------");
            array.Remove("1");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //RemoveAll
            Console.WriteLine("---------");
            array.Clear();
            array.RemoveRange(1, 2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
