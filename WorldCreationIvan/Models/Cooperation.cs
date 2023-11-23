using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCreationIvan.Interfaces;

namespace WorldCreationIvan.Models
{
    public class Cooperation : Region, IRegionable
    {
        private List<Region> memberCooperation;
        public Cooperation(string name, double square, double numberOfPeoplePerSquareMeter)
            : base(name, square, numberOfPeoplePerSquareMeter)
        {
            memberCooperation = new List<Region>();
        }

        public void AddRegion(Region region)
        {
            memberCooperation.Add(region);
        }

        public override double CalculateArea()
        {
            return memberCooperation.Sum(region => region.CalculateArea());
        }

        public override double CalculatePopulation()
        {
            return memberCooperation.Sum(region => region.CalculatePopulation());
        }

        public override string ToString()
        {
            string result = $"Cooperation " + base.ToString() + "\n";

            for (int i = 0; i < memberCooperation.Count; i++)
            {
                result += memberCooperation[i].ToString() + (i < memberCooperation.Count - 1 ? "\n" : "");
            }

            return result;
        }
    }
}
