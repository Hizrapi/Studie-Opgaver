using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Car_app_3._0
{
    public class CarOwnerManager
    {
        CarManager carManager = new CarManager();
        public List<CarOwner> carOwners;

        public CarOwnerManager()
        {
            carOwners = new List<CarOwner>();
        }

        // Tilføj en ny bilejer
        public void AddCarOwner(string name)
        {
            carOwners.Add(new CarOwner(name));
            Console.WriteLine($"Bilejer {name} tilføjet.");
        }

        // Fjern en bilejer
        public void RemoveCarOwner(string name)
        {
            Console.Write("What is the Owners name you want to remove? ");
            name = Console.ReadLine()??"Unknown";
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Ugyldigt navn.");
                return;
            } 
            CarOwner ownerToRemove = carOwners.FirstOrDefault(o => o.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (ownerToRemove != null)
            {
                carOwners.Remove(ownerToRemove);
                Console.WriteLine($"Bilejer {name} fjernet.");
            }
            else
            {
                Console.WriteLine("Bilejer ikke fundet.");
            }
        }

        // Vis alle bilejere
        public void ShowCarOwners()
        {
            if (carOwners.Count == 0)
            {
                Console.WriteLine("Ingen registrerede bilejere.");
                return;
            }

            Console.WriteLine("\nREGISTREREDE BILEJERE:");
            foreach (var owner in carOwners)
            {
                Console.WriteLine($"{owner.Name} ejer {owner.Cars.Count} biler.");
            }
        }

        // Tilføj en bil til en bilejer
        public void AddCarToOwner(string ownerName, Car car)
        {
            CarOwner owner = carOwners.FirstOrDefault(o => o.Name.Equals(ownerName, StringComparison.OrdinalIgnoreCase));
            if (owner != null)
            {
                
                owner.Cars.Add(car);
                Console.WriteLine($" {car.Brand} {car.Model} tilføjet til {owner.Name}.");
            }
            else
            {
                Console.WriteLine("Bilejer ikke fundet.");
            }
        }
    }

}
