namespace _05.Encapsulation;
internal class BankAccount
{
    // Encapsulation: Property is not acceissble from other class
    private string AccountNumber { get; set; }

    // Encapsulation: Set function is restricted to access from other class (read-only access)
    public decimal AccountBalance { get; private set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountBalance = initialBalance;
    }

    // Encapsulation: Public method to get account number (read-only access)
    public string GetAccountNumber()
    {
        if (string.IsNullOrWhiteSpace(AccountNumber))
            throw new NullReferenceException("Account number is not found.");

        return AccountNumber;
    }

    // Encapsulation: Public method to deposit money (controlled write access)
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            AccountBalance += amount;
            Console.WriteLine($"Successfully deposited {amount}. New balance: {AccountBalance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Encapsulation: Public method to withdraw money (controlled write access)
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= AccountBalance)
        {
            AccountBalance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. New balance: {AccountBalance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}
