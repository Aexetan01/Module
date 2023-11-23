using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCreationIvan.Models
{
    public class Peninsula : Island
    {
        public Peninsula(string name, double square, double numberOfPeoplePerSquareMeter)
            : base(name, square, numberOfPeoplePerSquareMeter)
        {
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }

        public override double CalculatePopulation()
        {
            return base.CalculatePopulation();
        }

        public override string ToString()
        {
            return $"Peninsula " + base.ToString();
        }
    }
}
