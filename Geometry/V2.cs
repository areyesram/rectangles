using System.Linq;

namespace areyesram.Geometry
{
    internal class V2 : IFinder
    {
        public Rectangle[] FindRectangles(Point[] points)
        {
            var unique = points.Distinct().ToArray();
            var candidates = unique
                .SelectMany(p1 => unique.Where(p2 => p2.X == p1.X && p2.Y > p1.Y)
                    .Select(p2 => new QuadPoint
                    {
                        P1 = p1,
                        P2 = p2
                    })
                )
                .SelectMany(o => unique.Where(p3 => p3.Y == o.P1.Y && p3.X > o.P1.X)
                    .Select(p3 => new QuadPoint
                    {
                        P1 = o.P1,
                        P2 = o.P2,
                        P3 = p3
                    }))
                .Where(o => unique.Any(p4 => p4.X == o.P3.X && p4.Y == o.P2.Y))
                .Select(o => new Rectangle(o.P1.X, o.P1.Y, o.P3.X, o.P2.Y))
                .ToArray();
            return candidates;
        }
    }
}
