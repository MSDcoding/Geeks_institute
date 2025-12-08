// Temperature Advice

using System;

class Exercise7
{
	public static int GetRandomTemp(string season)
{
    Random rnd = new Random();
    int min = -10, max = 40;

    if (season == "winter") { min = -10; max = 16; }
    if (season == "spring") { min = 0; max = 23; }
    if (season == "summer") { min = 16; max = 40; }
    if (season == "autumn") { min = 0; max = 23; }

    return rnd.Next(min, max + 1);
}

public static void Temperature()
{
    Console.Write("enter a season: ");
    string season =
    Console.ReadLine().ToLower();

    int Temp = GetRandomTemp(season);

    Console.WriteLine("temperature is : " + Temp + " C");

    if (Temp<0)
    {
        Console.WriteLine("it is verry cold ");
    }
    else if (Temp < 15)
    {
        Console.WriteLine("it still cold out there");
    }
    else if (Temp<30)
    {
        Console.WriteLine("it is good mood ");
    }
    else
    {
        Console.WriteLine("it is verry hot ");
    }
  }
}