namespace Number06;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a month number (1-12):");
        int month;
        while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid input. Please enter a valid month number (1-12):");
        }

        string season = DetermineSeason(month);
        Console.WriteLine($"The season for month {month} is {season}.");
    }

    static string DetermineSeason(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "Winter";
            case 3:
            case 4:
            case 5:
                return "Spring";
            case 6:
            case 7:
            case 8:
                return "Summer";
            case 9:
            case 10:
            case 11:
                return "Autumn";
            default:
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
        }
    }
}
