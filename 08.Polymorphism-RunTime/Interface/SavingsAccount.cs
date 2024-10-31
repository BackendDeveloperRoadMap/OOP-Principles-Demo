namespace _08.Polymorphism_RunTime.Interface;
internal class SavingsAccount : IBankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    private readonly double _interestRate = 0.04;

    public SavingsAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public double CalculateInterest()
    {
        double interest = Balance * _interestRate;
        return interest;
    }
}