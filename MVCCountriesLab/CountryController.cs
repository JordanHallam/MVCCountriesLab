using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryController
    {
        List<Country> CountryDB { get; set; }
        
        public CountryController()
        {
            List<string> countryColors = new List<string>()
            {
                "Red white and Blue", "Red and White", "Black, Green, Red, Blue, Yellow, and White"
            };
            CountryDB.Add(new Country() { Name = "France", Continent = Continent.Europe, Colors = countryColors });
            CountryDB.Add(new Country() { Name = "Canada", Continent = Continent.NorthAmerica, Colors = countryColors });
            CountryDB.Add(new Country() { Name = "South Africa", Continent = Continent.Africa, Colors = countryColors });
        }
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            CountryListViewer clv = new CountryListViewer(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            clv.Display();
            int index = int.Parse(Console.ReadLine());
            
            CountryAction(CountryDB[index]);
        }
    }
}
