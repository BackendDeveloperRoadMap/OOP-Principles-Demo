// ========================= Primitive Type =========================

using _01.DataType;

int num1 = 70;
int num2 = num1; // will show 70
num1 = 80; // will show 80
Console.WriteLine($"Num1 value is {num1} and Num2 value is {num2}");

string str1 = "Hello Nasir";
string str2 = str1;
str1 = "Bonjour";
Console.WriteLine($"STR1 value is {str1} and STR2 value is {str2}");

// ========================= Reference Type =========================
Person person1 = new Person
{
    Name = "Mohammad Nasir Uddin",
    Address = "Khejurbagh, Dhaka"
};

Person person2 = person1;

person1.Name = "Shaheenur Akter Sonya";

Console.WriteLine(person2);

Console.ReadKey();
