namespace _09.MethodHiding;
internal class SavingsAccount : BankAccount
{
    public new void DisplayAccountInfo()
    {
        Console.WriteLine("Displaying Savings Account specific information.");
    }
}
