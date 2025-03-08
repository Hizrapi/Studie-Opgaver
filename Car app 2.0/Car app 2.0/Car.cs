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
        private char brændStofType;
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

        public char BrændStofType
        {
            get { return brændStofType; }
            set { brændStofType = value; }
        }

        public bool IsEngineOn
        {
            get { return isEngineOn; }
            set { isEngineOn = value; }
        }

        // Constructor
        public Car(string brand, string model, int year, double kmPerLiter, double odometer)
        {
            Brand = brand;
            Model = model;
            Year = year;
            KmPerLiter = kmPerLiter;
            Odometer = odometer; // Correctly set the initial odometer value
            IsEngineOn = false; // Motoren er slukket til at starte med.
        }

        public void ReadCarDetails(List<Car> teamCars)
        {
            Console.Write("Indtast bilens mærke: ");
            Brand = Console.ReadLine();

            Console.Write("Indtast bilens model: ");
            Model = Console.ReadLine();

            Console.Write("Indtast bilens årgang: ");
            Year = int.Parse(Console.ReadLine());

            Console.Write("Indtast bilens kilometerstand: ");
            Odometer = double.Parse(Console.ReadLine());

            Console.Write("Indtast bilens Brændstoff type [E]l, [B]enzin og [D]iesel: ");
            BrændStofType = char.Parse(Console.ReadLine());

            Console.Write("Indtast bilens brændstofforbrug: ");
            KmPerLiter = double.Parse(Console.ReadLine());

            IsEngineOn = false; // Motoren er slukket til at starte med.

            // Tilføj det nye Car-objekt til listen
            teamCars.Add(new Car(Brand, Model, Year, KmPerLiter, Odometer));
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
        }

        public static void PrintAllTeamCars(List<Car> teamCars)
        {
            foreach (Car car in teamCars)
            {
                car.PrintCarDetails();
                Console.WriteLine();
            }
        }
    }
}

