namespace _08.Polymorphism_RunTime.AbstractClass;
internal class SavingsAccount : BankAccount
{
    private readonly double _interestRate = 0.04;

    public SavingsAccount(
        string accountNumber,
        double balance)
        : base(accountNumber, balance)
    {

    }

    // Overriding CalculateInterest for SavingsAccount
    public override void CalculateInterest()
    {
        double interest = Balance * _interestRate;
        Console.WriteLine($"Savings Account Number: {AccountNumber} and Interest Amount: {interest:C}");
    }
}
