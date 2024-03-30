using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //void delegate with no argument
    public delegate void PlayerInfDel();
    //void delegate with string
    public delegate void PlayerWithNameDel(string name);
    //void delegate with string and one int
    public delegate void PlayerWithNameGoalsDel(string name,int goals);
    //void delegate with int 
    public delegate void PlayerWithGoalsDel(int goals);

    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerInfDel ronaldo = new PlayerInfDel(DisplayInformaion);
            ronaldo();
            PlayerWithNameDel PlayerName = new PlayerWithNameDel(DisplayInformaion);
            PlayerName("Messi");
            PlayerWithNameGoalsDel NamePlayer = new PlayerWithNameGoalsDel(DisplayInformaion);
            NamePlayer("Hallend", 60);
            PlayerWithGoalsDel PlayerGoals = new PlayerWithGoalsDel(DisplayInformaion);
            PlayerGoals(8);
        }
        public static void DisplayInformaion()
        {
            Console.WriteLine("Informaion about the player: Ronaldinho");
        }
        public static void DisplayInformaion(string playerName)
        {
            Console.WriteLine("Informaion about the player: " + playerName);
        }
        public static void DisplayInformaion(string playerName,int goals)
        {
            Console.WriteLine("Informaion about the player: " +playerName +"Goals: " +goals );
        }
        public static string DisplayInformaion(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: (playerName) = "Ronaldo";break;
                case 8: (playerName) = "Iniesta";break;
                case 9: (playerName) = "Messi";break;
                default:break;
            }
            return playerName;
        }
    }
}
