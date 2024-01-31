using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            List<string> Firstlist= new List<string>();
            IList<string> Secondlist= new List<string>();

            //Adding
            Firstlist.Add("England");
            Firstlist.Add("China");
            Firstlist.Add("Germmany");
            //Displaying
            foreach (var item in Firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            //Index
            Console.WriteLine("After Chenging ...");
            Firstlist[2] = "Egypt";
            foreach (var item in Firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            //Capacity
            Console.WriteLine("Count is "+ Firstlist.Count);
            Console.WriteLine("-----------");

            //Sorting
            Console.WriteLine("After sorting....");
            Firstlist.Sort();
            foreach (var item in Firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");

            //Reversing
            Firstlist.Reverse();
            Console.WriteLine("After Reversing....");
            foreach (var item in Firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");

            //Contains
            if (Firstlist.Contains("China"))
            {
                Console.WriteLine("This list Contains China");
            }
            else
            {
                Console.WriteLine("This list does not contain China");
            }
            Console.WriteLine("-------------");

            //GetRange
            Secondlist = Firstlist.GetRange(0, 2);
            Console.WriteLine("Now we are in the second list");
            foreach (var item in Secondlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            //Removing
            Firstlist.Remove("China");
            Console.WriteLine("After Removing.....");
            foreach (var item in Firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            //Remove All
            Firstlist.Clear();

            
        }
    }
}
