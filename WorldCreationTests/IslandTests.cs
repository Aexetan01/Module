using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class IslandTests
    {
        [TestMethod]
        public void IsCreation_Island()
        {
            string name = "Island";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual((name, square, numberOfPeoplePerSquareMeter), (island.Name, island.Square, island.NumberOfPeoplePerSquareMeter));
        }

        [TestMethod]
        public void IsCorrectArea_Island()
        {
            string name = "Island";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square, island.CalculateArea());
        }

        [TestMethod]
        public void IsCorrectPopulation_Island()
        {
            string name = "Island";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Island island = new Island(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square * numberOfPeoplePerSquareMeter, island.CalculatePopulation());
        }
    }
}
