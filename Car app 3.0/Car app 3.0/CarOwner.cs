using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class CarOwner
    {
        public string Name { get; set; }
        public List<Car> Cars { get; private set; }

        public CarOwner(string name)
        {
            Name = name;
            Cars = new List<Car>();
        }

        // Tilføj en bil til bilejeren
        public void AddCar(Car car)
        {
            Cars.Add(car);
            Console.WriteLine($" {car.Brand} {car.Model} tilføjet til {Name}.");
        }

        // Fjern en bil fra bilejeren
        public void RemoveCar(string model)
        {
            Car? carToRemove = Cars.FirstOrDefault(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
            if (carToRemove != null)
            {
                Cars.Remove(carToRemove);
                Console.WriteLine($" {carToRemove.Brand} {carToRemove.Model} fjernet fra {Name}.");
            }
            else
            {
                Console.WriteLine(" Bilen blev ikke fundet hos denne ejer.");
            }
        }

        // Vis bilejerens biler
        public void ShowCars()
        {
            if (Cars.Count == 0)
            {
                Console.WriteLine($" {Name} ejer ingen biler.");
                return;
            }

            Console.WriteLine($"\n BILER EJET AF {Name}:");
            foreach (var car in Cars)
            {
                Console.WriteLine($" {car.Brand} {car.Model} ({car.Year}) - {car.Odometer} km, {car.BrændStofType}");
            }
        }
    }


    

    //public class Trip
    //{
    //    public string StartLocation { get; set; }
    //    public string EndLocation { get; set; }
    //    public int Distance { get; set; }

    //    public Trip(string startLocation, string endLocation, int distance)
    //    {
    //        StartLocation = startLocation;
    //        EndLocation = endLocation;
    //        Distance = distance;
    //    }
    //}
}
