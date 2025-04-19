using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trænings_projekt
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public string WheelType;
        public string GasolineType;
        public double KmPerLiter;

        public Car(string brand, string model, int year, string wheelType, string gasolineType, double kmPerLiter)
        {
            Brand = brand;
            Model = model;
            Year = year;
            WheelType = wheelType;
            GasolineType = gasolineType;
            KmPerLiter = kmPerLiter;

        }

        public void CarInfo()
        {
            Console.WriteLine($"Hej, din bil er {Brand}, {Model}, fra {Year}, den har {WheelType} på og kører {KmPerLiter} km per liter");
        }
    }
}
