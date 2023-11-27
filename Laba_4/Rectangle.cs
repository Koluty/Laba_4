using Laba_4.Interface;
using System;


namespace Laba_4
{
    public class Rectangle : Point, IRectangle
    {
        public Rectangle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, string color) : base(a, b, c, d)
        {
            double AB = Length(A, B);
            double BC = Length(B, C);
            double CD = Length(C, D);
            double DA = Length(D, A);
            if (AB == CD && BC == DA)
            {
                Color = color;
            }
            else
            {
                throw new ArgumentException("The provided points do not form a rectangle.");
            }
        }
        public string Color { get; set; }
        public double Length((double x, double y) a, (double x, double y) b) => (double)(Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)));
        public virtual double Area()
        {
            double RectangleWidth = Length(A, B);
            double RectangleLength = Length(B, C);

            return RectangleLength * RectangleWidth;
        }
        public virtual double Perimeter()
        {
            double RectangleWidth = Length(A, B);
            double RectangleLength = Length(B, C);
            return 2 * (RectangleLength + RectangleWidth);
        }
        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
