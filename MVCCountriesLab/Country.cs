using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class Country
    {
        public string Name;
        public string Continent;
        public List<string> Colors;

        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
