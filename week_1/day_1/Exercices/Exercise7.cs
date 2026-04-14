// Even or Odd?

using System;

class Ex7
{
	public static void EvenOrOdd()
	{
		for (int i = 1; i <= 10 ;i++)
		{
			if (i%2 == 0)
			 Console.WriteLine(i + " is Even");
			 else
			 Console.WriteLine(i + " is Odd");
		}
	}
}