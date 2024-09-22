using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// First namespace: PersonalInfo
namespace PersonalInfo
{
    // Class Person inside the PersonalInfo namespace
    public class Person
    {
        // Fields
        public string Name;
        public int Age;

        // Constructor to initialize Person object
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display person's information
        public void DisplayPersonInfo()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

// Second namespace: CompanyInfo
namespace CompanyInfo
{
    // Class Company inside the CompanyInfo namespace
    public class Company
    {
        // Fields
        public string CompanyName;
        public string Location;

        // Constructor to initialize Company object
        public Company(string companyName, string location)
        {
            CompanyName = companyName;
            Location = location;
        }

        // Method to display company's information
        public void DisplayCompanyInfo()
        {
            System.Console.WriteLine($"Company: {CompanyName}, Location: {Location}");
        }
    }
}

// Main Program
namespace AccessClassInDifferentNamespace
{
    class Program
    {
        // Main method
        /*static void Main(string[] args)
        {
            // Accessing the Person class from PersonalInfo namespace
            PersonalInfo.Person person = new PersonalInfo.Person("Sarita Shrestha", 20);
            person.DisplayPersonInfo();  // Call method to display person's information

            System.Console.WriteLine();

            // Accessing the Company class from CompanyInfo namespace
            CompanyInfo.Company company = new CompanyInfo.Company("TechCorp", "London");
            company.DisplayCompanyInfo();  // Call method to display company's information

            System.Console.ReadLine(); // To keep the console open
        }*/
    }
}

