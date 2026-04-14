// FizzBuzz

using System;
class FizzBuzz
{
	public static void Fibuzz()
	{
		Console.Write("enter num bettwen 1 and 100 : ");
		int n = int.Parse(Console.ReadLine());

		if (n % 3 == 0 && n % 5 == 0 )
		{
			Console.WriteLine("FizzBuzz");
		}
		else if (n % 3 == 0)
		{
			Console.WriteLine("Fizz");
		}
		else if (n % 5 == 0)
		{
			Console.WriteLine("buzz");
		}
		else 
		{
			Console.WriteLine(n);
		}
	}
}


