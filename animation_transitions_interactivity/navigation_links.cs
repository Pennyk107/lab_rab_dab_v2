using System;

/// <summary>
/// Класс InteractiveElementsExample демонстрирует интерактивную презентацию с возможностью навигации.
/// </summary>
class InteractiveElementsExample
{
    /// <summary>
    /// Главный метод программы, который запускает интерактивную презентацию.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
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
                // Логика навигации
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