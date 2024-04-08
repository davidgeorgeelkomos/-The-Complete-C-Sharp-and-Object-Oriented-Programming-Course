using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_bodied_Members
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumberFaster(2,3));
            Animal Dogs = new Animal();
            Dogs.Name = "Lolo";
            Dogs.Age = 2;
            Console.WriteLine(Dogs.Name);
        }
        public static int AddTwoNumberFaster (int x,int y) => x + y;
        public static int AddTwoNumbers(int x, int y) 
        {
            return x + y;
        }
    }
    class Animal
    {
        public Animal() => Console.WriteLine("New animal has been created" );
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get =>  name; 
            set => name = value; 
        }
    }
}
