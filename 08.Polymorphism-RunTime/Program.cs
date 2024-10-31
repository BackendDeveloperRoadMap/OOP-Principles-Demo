using concreteClass = _08.Polymorphism_RunTime.ConcreteClass;
using abstractClass = _08.Polymorphism_RunTime.AbstractClass;
using interfaceClass = _08.Polymorphism_RunTime.Interface;

namespace _08.Polymorphism_RunTime;

internal class Program
{
    static void Main(string[] args)
    {
        // Concrete class example for Polymorphism
        concreteClass.BankAccount concreteSavingAccount = new concreteClass.SavingsAccount("1001", 100);
        concreteSavingAccount.CalculateInterest();

        abstractClass.BankAccount concreteSalaryAccount = new abstractClass.SalaryAccount("1001", 100);
        concreteSalaryAccount.CalculateInterest();

        // Abstract class example for Polymorphism
        abstractClass.BankAccount abstractSavingsAccount = new abstractClass.SavingsAccount("1002", 200);
        abstractSavingsAccount.CalculateInterest();

        abstractClass.BankAccount abstractSalaryAccount = new abstractClass.SalaryAccount("1002", 200);
        abstractSalaryAccount.CalculateInterest();

        // Interface example for Polymorphism
        interfaceClass.IBankAccount interfaceSavingsAccount = new interfaceClass.SavingsAccount("1003", 300);
        interfaceSavingsAccount.CalculateInterest();

        interfaceClass.IBankAccount interfaceSalaryAccount = new interfaceClass.SalaryAccount("1003", 300);
        interfaceSalaryAccount.CalculateInterest();

    }
}
