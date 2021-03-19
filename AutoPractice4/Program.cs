using AutoPractice4.Models;
using Library;
using System;

namespace AutoPractice4
{
    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = VehiclesCollections.ReadVehiclesFromSource();
            var description = vehicles[0].Description();
            VehiclesCollections.PrintVehicles(vehicles);
            VehiclesCollections.PrintVehicles(VehiclesCollections.FilterByCountry(vehicles, "Italy"));

            string str1 = "%^^ Some string 12 . ";
            int count = 0;
            foreach (Char ch in str1.ToCharArray()) {
               if (Char.IsLetterOrDigit(ch)) {
                   count++;
               }
            }
            Console.WriteLine($"Amount of digits and letters in string {str1} is {count}.");

            Car car = new Car("Ford") { VolumeDrive = 4.4 };
            Console.WriteLine($"Volume drive of car is {car.VolumeDrive}");

            string str2 = "Some string2";
            string str3 = "Some string2";
            bool equal = true;
            if (str2.Length != str3.Length) {
               equal = false;
            } else {
               for (int i = 0; i < str2.Length; i++)
               {
                   if (str2[i] != str3[i]) {
                       equal = false;
                   }
               }
            }
            Console.WriteLine("Strings are{0} equal", equal?"":" not");
        }
    }
}
