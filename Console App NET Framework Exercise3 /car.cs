using System;

namespace Exercise4_Vehicles
{
    // Derived class inheriting from Vehicle
    public class Car : Vehicle
    {
        // Additional properties specific to Car
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        
        // Constructor calling base constructor
        public Car(string name, int passengerCount, string color, int doors) 
            : base(name, passengerCount)
        {
            Color = color;
            NumberOfDoors = doors;
        }
        
        // Override the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call parent method
            Console.WriteLine($"Type: Car");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Doors: {NumberOfDoors}");
        }
        
        // Car-specific method
        public void Honk()
        {
            Console.WriteLine($"{Name} says: Beep beep!");
        }
    }
}
