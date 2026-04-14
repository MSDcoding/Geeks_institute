// build a triangle pattern 

using System;

class Triangle
{
	public static void pattern()
	{
		for (int i = 1 ; i <= 5 ; i++)
		{
			for (int j = 1 ; j <= i ; j++)
			{
			  Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
