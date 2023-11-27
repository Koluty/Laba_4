using Laba_4.Interface;
using System;

namespace Laba_4
{
    public class IsoscelesTrapezium : Point, IRectangle
    {
        public IsoscelesTrapezium((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, string color) : base(a, b, c, d)
        {
            double AB = Length(A, B);
            double BC = Length(B, C);
            double CD = Length(C, D);
            double DA = Length(D, A);
            // Check if BC equals DA and AB is parallel to CD
            if (BC == DA && (A.y - B.y) * (C.x - D.x) == (A.x - B.x) * (C.y - D.y))
            {
                Color = color;
            }
            else
            {
                throw new ArgumentException("The provided points do not form an isosceles trapezium.");
            }
        }
        public string Color { get; set; }
        public double Length((double x, double y) a, (double x, double y) b) => (double)(Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)));
        public double Area()
        {
            double UpperВase = Length(A, B);
            double LowerВase = Length(D, C);

            double LeftLateral = Length(A, D);
            double RightLateral = Length(B, C);

            double h = Math.Sqrt(Math.Pow(LeftLateral, 2) - Math.Pow((UpperВase - LowerВase) / 2, 2));
            return 0.5 * (UpperВase + LowerВase) * h;
        }
        public double Perimeter()
        {
            double UpperВase = Length(A, B);
            double LowerВase = Length(D, C);

            double LeftLateral = Length(A, D);
            double RightLateral = Length(B, C);

            return UpperВase + LowerВase + LeftLateral + RightLateral;
        }
        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
