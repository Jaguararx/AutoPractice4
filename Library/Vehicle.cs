using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        internal Owner Owner { get; set; }
        public Vehicle(string brand, string model = "", string year = "") {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
