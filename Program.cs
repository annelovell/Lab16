using System;
using System.Collections.Generic;
using System.IO;

namespace Lab16_CountriesWithFileIO
{
    class Program: CountriesApp
    {
        public static void Main(string[] args)
        {
            

                List<Country> countries = new List<Country>
            {
                new Country("United States of America", "North America", "English"),
                new Country("Mexico", "North America", "Spanish"),
                new Country("Belgium", "Europe", "Dutch"),
                new Country("Nigeria", "Africa", "English"),
                new Country("Australia", "Australia", "Australian English"),
            };
        

        }
        
        
    }
}
