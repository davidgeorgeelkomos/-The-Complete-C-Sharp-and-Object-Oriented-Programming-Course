
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Tuples_with_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ronaldo = (7, "Ronaldo", 60);
            var giggs = (10, "Giggs", 40);

            DisplayPlayerInformaion(ronaldo);
            DisplayPlayerInformaion(giggs);
            DisplayPlayerInformaion(DisplayPlayerInformaion());

        }
        public static void DisplayPlayerInformaion((int PlayerNo,string PlayerName,int PlayerGoals)player)
        {
            Console.WriteLine(player.PlayerNo);
            Console.WriteLine(player.PlayerName);
            Console.WriteLine(player.PlayerGoals);
            Console.WriteLine("-------------");
        }
        public static (int,string,int) DisplayPlayerInformaion()
        {
            var messi = (10, "Messi", 70);
            return messi;
        }
    }
}
