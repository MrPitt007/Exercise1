// Exercise 1 — Hello World

Console.WriteLine("Hello World!");

// Exercise 2 — Variables & Data Types

string name = "Pieter";      // string (text)
int age = 30;                // integer
double height = 1.82;        // decimal number
bool isLearningCSharp = true; // boolean
char grade = 'A';            // single character

// Print values
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Height: {height}");
Console.WriteLine($"Learning C#: {isLearningCSharp}");
Console.WriteLine($"Grade: {grade}");
``
// Exercise 3 — If / Else

int ageCheck = 17;

if (ageCheck >= 18)
{
    Console.WriteLine("You are old enough to drive.");
}
else
{
    Console.WriteLine("You are NOT old enough to drive.");
}

// Exercise 4 — Loops

// For loop: count from 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Number: {i}");
}

// While loop: countdown from 5 to 1
int countdown = 5;

while (countdown > 0)
{
    Console.WriteLine($"Countdown: {countdown}");
    countdown--;

    Exercise 4 complete
}


