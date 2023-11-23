using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCreationIvan.Models
{
    public class Metric : Region
    {
        public Metric(string name, double square, double numberOfPeoplePerSquareMeter) : 
            base(name, square, numberOfPeoplePerSquareMeter) { }

        public override double CalculateArea()
        {
            return Square;
        }

        public override double CalculatePopulation()
        {
            return Square * NumberOfPeoplePerSquareMeter;
        }

        public override string ToString()
        {
            return $"Materic " + base.ToString();
        }
    }
}
