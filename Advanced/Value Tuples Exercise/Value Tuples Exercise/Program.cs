using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Tuples_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfPlayer = new List<(int PlayerNo, string PlayerNa, int PlayerGoals)>();

            listOfPlayer.Add((7, "Ronaldo", 60));
            listOfPlayer.Add((10, "Messi", 70));
            listOfPlayer.Add((10, "Salah", 60));
            listOfPlayer.Add((9, "Haaland", 45));

            foreach (var Player in listOfPlayer)
            {
                Console.WriteLine($"{Player.PlayerNo} - {Player.PlayerNa} - {Player.PlayerGoals}");
                Console.WriteLine("---------------");
            }
            Console.WriteLine("---------------");

            listOfPlayer.Sort();

            foreach (var Player in listOfPlayer)
            {
                Console.WriteLine($"{Player.PlayerNo} - {Player.PlayerNa} - {Player.PlayerGoals}");
                Console.WriteLine("---------------");
            }

        }
    }
}
