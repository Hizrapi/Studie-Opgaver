using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Repository_Pattern
{
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public string LicensePlate { get; }
        public string FuelType { get; }
        public List<Trip> Trips {  get; }

        public Car(string licensePlate, string brand, int year, string model, string color,  string fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            LicensePlate = licensePlate;
            FuelType = fuelType;
            Trips = new List<Trip>();
        }
        public override string ToString()
        {
            return $"{Brand},{Model},({Year}),{Color},{LicensePlate},{FuelType})";
        }

        public static Car FromString(string input)
        {
            var parts = input.Split(',');
            return new Car(parts[0], parts[1], int.Parse(parts[2]), parts[3], parts[4], parts[5]);
        }
    }

}
