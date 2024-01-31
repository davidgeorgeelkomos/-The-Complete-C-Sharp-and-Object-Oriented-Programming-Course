using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewWorldSpace;

namespace Country_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();

            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Languages.Arabic.ToString();
            countryLanguages.SecondLanguage = Languages.Japanese.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanteName = "Earth";
            countryOneInstance.CountryName = "Egypt";
            countryOneInstance.Currency = Currencies.EGP;
            countryOneInstance.Continents = Continents.Africa;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);

            Console.WriteLine($"Welcome to {countryOneInstance.PlanteName}, We live in {countryOneInstance.CountryName} that's in {countryOneInstance.Continents} that it's Currency is {countryOneInstance.Currency} and its language is {countryOneInstance.CountryLanguages}");
        }
    }
}
