using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Car
{
    public class ElectricCar : Car, IEnergy
    {
        public double EnergyLevel { get; private set; }
        public double MaxEnergy { get; }

        private double kmPerKwh;

        public ElectricCar(string brand, string model, string licensePlate, double maxEnergy, double kmPerKwh)
            : base(brand, model, licensePlate)
        {
            MaxEnergy = maxEnergy;
            EnergyLevel = maxEnergy;
            this.kmPerKwh = kmPerKwh;
        }

        public override void StartEngine() => Console.WriteLine($"{Brand} starter elmotor.");
        public override void StopEngine() => Console.WriteLine($"{Brand} slukker elmotor.");

        public override void Drive(double kilometers)
        {
            double energyNeeded = kilometers / kmPerKwh;
            if (energyNeeded <= EnergyLevel)
            {
                EnergyLevel -= energyNeeded;
                Odometer += kilometers;
            }
        }

        public override bool CanDrive(double kilometers)
        {
            return (kilometers / kmPerKwh) <= EnergyLevel;
        }

        public void Refill(double amount)
        {
            EnergyLevel = Math.Min(MaxEnergy, EnergyLevel + amount);
        }

        public void UseEnergy(double kilometers)
        {
            EnergyLevel -= kilometers / kmPerKwh;
        }
    }

}
