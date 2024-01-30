using System;

public class Account
{
    // Properties
    public int AccountId { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public decimal Balance { get; }

    static int _numberOfAccounts;

    // Constructor
    public Account(string firstName, string lastName, decimal balance)
    {
        Random random = new Random();
        AccountId = random.Next(100000000, 1000000000);;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;

        _numberOfAccounts++;  
    }

    public static int NumberOfAccounts {
        get => _numberOfAccounts;
    }

        // Override ToString method
    public override string ToString()
    {
        return $"Account ID: {AccountId}\nFull Name: {FirstName} {LastName}\nBalance: {Balance:C}";
    }
}
