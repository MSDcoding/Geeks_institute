//star wars quiz

using System;
using System.Collections.Generic;

class Exercise8
{
    public static void starwar()
    {
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "grogu"} },
            new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "tatooine"} },
            new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
            new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "anakin skywalker"} },
            new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "darth vader"} },
            new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "wookiee"} }
        };

        int correct = 0;
        int wrong = 0;

        List<string> wrongList = new List<string>();

        Console.WriteLine("Star Wars Quiz ");

        foreach (var item in data)
        {
            string q = item["question"];
            string a = item["answer"];

            Console.WriteLine(q);
            Console.Write("Your answer: ");

            string userAns = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (userAns == a.ToLower())
            {
                correct++;
                Console.WriteLine(" Correct ");
            }
            else
            {
                wrong++;
                Console.WriteLine("Wrong, Correct was: " + a);
                wrongList.Add(
                    "Quest : " + q +
                    " Your answer: " + userAns +
                    "  Correct answer: " + a + "\n"
                );
            }
        }

        Console.WriteLine("RESULTS");
        Console.WriteLine("Correct answers: " + correct);
        Console.WriteLine("Wrong answers: " + wrong);

        if (wrongList.Count > 0)
        {
            Console.WriteLine("Details of wrong answers:");
            foreach (var entry in wrongList)
            {
                Console.WriteLine(entry);
            }
        }
        if (wrong > 3)
        {
            Console.WriteLine("You got more than 3 wrong plaise Try again ");
        }
    }
}

      