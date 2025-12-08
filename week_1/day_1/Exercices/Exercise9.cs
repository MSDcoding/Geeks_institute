// swap betwen two number

using System;

class Ex9
{
	public static void Nmberswap()
	{
		int a = 22;
		int b = 11;

		Console.WriteLine("before swap : a = "+a+", b = "+b);
		int temp = a;
		a = b;
		b = temp;

		Console.WriteLine(" after swap : a = "+a+", b = "+b);
	}
}