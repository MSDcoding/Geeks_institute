using System;
public class Account
{
    public string AccountNumber { get; set; } 
    public int PIN { get; set; }               
    public double Balance { get; set; }        

    public Account(string accountNumber, int pin, double initialBalance)
    {
        AccountNumber = accountNumber;
        PIN = pin;
        Balance = initialBalance;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ${Balance}");
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
        else
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful! New balance: ${Balance}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: ${Balance}");
        }
    }
}
