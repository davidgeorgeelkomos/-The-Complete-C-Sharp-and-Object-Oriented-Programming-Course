using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Exercise
{
    internal class Program
    {
        public delegate void PlayerNameGoals(Dictionary<string, int> Players);
        static void Main(string[] args)
        {
            Dictionary<string,int> players = new Dictionary<string,int>();
            players.Add("Messi", 60);
            players.Add("Ronaldo", 59);
            players.Add("Neymar", 58);

            PlayerNameGoals player = new PlayerNameGoals(Displayer);
            player(players);

        }
        public static void Displayer(Dictionary<string,int> Players)
        {
            foreach (var player in Players)
            {
                Console.WriteLine($"Player name is: {player.Key} \nAnd he scored: {player.Value}");
                Console.WriteLine("---------------");
            }
        }
    }
}
