namespace _08.Polymorphism_RunTime.Interface;
internal class SalaryAccount : IBankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    private readonly double _interestRate = 0.02;

    public SalaryAccount(string accountNumber, double balance)
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
