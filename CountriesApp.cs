using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lab16_CountriesWithFileIO
{
    class CountriesApp
    {


        public static List<Country> GetCountries()

        {
            List<Country> countries = new List<Country>();

            Console.WriteLine("Please select an option 1-3:");
            Console.WriteLine(" 1) See the list of Countries, \n 2) Add a country, or \n 3) Exit: ");
            string userInput = Console.ReadLine();
            int userInput2 = Convert.ToInt32(userInput);

            if (userInput2 == 1)
            {
                foreach (Country country in countries)
                {
                    Console.WriteLine($"{country}");

                }
            }
            else if (userInput2 == 2)
            {
                Console.WriteLine("Please enter a country: ");
                string userInput3 = Console.ReadLine();
                userInput3.Add(new CountriesTextFile());
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
            return null;
        }
           
        
    }   

    
}
