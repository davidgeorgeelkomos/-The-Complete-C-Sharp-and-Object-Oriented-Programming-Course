using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate_Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> actionOne = DisplayInfo;
            actionOne(09995000);

            Action actionTwo = DisplayInfo;
            actionTwo();
        }
        public static void DisplayInfo(int number)
        {
            Console.WriteLine("Daniel De Rossi number is : " + number);
        }
        public static void DisplayInfo()
        {
            Console.WriteLine("Gabrial Batista");
        }
    }
}
