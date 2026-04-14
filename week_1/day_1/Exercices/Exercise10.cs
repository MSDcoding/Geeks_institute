// Simple Multiplication Table

using System;

class Ex10
{
	public static void Multiplcation()
	{
		Console.WriteLine("Enter number : ");
		int n = int.Parse(Console.ReadLine());
		for (int i = 1 ; i <= 10 ; i++)
		{
			Console.WriteLine(n+ "x" + i + "=" + (n*i));
		}
	}
}
