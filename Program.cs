using System;

class Program
{
    static void Main()
    {
        // Display welcome message required by the assignment
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask user for the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine()); // Convert input to a number

        // Check if the weight exceeds the limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program early
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if total dimensions exceed limit
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program early
        }

        // Calculate volume (height × width × length)
        double volume = width * height * length;

        // Calculate quote: (volume × weight) / 100
        double quote = (volume * weight) / 100;

        // Display quote formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}
