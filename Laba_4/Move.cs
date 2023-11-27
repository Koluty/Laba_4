using Laba_4.Interface;

namespace Laba_4
{
    public class Move : IMove
    {
        private (double x, double y) MoveNewxy(in (double x, double y) a, in (double x, double y) move) => (a.x + move.x, a.y + move.y);
        public ((double x, double y), (double x, double y), (double x, double y), (double x, double y)) Moving((double x, double y) a, (double x, double y) b, (double x, double y) c, (double x, double y) d, in (double x, double y) move)
        {
            var newA = MoveNewxy(a, move);
            var newB = MoveNewxy(b, move);
            var newC = MoveNewxy(c, move);
            var newD = MoveNewxy(d, move);
            return (newA, newB, newC, newD);
        }
    }
}
