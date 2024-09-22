using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    public class Point
    {
        // Fields
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
    internal class QN7
    {
        /*static void Main(string[] args)
        {
            Point point = new Point(18, -9);

            Console.Write("Original ");
            point.Display();

            Point negatedPoint = -point;

            Console.Write("Negated ");
            negatedPoint.Display();
            Console.Read();
            Console.ReadKey();
        }*/
    }
}