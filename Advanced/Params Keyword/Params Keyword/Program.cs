using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray(new string[4] {"John","Tramp","Obama","Biden"});
            Console.WriteLine("--------------");
            LoopThroughArray("Ahmad", "Mohamad", "Aly", "Aya");
        }

        public static void LoopThroughArray(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
