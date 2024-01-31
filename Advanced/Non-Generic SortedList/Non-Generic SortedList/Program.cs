using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Policy;

namespace Non_Generic_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            SortedList sortedList = new SortedList();

            //Adding
            sortedList.Add(5,"May");
            sortedList.Add(1,"Jan");
            sortedList.Add(3,"Mar");
            sortedList.Add(2,"Feb");
            sortedList.Add(4,"Apr");

            //Foreach
            Console.WriteLine("--------------");
            Console.WriteLine("Using Foreach");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //for
            Console.WriteLine("--------------");
            Console.WriteLine("Using For");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            //index
            Console.WriteLine("--------------");
            Console.WriteLine("In index");
            Console.WriteLine(sortedList[5].ToString());

            //Capasty
            Console.WriteLine("--------------");
            Console.WriteLine("Count is " + sortedList.Count);

            //Remove
            Console.WriteLine("--------------");
            Console.WriteLine("After Removing");
            sortedList.Remove(1);
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //Contains
            Console.WriteLine("--------------");
            Console.WriteLine("Contains condition");
            if (sortedList.Contains(2))
            {
                Console.WriteLine("Yes, This hash contain 2");
            }
            else
            {
                Console.WriteLine("No,There is no 2");
            }

            //CopyToArray
            Console.WriteLine("--------------");
            Console.WriteLine("After copying to array");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
