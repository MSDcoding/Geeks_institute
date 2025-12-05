// swap betwen two number

using System;

class Ex9
{
	public static void NumberSwapper()
	{
		int a = 22;
		int b = 11;

		int temp = a;
		a = b;
		b = temp;

		Console.WriteLine("a = "+a+", b = "+b);
	}
}