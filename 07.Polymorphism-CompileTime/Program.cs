namespace _07.Polymorphism_CompileTime;

internal class Program
{
    static void Main(string[] args)
    {
        // Compile time or Static Polymorphism
        Person person = new Person("Mr.", "Mohammad", "Nasir Uddin");
        person.PrintPersonName();
        person.PrintPersonName(true);
        person.PrintPersonName(false);

        Console.ReadKey();
    }
}
