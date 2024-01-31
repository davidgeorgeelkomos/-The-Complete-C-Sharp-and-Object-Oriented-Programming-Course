using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Orienteds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //60
            //    //Mathod 1 | 2
            //    int e, r, t, y;
            //    e = 3;
            //    r = 4;
            //    Displaymessage(e, r);
            //    t = 15;
            //    y = 43;
            //    Displaymessage(t, y);

            //    ////////
            //    /// 62
            //    /// exercise
            //    string userName = "";
            //    Console.WriteLine("What is your name?");
            //    userName = retarnName();
            //    Console.WriteLine("Hi " + userName);

            //    ////////////
            //    ///63
            //    ///Mathod 3

            //    string firstemployee, secondemployee;
            //    firstemployee = "David ";
            //    secondemployee = "Sophia ";

            //    Console.WriteLine($"Inside Mian Mathod:\n--------\n{firstemployee}\n{secondemployee}\n\n");

            //    ChagneNames(out firstemployee, ref secondemployee);

            //    Console.WriteLine($"Inside Mian Mathod:\n--------\n{firstemployee}\n{secondemployee}\n\n");


            ///////////
            ///64
            ///mathode 4

            //string guestName = "";

            //Console.WriteLine("Hello!, Dear guest, What's your name?");

            //guestName = Console.ReadLine();
            //if (guestName == string.Empty)
            //{
            //    WelcomeGeust();
            //}
            //else
            //{
            //    WelcomeGeust(guestName);
            //}

            ///////////
            ///65
            ///exercise

            //int u, i, o, intresult;
            //double p, a, s, doubleresult;
            //u = 2;
            //i= 3;
            //o = 4;
            //intresult = 0;

            //doubleresult= 0;
            //p = 9.7;
            //a = 4.6;
            //s = 0.72;

            //Console.WriteLine($"{u} + {i} = {PreformAdd(u, i)}");
            //Console.WriteLine($"{u} + {i} + {o}={PreformAdd(u, i, o)}");
            //Console.WriteLine($"{p} + {a} = {PreformAdd(p, a)}");
            //Console.WriteLine($"{p} + {a} + {s}= {PreformAdd(p, a, s)}");

            ///////////
            ////66:67
            ////class:constructors

            //person perOne = new person();
            //perOne.FirstNamee = "Ahmad";
            //perOne.LastNamee = "Mohey";
            //perOne.Country = "Egypt";
            //Console.WriteLine(perOne.FirstNamee);

            //person perTwo = new person();
            //perTwo.FirstNamee = "David";
            //perTwo.LastNamee = "A2A";
            //perTwo.Country = "Canada";
            //Console.WriteLine(perTwo.FirstNamee);

            //person perThree= new person();

            //Console.WriteLine(perThree.FirstNamee);

            ///////////////
            ////70
            ////scope
            

            
            



        }


        //static int PreformAdd(int num1,int num2)
        //{
        //    return num1 + num2;
        //}
        //static int PreformAdd(int num1, int num2,int num3)
        //{
        //    return num1 + num2 + num3;
        //}
        //static double PreformAdd(double num1, double num2)
        //{
        //    return num1 + num2;
        //}
        //static double PreformAdd(double num1, double num2,double num3)
        //{
        //    return num1 + num2 + num3;
        //}

        //static void WelcomeGeust()
        //{
        //    ///64
        //    Console.WriteLine("Okey, We hope you enjoy your time.");
        //}

        //static void WelcomeGeust(string name)
        //{
        //    ///64
        //    Console.WriteLine($"Thank you {name}, We hope you enjoy your time.");
        //}


        //static void ChagneNames(out string firstemp, ref string secondemp)
        //{
        //    //by the "out" you can create a new method but by "ref" you must announce the variable first
        //    //63
        //    firstemp = "Mohamad";
        //    secondemp = "Mona";
        //    Console.WriteLine($"Outside Mian Mathod:\n--------\n{firstemp}\n{secondemp}\n\n");

        //}
        //static void Displaymessage(int q, int w)
        //{
        //    ///60
        //    int endresult = 0;
        //    endresult = q + w;
        //    Console.WriteLine($"{q} + {w} = {endresult}");
        //    Console.WriteLine("Proces is done");
        //    Console.WriteLine("These proces is run by A2A");
        //    Console.WriteLine("Finish Time is: " + DateTime.Now.ToShortTimeString());
        //}

        //static string retarnName()
        //{
        //    ////62
        //    string userName = Console.ReadLine();
        //    return userName;

        //}
        //////

        ////////




    }
    //class person
    //{
    //    string fristNamee;
    //    string lastNamee;
    //    DateTime bithDate;
    //    string country;

    //    public string FirstNamee
    //    {
    //        get { return fristNamee; }
    //        set { fristNamee = value; }
    //    }
    //    public string LastNamee
    //    {
    //        get { return lastNamee; }
    //        set { lastNamee = value; }
    //    }
    //    public DateTime BirthDate { get; set; }
    //    public string Country { get; set; }
    //    public person()
    //    {
    //        fristNamee = "Unknow";
    //    }
    //}

    //class Scope
    //{
    //    string dogBreed;
    //    string dogName;
    //    string dogColor;
        
    //    public void TraingDog()
    //    {
    //        string trainerName;
    //    }


    //}

    

}
