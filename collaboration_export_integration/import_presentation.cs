using System;
using System.IO;

class ExportImportExample
{
    static void Main(string[] args)
    {
        string filePath = @"C:\presentation.txt";
        string content = "This is an example of presentation export.";

        // Export
        File.WriteAllText(filePath, content);
        Console.WriteLine("Presentation exported to file.");

        // Import
        string importedContent = File.ReadAllText(filePath);
        Console.WriteLine("Imported content:");
        Console.WriteLine(importedContent);
    }
}