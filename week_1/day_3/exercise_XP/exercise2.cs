//cinemax #2

using System;

class Exercise2
{
	public static void cinemax()
	{
		Dictionary<string, int> family = new Dictionary<string, int>
{
    {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
};


int total = 0;

foreach (var person in family)
{
	int age = person.Value;
	int price = 0;

	if (age < 3)
	{
		price = 0;
	}
	else if (age <= 12)
	{
		price = 10;
	}
	else 
	{
		price = 15;
	}

	Console.WriteLine(person.Key + "pays :  $" + price);

	total += price;
}
Console.WriteLine("total cost for the family : $" + total);
	}
}
