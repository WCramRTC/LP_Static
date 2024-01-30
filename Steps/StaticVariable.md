- [Home](../README.md) - [Setup](Setup.md) - [Step 1: Static Variable](StaticVariable.md) - [Step 2: Static Method](StaticMethod.md) - [Step 3: Static Constructor](StaticConstructor.md)

# Static Variables



A static variable, also known as a class variable, is a variable in object-oriented programming (OOP) that is associated with a class rather than with an instance (object) of the class. It means that there is only one instance of the variable shared among all instances of the class.

Here are some key characteristics and purposes of static variables:

1. Shared Data: Static variables are used to store data that is common to all instances of a class. It means that if you modify a static variable in one instance, the change will be reflected in all other instances as well.

2. Memory Allocation: Static variables are allocated memory once, when the class is loaded, and they exist for the entire lifetime of the application. They are stored in a special area of memory known as the "static memory" or "class memory."

3. Accessing Static Variables: You can access static variables using the class name, followed by the dot operator, without the need to create an instance of the class. For example, `ClassName.StaticVariableName`.

4. Initialization: Static variables are typically initialized only once, usually at the time of declaration or in a static constructor (if defined).

5. Common Use Cases: Static variables are commonly used for constants, configuration settings, or for maintaining shared state or data that should be consistent across all instances of a class.

Here's an example of a static variable in C#:

```csharp
public class MyClass
{
    public static int staticVariable = 10; // Static variable
    
    public int instanceVariable = 20; // Instance variable
}
```

In this example, `staticVariable` is a static variable shared among all instances of `MyClass`, while `instanceVariable` is an instance variable that has a separate copy for each instance of the class.

---

## Assignment Continued

1. In our account class, we are going to add a new field, `int _numberOfAccounts`. This will be a static field.

### Usage: `static int _numberOfAccounts;`

```csharp
public class Account {

    // Fields...
    static int _numberOfAccounts;

    // Constructor..
        public Account(string firstName, string lastName, decimal balance)
    {
        //... Other code
        _numberOfAccounts++;        
    }

    public static int NumberOfAccounts {
        get => _numberOfAccounts;
    }
}
```

By declaring the field `static` it is no longer associated with the ***instanced*** object. We can now access the field though the `Account` class.

### Usage: `Account.NumberOfAccounts`

1. In program display the current number of accounts.

`Program.cs`

```csharp
    static void Main(string[] args)
    {
        Account newAccount = new Account("William", "Cram", 500);
        Console.WriteLine(newAccount.ToString());
        Console.WriteLine($"Number of Accounts: {Account.NumberOfAccounts}")
    }
```

2. Expected Result
```console
    Full Name: William Cram
    Balance: $500.00
    Number of Accounts: 1
```

Notice our the number of accounts is now 1. That happens because we added a new line to our constructor,

`Explination`
```csharp
   // Constructor..
        public Account(string firstName, string lastName, decimal balance)
    {
        // This incremented our Number of Accounts when we created a new instance of Account
        _numberOfAccounts++;        
    }
```

3. Add another account in `Program.cs`

`Program.cs`

```csharp
    static void Main(string[] args)
    {
        Account newAccount = new Account("William", "Cram", 500);
        Console.WriteLine(newAccount.ToString());

        Console.WriteLine($"Number of Accounts: {Account.NumberOfAccounts}");

        // Add another account
        Account secondAccount = new Account("Josh", "Emery", 50000000);

        // Display number of Accounts
        Console.WriteLine($"Number of Accounts: {Account.NumberOfAccounts}")
    }
```

```console
Account ID: 755073424
Full Name: William Cram
Balance: ¤500.00
Number of Accounts: 1
Account ID: 945950538
Full Name: Josh Emery
Balance: ¤50,000,000.00
Number of Accounts: 2
```

> Notice that the Accounts keeps goig up, that's because every time our constructor is called, it increments the number of Accounts made. And because a static field is a shared field, the change impacts the same value.