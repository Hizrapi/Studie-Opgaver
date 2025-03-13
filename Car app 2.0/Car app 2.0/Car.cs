using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_2._0
{
    internal class Car
    {
        private string brand;
        private string model;
        private int year;
        private double odometer;
        private double kmPerLiter;
        private FuelType brændStofType;
        private bool isEngineOn;       

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Odometer
        {
            get { return odometer; }
            set { odometer = value; }
        }

        public double KmPerLiter
        {
            get { return kmPerLiter; }
            set { kmPerLiter = value; }
        }

        public FuelType BrændStofType
        {
            get { return brændStofType; }
            set { brændStofType = value; }
        }

        public bool IsEngineOn
        {
            get { return isEngineOn; }
            set { isEngineOn = value; }
        }

        // Min Constructor til liste
        public Car(string brand, string model, int year, double kmPerLiter, double odometer, FuelType brændStofType)
        {
            Brand = brand ?? throw new ArgumentNullException(nameof(brand));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Year = year;
            KmPerLiter = kmPerLiter;
            Odometer = odometer;
            BrændStofType = brændStofType;
            IsEngineOn = false;
        }

        public void ReadCarDetails(List<Car> teamCars)
        {
            Console.Write("Indtast bilens mærke: ");
            Brand = Console.ReadLine() ?? throw new ArgumentNullException("Brand cannot be null");

            Console.Write("Indtast bilens model: ");
            Model = Console.ReadLine() ?? throw new ArgumentNullException("Model cannot be null");

            Console.Write("Indtast bilens årgang: ");
            Year = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("Year cannot be null"));

            Console.Write("Indtast bilens kilometerstand: ");
            Odometer = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("Odometer cannot be null"));

            Console.Write("Indtast bilens Brændstoff type [B]enzin, [D]iesel, [E]l, [H]ybrid: ");
            char fuelTypeChar = char.Parse(Console.ReadLine()?.ToUpper() ?? throw new ArgumentNullException("Fuel type cannot be null"));
            BrændStofType = fuelTypeChar switch
            {
                'B' => FuelType.Benzin,
                'D' => FuelType.Diesel,
                'E' => FuelType.Electric,
                'H' => FuelType.Hybrid,
                _ => throw new ArgumentException("Ugyldig brændstoftype")
            };

            Console.Write("Indtast bilens brændstofforbrug: ");
            KmPerLiter = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException("KmPerLiter cannot be null"));

            IsEngineOn = false; // Motoren er slukket til at starte med.

            // Tilføj det nye Car-objekt til listen
            teamCars.Add(new Car(Brand, Model, Year, KmPerLiter, Odometer, BrændStofType));
        }

        public void ToggleEngine(bool turnOn)
        {
            IsEngineOn = turnOn;
            if (IsEngineOn)
            {
                Console.WriteLine("Motoren er nu tændt.");
            }
            else
            {
                Console.WriteLine("Motoren er nu slukket.");
            }
        }

        public void Drive(double distance)
        {
            if (IsEngineOn)
            {
                Odometer += distance;
                Console.WriteLine($"Du har kørt {distance} km. Ny kilometerstand: {Odometer} km.");
            }
            else
            {
                Console.WriteLine("Motoren er ikke tændt. Tænd motoren først.");
            }
        }

        public double CalculateTripPrice(double distance, double literPrice)
        {
            if (KmPerLiter == 0)
            {
                Console.WriteLine("Km per liter kan ikke være 0.");
                return 0;
            }

            double litersUsed = distance / KmPerLiter;
            double tripPrice = litersUsed * literPrice;
            return tripPrice;
        }

        public bool IsPalindrome(int km)
        {
            string kmStr = km.ToString();
            int len = kmStr.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (kmStr[i] != kmStr[len - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintCarDetails()
        {
            Console.WriteLine($"Bilens mærke: {Brand}");
            Console.WriteLine($"Bilens model: {Model}");
            Console.WriteLine($"Bilens årgang: {Year}");
            Console.WriteLine($"Bilens kilometerstand: {Odometer}");
            Console.WriteLine($"Bilens km per liter: {KmPerLiter}");
            Console.WriteLine($"Bilens brændstoftype: {BrændStofType}");
        }

        public static void PrintAllTeamCars(List<Car> teamCars, List<Tripdistance> tripList)
        {
            foreach (Car car in teamCars)
            {
                car.PrintCarDetails();
                Console.WriteLine("Trips:");
                Tripdistance.PrintTripList(tripList);
            }
        }
    }
}

