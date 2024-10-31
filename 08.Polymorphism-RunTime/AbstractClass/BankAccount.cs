namespace _08.Polymorphism_RunTime.AbstractClass;
internal abstract class BankAccount
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

    // Abstract method to calculate interest
    public abstract void CalculateInterest();
}
