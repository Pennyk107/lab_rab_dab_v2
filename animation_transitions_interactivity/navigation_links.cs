using System;

class InteractiveElementsExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interactive Presentation");
        Console.WriteLine("1. Go to Next Slide");
        Console.WriteLine("2. Exit");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Moving to the next slide...");
                // Navigation logic
            }
            else if (input == "2")
            {
                Console.WriteLine("Exiting presentation.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}