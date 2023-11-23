using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCreationIvan.Interfaces;

namespace WorldCreationIvan.Models
{
    public class Union : Region, IRegionable
    {
        private List<Region> memberRegions;

        public Union(string name) :
            base(name)
        {
            memberRegions = new List<Region>();
        }

        public Union(string name, double square, double numberOfPeoplePerSquareMeter)
            : base(name, square, numberOfPeoplePerSquareMeter)
        {
            memberRegions = new List<Region>();
        }

        public override double CalculateArea()
        {
            return memberRegions.Sum(region => region.CalculateArea());
        }

        public override double CalculatePopulation()
        {
            return memberRegions.Sum(region => region.CalculatePopulation());
        }

        public void AddRegion(Region region)
        {
            memberRegions.Add(region);
        }

        public override string ToString()
        {
            string result = $"Union " + base.ToString() + "\n";

            for (int i = 0; i < memberRegions.Count; i++)
            {
                result += memberRegions[i].ToString() + (i < memberRegions.Count - 1 ? "\n" : "");
            }

            return result;
        }
    }
}
