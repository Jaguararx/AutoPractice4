using System;
using System.Linq;

namespace Library
{
    public static class VehiclesCollections
    {
        static public Vehicle[] ReadVehiclesFromSource() {
            Vehicle[] vehicles = new Vehicle[4] { 
                new Vehicle("Volvo") { Owner = new Owner("Italy")},
                new Vehicle("Audi") { Owner = new Owner("France")},
                new Vehicle("Ferrari") { Owner = new Owner("Italy")},
                new Vehicle("Ford") { Owner = new Owner("France")}
            };
            return vehicles;
        }

        static public Vehicle[] FilterByCountry(Vehicle[] vehicles, string country) {
            return vehicles.Where(c => c.Owner.Country == country).ToArray();
        }

        static public void PrintVehicles(Vehicle[] vehicles)
        {
            Console.WriteLine($"====List of Vehicles====");
            foreach (Vehicle vehicle in vehicles) {
                Console.WriteLine($"Vehicles of brand: {vehicle.Brand}, model: {vehicle.Model}, year: {vehicle.Year}, country: : {vehicle.Owner.Country}");
            }
            Console.WriteLine($"======End of list=======");
        }
    }
}
