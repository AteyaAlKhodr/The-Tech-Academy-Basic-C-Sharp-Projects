using System; // Provides access to Console and other basic functionality

namespace InterfaceExampleApp
{
    // Define an interface called IQuittable
    // Interfaces specify methods that must be implemented by any class that inherits from them
    interface IQuittable
    {
        // Define a void method called Quit() with no implementation
        // Any class that implements this interface must define how Quit() works
        void Quit();
    }

    // Create an Employee class that inherits from the IQuittable interface
    class Employee : IQuittable
    {
        // Define three public properties for the Employee class
        public int Id { get; set; }          // Employee's unique identifier
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name

        // Implement the Quit() method required by the IQuittable interface
        public void Quit()
        {
            // Display a message to indicate that the employee has quit
            Console.WriteLine($"{FirstName} {LastName} (Employee ID: {Id}) has quit the job.");
        }
    }

    // The Program class contains the Main() method — the starting point of the application
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and assign values to its properties
            Employee emp = new Employee
            {
                Id = 101,
                FirstName = "Ateya",
                LastName = "AlKhodr"
            };

            // Use polymorphism:
            // We create an object of type IQuittable, but assign it to an Employee instance
            // This works because Employee implements the IQuittable interface
            IQuittable quitter = emp;

            // Call the Quit() method using the IQuittable interface reference
            // The Employee class's version of Quit() will be executed
            quitter.Quit();

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
