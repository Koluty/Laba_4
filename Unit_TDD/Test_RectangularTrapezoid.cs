using Laba_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_TDD
{
    [TestClass]
    public class Test_RectangularTrapezoid
    {
        [TestMethod]
        public void RectangularTrapezoidCorrectCreate()
        {
            (double x, double y) a = (-4, 3);
            (double x, double y) b = (3, 3);
            (double x, double y) c = (7, -3);
            (double x, double y) d = (-3, -4);
            string color = "Blue";

            RectangularTrapezoid trapezoid = new RectangularTrapezoid(a, b, c, d, color);

            Assert.IsNotNull(trapezoid);
            Assert.AreEqual(color, trapezoid.Color);
        }
        [TestMethod]
        public void RectangularTrapezoidArea()
        {
            (double x, double y) a = (-1, 0);
            (double x, double y) b = (1, 0);
            (double x, double y) c = (3, 4);
            (double x, double y) d = (-3, 4);
            string color = "Blue";

            RectangularTrapezoid trapezoid = new RectangularTrapezoid(a, b, c, d, color);

            Assert.AreEqual(16, trapezoid.Area());
        }
        [TestMethod]
        public void RectangularTrapezoidPerimeter()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (4, 0);
            (double x, double y) c = (4, 3);
            (double x, double y) d = (0, 3);
            string color = "Blue";
            RectangularTrapezoid trapezoid = new RectangularTrapezoid(a, b, c, d, color);

            Assert.AreEqual(14, trapezoid.Perimeter());
        }
        [TestMethod]
        public void RectangularTrapezoidChangeColor()
        {
            (double x, double y) a = (-4, 3);
            (double x, double y) b = (3, 3);
            (double x, double y) c = (7, -3);
            (double x, double y) d = (-3, -4);
            string color = "Green";

            RectangularTrapezoid trapezoid = new RectangularTrapezoid(a, b, c, d, color);
            trapezoid.ChangeColor("Blue");
            Assert.AreEqual("Blue", trapezoid.Color);
        }
        [TestMethod]
        public void TrapezoidResize()
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (0, 2);
            (double x, double y) c = (4, 2);
            (double x, double y) d = (4, 0);
            string color = "Green";

            RectangularTrapezoid trap = new RectangularTrapezoid(a, b, c, d, color);
            Resize scl = new Resize();

            (trap.A, trap.B, trap.C, trap.D) = scl.ScalingTrapezoid(trap.A, trap.B, trap.C, trap.D, 1);

            Assert.AreEqual(trap.A, (-1, 0));
            Assert.AreEqual(trap.B, (-1, 2));
            Assert.AreEqual(trap.C, (5, 2));
            Assert.AreEqual(trap.D, (5, 0));
        }
        [TestMethod]
        public void RectangularTrapezoidChangeRotate()
        {
            (double x1, double y1) a = (0, 0);
            (double x2, double y2) b = (2, 0);
            (double x3, double y3) c = (4, 2);
            (double x4, double y4) d = (2, 2);
            string color = "Blue";

            RectangularTrapezoid trap = new RectangularTrapezoid(a, b, c, d, color);
            Rotate rot = new Rotate();

            (trap.A, trap.B, trap.C, trap.D) = rot.RotateFigure(trap.A, trap.B, trap.C, trap.D, 90);

            Assert.AreEqual((3, -1), trap.A);
            Assert.AreEqual((3, 1), trap.B);
            Assert.AreEqual((1, 3), trap.C);
            Assert.AreEqual((1, 1), trap.D);
        }
    }
}
