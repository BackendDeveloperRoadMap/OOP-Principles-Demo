namespace _06.Inheritance;
internal class Person
{
    protected string FirstName { get; set; }
    protected string LastName { get; set; }
    protected string Address { get; set; }

    public Person(string firstName, string lastName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public string GetPersonFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
