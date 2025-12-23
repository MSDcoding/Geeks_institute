//Birthdays Advanced
 

using System;
using System.Collections.Generic;

static class BirthdayLookup
{
    public static void birthay()
    {
        Dictionary<string, string> birthdays = new Dictionary<string, string>()
        {
            { "Ahmed", "2000/01/01" },
            { "Ali",   "2001/02/02" },
            { "Anas",  "2002/03/03" },
            { "Driss", "2003/04/04" },
            { "Ayoub", "2004/05/05" }
        };

        Console.WriteLine("Welcome to Birthdays Advanced ");
        Console.WriteLine("We have birthday info for:");

        foreach (string person in birthdays.Keys)
        {
            Console.WriteLine(" " + person);
        }

        Console.Write("\nEnter a name: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine(name + "his birthday is " + birthdays[name]);
        }
        else
        {
            Console.WriteLine("Sorry, we don’t have the birthday information for " + name + ".");
        }
    }
}
