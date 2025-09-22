using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.Write("Please enter the package weight: ");
        double weight;
        // Try parsing input and validating
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input for weight. Please enter a numeric value.");
            return;
        }

        // Check if weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit program
        }

        // Prompt for package width
        Console.Write("Please enter the package width: ");
        double width;
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Invalid input for width. Please enter a numeric value.");
            return;
        }

        // Prompt for package height
        Console.Write("Please enter the package height: ");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid input for height. Please enter a numeric value.");
            return;
        }

        // Prompt for package length
        Console.Write("Please enter the package length: ");
        double length;
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input for length. Please enter a numeric value.");
            return;
        }

        // Check if total dimensions exceed limit
        double dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit program
        }

        // Calculate shipping quote
        double quote = (width * height * length * weight) / 100.0;

        // Display the quote formatted to 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
