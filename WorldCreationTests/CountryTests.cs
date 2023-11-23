using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class CountryTests
    {
        [TestMethod]
        public void IsCorrectPopulation_Country()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Country country = new Country("", 0, 0);

            country.AddRegion(island);
            country.AddRegion(metric);
            country.AddRegion(peninsula);

            Assert.AreEqual(island.CalculatePopulation() + metric.CalculatePopulation() + peninsula.CalculatePopulation(),
                country.CalculatePopulation());
        }

        [TestMethod]
        public void IsCorrectArea_Country()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Country country = new Country("", 0, 0);

            country.AddRegion(island);
            country.AddRegion(metric);
            country.AddRegion(peninsula);

            Assert.AreEqual(island.CalculateArea() + metric.CalculateArea() + peninsula.CalculateArea(),
                country.CalculateArea());
        }
    }
}
