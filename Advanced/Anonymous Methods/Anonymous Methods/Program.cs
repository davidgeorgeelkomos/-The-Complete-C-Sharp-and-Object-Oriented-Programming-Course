using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoWithNumber(int Number);
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInfo);
            normalDelegate();

            DisplayInfoWithNumber OneParameterDelegate = new DisplayInfoWithNumber(GetInfo);
            OneParameterDelegate(200);

            Console.WriteLine("-----------");

            DisplayInfo normalDelegateAnonymous = delegate{ Console.WriteLine("Hi from the Anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoWithNumber OneParameterDelegateAnonymouns = delegate (int number) { Console.WriteLine("Hi from the anonymous method which takes one parameter: "+ number); };
            OneParameterDelegateAnonymouns(15);

        }
        public static void GetInfo()
        {
            Console.WriteLine("Delegate With No Information");
        }
        public static void GetInfo(int x)
        {
            Console.WriteLine("Delegate with one parameter: " + x);
        }
    }
}
