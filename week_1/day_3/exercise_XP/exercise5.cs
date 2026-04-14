// random number guess

using System;

class Exercise5
{
 public static void NumberGuess(int Your_Number)
 {
	 Random r = new Random();
	 int x = r.Next(1, 101);

	 Console.WriteLine("your number : " + Your_Number);
     
	 Console.WriteLine("random num : " + x);

	 if (Your_Number == x )
	 {
		 Console.WriteLine("success msg");
	       }
			 else
			 {
				 Console.WriteLine("fail msg");
			 }
        }
}