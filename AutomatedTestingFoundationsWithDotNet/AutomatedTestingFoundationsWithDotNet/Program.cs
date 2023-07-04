using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sequence of symbols:");
        string sequence = Console.ReadLine();
        int maxConsecutive = FindMaxConsecutiveSymbols(sequence);
        Console.WriteLine("Maximum number of unequal consecutive characters: " + maxConsecutive);
    }

    static int FindMaxConsecutiveSymbols(string sequence)
    {
        int maxCount = 0;
        int currentCount = 0;
        char previousSymbol = '\0';

        foreach (char symbol in sequence)
        {
            if (symbol != previousSymbol)
            {
                currentCount = 1;
            }
            else
            {
                currentCount++;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            previousSymbol = symbol;
        }

        return maxCount;
    }
}
