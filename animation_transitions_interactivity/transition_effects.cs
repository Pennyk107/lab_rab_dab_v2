using System;
using System.Threading;

class SlideTransitionExample
{
    static void Main(string[] args)
    {
        string[] slides = { "Slide 1: Title", "Slide 2: Content", "Slide 3: Image" };

        Console.WriteLine("Slide Transitions:");

        foreach (var slide in slides)
        {
            Console.Clear();
            Console.WriteLine(slide);
            Thread.Sleep(1000); // Delay for transition effect
        }

        Console.WriteLine("Presentation completed!");
    }
}