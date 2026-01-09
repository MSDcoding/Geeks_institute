using System;
using System.Collections.Generic;

class Exercise3
{
    public static void ZaraBrand()
    {
        var brand = new Dictionary<string, object>()
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>() {"men", "women", "children", "home"} },
            {"international_competitors", new List<string>() {"Gap", "H&M", "Benetton"} },
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>()
                {
                    {"France", new List<string>() {"blue"} },
                    {"Spain", new List<string>() {"red"} },
                    {"US", new List<string>() {"pink", "green"} }
                }
            }
        };
        brand["number_stores"] = 2;

        List<string> clothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine("Zara kaykhdem 3la: " + string.Join(", ", clothes));
        brand["country_creation"] = "Spain";

        if (brand.ContainsKey("international_competitors"))
        {
            List<string> competitors = (List<string>)brand["international_competitors"];
            competitors.Add("Desigual");
        }

        brand.Remove("creation_date");

        List<string> competitorsList = (List<string>)brand["international_competitors"];
        Console.WriteLine("Last competitor: " + competitorsList[competitorsList.Count - 1]);

        Dictionary<string, List<string>> colors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine("US colors: " + string.Join(", ", colors["US"]));

        Console.WriteLine("Key-value pairs count: " + brand.Count);

        Console.WriteLine("Keys:");
        foreach (var key in brand.Keys)
        {
            Console.WriteLine("- " + key);
        }

        var more_on_zara = new Dictionary<string, object>()
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        foreach (var item in more_on_zara)
        {
            brand[item.Key] = item.Value;
        }

        Console.WriteLine("number_stores after merge: " + brand["number_stores"]);
        Console.WriteLine("Explanation: ");
    }
}
