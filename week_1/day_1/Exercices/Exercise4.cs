//Exercise 4: The Bouncer (If/Else)


class Ex4
{
    public static void Bouncer()
    {
        Console.Write("Please enter your age : ");
         int userAge = int.Parse(Console.ReadLine());
        
         if (userAge>=18)
        {
        Console.WriteLine("Access Granted.");
        }
        else
        {
          Console.WriteLine("Access Denied.");
       }
    }
}
