using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class CooperationTests
    {
        [TestMethod]
        public void IsCorrectPopulation_Cooperation()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Cooperation cooperation = new Cooperation("", 0, 0);

            cooperation.AddRegion(island);
            cooperation.AddRegion(metric);
            cooperation.AddRegion(peninsula);

            Assert.AreEqual(island.CalculatePopulation() + metric.CalculatePopulation() + peninsula.CalculatePopulation(),
                cooperation.CalculatePopulation());
        }

        [TestMethod]
        public void IsCorrectArea_Cooperation()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Cooperation cooperation = new Cooperation("", 0, 0);

            cooperation.AddRegion(island);
            cooperation.AddRegion(metric);
            cooperation.AddRegion(peninsula);

            Assert.AreEqual(island.CalculateArea() + metric.CalculateArea() + peninsula.CalculateArea(),
                cooperation.CalculateArea());
        }
    }
}
