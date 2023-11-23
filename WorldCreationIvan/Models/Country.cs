using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCreationIvan.Interfaces;

namespace WorldCreationIvan.Models
{
    public class Country : Region, IRegionable
    {
        private List<Region> countryRegionMemebers;

        public Country(string name, double square, double numberOfPeoplePerSquareMeter) 
            : base(name, square, numberOfPeoplePerSquareMeter)
        {
            countryRegionMemebers = new List<Region>();
        }

        public override double CalculateArea()
        {
            return countryRegionMemebers.Sum(region => region.CalculateArea());
        }

        public override double CalculatePopulation()
        {
            return countryRegionMemebers.Sum(region => region.CalculatePopulation());
        }

        public void AddRegion(Region region)
        {
            countryRegionMemebers.Add(region);
        }

        public override string ToString()
        {
            string result = $"Country " + base.ToString() + "\n";

            for(int i = 0; i < countryRegionMemebers.Count; i++)
            {
                result += countryRegionMemebers[i].ToString() + (i < countryRegionMemebers.Count - 1 ? "\n" : "");
            }

            return result;
        }
    }
}
