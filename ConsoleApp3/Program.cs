// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Reads the Test cases that is inputted
        Console.Write("No. of test cases: ");
        int T = int.Parse(Console.ReadLine());

        // Using List to Store the Data
        List<string> results = new List<string>();

        // Used to process each test case
        for (int i = 0; i < T; i++)
        {
            // Read the prices for Uber and Grab
            string[] input = Console.ReadLine().Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            // For comparing the prices and the result
            if (X < Y)
            {
                results.Add("FIRST");
            }
            else if (X > Y)
            {
                results.Add("SECOND");
            }
            else
            {
                results.Add("ANY");
            }
        }

        // OUTPU 
        Console.WriteLine("\nOUTPUT:");
        Console.WriteLine("\nResult:");
        foreach (var result in results)
        {
            Console.WriteLine($"    {result}");
        }
    }
}

