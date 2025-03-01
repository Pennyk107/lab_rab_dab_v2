using System;
using System.Threading;

/// <summary>
/// Класс TimingExample демонстрирует автоматическую презентацию с заданным временем отображения каждого слайда.
/// </summary>
class TimingExample
{
    /// <summary>
    /// Главный метод программы, который запускает автоматическую презентацию.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Automatic Presentation with Timing");

        // Массив строк, представляющих слайды презентации
        string[] slides = { "Slide 1: Introduction", "Slide 2: Main Content", "Slide 3: Conclusion" };

        // Цикл для отображения каждого слайда
        foreach (var slide in slides)
        {
            Console.Clear(); // Очистка консоли перед выводом нового слайда
            Console.WriteLine(slide); // Вывод текущего слайда
            Thread.Sleep(2000); // Пауза на 2 секунды перед переходом к следующему слайду
        }

        Console.WriteLine("Presentation completed!");
    }
}