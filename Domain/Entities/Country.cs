using System.Collections.Generic;

namespace OweWay.Domain.Entities
{
    public class Country
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        /// <summary>
        /// Offical language of the country
        /// </summary>
        public string Language { get; private set; }
        public long Population { get; private set; }
        /// <summary>
        /// Area in square kilometers
        /// </summary>
        public double Area { get; private set; } 
        
        public IEnumerable<Currency> Currencies { get; private set; } = new List<Currency>();

        public Country(string name, string language, long population, double area)
        {
            Name = name;           
            Language = language;
            Population = population;
            Area = area;
        }
        
        public void UpdatePopulation(long newPopulation)
        {
            if (newPopulation > 0) // Ensure valid population value
            {
                Population = newPopulation;
            }
        }
        
        public string GetCountryInfo()
        {
            return $"Country: {Name}, Language: {Language}, Population: {Population}, Area: {Area} sq km";
        }
    }
}
