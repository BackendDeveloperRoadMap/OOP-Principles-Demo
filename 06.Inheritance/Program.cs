using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.AccessControl;
using System;

namespace _06.Inheritance;

internal class Program
{
    //Upcasting: When you assign a derived class object (e.g., Employee) to a base class
    //reference(e.g., Person), only the members declared in the base class are accessible
    //through the reference.

    //The GetSalary() method belongs to the Employee class, but the Person reference
    //is unaware of any methods declared only in the derived class.

    static void DisplayEmployeeName(Employee? employee)
    {
        Console.WriteLine($"Employee name is : {employee?.GetPersonFullName()}");
        Console.WriteLine($"Employee salary is : {employee?.GetSalary()}");
    }

    static void Main(string[] args)
    {
        // Here Upcasting is hapening.
        Person employeePerson = new Employee("E001",
                                         "Adappt Ltd",
                                         "Mohammad",
                                         "Nasir Uddin",
                                         "Khejurbag, Dhaka",
                                         1000);

        //GetPersonFullName method is accessible
        //employeePerson.GetPersonFullName(); 

        //GetSalary method is not accessible
        //employeePerson..GetSalary();        

        // Downcasting is happening.
        Employee employee = (Employee)employeePerson;

        //DisplayEmployeeName(employeePerson as Employee);
        DisplayEmployeeName(employee);

        Console.ReadKey();
    }
}
