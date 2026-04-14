//personalized shirts

using System;

class Exercise6
{
	public static void MakeShirt(string size = "Large", string text = "I love C#")
      {
        Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
       }
       
       public static void personaliz()
       {
           MakeShirt();
           MakeShirt("medium");
           MakeShirt("small","blabla");
           MakeShirt(text: "hello word", size :"xl");
       }
}
