using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCreationIvan.Interfaces;

namespace WorldCreationIvan.Models
{
    public abstract class Region : IAreaCalculatable, IPopulationCalculatable
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public double NumberOfPeoplePerSquareMeter { get; set; }

        public Region(string name)
        {
            Name = name;
            Square = 0;
            NumberOfPeoplePerSquareMeter = 0;
        }
        public Region(string name, double square, double numberOfPeoplePerSquareMeter)
        {
            Name = name;
            Square = square;
            NumberOfPeoplePerSquareMeter = numberOfPeoplePerSquareMeter;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePopulation();

        public override string ToString()
        {
            return $"Name: {Name}. Square: {CalculateArea()}. Population: {CalculatePopulation()}.";
        }
    }
}
