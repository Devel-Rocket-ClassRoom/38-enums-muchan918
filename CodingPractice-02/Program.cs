using System;


Animal animal = Animal.Dragon;
int num = (int)animal;
string str = animal.ToString();

Console.WriteLine($"Animal.Dragon: {num}, {str}");

Array values = Enum.GetValues(typeof(Priority));
Console.WriteLine("Priority 열거형의 값들: ");
foreach(Priority p in values)
{
    Console.WriteLine($"{p} = {(int)p}");
}

enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}