namespace LP_Static;

class Program
{
    static void Main(string[] args)
    {
        Account newAccount = new Account("William", "Cram", 500);
        Console.WriteLine(newAccount.ToString());

        Console.WriteLine($"Number of Accounts: {Account.NumberOfAccounts}");

        // Add another account
        Account secondAccount = new Account("Josh", "Emery", 50000000);

        // Display secondAccount
        Console.WriteLine(secondAccount.ToString());

        // Display number of Accounts
        Console.WriteLine($"Number of Accounts: {Account.NumberOfAccounts}");
    }
}
