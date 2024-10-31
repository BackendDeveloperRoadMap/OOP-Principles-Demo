namespace _10.ConstructorChaining.SameClass;
internal class Employee
{
    private string Name { get; set; }
    private string? Address { get; set; }

    public Employee(string name)
    {
        Name = name;
        Console.WriteLine("Constructor with 1 parameter called.");
    }

    public Employee(string name, string address) : this(name)
    {
        Address = address;
        Console.WriteLine("Constructor with 2 parameters called.");
    }
}
