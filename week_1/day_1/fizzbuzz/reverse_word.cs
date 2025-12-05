// reverse a word

using System;

class Reverse
{
public static void reverse()
{
	Console.Write("enter the word : ");
	string word =Console.ReadLine();

	string reversed = "";
	int index = word.Lenght - 1; 

	while (index >= 0)
	{ 
		reversed = reversed + word[index];
		index =index - 1 ;
	}
	Console.WriteLine("Reversed: "+ reversed);
}
}