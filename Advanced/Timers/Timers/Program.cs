using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 3000;
            timer.Enabled = true;

            Console.WriteLine("Press (X) to exit");
            while (Console.Read() != 'x');
            
        }

        private static void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Yes,it is workind " +DateTime.Now.ToLongTimeString());
        }
    }
}
