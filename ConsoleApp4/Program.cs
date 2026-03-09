// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Exercise 2 – Variables

// Strings
string name = "Pieter";

// Integer
int age = 30;

// Double
double height = 1.82;

// Boolean
bool isLearningCSharp = true;

// Character
char grade = 'A';

// Print all values
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);
Console.WriteLine("Learning C#: " + isLearningCSharp);
Console.WriteLine("Grade: " + grade);

// Exercise 3 – If / Else

int ageCheck = 17;

if (ageCheck >= 18)
{
    Console.WriteLine("You are old enough to drive.");
}
else
{
    Console.WriteLine("You are NOT old enough to drive.");
}

// Exercise 4 – For Loop

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Number: " + i);
}
Console.WriteLine("Sync test");
