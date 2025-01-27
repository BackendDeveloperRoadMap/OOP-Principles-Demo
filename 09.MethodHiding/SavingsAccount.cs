namespace _09.MethodHiding;
internal class SavingsAccount : BankAccount
{

    /// <summary>
    /// The new keyword prevent to show any warning message
    /// </summary>
    public new void DisplayAccountInfo()
    {
        Console.WriteLine("Displaying Savings Account specific information.");
    }
}
