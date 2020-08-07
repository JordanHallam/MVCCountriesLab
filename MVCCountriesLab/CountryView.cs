using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry;

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Here is information about a country");
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine($"Flag Colors: {DisplayCountry.Colors}");

        }
    }
}
