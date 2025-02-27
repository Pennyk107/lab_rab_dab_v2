using System;

class InteractiveElementsExample
{
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