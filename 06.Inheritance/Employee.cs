namespace _06.Inheritance;
internal class Employee : Person
{
    private string EmployeeId { get; set; }
    private string CompanyName { get; set; }
    private  double Salary { get; set; }

    public Employee(
        string employeeId,
        string companyName,
        string firstName,
        string lastName,
        string address,
        double salary) : base(firstName, lastName, address)
    {
        EmployeeId = employeeId;
        CompanyName = companyName;
        Salary = salary;
    }

    public double GetSalary()
    {
        return Salary;
    }
}
