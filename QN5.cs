using System;

namespace VirtualMethodExample
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class 1
    class Dog : Animal
    {
        // Overriding the virtual method
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        // Overriding the virtual method
        public override void Sound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            // Base class reference, but object of derived class
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Calling the virtual method, which invokes the overridden method
            myDog.Sound(); // Output: Dog barks
            myCat.Sound(); // Output: Cat meows
        }*/
    }
}
