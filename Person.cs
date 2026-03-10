public class Person
{
    // Properties (data the object carries)
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; } // meters

    // Constructor (how to build a Person)
    public Person(string name, int age, double height)
    {
        Name = name;
        Age = age;
        Height = height;
    }

    // Method (behavior of the object)
    public string Introduce()
    {
        return $"Hi, I'm {Name}, I'm {Age} years old and {Height}m tall.";
    }
}

public void HaveBirthday()
{
    Age += 1;
    Console.WriteLine($"{Name} just had a birthday and is now {Age}!");
}
``
// Calling a method on an object (instance method)
var pieter = new Person("Pieter", 30, 1.82);
pieter.HaveBirthday();
Console.WriteLine(pieter.Introduce());

Exercise 7 complete

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
Exercise 8 complete (try/catch/finally, TryParse, custom exception)
