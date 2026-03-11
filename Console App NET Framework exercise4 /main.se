
using System.Collections.Generic;

namespace Exercise4_Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold different vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            
            // Create Car objects
            Car car1 = new Car("Toyota Camry", 5, "Red", 4);
            Car car2 = new Car("Honda Civic", 5, "Blue", 4);
            
            // Create Motorcycle objects
            Motorcycle moto1 = new Motorcycle("Harley Davidson", 2, false);
            Motorcycle moto2 = new Motorcycle("Ural", 3, true);
            
            // Add to list (polymorphism in action!)
            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(moto1);
            vehicles.Add(moto2);
            
            // Display all vehicles
            Console.WriteLine("=== ALL VEHICLES ===\n");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine(); // Empty line
            }
            
            // Demonstrate specific methods
            Console.WriteLine("=== SPECIFIC ACTIONS ===\n");
            car1.Honk();
            moto1.Wheelie();
            
            // Demonstrate polymorphism
            Console.WriteLine("\n=== POLYMORPHISM EXAMPLE ===");
            Vehicle myVehicle = new Car("Tesla Model 3", 5, "White", 4);
            myVehicle.DisplayInfo(); // Calls Car's DisplayInfo, not Vehicle's!
            
            Console.ReadKey();
        }
    }
}
