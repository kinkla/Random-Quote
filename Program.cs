using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] quotes = ReadQuotesFromFile("C:\\Users\\qinql\\OneDrive\\Desktop\\Random Quote\\Quotes.txt");

        if (quotes.Length == 0)
        {
            Console.WriteLine("No quotes found.");
            return;
        }

        Random random = new Random();
        int randomIndex = random.Next(quotes.Length);
        string randomQuote = quotes[randomIndex];

        Console.WriteLine("Random Quote:");
        Console.WriteLine(randomQuote);
    }

    static string[] ReadQuotesFromFile(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return new string[0];
    }
}