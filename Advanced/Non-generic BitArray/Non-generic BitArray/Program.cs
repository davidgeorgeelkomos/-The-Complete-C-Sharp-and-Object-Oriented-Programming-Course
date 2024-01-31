using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Non_generic_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray FirstArray = new BitArray(4);
            BitArray SecondArray = new BitArray(boolArray);

            //Setting Value
            FirstArray.Set(0,false);
            FirstArray.Set(1,false);
            FirstArray.Set(2,true);
            FirstArray.Set(3,true);

            //Display
            foreach (var item in FirstArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            foreach (var item in SecondArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            //AND - OR - NOT
            BitArray result = new BitArray(4);
            Console.WriteLine("AND");
            result = FirstArray.And(SecondArray);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            Console.WriteLine("OR");
            result = FirstArray.Or(SecondArray);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

            Console.WriteLine("NOT");
            result = FirstArray.Not();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");

        }
    }
}
