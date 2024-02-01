using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValuePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var capital = new List<KeyValuePair<string, string>>();

            capital.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capital.Add(new KeyValuePair<string, string>("Sweeden", "stockholm"));
            capital.Add(new KeyValuePair<string, string>("Portual", "Lisbon"));
            capital.Add(new KeyValuePair<string, string>("Japan", "Tokyo"));
            capital.Add(new KeyValuePair<string, string>("Egypt", "Cairo"));

            capital.RemoveAt(4);
            foreach (var item in capital)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine(GetFristAndSecondName().Value);
            Console.WriteLine(GetFristAndSecondName().Key);

        }
        public static KeyValuePair<string,string> GetFristAndSecondName()
        {
            string FristName = "Tony";
            string SecondName = "Stark";
            return new KeyValuePair<string,string>(FristName, SecondName);
        }
    }
}
