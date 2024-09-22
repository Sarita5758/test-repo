using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    internal class QN8
    {
        public class Point2
        {
            // Fields
            public int X { get; set; }
            public int Y { get; set; }

            // Constructor to initialize the point
            public Point2(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Overload the binary plus operator
            public static Point2 operator +(Point2 p1, Point2 p2)
            {
                return new Point2(p1.X + p2.X, p1.Y + p2.Y);
            }

            // Overload the binary minus operator
            public static Point2 operator -(Point2 p1, Point2 p2)
            {
                return new Point2(p1.X - p2.X, p1.Y - p2.Y);
            }

            // Override ToString method to provide a string representation of the point
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
        internal class question8
        {
            /*static void Main(string[] args)
            {
                // Create Point objects
                Point2 p1 = new Point2(9, 4);
                Point2 p2 = new Point2(3, 1);

                // Display the points
                Console.WriteLine($"Point 1: {p1}");
                Console.WriteLine($"Point 2: {p2}");

                // Add the points
                Point2 sum = p1 + p2;
                Console.WriteLine($"Sum: {sum}");

                // Subtract the points
                Point2 difference = p1 - p2;
                Console.WriteLine($"Difference: {difference}");
                Console.ReadKey();
                Console.Read();
            }*/
        }
    }
}
