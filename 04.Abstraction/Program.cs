using _04.Abstraction;

//The internal details of how the animals make sounds are abstracted from the user.
//The user only interacts with the Animal type.

Animal dog = new Dog();
Animal cat = new Cat();

dog.MakeSound();
cat.MakeSound();

Console.ReadKey();