using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var list = new List<movie<double, DateTime>>();

            var JohnWick = new movie<double, DateTime>();
            JohnWick.Name = "John Wick ";
            JohnWick.Director = "Chad Stahelski";
            JohnWick.Rate = 7.4;
            JohnWick.Release = new DateTime(2014,10,24);


            var JohnWickChapter2 = new movie<double, DateTime>();
            JohnWickChapter2.Name = "John Wick: Chapter 2 ";
            JohnWickChapter2.Director = "Chad Stahelski";
            JohnWickChapter2.Rate = 7.4;
            JohnWickChapter2.Release = new DateTime(2017, 2, 9);
            
            var JohnWickChapter3 = new movie<double, DateTime>();
            JohnWickChapter3.Name = "John Wick: Chapter 3 – Parabellum  ";
            JohnWickChapter3.Director = "Chad Stahelski";
            JohnWickChapter3.Rate = 7.4;
            JohnWickChapter3.Release = new DateTime(2019, 5, 17);
            
            var JohnWickChapter4 = new movie<double, DateTime>();
            JohnWickChapter4.Name = "John Wick: Chapter 4";
            JohnWickChapter4.Director = "Chad Stahelski";
            JohnWickChapter4.Rate = 7.7;
            JohnWickChapter4.Release = new DateTime(2023, 3, 24);


            list.Add(JohnWick);
            list.Add(JohnWickChapter2);
            list.Add(JohnWickChapter3);
            list.Add(JohnWickChapter4);

            
        }

        class movie<T , U>
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string director;

            public string Director
            {
                get { return director; }
                set { director = value; }
            }

            private U release;

            public U Release
            {
                get { return release; }
                set { release = value; }
            }

            private T rate;

            public T Rate
            {
                get { return rate; }
                set { rate = value; }
            }


        }
    }
}
