using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_Generic_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Hashtable hash = new Hashtable();

            //Add
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Marcedes", "Germany");

            //Display
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //Capasty
            Console.WriteLine("--------------");
            Console.WriteLine("Count is " + hash.Count);

            //Remove
            Console.WriteLine("--------------");
            Console.WriteLine("After Removing");
            hash.Remove("Microsoft");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //Contains
            Console.WriteLine("--------------");
            Console.WriteLine("Contains condition");
            if (hash.Contains("Sony"))
            {
                Console.WriteLine("Yes, This hash contain Japan");
            }
            else
            {
                Console.WriteLine("No,There is no Japan");
            }

            //CopyToArray
            Console.WriteLine("--------------");
            Console.WriteLine("After copying to array");
            ArrayList array= new ArrayList(hash.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
