using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the word : ");
        string word = Console.ReadLine();

        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];

            if (!letterPositions.ContainsKey(letter))
            {
                letterPositions[letter] = new List<int>();
            }

            letterPositions[letter].Add(i);
        }

        Console.WriteLine("\n resultat :");
        foreach (var item in letterPositions)
        {
            Console.Write(item.Key + " : [ ");
            foreach (int index in item.Value)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine("]");
        }
    }
}
