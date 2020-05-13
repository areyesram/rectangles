﻿using System.Collections.Generic;
using System.Linq;

namespace areyesram
{
    public class Geometry
    {
        public static Rectangle[] FindRectangles(Point[] points)
        {
            var candidates = points.Select(p => new
            {
                p1 = p,
                p2 = points.Where(o => o != p && o.X == p.X && o.Y != p.Y).ToArray(),
                p3 = points.Where(o => o != p && o.Y == p.Y && o.X != p.X).ToArray()
            }).Where(o => o.p2.Any() && o.p3.Any()).ToArray();
            var result = new List<Rectangle>();
            foreach (var c in candidates)
                foreach (var b in c.p2)
                    foreach (var a in c.p3)
                        if (points.Any(o => o.X == a.X && o.Y == b.Y))
                            result.Add(new Rectangle(c.p1.X, c.p1.Y, a.X, b.Y));
            return result.ToArray();
        }
    }
}