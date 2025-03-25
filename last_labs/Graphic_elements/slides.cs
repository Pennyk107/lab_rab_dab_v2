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
        Console.WriteLine("Интерактивная презентация");
        Console.WriteLine("1. Перейти к следующему слайду");
        Console.WriteLine("2. Выйти");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Переход к следующему слайду...");
                // Логика перехода
            }
            else if (input == "2")
            {
                Console.WriteLine("Выход из презентации.");
                break;
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }
        }
    }
}