using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Value_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ronaldoGoals = (Year2015: 50, Year2016: 60, Year2017: 70);
            var ronaldo = (PlayerNa: "Ronaldo", PlayerNum: 7, PlayerGoals: ronaldoGoals);
            Console.WriteLine(ronaldo.PlayerNa);
            Console.WriteLine(ronaldo.PlayerNum);
            Console.WriteLine(ronaldo.PlayerGoals.Year2015);
            Console.WriteLine(ronaldo.PlayerGoals.Year2016);
            Console.WriteLine(ronaldo.PlayerGoals.Year2017);
        }
    }
}
