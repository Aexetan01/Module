using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class PeninsulaTests
    {
        [TestMethod]
        public void IsCreation_Peninsula()
        {
            string name = "Peninsula";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Peninsula peninsula = new Peninsula(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual((name, square, numberOfPeoplePerSquareMeter),
                (peninsula.Name, peninsula.Square, peninsula.NumberOfPeoplePerSquareMeter));
        }

        [TestMethod]
        public void IsCorrectArea_Peninsula()
        {
            string name = "Peninsula";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Peninsula island = new Peninsula(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square, island.CalculateArea());
        }

        [TestMethod]
        public void IsCorrectPopulation_Peninsula()
        {
            string name = "Peninsula";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Peninsula peninsula = new Peninsula(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square * numberOfPeoplePerSquareMeter, peninsula.CalculatePopulation());
        }
    }
}
