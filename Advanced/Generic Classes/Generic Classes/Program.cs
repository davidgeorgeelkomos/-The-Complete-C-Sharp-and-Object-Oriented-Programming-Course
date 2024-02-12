using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building<int> empireState = new Building<int>();
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;
            Console.WriteLine("Name " + empireState.Name);
            Console.WriteLine("City " + empireState.City);
            Console.WriteLine("Height " + empireState.Height);
            Console.WriteLine("Weight " + empireState.Weight);
            Console.WriteLine("---------------");

            Building<double> burjKhalifa = new Building<double>();
            burjKhalifa.Name = "Burj Khalifa";
            burjKhalifa.City = "Dubai";
            burjKhalifa.Height = 830;
            burjKhalifa.Weight = 450000;
            Console.WriteLine("Name " + burjKhalifa.Name);
            Console.WriteLine("City " + burjKhalifa.City);
            Console.WriteLine("Height " + burjKhalifa.Height);
            Console.WriteLine("Weight " + burjKhalifa.Weight);
            Console.WriteLine("---------------");

            Building<float> eiffelTower = new Building<float>();
            eiffelTower.Name = "Eiffel Tower";
            eiffelTower.City = "Paris";
            eiffelTower.Height = 324;
            eiffelTower.Weight = 7300;
            Console.WriteLine("Name " + eiffelTower.Name);
            Console.WriteLine("City " + eiffelTower.City);
            Console.WriteLine("Height " + eiffelTower.Height);
            Console.WriteLine("Weight " + eiffelTower.Weight);
            Console.WriteLine("---------------");
        }

        class Building<T>
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string city;

            public string City
            {
                get { return city; }
                set { city = value; }
            }
            private T height;

            public T Height
            {
                get { return height; }
                set { height = value; }
            }
            private T weight;

            public T Weight
            {
                get { return weight; }
                set { weight = value; }
            }



        }
    }
}
