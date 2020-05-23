using System.Collections.Generic;
using System.Linq;

namespace areyesram.Geometry
{
    internal class V3 : IFinder
    {
        public Rectangle[] FindRectangles(Point[] points)
        {
            var result = new List<Rectangle>();
            var unique = points.Distinct().ToArray();
            var lookup = unique.ToDictionary(k => k.GetHashCode(), v => v);
            foreach (var p1 in unique)
            {
                foreach (var p3 in unique.Where(p => p.X > p1.X && p.Y > p1.Y))
                {
                    if (lookup.ContainsKey(new Point(p1.X, p3.Y).GetHashCode())
                        && lookup.ContainsKey(new Point(p3.X, p1.Y).GetHashCode()))
                        result.Add(new Rectangle(p1.X, p1.Y, p3.X, p3.Y));
                }
            }
            return result.ToArray();
        }
    }
}
