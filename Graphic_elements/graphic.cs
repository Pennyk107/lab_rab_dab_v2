using System;
using System.Threading;

class AnimationExample
{
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