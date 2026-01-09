// Exercise 7: Temperature Advice
using System;

class Exercise7
{
    public static void Temperature()
    {
        Console.WriteLine("Temperature Advice");
        Console.Write("season: ");
        string monthInput = Console.ReadLine();

        string season;

        if (!string.IsNullOrWhiteSpace(monthInput))
        {
            int month = int.Parse(monthInput);
            season = GetSeasonFromMonth(month);
            Console.WriteLine("Season (from month): " + season);
        }
        else
        {
            Console.Write("season (winter/spring/summer/autumn): ");
            season = Console.ReadLine().ToLower();
        }

        double temp = GetRandomTempFloat(season);

        Console.WriteLine("Temperature: " + temp + "°C");
        GiveAdvice(temp);
    }

    public static double GetRandomTempFloat(string season)
    {
        Random rnd = new Random();
        int min = -10, max = 40;

        if (season == "winter") { min = -10; max = 16; }
        if (season == "spring") { min = 0; max = 23; }
        if (season == "summer") { min = 16; max = 40; }
        if (season == "autumn") { min = 0; max = 23; }

        int whole = rnd.Next(min, max + 1);
        double decimalPart = rnd.NextDouble();
        return Math.Round(whole + decimalPart, 1);
    }

    public static void GiveAdvice(double temp)
    {
        if (temp <= 0) Console.WriteLine("Advice: Bard ljew bzaaf lbes 7wajek hahha");
        else if (temp < 16) Console.WriteLine("Advice: Bard ljew lbes jacjet haha");
        else if (temp < 25) Console.WriteLine("Advice: jaw mzyan lbes li 3jbek hahah");
        else Console.WriteLine("Advice: lhal skhon hhh");
    }

    public static string GetSeasonFromMonth(int month)
    {
        if (month == 12 || month == 1 || month == 2) return "winter";
        if (month == 3 || month == 4 || month == 5) return "spring";
        if (month == 6 || month == 7 || month == 8) return "summer";
        if (month == 9 || month == 10 || month == 11) return "autumn";
        return "winter";
    }
}
