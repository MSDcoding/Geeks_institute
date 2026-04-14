//afternoon at the zoo

using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string Name;
    public List<string> Animals;

    public Zoo(string zooName)
    {
        Name = zooName;
        Animals = new List<string>();
    }

    public void AddAnimal(string newAnimal)
    {
        newAnimal = newAnimal.Trim();

        if (!Animals.Contains(newAnimal))
        {
            Animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added");
        }
        else
        {
            Console.WriteLine($"{newAnimal} already exists.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("Animals in the zoo:");

        if (Animals.Count == 0)
        {
            Console.WriteLine("empty");
            return;
        }

        foreach (var a in Animals)
            Console.WriteLine(" " + a);
    }

    public void SellAnimal(string animalSold)
    {
        animalSold = animalSold.Trim();

        if (Animals.Remove(animalSold))
            Console.WriteLine($"{animalSold} was sold.");
        else
            Console.WriteLine($"{animalSold} not found.");
    }

    public Dictionary<char, List<string>> SortAnimals()
    {
        var sorted = Animals
            .OrderBy(a => a)
            .GroupBy(a => char.ToUpper(a[0]))
            .ToDictionary(g => g.Key, g => g.ToList());

        return sorted;
    }

    public void GetGroups()
    {
        var groups = SortAnimals();

        Console.WriteLine("Groups:");
        foreach (var g in groups)
        {
            Console.WriteLine($"{g.Key}: {string.Join(", ", g.Value)}");
        }
    }
}

class Exercise12
{
    public static void Run()
    {
        var newYorkZoo = new Zoo("New York Zoo");

        while (true)
        {
            Console.Write("Which animal should we add to the zoo?: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "stop") break;
            if (string.IsNullOrWhiteSpace(input)) continue;

            newYorkZoo.AddAnimal(input);
        }

        while (true)
        {
            Console.Write("Which animal that we have to sell: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "stop") break;
            if (string.IsNullOrWhiteSpace(input)) continue;

            newYorkZoo.SellAnimal(input);
        }

        newYorkZoo.GetAnimals();
        newYorkZoo.GetGroups();
    }
}
