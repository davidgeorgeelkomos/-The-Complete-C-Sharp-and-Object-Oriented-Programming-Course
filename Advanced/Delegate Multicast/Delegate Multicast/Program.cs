using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Multicast
{
    internal class Program
    {
        public delegate void sayHiDelegate(); 
        static void Main(string[] args)
        {
            sayHiDelegate SayHi = null;

            SayHi = new sayHiDelegate(sayHiArabic);
            SayHi += new sayHiDelegate(sayHiEnglish);
            SayHi += new sayHiDelegate(sayHiSpanish);
            SayHi += new sayHiDelegate(sayHiGermany);
            SayHi += new sayHiDelegate(sayHiJapan);

            SayHi();

        }
        public static void sayHiEnglish()
        {
            Console.WriteLine("Hi");
        }
        public static void sayHiArabic()
        {
            Console.WriteLine("Marhaba");
        }
        public static void sayHiGermany()
        {
            Console.WriteLine("Hallo");
        }
        public static void sayHiJapan()
        {
            Console.WriteLine("Kon Nichiwa");
        }
        public static void sayHiSpanish()
        {
            Console.WriteLine("Hola");
        }

    }
}
