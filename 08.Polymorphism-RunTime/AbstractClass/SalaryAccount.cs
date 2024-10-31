namespace _08.Polymorphism_RunTime.AbstractClass;
internal class SalaryAccount : BankAccount
{
    private readonly double _interestRate = 0.02;

    public SalaryAccount(
        string accountNumber,
        double balance)
        : base(accountNumber, balance)
    {

    }

    public override void CalculateInterest()
    {
        double interest = Balance * _interestRate;
        Console.WriteLine($"Salary Account Number: {AccountNumber} and Current Amount: {interest:C}");
    }
}
