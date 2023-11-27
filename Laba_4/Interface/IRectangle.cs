
namespace Laba_4.Interface
{
    internal interface IRectangle
    {
        string Color { get; set; }
        double Length((double x, double y) a, (double x, double y) b);
        double Area();
        double Perimeter();
    }
}
