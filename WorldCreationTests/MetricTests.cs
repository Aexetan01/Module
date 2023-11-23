using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorldCreationIvan.Models;

namespace WorldCreationTests
{
    [TestClass]
    public class MetricTests
    {
        [TestMethod]
        public void IsCreation_Metric()
        {
            string name = "Metric";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Metric metric = new Metric(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual((name, square, numberOfPeoplePerSquareMeter),
                (metric.Name, metric.Square, metric.NumberOfPeoplePerSquareMeter));
        }

        [TestMethod]
        public void IsCorrectArea_Metric()
        {
            string name = "Metric";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Metric metric = new Metric(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square, metric.CalculateArea());
        }

        [TestMethod]
        public void IsCorrectPopulation_Metric()
        {
            string name = "Metric";
            double square = 100;
            double numberOfPeoplePerSquareMeter = 100;

            Metric metric = new Metric(name, square, numberOfPeoplePerSquareMeter);
            Assert.AreEqual(square * numberOfPeoplePerSquareMeter, metric.CalculatePopulation());
        }
    }
}
