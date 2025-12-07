//Multiples list Generator

using System;

class Challenge1
{
	public static void MultiplesList()
	{
		Console.Write("enter a number : ");
		int number =
		  int.Parse(Console.ReadLine()!);

		Console.Write("enter a length : ");
		int length =
		 int.Parse(Console.ReadLine()!);

		Console.Write("res : ");

		for (int i = 1 ; i <= length ; i++)
		{
			int value = number * i;
			Console.Write(value);

				if (i < length)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine();
	}
}
