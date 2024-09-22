using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    public class Box<T>
    {
        // Private field to store the item
        private T _item;

        // Constructor to initialize the box with an item
        public Box(T item)
        {
            _item = item;
        }

        // Method to get the item
        public T GetItem()
        {
            return _item;
        }

        // Method to set a new item
        public void SetItem(T item)
        {
            _item = item;
        }
    }

    // Define a generic method to swap two values
    public static class Utils
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    internal class  QN11
    {
        static void Main(string[] args)
        {
            // Create a Box instance for an integer
            Box<int> intBox = new Box<int>(123);
            Console.WriteLine($"Integer in box: {intBox.GetItem()}"); // Output: Integer in box: 123

            // Create a Box instance for a string
            Box<string> stringBox = new Box<string>("Hello Dot Net");
            Console.WriteLine($"String in box: {stringBox.GetItem()}"); // Output: String in box: Hello

            // Use the Swap method
            int a = 22, b = 30;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            Utils.Swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            string first = "First", second = "Second";
            Console.WriteLine($"Before swap: first = {first}, second = {second}");
            Utils.Swap(ref first, ref second);
            Console.WriteLine($"After swap: first = {first}, second = {second}");
            Console.ReadKey();
            Console.Read();
        }
    }
}
