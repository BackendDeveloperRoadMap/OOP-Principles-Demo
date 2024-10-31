using BaseClass = _10.ConstructorChaining.BaseClass;
using SameClass = _10.ConstructorChaining.SameClass;

namespace _10.ConstructorChaining;

internal class Program
{
    static void Main(string[] args)
    {
        SameClass.Employee sameEmp = new SameClass.Employee("Mohammad Nasir Uddin", "Dhaka");

        BaseClass.Employee baseEmp = new BaseClass.Employee("Nasir Uddin", 5000);

        Console.ReadKey();
    }
}
