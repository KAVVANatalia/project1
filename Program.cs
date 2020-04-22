using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Users\project1\gdp2019.csv";
            CsvReader reader = new CsvReader(filePath);
            Country[] countries =reader.ReadFirstNCoutries(5);

            foreach(Country country in countries){
            Console.WriteLine($"{country.GDP}:{country.Region}:{country.Name}");
            }
        }
    }
}
