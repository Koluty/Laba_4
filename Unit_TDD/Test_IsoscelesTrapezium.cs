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
        [TestMethod]
        public void IsoscelesTrapezoidMove()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Blue";

            IsoscelesTrapezium trapezoid = new IsoscelesTrapezium(a, b, c, d, color);
            Move pos = new Move();

            (trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D) = pos.Moving(trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D, (1, 0));

            Assert.AreEqual((1, 0), trapezoid.A);
            Assert.AreEqual((3, 0), trapezoid.B);
            Assert.AreEqual((5, 2), trapezoid.C);
            Assert.AreEqual((3, 2), trapezoid.D);
        }
        [TestMethod]
        public void IsoscelesTrapezoidResize()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Green";

            IsoscelesTrapezium trapezoid = new IsoscelesTrapezium(a, b, c, d, color);
            Resize scl = new Resize();

            (trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D) = scl.ScalingTrapezoid(trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D, 1);

            Assert.AreEqual(trapezoid.A, (-1, 0));
            Assert.AreEqual(trapezoid.B, (1, 0));
            Assert.AreEqual(trapezoid.C, (5, 2));
            Assert.AreEqual(trapezoid.D, (3, 2));
        }
        [TestMethod]
        public void IsoscelesTrapezoidChangeRotate()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (2, 0);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (2, 2);
            string color = "Blue";

            IsoscelesTrapezium trapezoid = new IsoscelesTrapezium(a, b, c, d, color);
            Rotate rot = new Rotate();

            (trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D) = rot.RotateFigure(trapezoid.A, trapezoid.B, trapezoid.C, trapezoid.D, 90);

            Assert.AreEqual(trapezoid.A, (3, -1));
            Assert.AreEqual(trapezoid.B, (3, 1));
            Assert.AreEqual(trapezoid.C, (1, 3));
            Assert.AreEqual(trapezoid.D, (1, 1));
        }
    }
}
