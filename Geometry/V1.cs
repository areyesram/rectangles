using System.Collections.Generic;
using System.Linq;

namespace areyesram.Geometry
{
    public class V1: IFinder
    {
        public Rectangle[] FindRectangles(Point[] points)
        {
            var unique = points.Distinct().ToArray();
            var candidates = unique
                .Select(p => new
                {
                    p1 = p,
                    p2 = unique.Where(o => o.X == p.X && o.Y > p.Y).ToArray(),
                    p3 = unique.Where(o => o.Y == p.Y && o.X > p.X).ToArray()
                }).Where(o => o.p2.Any() && o.p3.Any()).ToArray();
            var result = new List<Rectangle>();
            foreach (var c in candidates)
                foreach (var b in c.p2)
                    foreach (var a in c.p3)
                        if (unique.Any(o => o.X == a.X && o.Y == b.Y))
                            result.Add(new Rectangle(c.p1.X, c.p1.Y, a.X, b.Y));
            return result.ToArray();
        }
    }
}
