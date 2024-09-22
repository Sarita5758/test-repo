using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    public class SimplePerson
    {
        // Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Read-only property
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        // Computed property with validation
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0) // Validation: Age must be non-negative
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }

        // Constructor to initialize properties
        public SimplePerson(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age; // Uses the computed property with validation
        }

        // Method to display person details
        public void DisplayInfo()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    internal class QN9
    {
        /*static void Main(string[] args)
        {
            // Create an instance of SimplePerson
            SimplePerson person = new SimplePerson("Sarita", "Shrestha", 22);

            // Display person's information
            person.DisplayInfo();

            // Attempt to set an invalid age
            person.Age = -5; // This will trigger the validation message

            // Display updated person's information
            person.DisplayInfo();
            Console.ReadKey();
            Console.Read();
        }*/
    }
}
