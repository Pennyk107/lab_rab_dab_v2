using System;
using System.Collections.Generic;

class CollaborationExample
{
    static List<string> comments = new List<string>();

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