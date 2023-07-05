using System;

class BaseConverter
{
    static string ConvertToBase(int decimalNum, int baseNum)
    {
        if (decimalNum == 0)
        {
            return "0";
        }

        string[] digits = new string[32];
        int index = 0;

        while (decimalNum > 0)
        {
            int remainder = decimalNum % baseNum;
            digits[index++] = remainder.ToString();
            decimalNum /= baseNum;
        }

        Array.Reverse(digits, 0, index);
        return string.Join("", digits, 0, index);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the decimal number:");
        if (!int.TryParse(Console.ReadLine(), out int decimalNumber))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        Console.WriteLine("Enter the new base (2-20):");
        if (!int.TryParse(Console.ReadLine(), out int baseNumber))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        if (baseNumber < 2 || baseNumber > 20)
        {
            Console.WriteLine("Base should be between 2 and 20.");
            return;
        }

        string convertedNumber = ConvertToBase(decimalNumber, baseNumber);
        Console.WriteLine($"The number {decimalNumber} in base {baseNumber} is: {convertedNumber}");
    }
}
