using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{

    class CountryController
    {
        List<Country> CountryDb;

        public CountryController()
        {
            CountryDb = new List<Country> {
            new Country("Murica!", "North America", new List<string> { "Red", "White", "Blue" }),
            new Country("Cananada", "North America", new List<string> { "Red", "White" }),
            new Country("Blubbering", "Europe", new List<string>{"Green", "Yellow", "Blue", "Black"})
        };
        }

        public void CountryAction(Country c)
        {
            CountryView countryDisp = new CountryView(c);
            countryDisp.Display();
            
        }

        public void WelcomeAction()
        {
            bool loopProgram = true;
            while (loopProgram)
            {
                CountryListView cC = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                CountryListAction(); 
                loopProgram = Validator.Validator.getContinue("Would you like to check out another country?");

            }

            Console.WriteLine("Goodbye!");
        }

        public void CountryListAction()
        {
            CountryListView cC = new CountryListView(CountryDb);
            cC.Display();
            Console.WriteLine("Please enter the country's number to get more information.");
            int numberUsed = Validator.Validator.GetNumber(0, CountryDb.Count - 1);
            CountryAction(CountryDb[numberUsed]);
            

        }

    }
}
