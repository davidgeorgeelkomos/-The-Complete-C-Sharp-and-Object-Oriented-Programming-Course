using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_of_Animals_and_Trainers_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals Dog = new Animals();
            Dog.Name = "Lolo";

            Animals Cat = new Animals();
            Cat.Name = "Bosbos";

            Animals dog = new Animals();
            dog.Name = "Soso";

            Trainers mohy = new Trainers();
            mohy.TrainerName = "Mohy";

            ArrayList list = new ArrayList();
            list.Add(Dog);
            list.Add(Cat);
            list.Add(dog);
            list.Add(mohy);

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType()) 
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else
                {
                    ((Trainers)item).SayHi();
                }
            }
        }
        
        struct Animals
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            
            public void SayHi()
            {
                Console.WriteLine("Hi ,I am an Animal my name is "+name);
            }
            public void Feed()
            {
                Console.WriteLine(name + " is now eating");
            }

        }

        struct Trainers
        {
            private string trainer;

            public string TrainerName
            {
                get { return trainer; }
                set { trainer = value; }
            }

            public void SayHi()
            {
                Console.WriteLine("Hi , I am the Trainer my name is "+ trainer);
            }

        }
    }
}
