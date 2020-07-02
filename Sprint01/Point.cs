using System;

namespace Sprint01
{
    internal class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int[] GetXYPair()
        {
            return new int[2] { x, y };
        }

        protected internal double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

        protected internal double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2));
        }

        public static explicit operator double(Point point)
        {
            return point.Distance(0, 0);
        }
    }
}