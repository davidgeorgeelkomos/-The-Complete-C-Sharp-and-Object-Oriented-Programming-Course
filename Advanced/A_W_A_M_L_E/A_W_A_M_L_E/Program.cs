using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_W_A_M_L_E
{
    //A_W_A_M_L_E is short to("Action with anonymous method and lambda expression")

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "David";
            //Action
            Action<string> actionMessage = ShowMeMessage;
            Console.WriteLine("Using Action :");
            actionMessage(name);
            Console.WriteLine("---------");

            //Anonymous Method
            Action<string> anonymousMetode = delegate (string myName) { Console.WriteLine($"Hi, how are you today,{myName}?"); };
            Console.WriteLine("Using Anonymous Method :");
            anonymousMetode(name);
            Console.WriteLine("----------");

            //Lambda Expression
            Action<string> anonymousExpression = text => Console.WriteLine($"Hi, how are you today,{text}?");
            Console.WriteLine("Using Lambda Expression :");
            anonymousExpression(name);


        }
        public static void ShowMeMessage(string name)
        {
            Console.WriteLine($"Hi, how are you today,{name}?");
        }
    }
}
