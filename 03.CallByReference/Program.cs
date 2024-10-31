// Method that takes an integer by reference
static void Increment(ref int num)
{
    num++; // Increment the value
    Console.WriteLine("Value inside Increment method: " + num);
}

int originalValue = 10;

// Call the method by reference
Increment(ref originalValue);

// The original value is changed
Console.WriteLine("Value after method call: " + originalValue);