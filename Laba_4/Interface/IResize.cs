
namespace Laba_4.Interface
{
    internal interface IResize
    {
        ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) ScalingRectangle((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, double newSize);
        ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) ScalingTrapezoid((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, double newSize);
    }
}
