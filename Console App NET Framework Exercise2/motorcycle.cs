
using System;

namespace Exercise4_Vehicles
{
    public class Motorcycle : Vehicle
    {
        // Additional properties
        public bool HasSidecar { get; set; }
        
        // Constructor
        public Motorcycle(string name, int passengerCount, bool hasSidecar) 
            : base(name, passengerCount)
        {
            HasSidecar = hasSidecar;
        }
        
        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Motorcycle");
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
        
        // Motorcycle-specific method
        public void Wheelie()
        {
            Console.WriteLine($"{Name} does a wheelie!");
        }
    }
}
