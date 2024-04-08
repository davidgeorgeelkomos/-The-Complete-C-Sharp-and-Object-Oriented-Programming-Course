using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Events
{
    public delegate void myDelegate(string name);
    internal class Program
    {
        public event myDelegate myEvent;

        public Program()
        {
            myEvent += new myDelegate(SayHiEnglish);
            myEvent += new myDelegate(SayHiArabic);
            myEvent += new myDelegate(SayHiItaly);
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.myEvent("jack");

        }
        public void SayHiEnglish(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
        public void SayHiArabic(string name)
        {
            Console.WriteLine($"Marhaba {name}");
        }
        public void SayHiItaly(string name)
        {
            Console.WriteLine($"Caio {name}");
        }
    }
}
