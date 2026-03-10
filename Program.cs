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

// Exercise 5 — Classes & Objects

var pieter = new Person("Pieter", 30, 1.82);
var inari  = new Person("Inari", 28, 1.70);

Console.WriteLine(pieter.Introduce());
Console.WriteLine(inari.Introduce());

// Exercise 6 — Arrays & Lists

// Array of integers
int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine("Array values:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Exercise 7 — Methods (Functions)

// 1) A method that prints a greeting (no return value)
void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// 2) A method that adds two integers (returns an int)
int Add(int a, int b)
{
    return a + b;
}

// 3) A method that formats a person line (returns a string)
string FormatPerson(string name, int age)
{
    return $"Name: {name}, Age: {age}";
}

// ---- Calls (run these to test) ----
Greet("Pieter");

int sum = Add(10, 20);
Console.WriteLine($"Sum = {sum}");

string line = FormatPerson("Inari", 28);
Console.WriteLine(line);


// Overloaded methods: same name, different parameter lists
int Add(int a, int b, int c)
{
    return a + b + c;
}

double Add(double a, double b)
{
    return a + b;
}

// ---- Calls (overload selection happens automatically) ----
Console.WriteLine($"Add(5, 7, 3) = {Add(5, 7, 3)}");     // uses (int,int,int)
Console.WriteLine($"Add(2.5, 1.5) = {Add(2.5, 1.5)}");   // uses (double,double)
