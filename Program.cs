using System.Text.Json;

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

Exercise 8 complete (try/catch/finally, TryParse, custom exception)

    // Exercise 8 — Exception Handling

// 8.1 Divide-by-zero (basic try/catch)
try
{
    int a = 10;
    int b = 0;
    int result = a / b; // will throw DivideByZeroException
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Cannot divide by zero: {ex.Message}");
}

// 8.2 Multiple catch blocks (format + overflow + generic)
try
{
    Console.WriteLine("Enter an integer (e.g., 123):");
    string? input = Console.ReadLine();

    // Parsing can throw FormatException or OverflowException
    int number = int.Parse(input!);
    Console.WriteLine($"You entered: {number}");
}
catch (FormatException)
{
    Console.WriteLine("That wasn’t a valid integer format.");
}
catch (OverflowException)
{
    Console.WriteLine("The number is too large or too small for an int.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

// 8.3 finally block (always runs)
System.IO.StreamReader? reader = null;
try
{
    // Trying to open a file that may not exist (adjust path if you create one)
    string path = "data.txt";
    reader = new System.IO.StreamReader(path);
    string content = reader.ReadToEnd();
    Console.WriteLine($"File content:\n{content}");
}
catch (System.IO.FileNotFoundException)
{
    Console.WriteLine("File not found. (This is expected if you didn’t create data.txt)");
}
finally
{
    // Ensures resource cleanup even if an exception occurred
    if (reader != null)
    {
        reader.Dispose();
        Console.WriteLine("Reader disposed in finally block.");
    }
}

// 8.4 Safe parsing with TryParse (no exceptions thrown)
Console.WriteLine("Enter another integer (safe parse):");
string? raw = Console.ReadLine();
if (int.TryParse(raw, out int safeNumber))
{
    Console.WriteLine($"Safe parsed number = {safeNumber}");
}
else
{
    Console.WriteLine("Could not parse that as an integer (TryParse returned false).");
}

// 8.5 (Optional bonus) Throw and catch your own exception
try
{
    int age = -5;
    ValidateAge(age);
    Console.WriteLine("Age validated.");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Validation failed: {ex.Message}");
}

// Local function for validation (throws when invalid)
void ValidateAge(int ageValue)
{
    if (ageValue < 0 || ageValue > 130)
        throw new ArgumentOutOfRangeException(nameof(ageValue), ageValue, "Age must be between 0 and 130.");
}

// Exercise 9 — File Handling

using System.IO; // Make sure this is at the top of your file

string filePath = "data.txt";

// 9.1 Write text to a new file
try
{
    File.WriteAllText(filePath, "This is Exercise 9.\n");
    Console.WriteLine("File created and initial text written.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error writing file: {ex.Message}");
}

// 9.2 Append additional lines
try
{
    File.AppendAllText(filePath, "Appending a new line.\n");
    File.AppendAllText(filePath, "File handling in C# is easy!\n");
    Console.WriteLine("Additional lines appended.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error appending text: {ex.Message}");
}

// 9.3 Read the entire file
try
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("File content:");
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("The file was not found when trying to read it.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error reading the file: {ex.Message}");
}

// 9.4 Read file line by line
try
{
    Console.WriteLine("Reading file line by line:");

    string[] lines = File.ReadAllLines(filePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error reading file line by line: {ex.Message}");
}
// Exercise 9 — File Handling

using System.IO; // Make sure this is at the top of your file

string filePath = "data.txt";

// 9.1 Write text to a new file
try
{
    File.WriteAllText(filePath, "This is Exercise 9.\n");
    Console.WriteLine("File created and initial text written.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error writing file: {ex.Message}");
}

// 9.2 Append additional lines
try
{
    File.AppendAllText(filePath, "Appending a new line.\n");
    File.AppendAllText(filePath, "File handling in C# is easy!\n");
    Console.WriteLine("Additional lines appended.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error appending text: {ex.Message}");
}

// 9.3 Read the entire file
try
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("File content:");
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("The file was not found when trying to read it.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error reading the file: {ex.Message}");
}

// 9.4 Read file line by line
try
{
    Console.WriteLine("Reading file line by line:");

    string[] lines = File.ReadAllLines(filePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error reading file line by line: {ex.Message}");
}

// Exercise 10 — JSON Handling

// Create a simple data object
var personJson = new
{
    Name = "Pieter",
    Age = 30,
    Height = 1.82
};

// 10.1 Serialize to JSON (object → JSON string)
string jsonString = JsonSerializer.Serialize(personJson, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine("Serialized JSON:");
Console.WriteLine(jsonString);

// 10.2 Save JSON to a file
string jsonPath = "person.json";
File.WriteAllText(jsonPath, jsonString);
Console.WriteLine("JSON written to person.json");

// 10.3 Read the JSON back from file
string jsonFromFile = File.ReadAllText(jsonPath);
Console.WriteLine("JSON read from file:");
Console.WriteLine(jsonFromFile);

// 10.4 Deserialize JSON back into a C# object
try
{
    var deserializedPerson = JsonSerializer.Deserialize<Person>(jsonFromFile);

    if (deserializedPerson != null)
    {
        Console.WriteLine("Deserialized person:");
        Console.WriteLine(deserializedPerson.Introduce());
    }
    else
    {
        Console.WriteLine("Deserialization returned null.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error deserializing JSON: {ex.Message}");
}
