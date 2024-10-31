namespace _09.MethodHiding;

internal class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new SavingsAccount();
        SavingsAccount savings = new SavingsAccount();

        account.DisplayAccountInfo();  // Calls BankAccount version (method hidden)
        savings.DisplayAccountInfo();  // Calls SavingsAccount version

        Console.ReadKey();
    }
}
