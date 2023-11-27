using Laba_4.Interface;
using System;


namespace Laba_4
{
    public class Resize : IResize
    {
        public ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) ScalingRectangle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, double newSize)
        {
            if (newSize < 0)
            {
                throw new ArgumentException("New size must be a positive number.");
            }

            (double x, double y) newA = (a.x - newSize, a.y - newSize);
            (double x, double y) newB = (b.x - newSize, b.y + newSize);
            (double x, double y) newC = (c.x + newSize, c.y + newSize);
            (double x, double y) newD = (d.x + newSize, d.y - newSize);
            return (newA, newB, newC, newD);
        }
        public ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) ScalingTrapezoid((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, double newSize)
        {
            if (newSize < 0)
            {
                throw new ArgumentException("New size must be a positive number.");
            }

            (double x, double y) newA = (a.x - newSize, a.y);
            (double x, double y) newB = (b.x - newSize, b.y);
            (double x, double y) newC = (c.x + newSize, c.y);
            (double x, double y) newD = (d.x + newSize, d.y);
            return (newA, newB, newC, newD);
        }
    }
}
