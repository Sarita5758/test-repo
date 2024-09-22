using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Single Inheritance
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    // Multi-Level Inheritance
    public class Puppy : Dog
    {
        public void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }

    // Hierarchical Inheritance
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }
    internal class QN4
    {
         /*static void Main(string[] args)
         {
             // Demonstrating Single Inheritance
             Dog dog = new Dog { Name = "Dog" };
             dog.Eat();   // Method from base class
             dog.Bark();  // Method from derived class

             // Demonstrating Multi-Level Inheritance
             Puppy puppy = new Puppy { Name = "Puppy" };
             puppy.Eat(); // Method from base class
             puppy.Bark(); // Method from intermediate class
             puppy.Play(); // Method from derived class

             // Demonstrating Hierarchical Inheritance
             Cat cat = new Cat { Name = "Cat" };
             cat.Eat();  // Method from base class
             cat.Meow(); // Method from derived class
             Console.Read();
             Console.ReadKey();
         }*/
    }
}
