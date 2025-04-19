using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class CarManager
    
    {
        Trip trip = null; // Initialize as null or provide valid arguments if needed
        private List<Car> cars;

        public CarManager()
        {
            cars = new List<Car>();
        }

        // Tilføj en bil
        public void AddCar(string brand, string model, int year, double kmPerLiter, double fuelTank, FuelType fuelType, List<Trip> trips)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) || year <= 0 || kmPerLiter <= 0 || fuelTank <= 0)
            {
                Console.WriteLine("Ugyldige biloplysninger.");
                return;
            }

            // Tjek om bilen allerede findes
            if (cars.Any(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Bilen findes allerede.");
                return;
            }
        {
            Car newCar = new Car(brand, model, year, kmPerLiter, fuelTank, fuelType, new List<Trip>());
            cars.Add(newCar);
            Console.WriteLine($"{brand} {model} ({year}) tilføjet.");
        }
        }

        // Fjern en bil
        public void RemoveCar(string model)
        {
            Car? carToRemove = cars.FirstOrDefault(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
                Console.WriteLine($"{carToRemove.Brand} {carToRemove.Model} fjernet.");
            }
            else
            {
                Console.WriteLine("Bilen blev ikke fundet.");
            }
        }

        // Vis alle biler
        public void ShowCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("Ingen biler registreret.");
                return;
            }

            Console.WriteLine("\nREGISTREREDE BILER:");
            foreach (var car in cars)
            {
                Console.WriteLine($"➡ {car.Brand} {car.Model} ({car.Year}) - {car.Odometer} km, {car.BrændStofType}");
            }
        }

        // Tænd/sluk motor
        public void ToggleCarEngine(string model)
        {
            Car? car = cars.FirstOrDefault(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
            if (car != null)
            {
                car.ToggleEngine();
            }
            else
            {
                Console.WriteLine("Bilen blev ikke fundet.");
            }
        }

        // Tilføj en tur
        //public void AddTripToCar(string model, string startLocation, string endLocation, int distance)
        //{
        //    Car? car = cars.FirstOrDefault(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
        //    if (car != null)
        //    {
        //        car.Trips.Add(new Trip(startLocation, endLocation, distance));
        //        Console.WriteLine($"✅ Tur fra {startLocation} til {endLocation} ({distance} km) tilføjet til {model}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("🚨 Bilen blev ikke fundet.");
        //    }
        //}
    }
}



   


