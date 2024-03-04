using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Recursive_Methods_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = @"C:\Users\a2aka\D\Games";
            Console.WriteLine(path);
            DisplayFolders(path, 0);
        }
        public static void DisplayFolders(string path,int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder, indent);
            }
        }
    }
}
