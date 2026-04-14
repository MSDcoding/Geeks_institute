//double dice

using System;
using System.Collections.Generic;

class Program
{
    static Random rnd = new Random();

    static int ThrowDice()
    {
        return rnd.Next(1, 7);
    }

    static int ThrowUntilDoubles()
    {
        int rolls = 0;

        while (true)
        {
            int d1 = ThrowDice();
            int d2 = ThrowDice();
            rolls++;

            if (d1 == d2)
                return rolls;
        }
    }

    static void Main()
    {
        List<int> results = new List<int>();

        for (int i = 0; i < 100; i++)
            results.Add(ThrowUntilDoubles());

        int totalThrows = 0;
        foreach (int r in results)
            totalThrows += r;

        double avg = (double)totalThrows / results.Count;

        Console.WriteLine("Total number of throws: " + totalThrows);
        Console.WriteLine("Average throws to reach doubles: " + Math.Round(avg, 2));
    }
}
