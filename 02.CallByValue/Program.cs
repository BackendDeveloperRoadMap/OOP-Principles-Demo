// Method that takes an integer as a parameter
static void Increment(int num)
{
    num++; // Increment the value
    Console.WriteLine("Value inside Increment method: " + num);
}


int originalValue = 10;

// Call the method by value
Increment(originalValue);

// The original value remains unchanged
Console.WriteLine("Value after method call: " + originalValue);