using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In the Toolbar select "Tools" then "NuGet Package Manager" then "Manage NuGet Package for Solution"
            // Search for "ValeuTuple" Select "System.ValueTuple" and install it

            int x = 0;

            (int playerNumber, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
            Console.WriteLine(ronaldo.playerNumber);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals);
            Console.WriteLine("--------------");

            var messi = (playerNumber: 10, playerName: "Messi", playerGoals: 60);
            Console.WriteLine(messi.playerNumber);
            Console.WriteLine(messi.playerName);
            Console.WriteLine(messi.playerGoals);
        }
    }
}
