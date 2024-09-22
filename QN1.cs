using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarita.Lab2
{
    internal class QN1
    {
        class Employee
        {
            // Fields
            public string Name;
            public string Email;
            public double Salary;

            // Constructor to initialize the Employee object
            public Employee(string name, string email, double salary)
            {
                Name = name;
                Email = email;
                Salary = salary;
            }

            // Method to display employee details
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Salary: {Salary:C}"); // Format as currency
            }
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create an employee object using the constructor
                Employee emp = new Employee("John Doe", "john.doe@example.com", 50000);

                // Display the employee details
                emp.DisplayEmployeeDetails();

                Console.ReadLine(); // To prevent the console from closing immediately
            }*/
        }
    }
}
