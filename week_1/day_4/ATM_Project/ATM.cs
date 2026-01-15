using System;
using System.Collections.Generic;

public class ATM
{
    private List<Account> accounts;
    public ATM(List<Account> accountsList)
    {
        accounts = accountsList;
    }

    public Account Authenticate()
    {
        while (true)
        {
            Console.Write("Please enter your account number: ");
            string accountNumberInput = Console.ReadLine();

            Console.Write("Enter your PIN: ");
            string pinInput = Console.ReadLine();

            int pin;
            if (!int.TryParse(pinInput, out pin))
            {
                Console.WriteLine("PIN must be numeric. Try again.\n");
                continue;  
            }

            Account foundAccount = null;
            foreach (Account acc in accounts)
            {
                if (acc.AccountNumber == accountNumberInput)
                {
                    foundAccount = acc;
                    break;
                }
            }

            if (foundAccount != null && foundAccount.PIN == pin)
            {
                Console.WriteLine("Authentication successful!\n");
                return foundAccount; 
            }
            else
            {
                Console.WriteLine("Invalid account number or PIN. Try again.\n");
            }
        }
    }
    public void ShowMenu()
    {
        Console.WriteLine("ATM Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Exit");
        Console.Write("Select an option: ");
    }

    public void PerformAction(Account account, string choice)
    {
        switch (choice)
        {
            case "1":
                
                account.CheckBalance();
                break;

            case "2":
            
                Console.Write("Enter deposit amount: ");
                string depInput = Console.ReadLine();
                if (double.TryParse(depInput, out double depAmount))
                {
                    account.Deposit(depAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a number.");
                }
                break;

            case "3":
                
                Console.Write("Enter withdrawal amount: ");
                string witInput = Console.ReadLine();
                if (double.TryParse(witInput, out double witAmount))
                {
                    account.Withdraw(witAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a number.");
                }
                break;

            case "4":

                Console.WriteLine("\nThank you for using our ATM. Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid option. Please select 1-4.");
                break;
        }
    }
}
 