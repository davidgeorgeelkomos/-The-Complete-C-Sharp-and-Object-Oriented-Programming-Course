using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAboutDelegate
{

    //void delegate with one string and one int
    public delegate void PlayerInformationWithGoals(string name, int Goals);

    //void delegate with one string and one int
    public delegate string PlayerInformationBasedOnNumberAndClub(int goals, string club, string country = "Unknown");

    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerInformationWithGoals playerone = new PlayerInformationWithGoals(DisplayInformation);
            PlayerInformationBasedOnNumberAndClub playerTwo = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);

            //playerone("Ronaldo",60);
            //playerTwo(7, "Real Madrid");

            Console.WriteLine(playerTwo.Method);
            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType.Name} ,{item.Name}, {item.Position}, {item.IsOptional}, {item.DefaultValue}");
            }

        }
        public static void DisplayInformation(string playerName,int goals)
        {
            Console.WriteLine("Informaion About the player: " + playerName +"\n"+"He scored: " + goals);
        }
        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            // Some logic goes in here
            Console.WriteLine("Hi...");
            return string.Empty;
        }
    }
}
