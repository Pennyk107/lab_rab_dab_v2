using System;
using System.Threading;

class TimingExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Automatic Presentation with Timing");

        string[] slides = { "Slide 1: Introduction", "Slide 2: Main Content", "Slide 3: Conclusion" };

        foreach (var slide in slides)
        {
            Console.Clear();
            Console.WriteLine(slide);
            Thread.Sleep(2000); // Each slide displays for 2 seconds
        }

        Console.WriteLine("Presentation completed!");
    }
}