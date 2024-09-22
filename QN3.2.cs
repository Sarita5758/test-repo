using System;

namespace PartialClassExample
{
    public partial class Person
    {
        public int Age;

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Program
    {
       /* static void Main(string[] args)
        {
            // Create an instance of the partial Person class
            Person person = new Person("Sarita", "Shrestha");
            person.Age = 20;

            // Call methods from different parts of the partial class
            person.DisplayFullName();
            person.DisplayAge();

            Console.ReadLine(); // Keep console open
        }*/
    }
}
