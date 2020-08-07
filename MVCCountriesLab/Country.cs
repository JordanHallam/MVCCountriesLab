using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    public enum Continent
    {
        NorthAmerica,
        SouthAmerica,
        Antartica,
        Africa,
        Australia,
        Europe,
        Asia

    }
    class Country //MODEL
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
