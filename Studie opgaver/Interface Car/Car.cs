using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Car
{
    public abstract class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public string LicensePlate { get; }
        public double Odometer { get; protected set; }

        protected Car(string brand, string model, string licensePlate)
        {
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            Odometer = 0;
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
        public abstract void Drive(double kilometers);
        public abstract bool CanDrive(double kilometers);
    }
}
