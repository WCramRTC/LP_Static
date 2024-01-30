- [Home](../README.md) - [Setup](Setup.md) - [Step 1: Static Variable](StaticVariable.md) - [Step 2: Static Method](StaticMethod.md) - [Step 3: Static Constructor](StaticConstructor.md)

# Setup

1. Create an `Account.cs` class and add the following code
```csharp
using System;

public class Account
{
    // Properties
    public int AccountId { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public decimal Balance { get; }

    // Constructor
    public Account(string firstName, string lastName, decimal balance)
    {
        Random random = new Random();
        AccountId = random.Next(100000000, 1000000000);;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

        // Override ToString method
    public override string ToString()
    {
        return $"Account ID: {AccountId}\nFull Name: {FirstName} {LastName}\nBalance: {Balance:C}";
    }
}

```

2. Test your code

In your program.cs create a new Account instance and display the ToString().

`Program.cs`

```csharp
     static void Main(string[] args)
    {
        Account newAccount = new Account("William", "Cram", 500);
        Console.WriteLine(newAccount.ToString());
    }
```