using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class UnionTests
    {
        [TestMethod]
        public void IsCorrectPopulation_Union()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Union union = new Union("");

            union.AddRegion(island);
            union.AddRegion(metric);
            union.AddRegion(peninsula);

            Assert.AreEqual(island.CalculatePopulation() + metric.CalculatePopulation() + peninsula.CalculatePopulation(),
                union.CalculatePopulation());
        }

        [TestMethod]
        public void IsCorrectArea_Union()
        {
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island("Island", square, numberOfPeoplePerSquareMeter);
            Metric metric = new Metric("Metric", square, numberOfPeoplePerSquareMeter);
            Peninsula peninsula = new Peninsula("Peninsula", square, numberOfPeoplePerSquareMeter);

            Union union = new Union("");

            union.AddRegion(island);
            union.AddRegion(metric);
            union.AddRegion(peninsula);

            Assert.AreEqual(island.CalculateArea() + metric.CalculateArea() + peninsula.CalculateArea(),
                union.CalculateArea());
        }
    }
}
