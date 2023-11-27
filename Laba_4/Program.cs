using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double x, double y) a = (0, 0);
            (double x, double y) b = (4, 0);
            (double x, double y) c = (6, 3);
            (double x, double y) d = (2, 3);
            string color = "Blue";
            IsoscelesTrapezium trapezoid = new IsoscelesTrapezium(a, b, c, d, color);
            Console.WriteLine(trapezoid.Area());
        }
    }
}
