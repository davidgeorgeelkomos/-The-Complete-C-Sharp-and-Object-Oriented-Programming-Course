using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Animal_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            Animals cat = new Animals();
            Animals caw = new Animals();
            dog.Name = "Lolo";
            cat.Name = "bosbos";
            caw.Name = "momo";

            List<Animals> list = new List<Animals>();
            list.Add(dog);
            list.Add(cat);
            list.Add(caw);
            foreach ( var item in list)
            {
                item.SayHi();
                item.Feed();

            }

        }
        
    }
    class Animals
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("Hi my name is " + name);
        }
        public void Feed() 
        {
            Console.WriteLine(name + " is eating");         
        }
    }
}
