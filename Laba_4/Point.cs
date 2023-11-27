using Laba_4.Interface;

namespace Laba_4
{
    public class Point : IPoint
    {
        public Point((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d) 
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public (double x, double y) A { get; set; }
        public (double x, double y) B { get; set; }
        public (double x, double y) C { get; set; }
        public (double x, double y) D { get; set; }

    }
}

