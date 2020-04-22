using System;

namespace test1
{
    class Country
    {
        public string Name{get;}
        public string Code{get;}
        public string Region{get;}
        public int GDP{get;}

       public Country(string name, string code, string region, int gdp){
           this.Name = name;
           this.Code = code;
           this.Region=region;
           this.GDP=gdp;
       }
    }
}