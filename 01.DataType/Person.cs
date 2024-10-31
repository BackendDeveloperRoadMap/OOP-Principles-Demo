using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DataType;
internal class Person
{
    public string? Name { get; set; }
    public string? Address { get; set; }

    public override string ToString()
    {
        return $"Name is : {Name} and Address is : {Address}";
    }
}
