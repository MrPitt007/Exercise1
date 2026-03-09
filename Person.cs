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
