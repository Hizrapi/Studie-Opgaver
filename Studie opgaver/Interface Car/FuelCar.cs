using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Car
{
    public class FuelCar : Car, IEnergy
    {
        public double EnergyLevel { get; private set; }
        public double MaxEnergy { get; }

        private double kmPerLiter;

        public FuelCar(string brand, string model, string licensePlate, double maxEnergy, double kmPerLiter)
            : base(brand, model, licensePlate)
        {
            MaxEnergy = maxEnergy;
            EnergyLevel = maxEnergy;
            this.kmPerLiter = kmPerLiter;
        }

        public override void StartEngine() => Console.WriteLine($"{Brand} starter benzinmotor.");
        public override void StopEngine() => Console.WriteLine($"{Brand} stopper motoren.");

        public override void Drive(double kilometers)
        {
            double fuelNeeded = kilometers / kmPerLiter;
            if (fuelNeeded <= EnergyLevel)
            {
                EnergyLevel -= fuelNeeded;
                Odometer += kilometers;
            }
        }

        public override bool CanDrive(double kilometers)
        {
            return (kilometers / kmPerLiter) <= EnergyLevel;
        }

        public void Refill(double amount)
        {
            EnergyLevel = Math.Min(MaxEnergy, EnergyLevel + amount);
        }

        public void UseEnergy(double kilometers)
        {
            EnergyLevel -= kilometers / kmPerLiter;
        }
    }

}
