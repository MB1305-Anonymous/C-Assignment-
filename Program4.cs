namespace Number04;

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the day of the week (e.g., Monday, Tuesday, etc.):");
        string input = Console.ReadLine();
        if (Enum.TryParse(input, true, out DayOfWeek day))
        {
            string greeting = GetDayGreeting(day);
            Console.WriteLine(greeting);
        }
        else
        {
            Console.WriteLine("Invalid day of the week entered.");
        }
    }

    public static string GetDayGreeting(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Monday:
                return "Happy Monday! Let's start the week with a smile!";
            case DayOfWeek.Tuesday:
                return "Happy Tuesday! Halfway to the weekend!";
            case DayOfWeek.Wednesday:
                return "Happy Wednesday! You're over the hump!";
            case DayOfWeek.Thursday:
                return "Happy Thursday! One more day to the weekend!";
            case DayOfWeek.Friday:
                return "Thank God It's Friday! The weekend is almost here!";
            case DayOfWeek.Saturday:
                return "Happy Saturday! Enjoy your weekend!";
            case DayOfWeek.Sunday:
                return "Happy Sunday! Relax and recharge!";
            default:
                return "Hello! Have a great day!";
        }
    }
}
