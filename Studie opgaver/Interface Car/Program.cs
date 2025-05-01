namespace Interface_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Opret en FuelCar-baseret Taxi
            //FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "TX12345", 50, 15);
            //Taxi fuelTaxi = new Taxi("Toyota", "Corolla", "TX12345", fuelCar, 40, 12, 4);

            //// Opret en ElectricCar-baseret Taxi
            //ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "TX67890", 100, 5);
            //Taxi electricTaxi = new Taxi("Tesla", "Model S", "TX67890", electricCar, 40, 10, 4);

            //// Test taxi-funktionaliteten
            //void TestTaxi(Taxi taxi)
            //{
            //    taxi.StartEngine();
            //    taxi.StartMeter();
            //    taxi.Drive(10);
            //    double fare = taxi.CalculateFare(10, 15);
            //    taxi.StopMeter();
            //    taxi.StopEngine();
            //    Console.WriteLine($"Taxi ride complete. Total fare: {fare:C2}");
            //    Console.WriteLine($"Energy level: {taxi.EnergyLevel:F2}\n");
            //}

            //// Test begge taxi-typer
            //Console.WriteLine("Testing Fuel Taxi:");
            //TestTaxi(fuelTaxi);

            //Console.WriteLine("Testing Electric Taxi:");
            //TestTaxi(electricTaxi);

            FleetManager fleet = new FleetManager();

            FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", 50, 15);
            ElectricCar electricCar = new ElectricCar("Tesla", "Model S", "CD67890", 100, 5);
            Taxi fuelTaxi = new Taxi("Toyota", "Avensis", "TX12345", fuelCar, 40, 10, 4);
            Taxi electricTaxi = new Taxi("Tesla", "Model 3", "TX67890", electricCar, 40, 10, 4);

            fleet.AddVehicle(fuelCar);
            fleet.AddVehicle(electricCar);
            fleet.AddVehicle(fuelTaxi);
            fleet.AddVehicle(electricTaxi);

            fleet.DisplayFleetStatus();
            fleet.StartAllEngines();
            fleet.DriveAllVehicles(20);
            fleet.RefillAllVehicles();
            fleet.DisplayFleetStatus();
            fleet.StopAllEngines();


        }
    }
}
