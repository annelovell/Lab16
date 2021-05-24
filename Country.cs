using System;
using System.Collections.Generic;
using System.IO;

namespace Lab16_CountriesWithFileIO
{
    class Country
    {
       public string Name { get; set; }
       public string Continent { get; set; }
       public string PrimaryLanguage { get; set; }
       
        public Country(string name, string continent, string primaryLanguage)
        {
            Name = name;
            Continent = continent;
            PrimaryLanguage = primaryLanguage;
            
        }
        public Country()
        {

        }
       
        
    }
}
