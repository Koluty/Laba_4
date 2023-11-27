using Laba_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_TDD
{
    [TestClass]
    public class Test_IsoscelesTrapezium
    {
        [TestMethod]
        public void IsoscelesTrapeziumCorrectCreateLength()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Blue";

            IsoscelesTrapezium trap = new IsoscelesTrapezium(a, b, c, d, color);

            Assert.IsNotNull(trap);
            Assert.AreEqual(color, trap.Color);
        }
        [TestMethod]
        public void IsoscelesTrapeziumFailCreate()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (2, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Assert.ThrowsException<System.ArgumentException>(() => new IsoscelesTrapezium(a, b, c, d, color));
        }
        [TestMethod]
        public void IsoscelesTrapeziumArea()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (4, 0);
            (double x, double y) c = (6, 3);
            (double x, double y) d = (2, 3);
            string color = "Blue";

            IsoscelesTrapezium trap = new IsoscelesTrapezium(a, b, c, d, color);

            Assert.AreEqual(14.42, Math.Round(trap.Area(), 2));
        }
        [TestMethod]
        public void IsoscelesTrapeziumPerimeter()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Green";

            IsoscelesTrapezium trap = new IsoscelesTrapezium(a, b, c, d, color);

            Assert.AreEqual(9.66, Math.Round(trap.Perimeter(), 2));
        }
        [TestMethod]
        public void IsoscelesTrapeziumChangeColor()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Green";

            IsoscelesTrapezium trap = new IsoscelesTrapezium(a, b, c, d, color);
            trap.ChangeColor("Blue");

            Assert.AreEqual("Blue", trap.Color);
        }
    }
}
