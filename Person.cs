public Person() {}   // needed for JSON deserialization

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

    // Empty constructor for JSON deserialization
    public Person() {}

    // Your normal constructor
    public Person(string name, int age, double height)
    {
        Name = name;
        Age = age;
        Height = height;
    }

    public string Introduce()
    {
        return $"Hi, I'm {Name}, I'm {Age} years old and {Height}m tall.";
    }
}
