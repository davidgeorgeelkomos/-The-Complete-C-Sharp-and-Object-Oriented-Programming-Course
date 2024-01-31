using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptaionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int x = 0;
                int y = 0;
                double div = 0;
                Console.WriteLine("Type your First Nom...");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Type your second Nom...");
                y = int.Parse(Console.ReadLine());
                div = x / y;

                Console.WriteLine(div);

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            finally
            {
                
            }
            Console.ReadLine();

        }
    }
}
