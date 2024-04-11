using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768); // changed from another to new
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}"); // changed to put distance inside the brackets
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}"); // changed to put Point.ObjectCount inside brackets

        }
    }
    class Point
    {
        private readonly int x; // changed to read only
        private readonly int y; // changed to read only
        private static int objectCount = 0; // changed to static

        public Point() // deleted void
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }
        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        {
            return objectCount;
        }
    }

}
