using System;

/// <summary>
/// Класс MobileVersionExample демонстрирует упрощенную версию приложения для мобильных устройств.
/// </summary>
class MobileVersionExample
{
    /// <summary>
    /// Главный метод программы, который предоставляет пользователю выбор действий.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Mobile Version");
        Console.WriteLine("1. Open Presentation");
        Console.WriteLine("2. Edit Slide");
        Console.WriteLine("3. Save and Exit");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Presentation opened.");
                break;
            case "2":
                Console.WriteLine("Editing slide...");
                break;
            case "3":
                Console.WriteLine("Presentation saved.");
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}