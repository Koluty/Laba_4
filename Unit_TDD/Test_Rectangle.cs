using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba_4;

namespace Unit_TDD
{
    [TestClass]
    public class Test_Rectangle
    {
        [TestMethod]
        public void RectangleCorrectCreateLength()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Rectangle rec = new Rectangle(a, b, c, d, color);

            Assert.AreEqual(2, rec.Length(a, b));
            Assert.AreEqual(4, rec.Length(c, b));
            Assert.AreEqual(2, rec.Length(c, d));
            Assert.AreEqual(4, rec.Length(d, a));
        }
        [TestMethod]
        public void RectangleFailCreate()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (2, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Assert.ThrowsException<System.ArgumentException>(() => new Rectangle(a, b, c, d, color));
        }
        [TestMethod]
        public void RectangleArea()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Rectangle rec = new Rectangle(a, b, c, d, color);

            Assert.AreEqual(8, rec.Area());
        }
        [TestMethod]
        public void RectanglePerimeter()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Green";
            Rectangle rec = new Rectangle(a, b, c, d, color);
            Assert.AreEqual(12, rec.Perimeter());
        }
        [TestMethod]
        public void RectangleChangeColor()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Green";

            Rectangle rec = new Rectangle(a, b, c, d, color);
            rec.ChangeColor("Blue");
            Assert.AreEqual("Blue", rec.Color);
        }
        [TestMethod]
        public void RectangleMove()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Rectangle rec = new Rectangle(a, b, c, d, color);
            Move pos = new Move();

            (rec.A, rec.B, rec.C, rec.D) = pos.Moving(rec.A, rec.B, rec.C, rec.D, (1, 0));

            Assert.AreEqual(rec.A, (1, 0));
            Assert.AreEqual(rec.B, (1, 2));
            Assert.AreEqual(rec.C, (5, 2));
            Assert.AreEqual(rec.D, (5, 0));
        }
        [TestMethod]
        public void RectangleResize()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Green";

            Rectangle rec = new Rectangle(a, b, c, d, color);
            Resize scl = new Resize();

            (rec.A, rec.B, rec.C, rec.D) = scl.ScalingRectangle(rec.A, rec.B, rec.C, rec.D, 1);

            Assert.AreEqual(rec.A, (-1, -1));
            Assert.AreEqual(rec.B, (-1, 3));
            Assert.AreEqual(rec.C, (5, 3));
            Assert.AreEqual(rec.D, (5, -1));
        }

        [TestMethod]
        public void RectangleChangeRotate()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Blue";

            Rectangle rec = new Rectangle(a, b, c, d, color);
            Rotate rot = new Rotate();

            (rec.A, rec.B, rec.C, rec.D) = rot.RotateFigure(rec.A, rec.B, rec.C, rec.D, 90);

            Assert.AreEqual(rec.A, (3, -1));
            Assert.AreEqual(rec.B, (1, -1));
            Assert.AreEqual(rec.C, (1, 3));
            Assert.AreEqual(rec.D, (3, 3));
        }
        [TestMethod]
        public void RectangularTrapezoidMove()
        {
            (double x1, double y1) a = (0, 0);
            (double x2, double y2) b = (2, 0);
            (double x3, double y3) c = (4, 2);
            (double x4, double y4) d = (2, 2);
            string color = "Blue";

            RectangularTrapezoid trap = new RectangularTrapezoid(a, b, c, d, color);
            Move pos = new Move();

            (trap.A, trap.B, trap.C, trap.D) = pos.Moving(trap.A, trap.B, trap.C, trap.D, (1, 0));

            Assert.AreEqual(trap.A, (1, 0));
            Assert.AreEqual(trap.B, (3, 0));
            Assert.AreEqual(trap.C, (5, 2));
            Assert.AreEqual(trap.D, (3, 2));
        }
    }
}
