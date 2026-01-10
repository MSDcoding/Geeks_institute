using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        List<Account> accounts = new List<Account>();
        accounts.Add(new Account("12345", 6789, 1000.0));  
        accounts.Add(new Account("98765", 4321, 500.0));   

        ATM atm = new ATM(accounts);

        Console.WriteLine("Welcome to the ATM Machine!");

        Account currentAccount = atm.Authenticate();

        string choice = "";
        do
        {
            atm.ShowMenu();
            choice = Console.ReadLine();
            atm.PerformAction(currentAccount, choice);
        } 
        while (choice != "4");
    }
}
