// remove consecutive duplicate letters

using System;

class Challenge2
{
	public static void RemoveDuplicates()
	{
		Console.Write("Enter a string : ");
		string input = Console.ReadLine();

		if (string.IsNullOrEmpty(input))
		{
			Console.WriteLine("your input is empty : ");
			  return;
		}

		string res = "" + input[0];

		for (int i = 1 ; i < input.Length ; i++)
		{
		  if (input[i] != input[i-1])
		  {
			  res += input[i];
		  }
		}
		Console.WriteLine(res);
	}
}

