using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    public class Shape
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class Rectangle from Shape
    public class Rectangle : Shape
    {
        // Constructor for Rectangle which calls base class constructor
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }
    internal class QN10
    {
       /*static void Main(string[] args)
       {
           // Create an instance of Rectangle using the parameterized constructor
           Rectangle rect = new Rectangle(10, 5);

           // Display the dimensions and area of the rectangle
           Console.WriteLine($"Length: {rect.Length}");
           Console.WriteLine($"Breadth: {rect.Breadth}");
           Console.WriteLine($"Area of Rectangle: {rect.CalculateArea()}");
               Console.ReadKey();
               Console.Read();
       }*/
    }
}
