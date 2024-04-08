using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football info = new Football();
            info.DisplayClub("ManUnited", "England");
            info.DisplayPlayerInformation("Ronaldo", "Al Nasr");             
        }
        class Football
        {
            private DisplayInformation displayInfoInstance;

            public Football()
            {
                displayInfoInstance = new DisplayInformation();
                displayInfoInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent;
                displayInfoInstance.DisplayDateBeforeEvent += DisplayInfoInstance_DisplayDateBeforeEvent;
            }

            private void DisplayInfoInstance_DisplayDateBeforeEvent()
            {
                Console.WriteLine("Program is about to display information ....");
            }

            public void DisplayInfoInstance_DisplayDateAfterEvent()
            {
                Console.WriteLine("Information has been displayed on " + DateTime.Now.ToShortDateString());
            }

            public void DisplayClub(string clubName,string country)
            {
                displayInfoInstance.DisplayClub(clubName,country);
            }
            public void DisplayPlayerInformation(string playerName,string country)
            {
                displayInfoInstance.DisplayPlayer(playerName,country);
            }
        }
        class DisplayInformation
        {
            public delegate void DisplayDateAfterDelegate();
            public delegate void DisplayDateBeforeDelegate();

            public event DisplayDateAfterDelegate DisplayDateAfterEvent;
            public event DisplayDateBeforeDelegate DisplayDateBeforeEvent;

            public void DisplayClub(string clubName ,string country)
            {
                DisplayDateBeforeEvent();
                Console.WriteLine($"{clubName} from {country}");
                DisplayDateAfterEvent(); Console.WriteLine();
            }
            
            public void DisplayPlayer(string playerName,string clubName)
            {
                DisplayDateBeforeEvent();
                Console.WriteLine($"{playerName} from {clubName}");
                DisplayDateAfterEvent();
            }
        }
    }
}
