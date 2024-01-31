using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int q = 2;

            Console.WriteLine("Number x is " + q);


            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.200m;

            Console.WriteLine("Double is " + double_num + " Float is " + float_num + " Decimal is " + decimal_num);

            string firstName, lastName, House;

            firstName = "David";
            lastName = " George";
            House = "Mikhail";

            Console.WriteLine(firstName + lastName + " " + House);

            /////////////

            bool IsWorking;

            IsWorking = true;
            Console.WriteLine(IsWorking);

            int sam;
            sam = 0;

            int number1, number2;
            number1 = 1;
            number2 = 2;
            sam = number1;
            Console.WriteLine(sam);

            int serialNo = 100;
            string accountNom = "";
            float anyNo = 3.9f;

            accountNom = serialNo.ToString();

            Console.WriteLine(accountNom);
            //print the closest
            serialNo = Convert.ToInt32(anyNo);

            Console.WriteLine(serialNo);
            //only print first number
            serialNo = (int)anyNo;

            Console.WriteLine(serialNo);

            ////////////

            //var can do anything
            int w = 5;
            string name0 = "David";

            var test = name0;

            Console.WriteLine(test);
            //max value
            int e = 0;
            e = int.MaxValue;

            Console.WriteLine(e);

            //////////////

            // Now(give the date with the sec) Today (give only the date) and you can put the time by yourself
            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);

            Console.WriteLine(myDate.AddYears(-7));
            //"M" = 9      "MM" = 09    "MMM" = Sept   "MMMM" = September
            string formattedDate = string.Format("Date is {0:dddd \n d 'of' 'sept' 2017}", myDate);

            Console.WriteLine(formattedDate);

            /////////////

            Console.WriteLine("What is your name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Welcome " + name1);

            ///////////
            int r, t;
            int add, sub, mult, rem;
            float div;

            Console.WriteLine("Type your first number:");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine("Type Your Second number:");
            t = int.Parse(Console.ReadLine());

            Console.WriteLine("that's your choice.");
            add = r + t;
            Console.WriteLine(r + " + " + t + " = " + add);

            sub = r - t;
            Console.WriteLine(r + " - " + t + " = " + sub);

            mult = r * t;
            Console.WriteLine(r + " * " + t + " = " + mult);

            rem = r % t;
            Console.WriteLine(r + " % " + t + " = " + rem);

            div = (float)r / (float)t;
            Console.WriteLine(r + " / " + t + " = " + div);

            /////////////
            ///

            int y, u;

            Console.WriteLine("Type your first number");
            y = int.Parse((string)Console.ReadLine());

            Console.WriteLine("Type your second number");
            u = int.Parse((string)Console.ReadLine());

            if (y > u)
            {
                Console.WriteLine(y + " is greater then " + u);
            }
            else if (y < u)
            {
                Console.WriteLine(u + " is greater then " + y);
            }
            else
            {
                Console.WriteLine(y + " is equal to the " + u);
            }

            /////////////
            ///

            Console.WriteLine("Are you enjoying C#? ('yes' or 'no')");
            string input = Console.ReadLine();

            switch (input)
            {
                case "yes":
                    Console.WriteLine("Good for you.");
                    break;

                case "no":
                    Console.WriteLine("too bad for you.");
                    break;

                default:
                    Console.WriteLine("That's not the correct answer.");
                    break;
            }



            /////////////
            ///

            Console.WriteLine("Please type any number to see is it even or odd");

            int.TryParse(Console.ReadLine(), out int i);
            if (i == 0)
            {
                Console.WriteLine("Please put a number not letter.");
            }
            else
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("This is an even number");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("This is an odd number");
                }
                else
                {
                    Console.WriteLine("This is not a number.");
                }
            }


            ///////////////
            ///use Tryprase instead of prase put it when you want the code not crash when the user puts a letter not a number


            Console.WriteLine("Hi,What is your name?");
            string p = Console.ReadLine();
            Console.WriteLine("Hi " + p + ", My name is C#, How old are you?");
            int.TryParse(Console.ReadLine(), out int o);
            if (o == 0)
            {
                Console.WriteLine("Please Put a number not letter.");
            }
            else
            {
                int cs_age = DateTime.Now.Year - 2002;
                Console.WriteLine(o + " wow, As for me i was born in 2002, That make me " + cs_age + " years old");
            }

            /////////////////
            ///43


            string movieName = "    lord of the rings   ";

            //index
            Console.WriteLine(movieName[6]);

            //Trim Case
            Console.WriteLine(movieName.Trim());

            //Upper Case
            Console.WriteLine(movieName.ToUpper().Trim());

            //Lower Case
            Console.WriteLine(movieName.ToLower().Trim());

            //Length Case
            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);

            //Reaplce Case
            Console.WriteLine(movieName.Replace('l', 'L'));

            ////////
            ///44

            string tvShow = "Game of Thrones";

            //Index of
            Console.WriteLine(tvShow.IndexOf('o'));

            //Last Index of
            Console.WriteLine(tvShow.LastIndexOf('o'));

            //Substring     //if it was negative it will give from the last letter 
            Console.WriteLine(tvShow + tvShow.Substring(tvShow.Length - 1));
            Console.WriteLine(tvShow.Substring(8));
            Console.WriteLine(tvShow.Substring(5, 2));

            //Remove
            Console.WriteLine(tvShow.Remove(8));

            //Insert
            Console.WriteLine(tvShow.Insert(0, "The "));


            //////////
            ///45

            string tvShow1 = "Game of thronse   ";
            string oneseason = "Season 1";
            string newName = "";

            newName = tvShow1.Insert(tvShow1.Length, oneseason);
            Console.WriteLine(newName.Trim());

            /////////
            ///46

            Console.WriteLine("Admonz said \"Hi \t \n \t A2A\"");



            /////////
            ///47
            //there is three ways to type name 
            string nameee = "";
            Console.WriteLine("What is your name?");
            nameee = Console.ReadLine();
            Console.WriteLine("Welcome back " + nameee);
            Console.WriteLine("Welcome back {0}", nameee);
            Console.WriteLine($"Welcome back {nameee}");


            ///////
            ///48
            //loop

            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a + ": Hi");
            }
            for (int s = 10; s >= 1; s--)
            {
                if (s == 5)
                    break;
                Console.WriteLine(s + ": Hi");
            }


            /////////
            ///49
            //loooop2
            int d = 10;
            while (d >= 1)
            {
                Console.WriteLine("Game Of Thrones Season 0" + d);
                d--;
            }
            int f = 1;
            do
            {
                Console.WriteLine("do no." + f);
                f++;
            } while (f <= 10);


            //////////
            ///49
            //loooop3

            for (int h = 1; h <= 20; h++)
            {
                for (int g = 1; g <= 20; g++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }


            ///////////
            ///50
            //exercise
            for (int j = 0; j <= 100; j += 2)
            {

                int jj = 0;
                int jjj = 2;
                jj = j + jjj;
                Console.Write(jj + ",");
                if (jj == 100)
                {
                    break;
                }
            }
            Console.WriteLine();
            //or
            for (int k = 0; k <= 101; k++)
            {
                if (k % 2 == 0)
                    Console.Write(k + ",");
            }
            ///
            for (int l = 0; l <= 20; l++)
            {
                for (int zz = 0; zz <= l; zz++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }


            ////////
            ///51/52
            //Math

            double z = 5.365;

            //ceiling
            Console.WriteLine("Ceiling:" + Math.Ceiling(z));
            //floor
            Console.WriteLine("Floor: " + Math.Floor(z));
            //round
            Console.WriteLine("Round: " + Math.Round(z, 2));
            //truncate
            Console.WriteLine("Truncate: " + Math.Truncate(z));


            int x = 9;
            int c = 4;

            //max
            Console.WriteLine("Max: " + Math.Max(x, c));
            //min
            Console.WriteLine("Min: " + Math.Min(x, c));
            //sqrt
            Console.WriteLine("Sqrt: " + Math.Sqrt(x));
            //pow
            Console.WriteLine("Pow: " + Math.Pow(3, 2));


            /////////
            ///53
            //random number

            Random rand = new Random();
            int v = 0;
            v = rand.Next(1, 7);
            Console.WriteLine("The dice: " + v);

            double b = 0;
            b = rand.NextDouble() * v;
            Console.WriteLine("Randome Double Number: " + Math.Round(b, 3));


            ////////
            ///53
            //Arrays

            int[] nambers = new int[5] { 1, 10, 100, 1000, 10000 };
            string[] weekss = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int n = 0; n < nambers.Length; n++)
            {
                Console.WriteLine(nambers[n]);
            }
            foreach (var item in weekss)
            {
                Console.WriteLine(item);
            }

            /////////
            ///56
            //Assignments

            for (int m = 20; m >= 0; m--)
            {
                for (int mm = 0; mm <= m; mm++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }

            int[] dayss = new int[12] { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
            string[] monthss = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "Novamber", "Desamber" };
            for (int dd = 0; dd < dayss.Length; dd++)
            {
                Console.WriteLine(monthss[dd] + " - " + dayss[dd]);
            }

            string answer;
            bool repeat_question = true;

            while (repeat_question)
            {
                Console.Write("Roll dice? ");
                answer = Console.ReadLine().Trim().ToLower();
                if (answer == "yes")
                {
                    Random randome = new Random();
                    int ss = 0;
                    ss = randome.Next(1, 7);
                    Console.WriteLine("The dice: " + ss);
                }
                else if (answer == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                }
            }
            Console.ReadLine();
        }
    }

}
/////////                     *The End*                         \\\\\\\\\\\\\
