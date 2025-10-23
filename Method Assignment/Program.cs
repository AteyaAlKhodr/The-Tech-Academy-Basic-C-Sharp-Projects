using System; // Allows access to basic C# functionality like Console

namespace SimpleMathApp
{
    // Define a class that contains our method
    class MathOperations
    {
        // A void method that takes two integers
        public void PerformOperation(int num1, int num2)
        {
            // Do a simple math operation on the first number (add 5 to it)
            int result = num1 + 5;

            // Display the result of the math operation
            Console.WriteLine($"The result of adding 5 to {num1} is: {result}");

            // Display the second number
            Console.WriteLine($"The second number is: {num2}");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) an object of the MathOperations class
            MathOperations mathOp = new MathOperations();

            // Call the method using two numbers
            mathOp.PerformOperation(10, 20);

            // Call the same method again, but this time specify the parameters by name
            mathOp.PerformOperation(num1: 7, num2: 15);

            // Keep the console open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
