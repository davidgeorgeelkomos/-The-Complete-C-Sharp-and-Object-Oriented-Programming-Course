using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dogs dogs= new Dogs();
            Birds bird = new Birds();
        }
    }

    class Animal
    {
        public string animalName;
        public DateTime animalBirthDate;

        public void FeedAnima()
        {

        }
    }

    class Dogs : Animal
    {
        public string dogBreed;
        public string dogIntellgence;
        public bool isEasyToTrian;
    }

    class Birds :Animal
    {
        public string birdColor;
        public string birdCountry;
    }
}
