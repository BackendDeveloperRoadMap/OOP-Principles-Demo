namespace _10.ConstructorChaining.BaseClass;
internal class Person
{
    public string Name { get; set; }

    // Base class constructor
    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Person constructor called.");
    }
}
