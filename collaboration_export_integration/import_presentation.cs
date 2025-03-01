using System;
using System.IO;

/// <summary>
/// Класс ExportImportExample демонстрирует экспорт и импорт данных в текстовый файл.
/// </summary>
class ExportImportExample
{
    /// <summary>
    /// Главный метод программы, который экспортирует данные в файл и затем импортирует их обратно.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        string filePath = @"C:\presentation.txt";
        string content = "This is an example of presentation export.";

        // Экспорт
        File.WriteAllText(filePath, content);
        Console.WriteLine("Presentation exported to file.");

        // Импорт
        string importedContent = File.ReadAllText(filePath);
        Console.WriteLine("Imported content:");
        Console.WriteLine(importedContent);
    }
}