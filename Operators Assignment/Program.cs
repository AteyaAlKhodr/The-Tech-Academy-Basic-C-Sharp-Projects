using System; // Provides basic system functionality like Console

namespace EmployeeComparisonApp
{
    // Define a simple Employee class
    class Employee
    {
        // Properties to store employee details
        public int Id { get; set; }          // Employee's unique identifier
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name

        // Overload the "==" operator to compare Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both are null — if yes, they are considered equal
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If one is null and the other is not, they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare their Id properties to determine equality
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator — it must be overloaded in pair with "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the already defined "==" operator to determine inequality
            return !(emp1 == emp2);
        }

        // Override Equals() to ensure consistency with the overloaded operators
        public override bool Equals(object obj)
        {
            // If obj is not an Employee, return false
            if (obj == null || GetType() != obj.GetType())
                return false;

            // Cast the object to Employee and compare Ids
            Employee other = (Employee)obj;
            return Id == other.Id;
        }

        // Override GetHashCode() because Equals() was overridden
        public override int GetHashCode()
        {
            // Use Id's hash code since Id uniquely identifies an employee
            return Id.GetHashCode();
        }
    }

    // Main program class that runs when the application starts
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values to its properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "Ateya",
                LastName = "AlKhodr"
            };

            // Create the second Employee object and assign values to its properties
            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Ahmed",
                LastName = "Ateya"
            };

            // Compare the two Employee objects using the overloaded "==" operator
            Console.WriteLine("Comparing two employees using '==':");
            Console.WriteLine(emp1 == emp2); // Will print False since Ids differ

            // Compare the same two Employee objects using the overloaded "!=" operator
            Console.WriteLine("\nComparing two employees using '!=':");
            Console.WriteLine(emp1 != emp2); // Will print True since Ids differ

            // For demonstration, create another Employee with the same Id as emp1
            Employee emp3 = new Employee
            {
                Id = 1,
                FirstName = "Mohamed",
                LastName = "Ahmed"
            };

            // Compare emp1 and emp3 — should be equal because Ids match
            Console.WriteLine("\nComparing emp1 and emp3 using '==':");
            Console.WriteLine(emp1 == emp3); // Will print True since Ids are the same

            // Keep console open so user can view results
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
