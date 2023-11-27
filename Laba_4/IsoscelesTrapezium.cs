using System;

namespace Laba_4
{
    public class IsoscelesTrapezium : Rectangle
    {
        public IsoscelesTrapezium((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, string color) : base(a, b, c, d, color)
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
        public override double Area()
        {
            double UpperВase = Length(A, B);
            double LowerВase = Length(D, C);

            double LeftLateral = Length(A, D);
            double RightLateral = Length(B, C);

            double h = Math.Sqrt(Math.Pow(LeftLateral, 2) - Math.Pow((UpperВase - LowerВase) / 2, 2));
            return 0.5 * (UpperВase + LowerВase) * h;
        }
        public override double Perimeter()
        {
            double UpperВase = Length(A, B);
            double LowerВase = Length(D, C);

            double LeftLateral = Length(A, D);
            double RightLateral = Length(B, C);

            return UpperВase + LowerВase + LeftLateral + RightLateral;
        }
    }
}
