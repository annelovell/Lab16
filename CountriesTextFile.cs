using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab16_CountriesWithFileIO
{
    class CountriesTextFile
    {
        public Dictionary<string, Country> CountryDictionary { get; set; }

        public CountriesTextFile()
        {
            List<string> countries = new List<string>();
            StreamReader reader = new StreamReader("../../../Countries.txt");
            string line = reader.ReadLine();
            
           while(line != null)
            {
                string[] split = line.Split('|');
                Country country = new Country(split[0], split[1], split[2]);
                CountryDictionary.Add(split[0], country);
                
            }
            reader.Close();
           
            StreamWriter writer = new StreamWriter("../../../Countries.txt");
            foreach(string country in countries)
            {
                writer.WriteLine($"");
            }
            writer.Close();
        }
    }
}
