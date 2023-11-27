
namespace Laba_4.Interface
{
    internal interface IRotate
    {
        ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) RotateFigure((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, int turn);
    }
}
