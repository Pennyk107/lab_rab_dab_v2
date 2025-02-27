using System;
using System.IO;

class TextExample
{
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