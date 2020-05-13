using System;

namespace areyesram
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object other)
        {
            var o = other as Point;
            if (o == null) return false;
            return X == o.X && Y == o.Y;
        }

        public override int GetHashCode()
        {
            return (X + "," + Y).GetHashCode();
        }
    }
}