using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public void Display()
        {
            Console.WriteLine("Country: "+DisplayCountry.Name);
            Console.WriteLine("Continent: "+DisplayCountry.Continent);
            
            foreach(String color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                if (Console.ForegroundColor == ConsoleColor.Black)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                    Console.WriteLine(color);
                
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
