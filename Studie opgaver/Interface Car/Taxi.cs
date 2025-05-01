using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Car
{
    public class Taxi : Car, IEnergy
    {
        private IEnergy energySystem;

        public double PricePerKm { get; }
        public double StartFee { get; }
        public int MaxPassengers { get; }

        public double EnergyLevel => energySystem.EnergyLevel;
        public double MaxEnergy => energySystem.MaxEnergy;

        public Taxi(string brand, string model, string licensePlate, IEnergy energySystem, double pricePerKm, double startFee, int maxPassengers)
            : base(brand, model, licensePlate)
        {
            this.energySystem = energySystem;
            PricePerKm = pricePerKm;
            StartFee = startFee;
            MaxPassengers = maxPassengers;
        }

        public override void StartEngine() => Console.WriteLine($"{Brand} taxi starter motor.");
        public override void StopEngine() => Console.WriteLine($"{Brand} taxi stopper motor.");

        public override void Drive(double kilometers)
        {
            energySystem.UseEnergy(kilometers);
            Odometer += kilometers;
        }

        public override bool CanDrive(double kilometers)
        {
            return energySystem is not null && energySystem.EnergyLevel >= kilometers; // For simple logic
        }

        public void Refill(double amount) => energySystem.Refill(amount);
        public void UseEnergy(double kilometers) => energySystem.UseEnergy(kilometers);

        public void StartMeter() => Console.WriteLine("Taxameter startet.");
        public void StopMeter() => Console.WriteLine("Taxameter stoppet.");
        public double CalculateFare(double kilometers, double delayMinutes) => StartFee + kilometers * PricePerKm + (delayMinutes * 1.5);
    }

}
