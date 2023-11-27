using Laba_4.Interface;
using System;

namespace Laba_4
{
    public class Rotate : IRotate
    {
        private (double x, double y) Midle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d)
        {
            double x = (a.x + b.x + c.x + d.x) / 4;
            double y = (a.y + b.y + c.y + d.y) / 4;
            return (x, y);
        }
        private (double x, double y) NewXY((double x, double y) a, in (double x, double y) middle, int turn)
        {
            double arg = (double)(turn * Math.PI / 180);
            double x = (double)(Math.Round((a.x - middle.x) * Math.Cos(arg) - (a.y - middle.y) * Math.Sin(arg) + middle.x, 2));
            double y = (double)(Math.Round((a.x - middle.x) * Math.Sin(arg) + (a.y - middle.y) * Math.Cos(arg) + middle.y, 2));
            return (x, y);
        }
        public ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) RotateFigure((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, int turn)
        {
            (double x, double y) middle = Midle(a, b, c, d);
            (double x, double y) newA = NewXY(a, middle, turn);
            (double x, double y) newB = NewXY(b, middle, turn);
            (double x, double y) newC = NewXY(c, middle, turn);
            (double x, double y) newD = NewXY(d, middle, turn);
            return (newA, newB, newC, newD);
        }
    }
}
