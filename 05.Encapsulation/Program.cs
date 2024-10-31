namespace _05.Encapsulation;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new bank account with encapsulated data
        BankAccount account = new BankAccount("10123456789", 9000);

        // Accessing data through public Method and Property
        Console.WriteLine($"Account Number: {account.GetAccountNumber()}");
        Console.WriteLine($"Initial Balance: {account.AccountBalance}");

        // Modifying data through public methods
        account.Deposit(1000);
        account.Withdraw(3000);
        account.Withdraw(9000);
    }
}
