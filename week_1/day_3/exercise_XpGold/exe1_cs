// Birthday Look-up

using System;
using System.Collections.Generic;

static class BirthdayLookup
{
    public static void birthday()
    {
        Dictionary<string, string> birthdays = new Dictionary<string, string>()
        {
            { "Ahmed", "2000/01/01" },
            { "Ali", "2001/02/02" },
            { "Anas", "2002/03/03" },
            { "Driss", "2004/08/12" },
            { "Ayoub", "2004/05/05" }
        };

        Console.WriteLine("Welcome to the Birthday Lookup");
        Console.WriteLine("You can look up a persons birthday.");

        Console.Write("Enter a name: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine(name + " birthday is " + birthdays[name]);
        }
        else
        {
            Console.WriteLine("Sorry, that name is not in the list.");
        }
    }
}
