using System;
using System.Threading;

class AnimationExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Text Animation: Fade In and Out");

        string text = "Hello, World!";
        for (int i = 0; i < 5; i++) // Repeat animation 5 times
        {
            Console.Clear();
            Console.WriteLine(text); // Fade in
            Thread.Sleep(500);      // Delay 500 ms
            Console.Clear();        // Fade out
            Thread.Sleep(500);
        }

        Console.WriteLine("Animation completed!");
    }
}