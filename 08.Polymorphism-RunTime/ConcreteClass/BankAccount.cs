namespace _08.Polymorphism_RunTime.ConcreteClass;
internal class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public BankAccount(string accountNumber,
                       double balance) : this(accountNumber)
    {
        Balance = balance;
    }

    // Virtual method to calculate interest
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Generic interest calculation for a bank account.");
    }
}
