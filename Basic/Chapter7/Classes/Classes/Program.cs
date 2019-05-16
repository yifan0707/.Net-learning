using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(23, 56);
            Point p2 = new Point(22, 100);
            double distance = p1.CalDistance(p2);
            Console.WriteLine("Total Point Count: " + Point.GetPointCount());
            Console.ReadKey();
        }
    }

    class Point
    {
        private int x, y;
        private static int pointCount = 0;

        public Point()
        {
            x = -1;
            y = -1;
            pointCount++;
            Console.WriteLine("Default constructor called");
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            pointCount++;
            Console.WriteLine($"x: {x}, y: {y}");
        }

        public double CalDistance(Point p)
        {
            int xDiff = this.x - p.GetX();
            int yDiff = this.y - p.GetY();
            double result = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
            Console.WriteLine($"result: {result}");
            return result;
        }

        public static int GetPointCount()
        {
            return pointCount;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

    }
}
