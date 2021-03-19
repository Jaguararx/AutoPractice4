using Library;

namespace AutoPractice4
{
    public static class VehicleExtensions
    {
        public static string Description(this Vehicle vehicle) {
            return $"Vehicles of brand: {vehicle.Brand}, model: {vehicle.Model}, year: {vehicle.Year}";
        }
    }
}
