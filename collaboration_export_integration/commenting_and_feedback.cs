using System;
using System.Collections.Generic;

/// <summary>
/// Класс CollaborationExample демонстрирует режим совместной работы, позволяя добавлять и просматривать комментарии.
/// </summary>
class CollaborationExample
{
    static List<string> comments = new List<string>();

    /// <summary>
    /// Главный метод программы, который запускает режим совместной работы.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются в этом примере).</param>
    static void Main(string[] args)
    {
        Console.WriteLine("Collaboration Mode");
        Console.WriteLine("Add a comment:");

        while (true)
        {
            string comment = Console.ReadLine();
            if (comment.ToLower() == "exit") break;

            comments.Add(comment);
            Console.WriteLine("Comment added!");
        }

        Console.WriteLine("All comments:");
        foreach (var c in comments)
        {
            Console.WriteLine($"- {c}");
        }
    }
}