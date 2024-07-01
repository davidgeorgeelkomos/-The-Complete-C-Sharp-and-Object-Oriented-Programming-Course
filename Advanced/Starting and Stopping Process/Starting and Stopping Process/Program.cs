using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Starting_and_Stopping_Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process.Start("Notepad.exe");
          //  Process.Start(@"C:\Users\a2aka\D\Games\Dynasty Warriors 6\DW6_WIN.exe");
           // Process.Start("http://www.youtube.com");
            Process[] notepads = Process.GetProcessesByName("Notepad");
            foreach (var process in notepads)
            {
              process.Kill();
            }
        }
    }
}
