namespace _10.ConstructorChaining.BaseClass;
internal class Employee : Person
{
    public double Salary { get; set; }

    // Derived class constructor chaining to base class
    public Employee(string name, double salary) : base(name) // Chaining with `base`
    {
        Salary = salary;
        Console.WriteLine("Employee constructor called.");
    }
}
