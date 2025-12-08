//Convert lists into Dictionaries

using System;

class Exercise1
{
	public static void ConvertList()
	{
        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };
	Console.Write("{ ");

for (int i =0 ; i < keys.Count; i++)
{
	Console.Write(keys[i] + " : " + values[i]);
	
	if (i < keys.Count - 1)
	{
		Console.Write(", ");
	  }
   }
     Console.WriteLine(" }");
      
	}
}
