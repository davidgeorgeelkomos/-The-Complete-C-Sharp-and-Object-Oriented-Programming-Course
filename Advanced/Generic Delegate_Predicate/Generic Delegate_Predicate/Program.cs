using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = IsAdmin;
            Console.WriteLine(predicate(10));
        }
        public static bool IsAdmin(int empNo)
        {
            if(empNo == 10)
                return true;
            else
                return false;     
        }
    }
}
