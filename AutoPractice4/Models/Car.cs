using Library;


namespace AutoPractice4.Models
{
    public class Car : Vehicle
    {
        public double VolumeDrive { get; set; }
        public Car(string brand, string model = "", string year = "") : base (brand, model, year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
