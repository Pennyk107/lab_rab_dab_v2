using System;
using System.Threading;

/// <summary>
/// Класс AnimationExample демонстрирует анимацию текста с эффектом появления и исчезновения.
/// </summary>
class AnimationExample
{
    /// <summary>
    /// Главный метод программы, который запускает анимацию текста.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Анимация текста: появление и исчезновение");

        string text = "Hello, World!";
        for (int i = 0; i < 5; i++) // Повторяем анимацию 5 раз
        {
            Console.Clear();
            Console.WriteLine(text); // Появление текста
            Thread.Sleep(500);      // Задержка 500 мс
            Console.Clear();         // Исчезновение текста
            Thread.Sleep(500);
        }

        Console.WriteLine("Анимация завершена!");
    }
}