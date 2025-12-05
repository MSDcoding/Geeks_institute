//Temperature Converter

using System;

class Ex8
{
  public static void Temperature()
  {
	  Console.WriteLine("enter Temperature in celsius : ");
	  double celsius = double.Parse(Console.ReadLine());
	  double fahrenheit = celsius*9/5+32;
	     Console.WriteLine("Temperature in fahrenheit : "+ fahrenheit);
  }
}