using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListViewer
    {
        public List<Country> Countries;
        public CountryListViewer(List<Country> countires)
        {
            Countries = countires;
        }
        
        public void Display()
        {
            for (int index = 0; index > Countries.Count; index++)
            {
                Console.WriteLine($"{index} {Countries[index].Name}");
            }
        }
    }
}
