using System;
using System.Threading;

/// <summary>
/// Класс SlideTransitionExample демонстрирует переходы между слайдами с задержкой.
/// </summary>
class SlideTransitionExample
{
    /// <summary>
    /// Главный метод программы, который запускает презентацию с переходами между слайдами.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        string[] slides = { "Slide 1: Title", "Slide 2: Content", "Slide 3: Image" };

        Console.WriteLine("Slide Transitions:");

        foreach (var slide in slides)
        {
            Console.Clear();
            Console.WriteLine(slide);
            Thread.Sleep(1000); // Задержка для эффекта перехода
        }

        Console.WriteLine("Presentation completed!");
    }
}