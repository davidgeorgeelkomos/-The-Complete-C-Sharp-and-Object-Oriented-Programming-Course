using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_W_A_M_L_E
{
    //F_W_A_M_L_E is short to("Func with anonymous method and lambda expression")
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "David George";

            //Func
            Func<string, string> ConvertToUpper = UpperCasestring;
            Console.WriteLine("using Func ");
            Console.WriteLine(ConvertToUpper(name));
            Console.WriteLine("-----------");

            //Anonymous Method
            Func<string,string>  anonymousMetode = delegate(string myName) { return myName.ToUpper(); };
            Console.WriteLine("using Anonymous Method:");
            Console.WriteLine(anonymousMetode(name));
            Console.WriteLine("-----------");

            //Lambda expression
            Func<string,string> lambdaExpression = text => text.ToUpper();
            Console.WriteLine("using Lambda Expression");
            Console.WriteLine(lambdaExpression(name));


        }
        public static string UpperCasestring(string inputstring)
        {
            return inputstring.ToUpper();
        }
    }
}
