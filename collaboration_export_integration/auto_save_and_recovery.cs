using System;
using System.IO;

/// <summary>
/// Класс TextExample демонстрирует работу с текстовыми файлами: создание, запись и чтение.
/// </summary>
class TextExample
{
    /// <summary>
    /// Главный метод программы, который создает текстовый файл, записывает в него данные и читает их.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        // Создаем текстовый файл
        string filePath = @"C:\example_text.txt";

        // Записываем текст в файл
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Это пример текста.");
            writer.WriteLine("Мы работаем с файлами в C#.");
            writer.WriteLine("Текст успешно записан!");
        }

        // Читаем текст из файла
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            Console.WriteLine("Содержимое файла:");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        Console.WriteLine("Работа с текстом завершена!");
    }
}