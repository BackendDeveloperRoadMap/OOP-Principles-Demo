using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Polymorphism_CompileTime;
internal class Person
{
    private string Title { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }

    public Person(string title, string firstName, string lastName)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
    }

    public void PrintPersonName()
    {
        Console.WriteLine($"Person name without title is: {FirstName} {LastName}");
    }

    // Overloaded Method
    public void PrintPersonName(bool isShowTitle)
    {
        if (isShowTitle)
            Console.WriteLine($"Person name with title is: {Title} {FirstName} {LastName}");
        else
            PrintPersonName();
    }
}
