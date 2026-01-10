// Sum Sequence

using System;

class Exercise3
{
    public static int SumSequence(int x)
    {
        int x1 = x;
        int x2 = int.Parse(x.ToString() + x);
        int x3 = int.Parse(x.ToString() + x + x);
        int x4 = int.Parse(x.ToString() + x + x + x);

        return x1 + x2 + x3 + x4;
    }
    static void Main()
    {
        Console.Write("Dkhl number: ");
        int x = int.Parse(Console.ReadLine());

        int result = SumSequence(x);
        Console.WriteLine("Result = " + result);
    }
}
