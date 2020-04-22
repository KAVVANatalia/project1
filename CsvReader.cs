using System;
using System.IO;
namespace test1{ 

class CsvReader{
private string _csvFilePath;

public CsvReader(string csvFilePath){
    this._csvFilePath= csvFilePath;
}

        public Country[] ReadFirstNCoutries(int nCountries){
    Country[] countries= new Country[nCountries];
    using (StreamReader sr = new StreamReader(_csvFilePath)){
        sr.ReadLine();
        for(int i = 0; i<nCountries; i++){
            string csvLine = sr.ReadLine();
            countries[i]= ReadCountryFromCsvLine(csvLine);
        }
    }
    return countries;
}


        public Country ReadCountryFromCsvLine(string csvLine)
{
    string [] parts  = csvLine.Split(',');
    string name = parts[0];
    string code = parts[1];
    string region = parts[2];
    int gdp= int.Parse(parts[3]);
    return new Country(name, code, region, gdp);

}
}

 
}